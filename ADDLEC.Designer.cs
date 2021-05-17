
namespace ITPM
{
    partial class ADDLEC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label emIdLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label faNameLabel;
            System.Windows.Forms.Label depNameLabel;
            System.Windows.Forms.Label centerLabel;
            System.Windows.Forms.Label buildingLabel;
            System.Windows.Forms.Label lecLevelLabel;
            System.Windows.Forms.Label lecRankLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDLEC));
            this.addlectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectDataSet = new ITPM.lectDataSet();
            this.addlectTableAdapter = new ITPM.lectDataSetTableAdapters.addlectTableAdapter();
            this.tableAdapterManager = new ITPM.lectDataSetTableAdapters.TableAdapterManager();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addlectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.faNameComboBox = new System.Windows.Forms.ComboBox();
            this.depNameComboBox = new System.Windows.Forms.ComboBox();
            this.centerComboBox = new System.Windows.Forms.ComboBox();
            this.buildingComboBox = new System.Windows.Forms.ComboBox();
            this.lecLevelComboBox = new System.Windows.Forms.ComboBox();
            this.lecRankComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            emIdLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            faNameLabel = new System.Windows.Forms.Label();
            depNameLabel = new System.Windows.Forms.Label();
            centerLabel = new System.Windows.Forms.Label();
            buildingLabel = new System.Windows.Forms.Label();
            lecLevelLabel = new System.Windows.Forms.Label();
            lecRankLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addlectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addlectDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(218, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 29);
            label1.TabIndex = 37;
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // emIdLabel
            // 
            emIdLabel.AutoSize = true;
            emIdLabel.BackColor = System.Drawing.Color.Transparent;
            emIdLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emIdLabel.Location = new System.Drawing.Point(67, 8);
            emIdLabel.Name = "emIdLabel";
            emIdLabel.Size = new System.Drawing.Size(149, 29);
            emIdLabel.TabIndex = 36;
            emIdLabel.Text = "LECTURER ID:";
            emIdLabel.Click += new System.EventHandler(this.emIdLabel_Click);
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = System.Drawing.Color.Transparent;
            fullNameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fullNameLabel.Location = new System.Drawing.Point(91, 51);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(121, 29);
            fullNameLabel.TabIndex = 23;
            fullNameLabel.Text = "Full Name:";
            // 
            // faNameLabel
            // 
            faNameLabel.AutoSize = true;
            faNameLabel.BackColor = System.Drawing.Color.Transparent;
            faNameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            faNameLabel.Location = new System.Drawing.Point(57, 97);
            faNameLabel.Name = "faNameLabel";
            faNameLabel.Size = new System.Drawing.Size(155, 29);
            faNameLabel.TabIndex = 25;
            faNameLabel.Text = "Faculty Name:";
            // 
            // depNameLabel
            // 
            depNameLabel.AutoSize = true;
            depNameLabel.BackColor = System.Drawing.Color.Transparent;
            depNameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            depNameLabel.Location = new System.Drawing.Point(5, 140);
            depNameLabel.Name = "depNameLabel";
            depNameLabel.Size = new System.Drawing.Size(207, 29);
            depNameLabel.TabIndex = 27;
            depNameLabel.Text = "Department Name:";
            // 
            // centerLabel
            // 
            centerLabel.AutoSize = true;
            centerLabel.BackColor = System.Drawing.Color.Transparent;
            centerLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            centerLabel.Location = new System.Drawing.Point(109, 187);
            centerLabel.Name = "centerLabel";
            centerLabel.Size = new System.Drawing.Size(87, 29);
            centerLabel.TabIndex = 29;
            centerLabel.Text = "Center:";
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.BackColor = System.Drawing.Color.Transparent;
            buildingLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buildingLabel.Location = new System.Drawing.Point(593, 53);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new System.Drawing.Size(101, 29);
            buildingLabel.TabIndex = 31;
            buildingLabel.Text = "Building:";
            // 
            // lecLevelLabel
            // 
            lecLevelLabel.AutoSize = true;
            lecLevelLabel.BackColor = System.Drawing.Color.Transparent;
            lecLevelLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lecLevelLabel.Location = new System.Drawing.Point(623, 110);
            lecLevelLabel.Name = "lecLevelLabel";
            lecLevelLabel.Size = new System.Drawing.Size(71, 29);
            lecLevelLabel.TabIndex = 33;
            lecLevelLabel.Text = "Level:";
            // 
            // lecRankLabel
            // 
            lecRankLabel.AutoSize = true;
            lecRankLabel.BackColor = System.Drawing.Color.Transparent;
            lecRankLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lecRankLabel.Location = new System.Drawing.Point(590, 159);
            lecRankLabel.Name = "lecRankLabel";
            lecRankLabel.Size = new System.Drawing.Size(104, 29);
            lecRankLabel.TabIndex = 35;
            lecRankLabel.Text = "lec Rank:";
            lecRankLabel.Click += new System.EventHandler(this.lecRankLabel_Click);
            // 
            // addlectBindingSource
            // 
            this.addlectBindingSource.DataMember = "addlect";
            this.addlectBindingSource.DataSource = this.lectDataSet;
            // 
            // lectDataSet
            // 
            this.lectDataSet.DataSetName = "lectDataSet";
            this.lectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addlectTableAdapter
            // 
            this.addlectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addlectTableAdapter = this.addlectTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ITPM.lectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.addlectDataGridView);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(emIdLabel);
            this.panel3.Controls.Add(fullNameLabel);
            this.panel3.Controls.Add(this.fullNameTextBox);
            this.panel3.Controls.Add(faNameLabel);
            this.panel3.Controls.Add(this.faNameComboBox);
            this.panel3.Controls.Add(depNameLabel);
            this.panel3.Controls.Add(this.depNameComboBox);
            this.panel3.Controls.Add(centerLabel);
            this.panel3.Controls.Add(this.centerComboBox);
            this.panel3.Controls.Add(buildingLabel);
            this.panel3.Controls.Add(this.buildingComboBox);
            this.panel3.Controls.Add(lecLevelLabel);
            this.panel3.Controls.Add(this.lecLevelComboBox);
            this.panel3.Controls.Add(lecRankLabel);
            this.panel3.Controls.Add(this.lecRankComboBox);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(181, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 606);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(907, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 41;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.Location = new System.Drawing.Point(540, 524);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(158, 51);
            this.btnupdate.TabIndex = 40;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(721, 524);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 51);
            this.button4.TabIndex = 39;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // addlectDataGridView
            // 
            this.addlectDataGridView.AutoGenerateColumns = false;
            this.addlectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addlectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.addlectDataGridView.DataSource = this.addlectBindingSource;
            this.addlectDataGridView.Location = new System.Drawing.Point(29, 237);
            this.addlectDataGridView.Name = "addlectDataGridView";
            this.addlectDataGridView.RowHeadersWidth = 51;
            this.addlectDataGridView.RowTemplate.Height = 24;
            this.addlectDataGridView.Size = new System.Drawing.Size(1059, 255);
            this.addlectDataGridView.TabIndex = 38;
            this.addlectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addlectDataGridView_CellContentClick);
            this.addlectDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addlectDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "emId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "faname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Faculty Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "depname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Department Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "center";
            this.dataGridViewTextBoxColumn5.HeaderText = "Center";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "building";
            this.dataGridViewTextBoxColumn6.HeaderText = "Building";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "lvl";
            this.dataGridViewTextBoxColumn7.HeaderText = "Level";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "lrank";
            this.dataGridViewTextBoxColumn8.HeaderText = "Rank";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(224, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTextBox.Location = new System.Drawing.Point(231, 51);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(344, 28);
            this.fullNameTextBox.TabIndex = 24;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.fullNameTextBox_TextChanged);
            // 
            // faNameComboBox
            // 
            this.faNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faNameComboBox.FormattingEnabled = true;
            this.faNameComboBox.Items.AddRange(new object[] {
            "FOC",
            "FOE",
            "FOM",
            "H&S",
            "SOA",
            "SOL",
            "SOH"});
            this.faNameComboBox.Location = new System.Drawing.Point(231, 96);
            this.faNameComboBox.Name = "faNameComboBox";
            this.faNameComboBox.Size = new System.Drawing.Size(344, 30);
            this.faNameComboBox.TabIndex = 26;
            this.faNameComboBox.SelectedIndexChanged += new System.EventHandler(this.faNameComboBox_SelectedIndexChanged);
            // 
            // depNameComboBox
            // 
            this.depNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depNameComboBox.FormattingEnabled = true;
            this.depNameComboBox.Items.AddRange(new object[] {
            "Department Of Information Technology",
            "Department Of Humanity And Sciences",
            "Department Of Cyber Sequrity",
            "Department Of Data Science",
            "Department Of Engineering",
            "Department Of Law",
            "Department Of Management",
            "Department Of Architecture"});
            this.depNameComboBox.Location = new System.Drawing.Point(231, 139);
            this.depNameComboBox.Name = "depNameComboBox";
            this.depNameComboBox.Size = new System.Drawing.Size(344, 30);
            this.depNameComboBox.TabIndex = 28;
            this.depNameComboBox.SelectedIndexChanged += new System.EventHandler(this.depNameComboBox_SelectedIndexChanged);
            // 
            // centerComboBox
            // 
            this.centerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerComboBox.FormattingEnabled = true;
            this.centerComboBox.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Kandy"});
            this.centerComboBox.Location = new System.Drawing.Point(231, 185);
            this.centerComboBox.Name = "centerComboBox";
            this.centerComboBox.Size = new System.Drawing.Size(344, 30);
            this.centerComboBox.TabIndex = 30;
            this.centerComboBox.SelectedIndexChanged += new System.EventHandler(this.centerComboBox_SelectedIndexChanged);
            // 
            // buildingComboBox
            // 
            this.buildingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingComboBox.FormattingEnabled = true;
            this.buildingComboBox.Items.AddRange(new object[] {
            "New Building",
            "Computing",
            "Engineering",
            "Business"});
            this.buildingComboBox.Location = new System.Drawing.Point(721, 54);
            this.buildingComboBox.Name = "buildingComboBox";
            this.buildingComboBox.Size = new System.Drawing.Size(344, 30);
            this.buildingComboBox.TabIndex = 32;
            this.buildingComboBox.SelectedIndexChanged += new System.EventHandler(this.buildingComboBox_SelectedIndexChanged);
            // 
            // lecLevelComboBox
            // 
            this.lecLevelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecLevelComboBox.FormattingEnabled = true;
            this.lecLevelComboBox.Items.AddRange(new object[] {
            "Assistent Lecturer",
            "Lecturer",
            "Senior Lecturer",
            "Proffecer",
            "Dean"});
            this.lecLevelComboBox.Location = new System.Drawing.Point(721, 106);
            this.lecLevelComboBox.Name = "lecLevelComboBox";
            this.lecLevelComboBox.Size = new System.Drawing.Size(344, 30);
            this.lecLevelComboBox.TabIndex = 34;
            this.lecLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.lecLevelComboBox_SelectedIndexChanged);
            // 
            // lecRankComboBox
            // 
            this.lecRankComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecRankComboBox.FormattingEnabled = true;
            this.lecRankComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lecRankComboBox.Location = new System.Drawing.Point(721, 156);
            this.lecRankComboBox.Name = "lecRankComboBox";
            this.lecRankComboBox.Size = new System.Drawing.Size(344, 30);
            this.lecRankComboBox.TabIndex = 36;
            this.lecRankComboBox.SelectedIndexChanged += new System.EventHandler(this.lecRankComboBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button3.Location = new System.Drawing.Point(352, 524);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button2.Location = new System.Drawing.Point(166, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 606);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button8.Location = new System.Drawing.Point(11, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 51);
            this.button8.TabIndex = 45;
            this.button8.Text = "SEARCH SESSION";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button7.Location = new System.Drawing.Point(12, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 51);
            this.button7.TabIndex = 44;
            this.button7.Text = "ADD SESSION";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button6.Location = new System.Drawing.Point(11, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 51);
            this.button6.TabIndex = 43;
            this.button6.Text = "SEARCH LECTURER";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 51);
            this.button5.TabIndex = 42;
            this.button5.Text = "ADD SUBJECT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ADDLEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ADDLEC";
            this.Text = "Add Lecturer";
            this.Load += new System.EventHandler(this.ADDLEC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addlectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addlectDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.ComboBox faNameComboBox;
        private System.Windows.Forms.ComboBox depNameComboBox;
        private System.Windows.Forms.ComboBox centerComboBox;
        private System.Windows.Forms.ComboBox buildingComboBox;
        private System.Windows.Forms.ComboBox lecLevelComboBox;
        private System.Windows.Forms.ComboBox lecRankComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private lectDataSet lectDataSet;
        private System.Windows.Forms.BindingSource addlectBindingSource;
        private lectDataSetTableAdapters.addlectTableAdapter addlectTableAdapter;
        private lectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView addlectDataGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

