using DipolarCalc.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DipolarCalc
{
    public partial class MainForm : Form
    {
#if DEBUG
        private void DebugMsg(string msg)
        {
            MessageBox.Show(msg, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
#endif
        private double calcMuByBond(AtomType a1, AtomType a2, double d)
        {
            return Math.Abs(electroneg[a1] - electroneg[a2]) * d;
        }
        private double calcMuByAngle(double mu1, double mu2, double a)
        {
            double mu = Math.Sqrt(mu1 * mu1 + mu2 * mu2 - 2 * mu1 * mu2 * Math.Cos(Math.PI * a / 180.0));
            return mu;
        }
        private (Atom, Atom, Atom) BondToAtoms(string strGroup)
        {
            var strAtoms = strGroup.Split(new string[] { " - " }, StringSplitOptions.None);
            Atom a1 = new Atom(strAtoms[0]), a2 = new Atom(strAtoms[1]), a3;
            if (strAtoms.Length > 2) a3 = new Atom(strAtoms[2]);
            else a3 = new Atom();

            return (a1, a2, a3);
        }
        private double DistanceByPoints((double X, double Y, double Z) Point1, (double X, double Y, double Z) Point2)
        {
            double dX = Point1.X - Point2.X;
            double dY = Point1.Y - Point2.Y;
            double dZ = Point1.Z - Point2.Z;
            return Math.Round(Math.Sqrt(dX * dX + dY * dY + dZ * dZ), 3);
        }
        #region Data
        struct AtomType
        {
            public string value;
            public static AtomType GetAtomType(string type)
            {
                AtomType val;
                if (atomTypes.TryGetValue(type, out val))
                    return val;
                else throw new ArgumentException($"{type} is not available name of atom!");
            }
            public override bool Equals(object b)
            {
                AtomType B = (AtomType)b;
                return (value == B.value);
            }
            public override string ToString()
            {
                return value;
            }
            public override int GetHashCode()
            {
                return value.GetHashCode();
            }
        }
        struct Atom
        {
            public AtomType type;
            public string index;

            public Atom(string s)
            {
                type = AtomType.GetAtomType(s[0].ToString());
                index = s.Substring(1);
            }
            public override bool Equals(object b)
            {
                Atom B = (Atom)b;
                return (type.Equals(B.type) && index == B.index);
            }
            public override int GetHashCode()
            {
                return ToString().GetHashCode();
            }
            public override string ToString()
            {
                return $"{type}{index}";
            }
        }

        FormWindowState lastWindowState;
        List<Atom> atoms = new List<Atom>();
        Dictionary<(Atom, Atom), int> bondsIndexator = new Dictionary<(Atom, Atom), int>();
        List<(double d, double mu)> bonds = new List<(double d, double mu)> ();
        Dictionary<(Atom, Atom, Atom), int> anglesIndexator = new Dictionary<(Atom, Atom, Atom), int> ();
        List<(double angle, double mu)> angles = new List<(double angle, double mu)> ();
        List<(Atom, Atom, Atom)> molecule = new List<(Atom, Atom, Atom)>();
        static Dictionary<string, AtomType> atomTypes = new Dictionary<string, AtomType>();
        Dictionary<AtomType, double> electroneg = new Dictionary<AtomType, double>();
        string savedFileName = "";
        #endregion

        #region MainForm
        public MainForm()
        {
            LoadConfig();
            InitializeComponent();

            bondComboBox1.Items.AddRange(atomTypes.Keys.ToArray());
            bondComboBox2.Items.AddRange(atomTypes.Keys.ToArray());
            bondComboBox1.SelectedIndex = 0;
            bondComboBox2.SelectedIndex = 0;

            lastWindowState = WindowState;
            Form_ResizeEnd(this, new EventArgs());
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyLanguage(Thread.CurrentThread.CurrentCulture);
        }
        private void Form_SizeChanged(object sender, EventArgs e)
        {

            if (lastWindowState != WindowState)
            {
                lastWindowState = WindowState;
                Form_ResizeEnd(this, new EventArgs());
            }
        }
        private void Form_ResizeEnd(object sender, EventArgs e)
        {
            double workingWidth = bondListView.Width - System.Windows.SystemParameters.VerticalScrollBarWidth - 10;
            double col0 = 0.5;
            double col1 = 0.25;
            double col2 = 0.25;

            bondListView.Columns[0].Width = (int)Math.Floor(workingWidth * col0);
            bondListView.Columns[1].Width = (int)Math.Floor(workingWidth * col1);
            bondListView.Columns[2].Width = (int)Math.Floor(workingWidth * col2);

            angleListView.Columns[0].Width = (int)Math.Floor(workingWidth * col0);
            angleListView.Columns[1].Width = (int)Math.Floor(workingWidth * col1);
            angleListView.Columns[2].Width = (int)Math.Floor(workingWidth * col2);

            groupListView.Columns[0].Width = (int)Math.Floor(workingWidth);
        }
        #endregion

        private void LoadConfig()
        {
            if (!Directory.Exists("config"))
                Directory.CreateDirectory("config");

            //Electronegativity
            if (!File.Exists("config\\electroneg.toml"))
            {
                File.WriteAllText("config\\electroneg.toml", "#This text is generated automatically\n#Electronegativity of atoms\nH = 2,2\nC = 2,55\nN = 3,04\nO = 3,44\nP = 2,19\nS = 2,58");
            }
            foreach (var item in ReadTOML("config\\electroneg.toml"))
            {
                var atomType = new AtomType() { value = item.Key };
                atomTypes.Add(item.Key, atomType);
                electroneg.Add(atomType, Convert.ToDouble(item.Value));
            }
        }
        private Dictionary<string, string> ReadTOML(string fileName)
        {
            Dictionary<string, string> values= new Dictionary<string, string>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    var value = line.Split(new char[] { '#' }, 2)[0];
                    if (value == "") continue;
                    var valueparts = value.Split(new char[] { '=' }, 2);
                    values.Add(valueparts[0].Trim(), valueparts[1].Trim());
                }
            }

            return values;
        }
        private void ApplyLanguage(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ResourceManager LocRM = new ResourceManager("DipolarCalc.Resources.Strings", typeof(Strings).Assembly);
            CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;
            fileStrip.Text = LocRM.GetString("fileStip.Text", currentCulture);
            file_createStrip.Text = LocRM.GetString("file_createStrip.Text", currentCulture);
            file_openStrip.Text = LocRM.GetString("file_openStrip.Text", currentCulture);
            file_saveStrip.Text = LocRM.GetString("file_saveStrip.Text", currentCulture);
            langStrip.Text = LocRM.GetString("langStrip.Text", currentCulture);
            
            bondgroupBox.Text = LocRM.GetString("bondgroupBox.Text", currentCulture);
            bondLabel.Text = LocRM.GetString("bondLabel.Text", currentCulture);
            bondListView.Columns[0].Text = LocRM.GetString("tableLabel.Text", currentCulture);

            bond_addButton.Text = LocRM.GetString("addButton.Text", currentCulture);
            bond_delButton.Text = LocRM.GetString("delButton.Text", currentCulture);

            anglegroupBox.Text = LocRM.GetString("anglegroupBox.Text", currentCulture);
            angleLabel.Text = LocRM.GetString("angleLabel.Text", currentCulture);
            angleListView.Columns[0].Text = LocRM.GetString("tableLabel.Text", currentCulture);
            angle_addButton.Text = LocRM.GetString("addButton.Text", currentCulture);
            angle_delButton.Text = LocRM.GetString("delButton.Text", currentCulture);

            groupGroupBox.Text = LocRM.GetString("groupGroupBox.Text", currentCulture);
            groupLabel.Text = LocRM.GetString("groupLabel.Text", currentCulture);
            groupListView.Columns[0].Text = LocRM.GetString("tableLabel.Text", currentCulture);
            group_addButton.Text = LocRM.GetString("addButton.Text", currentCulture);
            group_delButton.Text = LocRM.GetString("delButton.Text", currentCulture);
            radiusLabel.Text = LocRM.GetString("radiusLabel.Text", currentCulture);
        }
        private string GetResource(string name)
        {
            ResourceManager LocRM = new ResourceManager("DipolarCalc.Resources.Strings", typeof(Strings).Assembly);
            return LocRM.GetString(name, Thread.CurrentThread.CurrentUICulture);
        }

        #region Strips
        private void langStrip_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "lang_enStrip":
                    ApplyLanguage(new CultureInfo("en-US"));
                    break;
                case "lang_ruStrip":
                    ApplyLanguage(new CultureInfo("ru-RU"));
                    break;
            }
        }

        private void file_createStrip_Click(object sender, EventArgs e)
        {
            if (atoms.Count == 0) return;
            if (MessageBox.Show(GetResource("MessageBox.Info.SaveProj"), GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                file_saveStrip_Click(sender, e);
            savedFileName = "";

            bondComboBox1.SelectedIndex = 0;
            bond_indexTextBox1.Text = "";
            bondComboBox2.SelectedIndex = 0;
            bond_indexTextBox2.Text = "";
            bond_dTextBox.Text = "";

            bondListView.Items.Clear();

            anglegroupBox.Enabled = false;

            anglecomboBox1.Items.Clear();
            anglecomboBox2.Items.Clear();
            anglecomboBox3.Items.Clear();
            angle_aTextBox.Text = "";

            angleListView.Items.Clear();

            groupGroupBox.Enabled = false;

            groupcomboBox.Items.Clear();

            groupListView.Items.Clear();

            radiusTextBox.Text = "";
            group_muLabel.Text = "";
            group_PLabel.Text = "-";

            atoms.Clear();
            bondsIndexator.Clear();
            bonds.Clear();
            anglesIndexator.Clear();
            angles.Clear();
            molecule.Clear();
        }

        private void file_openStrip_Click(object sender, EventArgs e)
        {
            file_createStrip_Click(sender, e);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = GetResource("OpenFileDialog.Filter");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    var ext = Path.GetExtension(openFileDialog.FileName);
                    try
                    {
                        if (ext == ".cml")
                        {
                            XNamespace ns = "http://www.xml-cml.org/schema";
                            var doc = XDocument.Parse(sr.ReadToEnd());
                            Dictionary<string, int> nOfAtoms = atomTypes.Keys.ToDictionary(key => key, _ => 0);
                            var loadedAtoms = new Dictionary<string, (string AtomName, (double X, double Y, double Z) Point)>();
                            foreach(var a in doc.Descendants(ns + "atom"))
                            {
                                var elemetType = (string)a.Attribute("elementType");
                                if (!nOfAtoms.ContainsKey(elemetType))
                                {
                                    MessageBox.Show(string.Format(GetResource("MessageBox.Error.NoAtomType"), elemetType), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                elemetType += nOfAtoms[elemetType]++.ToString();
                                loadedAtoms.Add(
                                    (string)a.Attribute("id"),
                                    (elemetType, ((double)a.Attribute("x3"), (double)a.Attribute("y3"), (double)a.Attribute("z3")))
                                );
                            }

                            var loadedBonds = new Dictionary<string, List<string>>();
                            foreach (var a in loadedAtoms.Keys) loadedBonds.Add(a, new List<string>());

                            foreach (var b in doc.Descendants(ns + "bond"))
                            {
                                var bond = ((string)b.Attribute("atomRefs2")).Split(' ').Where(a => a != "").ToArray();
                                var a1 = loadedAtoms[bond[0]];
                                var a2 = loadedAtoms[bond[1]];

                                loadedBonds[bond[0]].Add(bond[1]);
                                loadedBonds[bond[1]].Add(bond[0]);

                                AddBond(new Atom(a1.AtomName), new Atom(a2.AtomName), DistanceByPoints(a1.Point, a2.Point));
                            }

                            foreach(var bond in loadedBonds)
                            {
                                for (var i = 0; i < bond.Value.Count - 1; i++)
                                {
                                    for (var j = i + 1; j < bond.Value.Count; j++)
                                    {
                                        var Vec1 = loadedAtoms[bond.Value[i]].Point;
                                        var Vec2 = loadedAtoms[bond.Value[j]].Point;
                                        var PointCenter = loadedAtoms[bond.Key].Point;
                                        Vec1.X -= PointCenter.X;
                                        Vec1.Y -= PointCenter.Y;
                                        Vec1.Z -= PointCenter.Z;
                                        Vec2.X -= PointCenter.X;
                                        Vec2.Y -= PointCenter.Y;
                                        Vec2.Z -= PointCenter.Z;
                                        double angle = Math.Round(180.0 * Math.Acos(
                                            (Vec1.X * Vec2.X + Vec1.Y * Vec2.Y + Vec1.Z * Vec2.Z)
                                            /
                                            (
                                                Math.Sqrt(Vec1.X * Vec1.X + Vec1.Y * Vec1.Y + Vec1.Z * Vec1.Z)
                                                *
                                                Math.Sqrt(Vec2.X * Vec2.X + Vec2.Y * Vec2.Y + Vec2.Z * Vec2.Z)
                                            )
                                        ) / Math.PI, 3);
                                        var group = (new Atom(loadedAtoms[bond.Value[i]].AtomName), new Atom(loadedAtoms[bond.Key].AtomName), new Atom(loadedAtoms[bond.Value[j]].AtomName));
                                        AddAngle(group.Item1, group.Item2, group.Item3, angle);
                                        if (angles[anglesIndexator[group]].mu != 0)
                                            AddGroup(new Atom(loadedAtoms[bond.Value[i]].AtomName), new Atom(loadedAtoms[bond.Key].AtomName), new Atom(loadedAtoms[bond.Value[j]].AtomName));
                                    }
                                }
                            }
                        }
                        else //(ext == ".txt") myfilereader
                        {

                            string line;
                            sr.ReadLine(); // Bonds
                            while ((line = sr.ReadLine()) != "")
                            {
                                var blocks = line.Split('\t');
                                var bond = BondToAtoms(blocks[0]);
                                AddBond(bond.Item1, bond.Item2, Convert.ToDouble(blocks[1]));
                            }

                            sr.ReadLine(); // Angles
                            while ((line = sr.ReadLine()) != "")
                            {
                                var blocks = line.Split('\t');
                                var bond = BondToAtoms(blocks[0]);
                                AddAngle(bond.Item1, bond.Item2, bond.Item3, Convert.ToDouble(blocks[1]));
                            }

                            sr.ReadLine(); // Molecule
                            while ((line = sr.ReadLine()) != "")
                            {
                                var bond = BondToAtoms(line);
                                AddGroup(bond.Item1, bond.Item2, bond.Item3);
                            }

                            sr.ReadLine(); // Radius
                                radiusTextBox.Text = sr.ReadLine();
                        }

                    }
                    catch
                    {
                        MessageBox.Show(GetResource("MessageBox.Error.CorruptedFile"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                savedFileName = openFileDialog.FileName;
            }
        }

        private void file_saveStrip_Click(object sender, EventArgs e)
        {
            if (savedFileName != "")
            {
                using (StreamWriter sw = new StreamWriter(savedFileName))
                {
                    sw.WriteLine("Bonds");
                    foreach (var bond in bondsIndexator)
                    {
                        sw.Write(bond.Key.Item1.ToString() + " - ");    //a1
                        sw.Write(bond.Key.Item2.ToString() + "\t");     //a2
                        sw.WriteLine(bonds[bond.Value].d.ToString());   //d
                    }
                    sw.WriteLine();
                    sw.WriteLine("Angles");
                    foreach (var angle in anglesIndexator)
                    {
                        sw.Write(angle.Key.Item1.ToString() + " - ");       //a1
                        sw.Write(angle.Key.Item2.ToString() + " - ");       //a2
                        sw.Write(angle.Key.Item3.ToString() + "\t");        //a3
                        sw.WriteLine(angles[angle.Value].angle.ToString()); //angle
                    }
                    sw.WriteLine();
                    sw.WriteLine("Molecule");
                    foreach (var angle in molecule)
                    {
                        sw.Write(angle.Item1.ToString() + " - ");       //a1
                        sw.Write(angle.Item2.ToString() + " - ");       //a2
                        sw.WriteLine(angle.Item3.ToString());           //a3
                    }
                    sw.WriteLine();
                    sw.WriteLine("Radius");
                    double r;
                    try
                    {
                        r = Convert.ToDouble(radiusTextBox.Text.Replace('.', ','));
                    }
                    catch
                    {
                        r = 0;
                    }
                    sw.WriteLine(r.ToString());
                }
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                savedFileName = saveFileDialog.FileName;
                file_saveStrip_Click(sender, e);
            }
        }
        #endregion

        #region Bond
        private void bond_dTextBox_TextChanged(object sender, EventArgs e)
        {
            double d;
            try
            {
                d = Convert.ToDouble(bond_dTextBox.Text.Replace('.', ','));
            }
            catch
            {
                bond_dTextBox.ForeColor = Color.Red;
                bond_muLabel.Text = "-";
                return;
            }
            bond_dTextBox.ForeColor = Color.Black;
            double mu = 0;//FUNC!!!-----------------------------------------

            //
            mu = calcMuByBond(AtomType.GetAtomType((string)bondComboBox1.SelectedItem),
                    AtomType.GetAtomType((string)bondComboBox2.SelectedItem),
                    d);
            //

            bond_muLabel.Text = mu.ToString("N3");
        }

        private void AddBond(Atom a1, Atom a2, double d)
        {
            double mu = 000;//FUNC!!!-----------------------------------------

            //
            mu = calcMuByBond(a1.type, a2.type, d);
            //

            if (atoms.Contains(a1))
                a1 = atoms[atoms.IndexOf(a1)];
            else
            {
                atoms.Add(a1);
                anglecomboBox1.Items.Add(a1.ToString());
                anglecomboBox2.Items.Add(a1.ToString());
                anglecomboBox3.Items.Add(a1.ToString());
            }
            if (atoms.Contains(a2))
                a2 = atoms[atoms.IndexOf(a2)];
            else
            {
                atoms.Add(a2);
                anglecomboBox1.Items.Add(a2.ToString());
                anglecomboBox2.Items.Add(a2.ToString());
                anglecomboBox3.Items.Add(a2.ToString());
            }

            if (bondsIndexator.ContainsKey((a1, a2)) || bondsIndexator.ContainsKey((a2, a1)))
            {
                if (MessageBox.Show(GetResource("value_info"), GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    (Atom, Atom) idx;
                    if (bondsIndexator.ContainsKey((a1, a2)))
                        idx = (a1, a2);
                    else
                        idx = (a2, a1);

                    int i = bondsIndexator[idx];

                    bondListView.Items[i].SubItems[1].Text = d.ToString();
                    bondListView.Items[i].SubItems[2].Text = mu.ToString("N3");

                    bonds[i] = (d, mu);
                }
                return;
            }

            bondsIndexator.Add((a1, a2), bonds.Count);
            bonds.Add((d, mu));

            ListViewItem listItem = new ListViewItem($"{a1} - {a2}", 0);
            listItem.SubItems.Add(d.ToString());
            listItem.SubItems.Add(mu.ToString("N3"));
            bondListView.Items.Add(listItem);

            if (!anglegroupBox.Enabled)
            {
                anglegroupBox.Enabled = true;
                anglecomboBox1.SelectedIndex = 0;
                anglecomboBox2.SelectedIndex = 0;
                anglecomboBox3.SelectedIndex = 0;
            }
        }

        private void DeleteBondAt(int i)
        {
            (Atom, Atom) toDel = (new Atom(), new Atom());
            foreach (var bond in bondsIndexator.Keys.ToArray())
            {
                if (bondsIndexator[bond] > i)
                    bondsIndexator[bond]--;
                else if (bondsIndexator[bond] == i)
                    toDel = bond;
            }
            bondsIndexator.Remove(toDel);

            Atom a1 = toDel.Item1, a2 = toDel.Item2;
            int a1n = 0, a2n = 0;
            foreach(var bond in bondsIndexator.Keys)
            {
                if (bond.Item1.Equals(a1) || bond.Item2.Equals(a1)) a1n++;
                if (bond.Item1.Equals(a2) || bond.Item2.Equals(a2)) a2n++;
            }
            if (bonds.Count == 1)
                anglegroupBox.Enabled = false;

            if (a1n == 0)
            {
                anglecomboBox1.Items.Remove(a1.ToString());
                if (bonds.Count != 1) anglecomboBox1.SelectedIndex = 0;
                anglecomboBox2.Items.Remove(a1.ToString());
                if (bonds.Count != 1) anglecomboBox2.SelectedIndex = 0;
                anglecomboBox3.Items.Remove(a1.ToString());
                if (bonds.Count != 1) anglecomboBox3.SelectedIndex = 0;
                atoms.Remove(a1);
            }
            if(a2n == 0)
            {
                anglecomboBox1.Items.Remove(a2.ToString());
                if (bonds.Count != 1) anglecomboBox1.SelectedIndex = 0;
                anglecomboBox2.Items.Remove(a2.ToString());
                if (bonds.Count != 1) anglecomboBox2.SelectedIndex = 0;
                anglecomboBox3.Items.Remove(a2.ToString());
                if (bonds.Count != 1) anglecomboBox3.SelectedIndex = 0;
                atoms.Remove(a2);
            }

            

            List<int> iToDel = new List<int>();
            foreach (var angle in anglesIndexator.Keys)
            {
                if (angle.Item1.Equals(a1) && angle.Item2.Equals(a2) ||
                    angle.Item1.Equals(a2) && angle.Item2.Equals(a1) ||
                    angle.Item2.Equals(a1) && angle.Item3.Equals(a2) ||
                    angle.Item3.Equals(a2) && angle.Item3.Equals(a1))
                    iToDel.Add(anglesIndexator[angle]);
            }

            foreach (var ai in iToDel)
            {
                DeleteAngleAt(ai);
            }

            bonds.RemoveAt(i);
            bondListView.Items.RemoveAt(i);

            RecalculateMu();
        }

        private void bond_addButton_Click(object sender, EventArgs e)
        {
            double d;
            try
            {
                d = Convert.ToDouble(bond_dTextBox.Text.Replace('.', ','));
            }
            catch
            {

                MessageBox.Show(string.Format(GetResource("value_error"), "d"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Atom a1 = new Atom() { type = AtomType.GetAtomType((string)bondComboBox1.SelectedItem), index = bond_indexTextBox1.Text },
                a2 = new Atom() { type = AtomType.GetAtomType((string)bondComboBox2.SelectedItem), index = bond_indexTextBox2.Text };

            AddBond(a1, a2, d);
        }

        private void bond_delButton_Click(object sender, EventArgs e)
        {
            if(bondListView.SelectedIndices.Count == 0) return;
            var i = bondListView.SelectedIndices[0];
            
            DeleteBondAt(i);
        }
        #endregion

        #region Angle
        private void angle_aTextBox_TextChanged(object sender, EventArgs e)
        {
            double angle;
            try
            {
                angle = Convert.ToDouble(angle_aTextBox.Text.Replace('.', ','));
            }
            catch
            {
                angle_aTextBox.ForeColor = Color.Red;
                angle_muLabel.Text = "-";
                return;
            }
            angle_aTextBox.ForeColor = Color.Black;

            Atom a1 = atoms[anglecomboBox1.SelectedIndex],
                a2 = atoms[anglecomboBox2.SelectedIndex],
                a3 = atoms[anglecomboBox3.SelectedIndex];

            if ((bondsIndexator.ContainsKey((a1, a2)) || bondsIndexator.ContainsKey((a2, a1))) && (bondsIndexator.ContainsKey((a2, a3)) || bondsIndexator.ContainsKey((a3, a2))))
            {
                double mu = 000;//FUNC!!!-----------------------------------------

                //
                double mu1, mu2;
                if (bondsIndexator.ContainsKey((a1, a2)))
                    mu1 = bonds[bondsIndexator[(a1, a2)]].mu;
                else
                    mu1 = bonds[bondsIndexator[(a2, a1)]].mu;

                if (bondsIndexator.ContainsKey((a2, a3)))
                    mu2 = bonds[bondsIndexator[(a2, a3)]].mu;
                else
                    mu2 = bonds[bondsIndexator[(a3, a2)]].mu;

                mu = calcMuByAngle(mu1, mu2, angle);
                //

                angle_muLabel.Text = mu.ToString("N3");
            }  
            else
                angle_muLabel.Text = "-";
        }

        private void AddAngle(Atom a1, Atom a2, Atom a3, double angle)
        {
            double mu = 000;//FUNC!!!-----------------------------------------

            //
            double mu1, mu2;
            if (bondsIndexator.ContainsKey((a1, a2)))
                mu1 = bonds[bondsIndexator[(a1, a2)]].mu;
            else
                mu1 = bonds[bondsIndexator[(a2, a1)]].mu;

            if (bondsIndexator.ContainsKey((a2, a3)))
                mu2 = bonds[bondsIndexator[(a2, a3)]].mu;
            else
                mu2 = bonds[bondsIndexator[(a3, a2)]].mu;

            mu = calcMuByAngle(mu1, mu2, angle);
            //

            if (anglesIndexator.ContainsKey((a1, a2, a3)) || anglesIndexator.ContainsKey((a3, a2, a1)))
            {
                if (MessageBox.Show(GetResource("value_info"), GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    (Atom, Atom, Atom) idx;
                    if (anglesIndexator.ContainsKey((a1, a2, a3)))
                        idx = (a1, a2, a3);
                    else
                        idx = (a3, a2, a1);

                    int i = anglesIndexator[idx];

                    angleListView.Items[i].SubItems[1].Text = angle.ToString();
                    angleListView.Items[i].SubItems[2].Text = mu.ToString("N3");
                    
                    angles[i] = (angle, mu);
                }
                return;
            }

            groupcomboBox.Items.Add($"{a1} - {a2} - {a3}");

            anglesIndexator.Add((a1, a2, a3), angles.Count);
            angles.Add((angle, mu));

            ListViewItem listItem = new ListViewItem($"{a1} - {a2} - {a3}", 0);
            listItem.SubItems.Add(angle.ToString());
            listItem.SubItems.Add(mu.ToString("N3"));
            angleListView.Items.Add(listItem);

            if (!groupGroupBox.Enabled)
            {
                groupGroupBox.Enabled = true;
                groupcomboBox.SelectedIndex = 0;
            }
        }

        private void DeleteAngleAt(int i)
        {
            groupcomboBox.Items.RemoveAt(i);

            if (angles.Count == 1)
                groupGroupBox.Enabled = false;
            else
                groupcomboBox.SelectedIndex = 0;

            (Atom, Atom, Atom) toDel = (new Atom(), new Atom(), new Atom());
            foreach (var angle in anglesIndexator.Keys.ToArray())
            {
                if (anglesIndexator[angle] > i)
                    anglesIndexator[angle]--;
                else if (anglesIndexator[angle] == i)
                    toDel = angle;
            }
            anglesIndexator.Remove(toDel);

            List<int> iToDel = new List<int>();
            for (int gi = molecule.Count - 1; gi >= 0; gi--)
            {
                if (molecule[gi].Item1.Equals(toDel.Item1) && molecule[gi].Item2.Equals(toDel.Item2) && molecule[gi].Item3.Equals(toDel.Item3))
                    iToDel.Add(gi);
            }

            foreach (var gi in iToDel)
            {
                DeleteGroupAt(gi);
            }

            angles.RemoveAt(i);
            angleListView.Items.RemoveAt(i);

            RecalculateMu();
        }

        private void angle_addButton_Click(object sender, EventArgs e)
        {
            double angle;
            try
            {
                angle = Convert.ToDouble(angle_aTextBox.Text.Replace('.', ','));
            }
            catch
            {

                MessageBox.Show(string.Format(GetResource("value_error"), "α"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Atom a1 = atoms[anglecomboBox1.SelectedIndex],
                a2 = atoms[anglecomboBox2.SelectedIndex],
                a3 = atoms[anglecomboBox3.SelectedIndex];

            if (!(bondsIndexator.ContainsKey((a1, a2)) || bondsIndexator.ContainsKey((a2, a1)))) 
            {
                MessageBox.Show(string.Format(GetResource("bond_error"), $"{a1} - {a2}"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(bondsIndexator.ContainsKey((a2, a3)) || bondsIndexator.ContainsKey((a3, a2))))
            {
                MessageBox.Show(string.Format(GetResource("bond_error"), $"{a2} - {a3}"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddAngle(a1, a2, a3, angle);
        }

        private void angle_delButton_Click(object sender, EventArgs e)
        {
            if (angleListView.SelectedIndices.Count == 0) return;
            var i = angleListView.SelectedIndices[0];
            DeleteAngleAt(i);
        }
        #endregion

        #region Group
        private void RecalculateMu()
        {
            if (molecule.Count == 0)
            {
                group_muLabel.Text = "-";
            }
            else
            {

                double mu = 1;//FUNC!!!-----------------------------------------

                //
                foreach (var group in molecule)
                {
                    mu *= angles[anglesIndexator[group]].mu;
                }
                mu = Math.Pow(mu, 1.0 / molecule.Count);
                //

                group_muLabel.Text = mu.ToString("N3");
            }
            radiusTextBox_TextChanged(radiusTextBox, new EventArgs());
        }

        private void AddGroup(Atom a1, Atom a2, Atom a3)
        {
            molecule.Add((a1, a2, a3));

            groupListView.Items.Add(new ListViewItem($"{a1} - {a2} - {a3}", 0));

            RecalculateMu();
        }

        private void DeleteGroupAt(int i)
        {
            molecule.RemoveAt(i);
            groupListView.Items.RemoveAt(i);
            
        }

        private void group_addButton_Click(object sender, EventArgs e)
        {
            var atms = BondToAtoms(groupcomboBox.Text);
            AddGroup(atms.Item1, atms.Item2, atms.Item3);
        }

        private void group_delButton_Click(object sender, EventArgs e)
        {
            if(groupListView.SelectedIndices.Count == 0) return;
            var i = groupListView.SelectedIndices[0];
            DeleteGroupAt(i);
            RecalculateMu();
        }

        private void radiusTextBox_TextChanged(object sender, EventArgs e)
        {
            double r;
            try
            {
                r = Convert.ToDouble(radiusTextBox.Text.Replace('.', ','));
            }
            catch
            {
                radiusTextBox.ForeColor = Color.Red;
                group_PLabel.Text = "-";
                return;
            }
            radiusTextBox.ForeColor = Color.Black;

            double mu;
            try
            {
                mu = Convert.ToDouble(group_muLabel.Text);
            }
            catch
            {
                group_PLabel.Text = "-";
                return;
            }

            double V = Math.PI * r * r * r * 4.0 / 3.0;
            double k = 1000000000.0 / 299792458;                // коэффициент из D/A в Кл/м^2
            group_PLabel.Text = (k * mu / V).ToString("N3");
        }
        #endregion
    }
}
