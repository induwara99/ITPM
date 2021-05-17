
namespace ITPM
{
    partial class ADDSUB
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.panel3 = new System.Windows.Forms.Panel();
            this.addsubDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addsubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectDataSet1 = new ITPM.lectDataSet1();
            this.subidtextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.subnatextbox2 = new System.Windows.Forms.TextBox();
            this.offsemComboBox = new System.Windows.Forms.ComboBox();
            this.offyearComboBox = new System.Windows.Forms.ComboBox();
            this.lechoComboBox = new System.Windows.Forms.ComboBox();
            this.lectutComboBox = new System.Windows.Forms.ComboBox();
            this.leclabComboBox = new System.Windows.Forms.ComboBox();
            this.lecevaComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addsubTableAdapter = new ITPM.lectDataSet1TableAdapters.addsubTableAdapter();
            this.tableAdapterManager = new ITPM.lectDataSet1TableAdapters.TableAdapterManager();
            this.button8 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            emIdLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            faNameLabel = new System.Windows.Forms.Label();
            depNameLabel = new System.Windows.Forms.Label();
            centerLabel = new System.Windows.Forms.Label();
            buildingLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addsubDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(178, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 29);
            label1.TabIndex = 37;
            // 
            // emIdLabel
            // 
            emIdLabel.AutoSize = true;
            emIdLabel.BackColor = System.Drawing.Color.Transparent;
            emIdLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emIdLabel.Location = new System.Drawing.Point(41, 47);
            emIdLabel.Name = "emIdLabel";
            emIdLabel.Size = new System.Drawing.Size(131, 29);
            emIdLabel.TabIndex = 36;
            emIdLabel.Text = "SUBJECT ID:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = System.Drawing.Color.Transparent;
            fullNameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fullNameLabel.Location = new System.Drawing.Point(30, 92);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(142, 29);
            fullNameLabel.TabIndex = 23;
            fullNameLabel.Text = "OFFER YEAR:";
            // 
            // faNameLabel
            // 
            faNameLabel.AutoSize = true;
            faNameLabel.BackColor = System.Drawing.Color.Transparent;
            faNameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            faNameLabel.Location = new System.Drawing.Point(39, 137);
            faNameLabel.Name = "faNameLabel";
            faNameLabel.Size = new System.Drawing.Size(133, 29);
            faNameLabel.TabIndex = 25;
            faNameLabel.Text = "OFFER SEM:";
            // 
            // depNameLabel
            // 
            depNameLabel.AutoSize = true;
            depNameLabel.BackColor = System.Drawing.Color.Transparent;
            depNameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            depNameLabel.Location = new System.Drawing.Point(14, 182);
            depNameLabel.Name = "depNameLabel";
            depNameLabel.Size = new System.Drawing.Size(158, 29);
            depNameLabel.TabIndex = 27;
            depNameLabel.Text = "Subject Name:";
            // 
            // centerLabel
            // 
            centerLabel.AutoSize = true;
            centerLabel.BackColor = System.Drawing.Color.Transparent;
            centerLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            centerLabel.Location = new System.Drawing.Point(531, 47);
            centerLabel.Name = "centerLabel";
            centerLabel.Size = new System.Drawing.Size(200, 29);
            centerLabel.TabIndex = 29;
            centerLabel.Text = "Num Of Lec Hours:";
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.BackColor = System.Drawing.Color.Transparent;
            buildingLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buildingLabel.Location = new System.Drawing.Point(531, 94);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new System.Drawing.Size(200, 29);
            buildingLabel.TabIndex = 31;
            buildingLabel.Text = "Num Of Tut Hours:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(531, 138);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(203, 29);
            label2.TabIndex = 43;
            label2.Text = "Num Of Lab Hours:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(531, 182);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(202, 29);
            label3.TabIndex = 44;
            label3.Text = "Num Of Eva Hours:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.addsubDataGridView);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(this.subidtextBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(emIdLabel);
            this.panel3.Controls.Add(fullNameLabel);
            this.panel3.Controls.Add(this.subnatextbox2);
            this.panel3.Controls.Add(faNameLabel);
            this.panel3.Controls.Add(this.offsemComboBox);
            this.panel3.Controls.Add(depNameLabel);
            this.panel3.Controls.Add(this.offyearComboBox);
            this.panel3.Controls.Add(centerLabel);
            this.panel3.Controls.Add(this.lechoComboBox);
            this.panel3.Controls.Add(buildingLabel);
            this.panel3.Controls.Add(this.lectutComboBox);
            this.panel3.Controls.Add(this.leclabComboBox);
            this.panel3.Controls.Add(this.lecevaComboBox);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(182, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 606);
            this.panel3.TabIndex = 8;
            // 
            // addsubDataGridView
            // 
            this.addsubDataGridView.AutoGenerateColumns = false;
            this.addsubDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addsubDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.addsubDataGridView.DataSource = this.addsubBindingSource;
            this.addsubDataGridView.Location = new System.Drawing.Point(35, 238);
            this.addsubDataGridView.Name = "addsubDataGridView";
            this.addsubDataGridView.RowHeadersWidth = 51;
            this.addsubDataGridView.RowTemplate.Height = 24;
            this.addsubDataGridView.Size = new System.Drawing.Size(1050, 198);
            this.addsubDataGridView.TabIndex = 44;
            this.addsubDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addsubDataGridView_CellClick);
            this.addsubDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addsubDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "subid";
            this.dataGridViewTextBoxColumn1.HeaderText = "subid";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "offyear";
            this.dataGridViewTextBoxColumn2.HeaderText = "offyear";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "offsem";
            this.dataGridViewTextBoxColumn3.HeaderText = "offsem";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subname";
            this.dataGridViewTextBoxColumn4.HeaderText = "subname";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "lechours";
            this.dataGridViewTextBoxColumn5.HeaderText = "lechours";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "lectuthours";
            this.dataGridViewTextBoxColumn6.HeaderText = "lectuthours";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "leclabhours";
            this.dataGridViewTextBoxColumn7.HeaderText = "leclabhours";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "lecevahours";
            this.dataGridViewTextBoxColumn8.HeaderText = "lecevahours";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // addsubBindingSource
            // 
            this.addsubBindingSource.DataMember = "addsub";
            this.addsubBindingSource.DataSource = this.lectDataSet1;
            // 
            // lectDataSet1
            // 
            this.lectDataSet1.DataSetName = "lectDataSet1";
            this.lectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subidtextBox1
            // 
            this.subidtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subidtextBox1.Location = new System.Drawing.Point(183, 47);
            this.subidtextBox1.Name = "subidtextBox1";
            this.subidtextBox1.Size = new System.Drawing.Size(344, 28);
            this.subidtextBox1.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(911, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 41;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnupdate.Location = new System.Drawing.Point(536, 456);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(158, 51);
            this.btnupdate.TabIndex = 40;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(721, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 51);
            this.button4.TabIndex = 39;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // subnatextbox2
            // 
            this.subnatextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnatextbox2.Location = new System.Drawing.Point(183, 183);
            this.subnatextbox2.Name = "subnatextbox2";
            this.subnatextbox2.Size = new System.Drawing.Size(344, 28);
            this.subnatextbox2.TabIndex = 24;
            // 
            // offsemComboBox
            // 
            this.offsemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offsemComboBox.FormattingEnabled = true;
            this.offsemComboBox.Items.AddRange(new object[] {
            "Semester 1",
            "Semester 2"});
            this.offsemComboBox.Location = new System.Drawing.Point(183, 138);
            this.offsemComboBox.Name = "offsemComboBox";
            this.offsemComboBox.Size = new System.Drawing.Size(344, 30);
            this.offsemComboBox.TabIndex = 26;
            // 
            // offyearComboBox
            // 
            this.offyearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offyearComboBox.FormattingEnabled = true;
            this.offyearComboBox.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.offyearComboBox.Location = new System.Drawing.Point(183, 93);
            this.offyearComboBox.Name = "offyearComboBox";
            this.offyearComboBox.Size = new System.Drawing.Size(344, 30);
            this.offyearComboBox.TabIndex = 28;
            // 
            // lechoComboBox
            // 
            this.lechoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lechoComboBox.FormattingEnabled = true;
            this.lechoComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lechoComboBox.Location = new System.Drawing.Point(744, 46);
            this.lechoComboBox.Name = "lechoComboBox";
            this.lechoComboBox.Size = new System.Drawing.Size(344, 30);
            this.lechoComboBox.TabIndex = 30;
            // 
            // lectutComboBox
            // 
            this.lectutComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectutComboBox.FormattingEnabled = true;
            this.lectutComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lectutComboBox.Location = new System.Drawing.Point(744, 92);
            this.lectutComboBox.Name = "lectutComboBox";
            this.lectutComboBox.Size = new System.Drawing.Size(344, 30);
            this.lectutComboBox.TabIndex = 32;
            // 
            // leclabComboBox
            // 
            this.leclabComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leclabComboBox.FormattingEnabled = true;
            this.leclabComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.leclabComboBox.Location = new System.Drawing.Point(744, 136);
            this.leclabComboBox.Name = "leclabComboBox";
            this.leclabComboBox.Size = new System.Drawing.Size(344, 30);
            this.leclabComboBox.TabIndex = 34;
            // 
            // lecevaComboBox
            // 
            this.lecevaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecevaComboBox.FormattingEnabled = true;
            this.lecevaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lecevaComboBox.Location = new System.Drawing.Point(744, 182);
            this.lecevaComboBox.Name = "lecevaComboBox";
            this.lecevaComboBox.Size = new System.Drawing.Size(344, 30);
            this.lecevaComboBox.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(356, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(170, 456);
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
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 606);
            this.panel1.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button6.Location = new System.Drawing.Point(12, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 51);
            this.button6.TabIndex = 45;
            this.button6.Text = "ADD SESSION";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button7.Location = new System.Drawing.Point(12, 161);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 51);
            this.button7.TabIndex = 44;
            this.button7.Text = "SEARCH LECTURER";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 51);
            this.button5.TabIndex = 42;
            this.button5.Text = "ADD LECTURER";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addsubTableAdapter
            // 
            this.addsubTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addsubTableAdapter = this.addsubTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ITPM.lectDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button8.Location = new System.Drawing.Point(12, 237);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 51);
            this.button8.TabIndex = 47;
            this.button8.Text = "SEARCH SESSION";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // ADDSUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ADDSUB";
            this.Text = "ADD SUBJECT";
            this.Load += new System.EventHandler(this.ADDSUB_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addsubDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox subnatextbox2;
        private System.Windows.Forms.ComboBox offsemComboBox;
        private System.Windows.Forms.ComboBox offyearComboBox;
        private System.Windows.Forms.ComboBox lechoComboBox;
        private System.Windows.Forms.ComboBox lectutComboBox;
        private System.Windows.Forms.ComboBox leclabComboBox;
        private System.Windows.Forms.ComboBox lecevaComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox subidtextBox1;
        private lectDataSet1 lectDataSet1;
        private System.Windows.Forms.BindingSource addsubBindingSource;
        private lectDataSet1TableAdapters.addsubTableAdapter addsubTableAdapter;
        private lectDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView addsubDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}