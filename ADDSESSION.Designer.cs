
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDSESSION));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addsesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectDataSet2 = new ITPM.lectDataSet2();
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
            this.addsesTableAdapter = new ITPM.lectDataSet2TableAdapters.addsesTableAdapter();
            this.tableAdapterManager = new ITPM.lectDataSet2TableAdapters.TableAdapterManager();
            this.button7 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            emIdLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addsesDataGridView)).BeginInit();
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
            label3.Location = new System.Drawing.Point(946, 58);
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
            label5.Location = new System.Drawing.Point(881, 101);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.addsesDataGridView);
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
            this.panel3.Size = new System.Drawing.Size(1471, 563);
            this.panel3.TabIndex = 6;
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
            this.button6.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
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
            this.button5.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button5.Location = new System.Drawing.Point(12, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 51);
            this.button5.TabIndex = 42;
            this.button5.Text = "ADD SUBJECT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addsesDataGridView
            // 
            this.addsesDataGridView.AutoGenerateColumns = false;
            this.addsesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addsesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.addsesDataGridView.DataSource = this.addsesBindingSource;
            this.addsesDataGridView.Location = new System.Drawing.Point(483, 202);
            this.addsesDataGridView.Name = "addsesDataGridView";
            this.addsesDataGridView.RowHeadersWidth = 51;
            this.addsesDataGridView.RowTemplate.Height = 24;
            this.addsesDataGridView.Size = new System.Drawing.Size(976, 264);
            this.addsesDataGridView.TabIndex = 48;
            this.addsesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addsesDataGridView_CellClick);
            this.addsesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addsesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sesID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Session ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "lecname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Lecturer";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "asslecname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Assistant Lecturer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "grup";
            this.dataGridViewTextBoxColumn4.HeaderText = "Group";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "subj";
            this.dataGridViewTextBoxColumn5.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "numstd";
            this.dataGridViewTextBoxColumn6.HeaderText = "Number Of Students";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
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
            // 
            // numStudTextBox
            // 
            this.numStudTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStudTextBox.Location = new System.Drawing.Point(1116, 103);
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
            this.SubComboBox.Location = new System.Drawing.Point(1116, 59);
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::ITPM.Properties.Resources.background__1_;
            this.button7.Location = new System.Drawing.Point(12, 221);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 51);
            this.button7.TabIndex = 46;
            this.button7.Text = "SEARCH SESSION";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // ADDSESSION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 563);
            this.Controls.Add(this.panel3);
            this.Name = "ADDSESSION";
            this.Text = "ADD SESSION";
            this.Load += new System.EventHandler(this.ADDSESSION_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addsesDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView addsesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}