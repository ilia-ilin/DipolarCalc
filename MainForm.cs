using dipol_moment_gui.Resources;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: NeutralResourcesLanguageAttribute("en-US")]

namespace dipol_moment_gui
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
            Dictionary<AtomType, double> electroneg = new Dictionary<AtomType, double>()
            {
                {AtomType.H, 2.2},
                {AtomType.C, 2.55},
                {AtomType.N, 3.04},
                {AtomType.O, 3.44},
                {AtomType.P, 2.19},
            };
            return Math.Abs(electroneg[a1] -  electroneg[a2]) * d;
        }
        private double calcMuByAngle(double mu1, double mu2, double a)
        {
            double mu = Math.Sqrt(mu1 * mu1 + mu2 * mu2 - 2 * mu1 * mu2 * Math.Cos(Math.PI * a / 180.0));
            return mu;
        }
        enum AtomType
        {
            H = 'H',
            C = 'C',
            N = 'N',
            O = 'O',
            P = 'P'
        }

        

        struct Atom
        {
            public AtomType type;
            public string index;

            public Atom(string s)
            {
                type = GetAtomType(s[0].ToString());
                index = s.Substring(1);
            }
            public static AtomType GetAtomType(string type)
            {
                switch (type)
                {
                    case "H":
                        return AtomType.H;
                    case "C":
                        return AtomType.C;
                    case "N":
                        return AtomType.N;
                    case "O":
                        return AtomType.O;
                    case "P":
                        return AtomType.P;
                    default:
                        throw new ArgumentException($"{type} is not available name of atom!");
                }
            }
            public override bool Equals(object b)
            {
                Atom B = (Atom)b;
                return (type == B.type && index == B.index);
            }
            public override string ToString()
            {
                return $"{type}{index}";
            }
        }

        List<Atom> atoms = new List<Atom>();
        Dictionary<(Atom, Atom), (int, double, double)> bonds = new Dictionary<(Atom, Atom), (int, double, double)>();
        Dictionary<(Atom, Atom, Atom), (int, double, double)> angles = new Dictionary<(Atom, Atom, Atom), (int, double, double)>();
        List<(Atom, Atom, Atom)> molecule = new List<(Atom, Atom, Atom)>();

        string savedFileName = "";

        public MainForm()
        {
            InitializeComponent();
            bondComboBox1.SelectedIndex = 0;
            bondComboBox2.SelectedIndex = 0;
            bondTable.RowStyles[0] = new RowStyle(SizeType.Absolute, 30);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyLanguage(Thread.CurrentThread.CurrentCulture);
            //α
            //μ
        }

        private void ApplyLanguage(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ResourceManager LocRM = new ResourceManager("dipol_moment_gui.Resources.Strings", typeof(Strings).Assembly);
            CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;
            fileStrip.Text = LocRM.GetString("fileStip.Text", currentCulture);
            file_createStrip.Text = LocRM.GetString("file_createStrip.Text", currentCulture);
            file_openStrip.Text = LocRM.GetString("file_openStrip.Text", currentCulture);
            file_saveStrip.Text = LocRM.GetString("file_saveStrip.Text", currentCulture);
            langStrip.Text = LocRM.GetString("langStrip.Text", currentCulture);
            bondgroupBox.Text = LocRM.GetString("bondgroupBox.Text", currentCulture);
            bondLabel.Text = LocRM.GetString("bondLabel.Text", currentCulture);
            bond_tableLabel.Text = LocRM.GetString("tableLabel.Text", currentCulture);
            bond_addButton.Text = LocRM.GetString("addButton.Text", currentCulture);

            anglegroupBox.Text = LocRM.GetString("anglegroupBox.Text", currentCulture);
            angleLabel.Text = LocRM.GetString("angleLabel.Text", currentCulture);
            angle_tableLabel.Text = LocRM.GetString("tableLabel.Text", currentCulture);
            angle_addButton.Text = LocRM.GetString("addButton.Text", currentCulture);

            groupGroupBox.Text = LocRM.GetString("groupGroupBox.Text", currentCulture);
            groupLabel.Text = LocRM.GetString("groupLabel.Text", currentCulture);
            group_tableLabel.Text = LocRM.GetString("tableLabel.Text", currentCulture);
            group_addButton.Text = LocRM.GetString("addButton.Text", currentCulture);
            radiusLabel.Text = LocRM.GetString("radiusLabel.Text", currentCulture);
        }
        private string GetResource(string name)
        {
            ResourceManager LocRM = new ResourceManager("dipol_moment_gui.Resources.Strings", typeof(Strings).Assembly);
            return LocRM.GetString(name, Thread.CurrentThread.CurrentUICulture);
        }

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
            mu = calcMuByBond(Atom.GetAtomType((string)bondComboBox1.SelectedItem),
                    Atom.GetAtomType((string)bondComboBox2.SelectedItem),
                    d);
            //

            bond_muLabel.Text = mu.ToString();
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

            if (bonds.ContainsKey((a1, a2)) || bonds.ContainsKey((a2, a1)))
            {
                if (MessageBox.Show(GetResource("value_info"), GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    (Atom, Atom) idx;
                    if (bonds.ContainsKey((a1, a2)))
                        idx = (a1, a2);
                    else
                        idx = (a2, a1);

                    int i = bonds[idx].Item1;

                    var dlabel = (Label)bondTable.Controls[$"d{i + 1}"];
                    var mulabel = (Label)bondTable.Controls[$"mu{i + 1}"];
                    bondTable.Controls.Remove(dlabel);
                    bondTable.Controls.Remove(mulabel);
                    bonds[idx] = (i, d, mu);
                    dlabel.Text = d.ToString();
                    mulabel.Text = mu.ToString();
                    bondTable.Controls.Add(dlabel, 1, i + 1);
                    bondTable.Controls.Add(mulabel, 2, i + 1);
                }
                return;
            }

            bonds.Add((a1, a2), (bonds.Count, d, mu));

            int n = bondTable.RowCount;
            AnchorStyles anchor = AnchorStyles.Top | AnchorStyles.Right;
            bondTable.RowCount += 1;
            bondTable.Controls.Add(new Label() { Text = $"{a1} - {a2}", Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight, AutoSize = true }, 0, n);
            bondTable.Controls.Add(new Label() { Name = $"d{n}", Text = d.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 1, n);
            bondTable.Controls.Add(new Label() { Name = $"mu{n}", Text = mu.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 2, n);

            if (!anglegroupBox.Enabled)
            {
                anglegroupBox.Enabled = true;
                anglecomboBox1.SelectedIndex = 0;
                anglecomboBox2.SelectedIndex = 0;
                anglecomboBox3.SelectedIndex = 0;
            }
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
            
            Atom a1 = new Atom() { type = Atom.GetAtomType((string)bondComboBox1.SelectedItem), index = bond_indexTextBox1.Text },
                a2 = new Atom() { type = Atom.GetAtomType((string)bondComboBox2.SelectedItem), index = bond_indexTextBox2.Text };

            AddBond(a1, a2, d);
        }

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

            if ((bonds.ContainsKey((a1, a2)) || bonds.ContainsKey((a2, a1))) && (bonds.ContainsKey((a2, a3)) || bonds.ContainsKey((a3, a2))))
            {
                double mu = 0;//FUNC!!!-----------------------------------------

                //
                double mu1, mu2;
                if (bonds.ContainsKey((a1, a2)))
                    mu1 = bonds[(a1, a2)].Item3;
                else
                    mu1 = bonds[(a2, a1)].Item3;

                if (bonds.ContainsKey((a2, a3)))
                    mu2 = bonds[(a2, a3)].Item3;
                else
                    mu2 = bonds[(a3, a2)].Item3;

                mu = calcMuByAngle(mu1, mu2, angle);
                //

                angle_muLabel.Text = mu.ToString();
            }  
            else
                angle_muLabel.Text = "-";
        }

        private void AddAngle(Atom a1, Atom a2, Atom a3, double angle)
        {
            double mu = 000;//FUNC!!!-----------------------------------------

            //
            double mu1, mu2;
            if (bonds.ContainsKey((a1, a2)))
                mu1 = bonds[(a1, a2)].Item3;
            else
                mu1 = bonds[(a2, a1)].Item3;

            if (bonds.ContainsKey((a2, a3)))
                mu2 = bonds[(a2, a3)].Item3;
            else
                mu2 = bonds[(a3, a2)].Item3;

            mu = calcMuByAngle(mu1, mu2, angle);
            //

            if (angles.ContainsKey((a1, a2, a3)) || angles.ContainsKey((a3, a2, a1)))
            {
                if (MessageBox.Show(GetResource("value_info"), GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    (Atom, Atom, Atom) idx;
                    if (angles.ContainsKey((a1, a2, a3)))
                        idx = (a1, a2, a3);
                    else
                        idx = (a3, a2, a1);

                    int i = angles[idx].Item1;

                    var dlabel = (Label)angleTable.Controls[$"angle{i + 1}"];
                    var mulabel = (Label)angleTable.Controls[$"mu{i + 1}"];
                    angleTable.Controls.Remove(dlabel);
                    angleTable.Controls.Remove(mulabel);
                    angles[idx] = (i, angle, mu);
                    dlabel.Text = angle.ToString();
                    mulabel.Text = mu.ToString();
                    angleTable.Controls.Add(dlabel, 1, i + 1);
                    angleTable.Controls.Add(mulabel, 2, i + 1);
                }
                return;
            }

            groupcomboBox.Items.Add($"{a1} - {a2} - {a3}");

            angles.Add((a1, a2, a3), (angles.Count, angle, mu));

            int n = angleTable.RowCount;
            AnchorStyles anchor = AnchorStyles.Top | AnchorStyles.Right;
            angleTable.RowCount += 1;
            angleTable.Controls.Add(new Label() { Text = $"{a1} - {a2} - {a3}", Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight, AutoSize = true }, 0, n);
            angleTable.Controls.Add(new Label() { Name = $"angle{n}", Text = angle.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 1, n);
            angleTable.Controls.Add(new Label() { Name = $"mu{n}", Text = mu.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 2, n);

            if (!groupGroupBox.Enabled)
            {
                groupGroupBox.Enabled = true;
                groupcomboBox.SelectedIndex = 0;
            }
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

            if (!(bonds.ContainsKey((a1, a2)) || bonds.ContainsKey((a2, a1)))) 
            {
                MessageBox.Show(string.Format(GetResource("bond_error"), $"{a1} - {a2}"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(bonds.ContainsKey((a2, a3)) || bonds.ContainsKey((a3, a2))))
            {
                MessageBox.Show(string.Format(GetResource("bond_error"), $"{a2} - {a3}"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddAngle(a1, a2, a3, angle);
        }

        private (Atom, Atom, Atom) BondToAtoms(string strGroup)
        {
            var strAtoms = strGroup.Split(new string[] { " - " }, StringSplitOptions.None);
            Atom a1 = new Atom(strAtoms[0]), a2 = new Atom(strAtoms[1]), a3;
            if(strAtoms.Length > 2) a3 = new Atom(strAtoms[2]);
            else a3 = new Atom();

            return (a1, a2, a3);
        }

        private void AddGroup(Atom a1, Atom a2, Atom a3)
        {
            molecule.Add((a1, a2, a3));

            int n = groupTable.RowCount;
            AnchorStyles anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupTable.RowCount += 1;
            groupTable.Controls.Add(new Label() { Text = groupcomboBox.Text, Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight, AutoSize = true }, 0, n);

            double mu = 1;//FUNC!!!-----------------------------------------

            //
            foreach (var group in molecule)
            {
                mu *= angles[group].Item3;
            }
            mu = Math.Pow(mu, 1.0 / molecule.Count);
            //

            group_muLabel.Text = mu.ToString();
        }

        private void group_addButton_Click(object sender, EventArgs e)
        {
            var atms = BondToAtoms(groupcomboBox.Text);
            AddGroup(atms.Item1, atms.Item2, atms.Item3);
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


            double mu = Convert.ToDouble(group_muLabel.Text);
            double V = Math.PI * r * r * r * 4.0 / 3.0;
            double k = 1000000000.0 / 299792458; // коэффициент из D/A в Кл/м^2
            group_PLabel.Text = (k * mu / V).ToString();
        }

        private void file_createStrip_Click(object sender, EventArgs e)
        {
            if(atoms.Count == 0) return;
            if (MessageBox.Show("Сохранить проект?", GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                file_saveStrip_Click(sender, e);
            savedFileName = "";

            bondComboBox1.SelectedIndex = 0;
            bond_indexTextBox1.Text = "";
            bondComboBox2.SelectedIndex = 0;
            bond_indexTextBox2.Text = "";
            bond_dTextBox.Text = "";

            Control c1 = bondTable.Controls[0];
            Control c2 = bondTable.Controls[1];
            Control c3 = bondTable.Controls[2];
            bondTable.Controls.Clear();
            bondTable.Controls.Add(c1);
            bondTable.Controls.Add(c2);
            bondTable.Controls.Add(c3);

            anglegroupBox.Enabled = false;

            anglecomboBox1.Items.Clear();
            anglecomboBox2.Items.Clear();
            anglecomboBox3.Items.Clear();
            angle_aTextBox.Text = "";

            c1 = angleTable.Controls[0];
            c2 = angleTable.Controls[1];
            c3 = angleTable.Controls[2];
            angleTable.Controls.Clear();
            angleTable.Controls.Add(c1);
            angleTable.Controls.Add(c2);
            angleTable.Controls.Add(c3);

            groupGroupBox.Enabled = false;

            groupcomboBox.Items.Clear();

            c1 = groupTable.Controls[0];
            groupTable.Controls.Clear();
            groupTable.Controls.Add(c1);

            radiusTextBox.Text = "";
            group_muLabel.Text = "";
            group_PLabel.Text = "-";

            atoms.Clear();
            bonds.Clear();
            angles.Clear();
            molecule.Clear();
        }

        private void file_openStrip_Click(object sender, EventArgs e)
        {
            if (atoms.Count > 0 && MessageBox.Show("Сохранить проект?", GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //--------------------------------------------------------------------------------------------------------------------------------------------------ПЕРЕВОД
                file_saveStrip_Click(sender, e);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                savedFileName = openFileDialog.FileName;

                using (StreamReader sr = new StreamReader(savedFileName))
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
        }

        private void file_saveStrip_Click(object sender, EventArgs e)
        {
            if (savedFileName != "")
            {
                using (StreamWriter sw = new StreamWriter(savedFileName))
                {
                    sw.WriteLine("Bonds");
                    foreach (var bond in bonds)
                    {
                        sw.Write(bond.Key.Item1.ToString() + " - ");     //a1
                        sw.Write(bond.Key.Item2.ToString() + "\t");     //a2
                        sw.WriteLine(bond.Value.Item2.ToString());      //d
                    }
                    sw.WriteLine();
                    sw.WriteLine("Angles");
                    foreach(var angle in angles)
                    {
                        sw.Write(angle.Key.Item1.ToString() + " - ");    //a1
                        sw.Write(angle.Key.Item2.ToString() + " - ");    //a2
                        sw.Write(angle.Key.Item3.ToString() + "\t");    //a3
                        sw.WriteLine(angle.Value.Item2.ToString());     //angle
                    }
                    sw.WriteLine();
                    sw.WriteLine("Molecule");
                    foreach(var angle in molecule)
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
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                savedFileName = saveFileDialog.FileName;
                file_saveStrip_Click(sender, e);
            }
        }
    }
}
