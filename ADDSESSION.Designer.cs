
namespace ITPM
{
    partial class ADDSESSION
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
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label emIdLabel;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDSESSION));
            this.panel3 = new System.Windows.Forms.Panel();
            this.typecomboBox1 = new System.Windows.Forms.ComboBox();
            this.ducomBox1 = new System.Windows.Forms.ComboBox();
            this.addsesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addsesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lectDataSet3 = new ITPM.lectDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelSes = new System.Windows.Forms.Label();
            this.numStudTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lecNaComboBox = new System.Windows.Forms.ComboBox();
            this.AssNameComboBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.SubComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectDataSet2 = new ITPM.lectDataSet2();
            this.addsesTableAdapter = new ITPM.lectDataSet2TableAdapters.addsesTableAdapter();
            this.tableAdapterManager = new ITPM.lectDataSet2TableAdapters.TableAdapterManager();
            this.addsesTableAdapter1 = new ITPM.lectDataSet3TableAdapters.addsesTableAdapter();
            this.tableAdapterManager1 = new ITPM.lectDataSet3TableAdapters.TableAdapterManager();
            label1 = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            emIdLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addsesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addsesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(278, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 29);
            label1.TabIndex = 37;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = System.Drawing.Color.Transparent;
            fullNameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fullNameLabel.Location = new System.Drawing.Point(291, 55);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(167, 29);
            fullNameLabel.TabIndex = 23;
            fullNameLabel.Text = "Select Lecturer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(193, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(264, 29);
            label2.TabIndex = 42;
            label2.Text = "Select Assistent Lecturer:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(299, 184);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(157, 29);
            label3.TabIndex = 43;
            label3.Text = "Select Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(310, 146);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(147, 29);
            label4.TabIndex = 44;
            label4.Text = "Select Group:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(881, 56);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(222, 29);
            label5.TabIndex = 46;
            label5.Text = "Number of Students:";
            // 
            // emIdLabel
            // 
            emIdLabel.AutoSize = true;
            emIdLabel.BackColor = System.Drawing.Color.Transparent;
            emIdLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emIdLabel.Location = new System.Drawing.Point(330, 9);
            emIdLabel.Name = "emIdLabel";
            emIdLabel.Size = new System.Drawing.Size(129, 29);
            emIdLabel.TabIndex = 47;
            emIdLabel.Text = "SESSION ID:";
            emIdLabel.Click += new System.EventHandler(this.emIdLabel_Click);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(1036, 147);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(67, 29);
            label7.TabIndex = 56;
            label7.Text = "Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(995, 101);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(108, 29);
            label6.TabIndex = 54;
            label6.Text = "Duration:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.typecomboBox1);
            this.panel3.Controls.Add(label7);
            this.panel3.Controls.Add(this.ducomBox1);
            this.panel3.Controls.Add(label6);
            this.panel3.Controls.Add(this.addsesDataGridView1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.labelSes);
            this.panel3.Controls.Add(emIdLabel);
            this.panel3.Controls.Add(label5);
            this.panel3.Controls.Add(this.numStudTextBox);
            this.panel3.Controls.Add(label4);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(fullNameLabel);
            this.panel3.Controls.Add(this.lecNaComboBox);
            this.panel3.Controls.Add(this.AssNameComboBox);
            this.panel3.Controls.Add(this.groupComboBox);
            this.panel3.Controls.Add(this.SubComboBox);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1480, 563);
            this.panel3.TabIndex = 6;
            // 
            // typecomboBox1
            // 
            this.typecomboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecomboBox1.FormattingEnabled = true;
            this.typecomboBox1.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practicle",
            "Viva",
            "Evaluation"});
            this.typecomboBox1.Location = new System.Drawing.Point(1116, 148);
            this.typecomboBox1.Name = "typecomboBox1";
            this.typecomboBox1.Size = new System.Drawing.Size(344, 30);
            this.typecomboBox1.TabIndex = 57;
            // 
            // ducomBox1
            // 
            this.ducomBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ducomBox1.FormattingEnabled = true;
            this.ducomBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ducomBox1.Location = new System.Drawing.Point(1116, 102);
            this.ducomBox1.Name = "ducomBox1";
            this.ducomBox1.Size = new System.Drawing.Size(344, 30);
            this.ducomBox1.TabIndex = 55;
            // 
            // addsesDataGridView1
            // 
            this.addsesDataGridView1.AutoGenerateColumns = false;
            this.addsesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addsesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.addsesDataGridView1.DataSource = this.addsesBindingSource1;
            this.addsesDataGridView1.Location = new System.Drawing.Point(486, 226);
            this.addsesDataGridView1.Name = "addsesDataGridView1";
            this.addsesDataGridView1.RowHeadersWidth = 51;
            this.addsesDataGridView1.RowTemplate.Height = 24;
            this.addsesDataGridView1.Size = new System.Drawing.Size(974, 251);
            this.addsesDataGridView1.TabIndex = 49;
            this.addsesDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addsesDataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "sesID";
            this.dataGridViewTextBoxColumn14.HeaderText = "Session ID";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "lecname";
            this.dataGridViewTextBoxColumn7.HeaderText = "Lecturer Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "asslecname";
            this.dataGridViewTextBoxColumn8.HeaderText = "Assistent Lecturer Name";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "grup";
            this.dataGridViewTextBoxColumn9.HeaderText = "Group";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "subj";
            this.dataGridViewTextBoxColumn10.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "numstd";
            this.dataGridViewTextBoxColumn11.HeaderText = "Stidents Count";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "duration";
            this.dataGridViewTextBoxColumn12.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "typ";
            this.dataGridViewTextBoxColumn13.HeaderText = "Type";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // addsesBindingSource1
            // 
            this.addsesBindingSource1.DataMember = "addses";
            this.addsesBindingSource1.DataSource = this.lectDataSet3;
            // 
            // lectDataSet3
            // 
            this.lectDataSet3.DataSetName = "lectDataSet3";
            this.lectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 563);
            this.panel1.TabIndex = 49;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Location = new System.Drawing.Point(12, 221);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 51);
            this.button7.TabIndex = 46;
            this.button7.Text = "SEARCH SESSION";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button8.Location = new System.Drawing.Point(12, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 51);
            this.button8.TabIndex = 45;
            this.button8.Text = "ADD LECTURER";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(12, 147);
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
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Location = new System.Drawing.Point(12, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 51);
            this.button5.TabIndex = 42;
            this.button5.Text = "ADD SUBJECT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelSes
            // 
            this.labelSes.AutoSize = true;
            this.labelSes.BackColor = System.Drawing.Color.Transparent;
            this.labelSes.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSes.ForeColor = System.Drawing.Color.Red;
            this.labelSes.Location = new System.Drawing.Point(487, 9);
            this.labelSes.Name = "labelSes";
            this.labelSes.Size = new System.Drawing.Size(74, 29);
            this.labelSes.TabIndex = 48;
            this.labelSes.Text = "label6";
            this.labelSes.Click += new System.EventHandler(this.labelSes_Click);
            // 
            // numStudTextBox
            // 
            this.numStudTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStudTextBox.Location = new System.Drawing.Point(1116, 58);
            this.numStudTextBox.Name = "numStudTextBox";
            this.numStudTextBox.Size = new System.Drawing.Size(344, 28);
            this.numStudTextBox.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1302, 488);
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
            this.btnupdate.Location = new System.Drawing.Point(887, 488);
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
            this.button4.Location = new System.Drawing.Point(1092, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 51);
            this.button4.TabIndex = 39;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lecNaComboBox
            // 
            this.lecNaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecNaComboBox.FormattingEnabled = true;
            this.lecNaComboBox.Location = new System.Drawing.Point(486, 56);
            this.lecNaComboBox.Name = "lecNaComboBox";
            this.lecNaComboBox.Size = new System.Drawing.Size(344, 30);
            this.lecNaComboBox.TabIndex = 26;
            // 
            // AssNameComboBox
            // 
            this.AssNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssNameComboBox.FormattingEnabled = true;
            this.AssNameComboBox.Location = new System.Drawing.Point(486, 99);
            this.AssNameComboBox.Name = "AssNameComboBox";
            this.AssNameComboBox.Size = new System.Drawing.Size(344, 30);
            this.AssNameComboBox.TabIndex = 28;
            this.AssNameComboBox.SelectedIndexChanged += new System.EventHandler(this.AssNameComboBox_SelectedIndexChanged);
            // 
            // groupComboBox
            // 
            this.groupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "Y3S1.01",
            "Y3S1.02",
            "Y3S1.03",
            "Y3S1.04",
            "Y3S1.05",
            "Y3S1.06",
            "Y3S1.07",
            "Y3S1.08",
            "Y3S1.09",
            "Y3S1.10",
            "Y3S1.11",
            "Y3S1.12"});
            this.groupComboBox.Location = new System.Drawing.Point(485, 145);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(344, 30);
            this.groupComboBox.TabIndex = 30;
            // 
            // SubComboBox
            // 
            this.SubComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubComboBox.FormattingEnabled = true;
            this.SubComboBox.Location = new System.Drawing.Point(485, 185);
            this.SubComboBox.Name = "SubComboBox";
            this.SubComboBox.Size = new System.Drawing.Size(344, 30);
            this.SubComboBox.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button3.Location = new System.Drawing.Point(689, 488);
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
            this.button2.Location = new System.Drawing.Point(482, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addsesBindingSource
            // 
            this.addsesBindingSource.DataMember = "addses";
            this.addsesBindingSource.DataSource = this.lectDataSet2;
            // 
            // lectDataSet2
            // 
            this.lectDataSet2.DataSetName = "lectDataSet2";
            this.lectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addsesTableAdapter
            // 
            this.addsesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addsesTableAdapter = this.addsesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ITPM.lectDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addsesTableAdapter1
            // 
            this.addsesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.addsesTableAdapter = this.addsesTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = ITPM.lectDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ADDSESSION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 563);
            this.Controls.Add(this.panel3);
            this.Name = "ADDSESSION";
            this.Text = "ADD SESSION";
            this.Load += new System.EventHandler(this.ADDSESSION_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addsesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addsesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox lecNaComboBox;
        private System.Windows.Forms.ComboBox AssNameComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox SubComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox numStudTextBox;
        private System.Windows.Forms.Label labelSes;
        private lectDataSet2 lectDataSet2;
        private System.Windows.Forms.BindingSource addsesBindingSource;
        private lectDataSet2TableAdapters.addsesTableAdapter addsesTableAdapter;
        private lectDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private lectDataSet3 lectDataSet3;
        private System.Windows.Forms.BindingSource addsesBindingSource1;
        private lectDataSet3TableAdapters.addsesTableAdapter addsesTableAdapter1;
        private lectDataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView addsesDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.ComboBox typecomboBox1;
        private System.Windows.Forms.ComboBox ducomBox1;
    }
}