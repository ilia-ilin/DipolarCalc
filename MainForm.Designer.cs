namespace DipolarCalc
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
            this.bond_delButton = new System.Windows.Forms.Button();
            this.bondListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bond_dTextBox = new System.Windows.Forms.TextBox();
            this.bond_indexTextBox2 = new System.Windows.Forms.TextBox();
            this.bond_indexTextBox1 = new System.Windows.Forms.TextBox();
            this.bond_addButton = new System.Windows.Forms.Button();
            this.bond_muLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bondComboBox2 = new System.Windows.Forms.ComboBox();
            this.bondComboBox1 = new System.Windows.Forms.ComboBox();
            this.bondLabel = new System.Windows.Forms.Label();
            this.anglegroupBox = new System.Windows.Forms.GroupBox();
            this.angle_delButton = new System.Windows.Forms.Button();
            this.angleListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.anglecomboBox1 = new System.Windows.Forms.ComboBox();
            this.anglecomboBox3 = new System.Windows.Forms.ComboBox();
            this.angle_aTextBox = new System.Windows.Forms.TextBox();
            this.angle_addButton = new System.Windows.Forms.Button();
            this.angle_muLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.anglecomboBox2 = new System.Windows.Forms.ComboBox();
            this.angleLabel = new System.Windows.Forms.Label();
            this.groupGroupBox = new System.Windows.Forms.GroupBox();
            this.group_delButton = new System.Windows.Forms.Button();
            this.groupListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_PLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.group_muLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupcomboBox = new System.Windows.Forms.ComboBox();
            this.group_addButton = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.bondgroupBox.SuspendLayout();
            this.anglegroupBox.SuspendLayout();
            this.groupGroupBox.SuspendLayout();
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
            this.bondgroupBox.Controls.Add(this.bond_delButton);
            this.bondgroupBox.Controls.Add(this.bondListView);
            this.bondgroupBox.Controls.Add(this.bond_dTextBox);
            this.bondgroupBox.Controls.Add(this.bond_indexTextBox2);
            this.bondgroupBox.Controls.Add(this.bond_indexTextBox1);
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
            // bond_delButton
            // 
            this.bond_delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_delButton.Location = new System.Drawing.Point(789, 190);
            this.bond_delButton.Name = "bond_delButton";
            this.bond_delButton.Size = new System.Drawing.Size(100, 26);
            this.bond_delButton.TabIndex = 14;
            this.bond_delButton.Text = "Delete";
            this.bond_delButton.UseVisualStyleBackColor = true;
            this.bond_delButton.Click += new System.EventHandler(this.bond_delButton_Click);
            // 
            // bondListView
            // 
            this.bondListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bondListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.bondListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bondListView.FullRowSelect = true;
            this.bondListView.HideSelection = false;
            this.bondListView.Location = new System.Drawing.Point(9, 70);
            this.bondListView.MultiSelect = false;
            this.bondListView.Name = "bondListView";
            this.bondListView.Size = new System.Drawing.Size(625, 146);
            this.bondListView.TabIndex = 13;
            this.bondListView.UseCompatibleStateImageBehavior = false;
            this.bondListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chemical bond";
            this.columnHeader1.Width = 344;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "d";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "μ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 124;
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
            // bond_addButton
            // 
            this.bond_addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_addButton.Location = new System.Drawing.Point(789, 158);
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
            this.anglegroupBox.Controls.Add(this.angle_delButton);
            this.anglegroupBox.Controls.Add(this.angleListView);
            this.anglegroupBox.Controls.Add(this.label9);
            this.anglegroupBox.Controls.Add(this.anglecomboBox1);
            this.anglegroupBox.Controls.Add(this.anglecomboBox3);
            this.anglegroupBox.Controls.Add(this.angle_aTextBox);
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
            // angle_delButton
            // 
            this.angle_delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.angle_delButton.Location = new System.Drawing.Point(789, 190);
            this.angle_delButton.Name = "angle_delButton";
            this.angle_delButton.Size = new System.Drawing.Size(100, 26);
            this.angle_delButton.TabIndex = 17;
            this.angle_delButton.TabStop = false;
            this.angle_delButton.Text = "Delete";
            this.angle_delButton.UseVisualStyleBackColor = true;
            this.angle_delButton.Click += new System.EventHandler(this.angle_delButton_Click);
            // 
            // angleListView
            // 
            this.angleListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.angleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.angleListView.FullRowSelect = true;
            this.angleListView.HideSelection = false;
            this.angleListView.Location = new System.Drawing.Point(9, 70);
            this.angleListView.MultiSelect = false;
            this.angleListView.Name = "angleListView";
            this.angleListView.Size = new System.Drawing.Size(625, 146);
            this.angleListView.TabIndex = 16;
            this.angleListView.UseCompatibleStateImageBehavior = false;
            this.angleListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chemical bond";
            this.columnHeader4.Width = 340;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "α";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "μ";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 123;
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
            // angle_addButton
            // 
            this.angle_addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.angle_addButton.Location = new System.Drawing.Point(789, 158);
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
            this.groupGroupBox.Controls.Add(this.group_delButton);
            this.groupGroupBox.Controls.Add(this.groupListView);
            this.groupGroupBox.Controls.Add(this.group_PLabel);
            this.groupGroupBox.Controls.Add(this.label13);
            this.groupGroupBox.Controls.Add(this.radiusTextBox);
            this.groupGroupBox.Controls.Add(this.radiusLabel);
            this.groupGroupBox.Controls.Add(this.group_muLabel);
            this.groupGroupBox.Controls.Add(this.label17);
            this.groupGroupBox.Controls.Add(this.groupcomboBox);
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
            // group_delButton
            // 
            this.group_delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.group_delButton.Location = new System.Drawing.Point(789, 190);
            this.group_delButton.Name = "group_delButton";
            this.group_delButton.Size = new System.Drawing.Size(100, 26);
            this.group_delButton.TabIndex = 27;
            this.group_delButton.TabStop = false;
            this.group_delButton.Text = "Delete";
            this.group_delButton.UseVisualStyleBackColor = true;
            this.group_delButton.Click += new System.EventHandler(this.group_delButton_Click);
            // 
            // groupListView
            // 
            this.groupListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.groupListView.FullRowSelect = true;
            this.groupListView.HideSelection = false;
            this.groupListView.Location = new System.Drawing.Point(9, 70);
            this.groupListView.MultiSelect = false;
            this.groupListView.Name = "groupListView";
            this.groupListView.Size = new System.Drawing.Size(625, 146);
            this.groupListView.TabIndex = 26;
            this.groupListView.UseCompatibleStateImageBehavior = false;
            this.groupListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Chemical bond";
            this.columnHeader7.Width = 149;
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
            // group_addButton
            // 
            this.group_addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_addButton.Location = new System.Drawing.Point(789, 158);
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
            this.MinimumSize = new System.Drawing.Size(935, 822);
            this.Name = "MainForm";
            this.Text = "DipolarCalc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.Form_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bondgroupBox.ResumeLayout(false);
            this.bondgroupBox.PerformLayout();
            this.anglegroupBox.ResumeLayout(false);
            this.anglegroupBox.PerformLayout();
            this.groupGroupBox.ResumeLayout(false);
            this.groupGroupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox bond_indexTextBox1;
        private System.Windows.Forms.TextBox bond_indexTextBox2;
        private System.Windows.Forms.TextBox bond_dTextBox;
        private System.Windows.Forms.GroupBox anglegroupBox;
        private System.Windows.Forms.TextBox angle_aTextBox;
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
        private System.Windows.Forms.Button group_addButton;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label group_PLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label group_muLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView bondListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView angleListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView groupListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button bond_delButton;
        private System.Windows.Forms.Button group_delButton;
        private System.Windows.Forms.Button angle_delButton;
    }
}

