namespace dipol_moment_gui
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.file_createStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.file_openStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.file_saveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.langStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.lang_enStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.lang_ruStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.bondgroupBox = new System.Windows.Forms.GroupBox();
            this.bond_dTextBox = new System.Windows.Forms.TextBox();
            this.bond_indexTextBox2 = new System.Windows.Forms.TextBox();
            this.bond_indexTextBox1 = new System.Windows.Forms.TextBox();
            this.bondTable = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bond_tableLabel = new System.Windows.Forms.Label();
            this.bond_addButton = new System.Windows.Forms.Button();
            this.bond_muLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bondComboBox2 = new System.Windows.Forms.ComboBox();
            this.bondComboBox1 = new System.Windows.Forms.ComboBox();
            this.bondLabel = new System.Windows.Forms.Label();
            this.anglegroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.anglecomboBox1 = new System.Windows.Forms.ComboBox();
            this.anglecomboBox3 = new System.Windows.Forms.ComboBox();
            this.angle_aTextBox = new System.Windows.Forms.TextBox();
            this.angleTable = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.angle_tableLabel = new System.Windows.Forms.Label();
            this.angle_addButton = new System.Windows.Forms.Button();
            this.angle_muLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.anglecomboBox2 = new System.Windows.Forms.ComboBox();
            this.angleLabel = new System.Windows.Forms.Label();
            this.groupGroupBox = new System.Windows.Forms.GroupBox();
            this.group_PLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.group_muLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupcomboBox = new System.Windows.Forms.ComboBox();
            this.groupTable = new System.Windows.Forms.TableLayoutPanel();
            this.group_tableLabel = new System.Windows.Forms.Label();
            this.group_addButton = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.bondgroupBox.SuspendLayout();
            this.bondTable.SuspendLayout();
            this.anglegroupBox.SuspendLayout();
            this.angleTable.SuspendLayout();
            this.groupGroupBox.SuspendLayout();
            this.groupTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStrip,
            this.langStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStrip
            // 
            this.fileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_createStrip,
            this.file_openStrip,
            this.file_saveStrip});
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.Size = new System.Drawing.Size(37, 20);
            this.fileStrip.Text = "File";
            // 
            // file_createStrip
            // 
            this.file_createStrip.Name = "file_createStrip";
            this.file_createStrip.Size = new System.Drawing.Size(108, 22);
            this.file_createStrip.Text = "Create";
            this.file_createStrip.Click += new System.EventHandler(this.file_createStrip_Click);
            // 
            // file_openStrip
            // 
            this.file_openStrip.Name = "file_openStrip";
            this.file_openStrip.Size = new System.Drawing.Size(108, 22);
            this.file_openStrip.Text = "Open";
            this.file_openStrip.Click += new System.EventHandler(this.file_openStrip_Click);
            // 
            // file_saveStrip
            // 
            this.file_saveStrip.Name = "file_saveStrip";
            this.file_saveStrip.Size = new System.Drawing.Size(108, 22);
            this.file_saveStrip.Text = "Save";
            this.file_saveStrip.Click += new System.EventHandler(this.file_saveStrip_Click);
            // 
            // langStrip
            // 
            this.langStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lang_enStrip,
            this.lang_ruStrip});
            this.langStrip.Name = "langStrip";
            this.langStrip.Size = new System.Drawing.Size(71, 20);
            this.langStrip.Text = "Language";
            // 
            // lang_enStrip
            // 
            this.lang_enStrip.Name = "lang_enStrip";
            this.lang_enStrip.Size = new System.Drawing.Size(119, 22);
            this.lang_enStrip.Text = "English";
            this.lang_enStrip.Click += new System.EventHandler(this.langStrip_Click);
            // 
            // lang_ruStrip
            // 
            this.lang_ruStrip.Name = "lang_ruStrip";
            this.lang_ruStrip.Size = new System.Drawing.Size(119, 22);
            this.lang_ruStrip.Text = "Русский";
            this.lang_ruStrip.Click += new System.EventHandler(this.langStrip_Click);
            // 
            // bondgroupBox
            // 
            this.bondgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bondgroupBox.Controls.Add(this.bond_dTextBox);
            this.bondgroupBox.Controls.Add(this.bond_indexTextBox2);
            this.bondgroupBox.Controls.Add(this.bond_indexTextBox1);
            this.bondgroupBox.Controls.Add(this.bondTable);
            this.bondgroupBox.Controls.Add(this.bond_addButton);
            this.bondgroupBox.Controls.Add(this.bond_muLabel);
            this.bondgroupBox.Controls.Add(this.label3);
            this.bondgroupBox.Controls.Add(this.label2);
            this.bondgroupBox.Controls.Add(this.label1);
            this.bondgroupBox.Controls.Add(this.bondComboBox2);
            this.bondgroupBox.Controls.Add(this.bondComboBox1);
            this.bondgroupBox.Controls.Add(this.bondLabel);
            this.bondgroupBox.Location = new System.Drawing.Point(12, 48);
            this.bondgroupBox.Name = "bondgroupBox";
            this.bondgroupBox.Size = new System.Drawing.Size(895, 222);
            this.bondgroupBox.TabIndex = 2;
            this.bondgroupBox.TabStop = false;
            this.bondgroupBox.Text = "Dipole moment of a chemical bond";
            // 
            // bond_dTextBox
            // 
            this.bond_dTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_dTextBox.Location = new System.Drawing.Point(789, 29);
            this.bond_dTextBox.Name = "bond_dTextBox";
            this.bond_dTextBox.Size = new System.Drawing.Size(100, 24);
            this.bond_dTextBox.TabIndex = 12;
            this.bond_dTextBox.TextChanged += new System.EventHandler(this.bond_dTextBox_TextChanged);
            // 
            // bond_indexTextBox2
            // 
            this.bond_indexTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_indexTextBox2.Location = new System.Drawing.Point(698, 29);
            this.bond_indexTextBox2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bond_indexTextBox2.MaxLength = 7;
            this.bond_indexTextBox2.Name = "bond_indexTextBox2";
            this.bond_indexTextBox2.Size = new System.Drawing.Size(62, 24);
            this.bond_indexTextBox2.TabIndex = 11;
            // 
            // bond_indexTextBox1
            // 
            this.bond_indexTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_indexTextBox1.Location = new System.Drawing.Point(564, 29);
            this.bond_indexTextBox1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bond_indexTextBox1.MaxLength = 7;
            this.bond_indexTextBox1.Name = "bond_indexTextBox1";
            this.bond_indexTextBox1.Size = new System.Drawing.Size(62, 24);
            this.bond_indexTextBox1.TabIndex = 10;
            // 
            // bondTable
            // 
            this.bondTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bondTable.AutoScroll = true;
            this.bondTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.bondTable.ColumnCount = 3;
            this.bondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bondTable.Controls.Add(this.label5, 1, 0);
            this.bondTable.Controls.Add(this.label6, 2, 0);
            this.bondTable.Controls.Add(this.bond_tableLabel, 0, 0);
            this.bondTable.Location = new System.Drawing.Point(9, 70);
            this.bondTable.Name = "bondTable";
            this.bondTable.RowCount = 1;
            this.bondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bondTable.Size = new System.Drawing.Size(625, 146);
            this.bondTable.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(381, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "d";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(537, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "μ";
            // 
            // bond_tableLabel
            // 
            this.bond_tableLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bond_tableLabel.AutoSize = true;
            this.bond_tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bond_tableLabel.Location = new System.Drawing.Point(96, 1);
            this.bond_tableLabel.Name = "bond_tableLabel";
            this.bond_tableLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bond_tableLabel.Size = new System.Drawing.Size(120, 18);
            this.bond_tableLabel.TabIndex = 0;
            this.bond_tableLabel.Text = "Chemical bond";
            // 
            // bond_addButton
            // 
            this.bond_addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_addButton.Location = new System.Drawing.Point(789, 190);
            this.bond_addButton.Name = "bond_addButton";
            this.bond_addButton.Size = new System.Drawing.Size(100, 26);
            this.bond_addButton.TabIndex = 8;
            this.bond_addButton.Text = "Add";
            this.bond_addButton.UseVisualStyleBackColor = true;
            this.bond_addButton.Click += new System.EventHandler(this.bond_addButton_Click);
            // 
            // bond_muLabel
            // 
            this.bond_muLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_muLabel.AutoSize = true;
            this.bond_muLabel.Location = new System.Drawing.Point(683, 70);
            this.bond_muLabel.Name = "bond_muLabel";
            this.bond_muLabel.Size = new System.Drawing.Size(13, 18);
            this.bond_muLabel.TabIndex = 7;
            this.bond_muLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "μ   =";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // bondComboBox2
            // 
            this.bondComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bondComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bondComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bondComboBox2.FormattingEnabled = true;
            this.bondComboBox2.Items.AddRange(new object[] {
            "H",
            "C",
            "N",
            "O",
            "P"});
            this.bondComboBox2.Location = new System.Drawing.Point(651, 29);
            this.bondComboBox2.Name = "bondComboBox2";
            this.bondComboBox2.Size = new System.Drawing.Size(46, 26);
            this.bondComboBox2.TabIndex = 2;
            this.bondComboBox2.TabStop = false;
            this.bondComboBox2.SelectedIndexChanged += new System.EventHandler(this.bond_dTextBox_TextChanged);
            // 
            // bondComboBox1
            // 
            this.bondComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bondComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bondComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bondComboBox1.FormattingEnabled = true;
            this.bondComboBox1.Items.AddRange(new object[] {
            "H",
            "C",
            "N",
            "O",
            "P"});
            this.bondComboBox1.Location = new System.Drawing.Point(517, 29);
            this.bondComboBox1.Name = "bondComboBox1";
            this.bondComboBox1.Size = new System.Drawing.Size(46, 26);
            this.bondComboBox1.TabIndex = 1;
            this.bondComboBox1.TabStop = false;
            this.bondComboBox1.SelectedIndexChanged += new System.EventHandler(this.bond_dTextBox_TextChanged);
            // 
            // bondLabel
            // 
            this.bondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bondLabel.Location = new System.Drawing.Point(9, 32);
            this.bondLabel.Name = "bondLabel";
            this.bondLabel.Size = new System.Drawing.Size(502, 18);
            this.bondLabel.TabIndex = 0;
            this.bondLabel.Text = "Chemical bond length d:";
            this.bondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // anglegroupBox
            // 
            this.anglegroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anglegroupBox.Controls.Add(this.label9);
            this.anglegroupBox.Controls.Add(this.anglecomboBox1);
            this.anglegroupBox.Controls.Add(this.anglecomboBox3);
            this.anglegroupBox.Controls.Add(this.angle_aTextBox);
            this.anglegroupBox.Controls.Add(this.angleTable);
            this.anglegroupBox.Controls.Add(this.angle_addButton);
            this.anglegroupBox.Controls.Add(this.angle_muLabel);
            this.anglegroupBox.Controls.Add(this.label10);
            this.anglegroupBox.Controls.Add(this.label11);
            this.anglegroupBox.Controls.Add(this.label12);
            this.anglegroupBox.Controls.Add(this.anglecomboBox2);
            this.anglegroupBox.Controls.Add(this.angleLabel);
            this.anglegroupBox.Enabled = false;
            this.anglegroupBox.Location = new System.Drawing.Point(12, 276);
            this.anglegroupBox.Name = "anglegroupBox";
            this.anglegroupBox.Size = new System.Drawing.Size(895, 222);
            this.anglegroupBox.TabIndex = 13;
            this.anglegroupBox.TabStop = false;
            this.anglegroupBox.Text = "Dipole moment of a group of three conjugated atoms";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "-";
            // 
            // anglecomboBox1
            // 
            this.anglecomboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anglecomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anglecomboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anglecomboBox1.FormattingEnabled = true;
            this.anglecomboBox1.Location = new System.Drawing.Point(383, 29);
            this.anglecomboBox1.Name = "anglecomboBox1";
            this.anglecomboBox1.Size = new System.Drawing.Size(109, 26);
            this.anglecomboBox1.TabIndex = 14;
            this.anglecomboBox1.TabStop = false;
            this.anglecomboBox1.SelectedIndexChanged += new System.EventHandler(this.angle_aTextBox_TextChanged);
            // 
            // anglecomboBox3
            // 
            this.anglecomboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anglecomboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anglecomboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anglecomboBox3.FormattingEnabled = true;
            this.anglecomboBox3.Location = new System.Drawing.Point(651, 29);
            this.anglecomboBox3.Name = "anglecomboBox3";
            this.anglecomboBox3.Size = new System.Drawing.Size(109, 26);
            this.anglecomboBox3.TabIndex = 13;
            this.anglecomboBox3.TabStop = false;
            this.anglecomboBox3.SelectedIndexChanged += new System.EventHandler(this.angle_aTextBox_TextChanged);
            // 
            // angle_aTextBox
            // 
            this.angle_aTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.angle_aTextBox.Location = new System.Drawing.Point(789, 29);
            this.angle_aTextBox.Name = "angle_aTextBox";
            this.angle_aTextBox.Size = new System.Drawing.Size(100, 24);
            this.angle_aTextBox.TabIndex = 12;
            this.angle_aTextBox.TextChanged += new System.EventHandler(this.angle_aTextBox_TextChanged);
            // 
            // angleTable
            // 
            this.angleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.angleTable.AutoScroll = true;
            this.angleTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.angleTable.ColumnCount = 3;
            this.angleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.angleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.angleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.angleTable.Controls.Add(this.label4, 1, 0);
            this.angleTable.Controls.Add(this.label7, 2, 0);
            this.angleTable.Controls.Add(this.angle_tableLabel, 0, 0);
            this.angleTable.Location = new System.Drawing.Point(9, 70);
            this.angleTable.Name = "angleTable";
            this.angleTable.RowCount = 1;
            this.angleTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.angleTable.Size = new System.Drawing.Size(625, 146);
            this.angleTable.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(380, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "α";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(537, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "μ";
            // 
            // angle_tableLabel
            // 
            this.angle_tableLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.angle_tableLabel.AutoSize = true;
            this.angle_tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angle_tableLabel.Location = new System.Drawing.Point(96, 1);
            this.angle_tableLabel.Name = "angle_tableLabel";
            this.angle_tableLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.angle_tableLabel.Size = new System.Drawing.Size(120, 18);
            this.angle_tableLabel.TabIndex = 0;
            this.angle_tableLabel.Text = "Chemical bond";
            // 
            // angle_addButton
            // 
            this.angle_addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.angle_addButton.Location = new System.Drawing.Point(789, 190);
            this.angle_addButton.Name = "angle_addButton";
            this.angle_addButton.Size = new System.Drawing.Size(100, 26);
            this.angle_addButton.TabIndex = 8;
            this.angle_addButton.TabStop = false;
            this.angle_addButton.Text = "Add";
            this.angle_addButton.UseVisualStyleBackColor = true;
            this.angle_addButton.Click += new System.EventHandler(this.angle_addButton_Click);
            // 
            // angle_muLabel
            // 
            this.angle_muLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.angle_muLabel.AutoSize = true;
            this.angle_muLabel.Location = new System.Drawing.Point(683, 70);
            this.angle_muLabel.Name = "angle_muLabel";
            this.angle_muLabel.Size = new System.Drawing.Size(13, 18);
            this.angle_muLabel.TabIndex = 7;
            this.angle_muLabel.Text = "-";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "μ   =";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(766, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "=";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "-";
            // 
            // anglecomboBox2
            // 
            this.anglecomboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anglecomboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anglecomboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anglecomboBox2.FormattingEnabled = true;
            this.anglecomboBox2.Location = new System.Drawing.Point(517, 29);
            this.anglecomboBox2.Name = "anglecomboBox2";
            this.anglecomboBox2.Size = new System.Drawing.Size(109, 26);
            this.anglecomboBox2.TabIndex = 1;
            this.anglecomboBox2.TabStop = false;
            this.anglecomboBox2.SelectedIndexChanged += new System.EventHandler(this.angle_aTextBox_TextChanged);
            // 
            // angleLabel
            // 
            this.angleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.angleLabel.Location = new System.Drawing.Point(9, 32);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(368, 18);
            this.angleLabel.TabIndex = 0;
            this.angleLabel.Text = "Bond angle of a group of atoms α:";
            this.angleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupGroupBox
            // 
            this.groupGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupGroupBox.Controls.Add(this.group_PLabel);
            this.groupGroupBox.Controls.Add(this.label13);
            this.groupGroupBox.Controls.Add(this.radiusTextBox);
            this.groupGroupBox.Controls.Add(this.radiusLabel);
            this.groupGroupBox.Controls.Add(this.group_muLabel);
            this.groupGroupBox.Controls.Add(this.label17);
            this.groupGroupBox.Controls.Add(this.groupcomboBox);
            this.groupGroupBox.Controls.Add(this.groupTable);
            this.groupGroupBox.Controls.Add(this.group_addButton);
            this.groupGroupBox.Controls.Add(this.groupLabel);
            this.groupGroupBox.Enabled = false;
            this.groupGroupBox.Location = new System.Drawing.Point(12, 504);
            this.groupGroupBox.Name = "groupGroupBox";
            this.groupGroupBox.Size = new System.Drawing.Size(895, 267);
            this.groupGroupBox.TabIndex = 16;
            this.groupGroupBox.TabStop = false;
            this.groupGroupBox.Text = "Dipole moment of a functional \"topological atom\"";
            // 
            // group_PLabel
            // 
            this.group_PLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_PLabel.Location = new System.Drawing.Point(563, 236);
            this.group_PLabel.Name = "group_PLabel";
            this.group_PLabel.Size = new System.Drawing.Size(122, 18);
            this.group_PLabel.TabIndex = 25;
            this.group_PLabel.Text = "-";
            this.group_PLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(515, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = ", P   =";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiusTextBox.Location = new System.Drawing.Point(268, 233);
            this.radiusTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.radiusTextBox.MaxLength = 7;
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(62, 24);
            this.radiusTextBox.TabIndex = 23;
            this.radiusTextBox.TextChanged += new System.EventHandler(this.radiusTextBox_TextChanged);
            // 
            // radiusLabel
            // 
            this.radiusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(9, 236);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(249, 18);
            this.radiusLabel.TabIndex = 22;
            this.radiusLabel.Text = "Радиус \"топологического атома\" r";
            // 
            // group_muLabel
            // 
            this.group_muLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_muLabel.Location = new System.Drawing.Point(387, 236);
            this.group_muLabel.Name = "group_muLabel";
            this.group_muLabel.Size = new System.Drawing.Size(122, 18);
            this.group_muLabel.TabIndex = 21;
            this.group_muLabel.Text = "-";
            this.group_muLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(336, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 18);
            this.label17.TabIndex = 20;
            this.label17.Text = ", μ   =";
            // 
            // groupcomboBox
            // 
            this.groupcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupcomboBox.FormattingEnabled = true;
            this.groupcomboBox.Location = new System.Drawing.Point(512, 29);
            this.groupcomboBox.Name = "groupcomboBox";
            this.groupcomboBox.Size = new System.Drawing.Size(377, 26);
            this.groupcomboBox.TabIndex = 14;
            this.groupcomboBox.TabStop = false;
            // 
            // groupTable
            // 
            this.groupTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTable.AutoScroll = true;
            this.groupTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.groupTable.ColumnCount = 1;
            this.groupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.groupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.groupTable.Controls.Add(this.group_tableLabel, 0, 0);
            this.groupTable.Location = new System.Drawing.Point(9, 70);
            this.groupTable.Name = "groupTable";
            this.groupTable.RowCount = 1;
            this.groupTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.groupTable.Size = new System.Drawing.Size(625, 146);
            this.groupTable.TabIndex = 9;
            // 
            // group_tableLabel
            // 
            this.group_tableLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.group_tableLabel.AutoSize = true;
            this.group_tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_tableLabel.Location = new System.Drawing.Point(252, 1);
            this.group_tableLabel.Name = "group_tableLabel";
            this.group_tableLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.group_tableLabel.Size = new System.Drawing.Size(120, 18);
            this.group_tableLabel.TabIndex = 0;
            this.group_tableLabel.Text = "Chemical bond";
            // 
            // group_addButton
            // 
            this.group_addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_addButton.Location = new System.Drawing.Point(789, 190);
            this.group_addButton.Name = "group_addButton";
            this.group_addButton.Size = new System.Drawing.Size(100, 26);
            this.group_addButton.TabIndex = 8;
            this.group_addButton.TabStop = false;
            this.group_addButton.Text = "Add";
            this.group_addButton.UseVisualStyleBackColor = true;
            this.group_addButton.Click += new System.EventHandler(this.group_addButton_Click);
            // 
            // groupLabel
            // 
            this.groupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLabel.Location = new System.Drawing.Point(9, 32);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(497, 18);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "Group of three conjugated atoms";
            this.groupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 783);
            this.Controls.Add(this.groupGroupBox);
            this.Controls.Add(this.anglegroupBox);
            this.Controls.Add(this.bondgroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "DipolarCalc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bondgroupBox.ResumeLayout(false);
            this.bondgroupBox.PerformLayout();
            this.bondTable.ResumeLayout(false);
            this.bondTable.PerformLayout();
            this.anglegroupBox.ResumeLayout(false);
            this.anglegroupBox.PerformLayout();
            this.angleTable.ResumeLayout(false);
            this.angleTable.PerformLayout();
            this.groupGroupBox.ResumeLayout(false);
            this.groupGroupBox.PerformLayout();
            this.groupTable.ResumeLayout(false);
            this.groupTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStrip;
        private System.Windows.Forms.ToolStripMenuItem file_openStrip;
        private System.Windows.Forms.ToolStripMenuItem file_createStrip;
        private System.Windows.Forms.ToolStripMenuItem file_saveStrip;
        private System.Windows.Forms.ToolStripMenuItem langStrip;
        private System.Windows.Forms.ToolStripMenuItem lang_enStrip;
        private System.Windows.Forms.ToolStripMenuItem lang_ruStrip;
        private System.Windows.Forms.GroupBox bondgroupBox;
        private System.Windows.Forms.Label bondLabel;
        private System.Windows.Forms.ComboBox bondComboBox1;
        private System.Windows.Forms.ComboBox bondComboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bond_muLabel;
        private System.Windows.Forms.Button bond_addButton;
        private System.Windows.Forms.TableLayoutPanel bondTable;
        private System.Windows.Forms.TextBox bond_indexTextBox1;
        private System.Windows.Forms.TextBox bond_indexTextBox2;
        private System.Windows.Forms.TextBox bond_dTextBox;
        private System.Windows.Forms.Label bond_tableLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox anglegroupBox;
        private System.Windows.Forms.TextBox angle_aTextBox;
        private System.Windows.Forms.TableLayoutPanel angleTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label angle_tableLabel;
        private System.Windows.Forms.Button angle_addButton;
        private System.Windows.Forms.Label angle_muLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox anglecomboBox2;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.ComboBox anglecomboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox anglecomboBox1;
        private System.Windows.Forms.GroupBox groupGroupBox;
        private System.Windows.Forms.ComboBox groupcomboBox;
        private System.Windows.Forms.TableLayoutPanel groupTable;
        private System.Windows.Forms.Label group_tableLabel;
        private System.Windows.Forms.Button group_addButton;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label group_PLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label group_muLabel;
        private System.Windows.Forms.Label label17;
    }
}

