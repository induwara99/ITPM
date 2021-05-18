
namespace ITPM
{
    partial class PrintLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintLecturer));
            System.Windows.Forms.Label emIdLabel;
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label fanameLabel;
            System.Windows.Forms.Label depnameLabel;
            System.Windows.Forms.Label centerLabel;
            System.Windows.Forms.Label buildingLabel;
            System.Windows.Forms.Label lvlLabel;
            System.Windows.Forms.Label lrankLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtReceipt = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.print = new System.Windows.Forms.Button();
            this.lectDataSet = new ITPM.lectDataSet();
            this.addlectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addlectTableAdapter = new ITPM.lectDataSetTableAdapters.addlectTableAdapter();
            this.tableAdapterManager = new ITPM.lectDataSetTableAdapters.TableAdapterManager();
            this.addlectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addlectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.emIdTextBox = new System.Windows.Forms.TextBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.fanameTextBox = new System.Windows.Forms.TextBox();
            this.depnameTextBox = new System.Windows.Forms.TextBox();
            this.centerTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.lvlTextBox = new System.Windows.Forms.TextBox();
            this.lrankTextBox = new System.Windows.Forms.TextBox();
            this.addlectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsbtn = new System.Windows.Forms.Button();
            this.aDDLECBindingSource = new System.Windows.Forms.BindingSource(this.components);
            emIdLabel = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            fanameLabel = new System.Windows.Forms.Label();
            depnameLabel = new System.Windows.Forms.Label();
            centerLabel = new System.Windows.Forms.Label();
            buildingLabel = new System.Windows.Forms.Label();
            lvlLabel = new System.Windows.Forms.Label();
            lrankLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addlectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addlectBindingNavigator)).BeginInit();
            this.addlectBindingNavigator.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addlectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDLECBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-6, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 119);
            this.panel2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(418, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(465, 59);
            this.label6.TabIndex = 3;
            this.label6.Text = "Print Lecturer Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rtReceipt);
            this.panel1.Location = new System.Drawing.Point(678, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 456);
            this.panel1.TabIndex = 28;
            // 
            // rtReceipt
            // 
            this.rtReceipt.Location = new System.Drawing.Point(27, 20);
            this.rtReceipt.Name = "rtReceipt";
            this.rtReceipt.Size = new System.Drawing.Size(509, 412);
            this.rtReceipt.TabIndex = 0;
            this.rtReceipt.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.DarkGray;
            this.print.Location = new System.Drawing.Point(903, 615);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(158, 51);
            this.print.TabIndex = 50;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // lectDataSet
            // 
            this.lectDataSet.DataSetName = "lectDataSet";
            this.lectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addlectBindingSource
            // 
            this.addlectBindingSource.DataMember = "addlect";
            this.addlectBindingSource.DataSource = this.lectDataSet;
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
            // addlectBindingNavigator
            // 
            this.addlectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.addlectBindingNavigator.BindingSource = this.addlectBindingSource;
            this.addlectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.addlectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.addlectBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addlectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.addlectBindingNavigatorSaveItem});
            this.addlectBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.addlectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.addlectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.addlectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.addlectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.addlectBindingNavigator.Name = "addlectBindingNavigator";
            this.addlectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.addlectBindingNavigator.Size = new System.Drawing.Size(1285, 31);
            this.addlectBindingNavigator.TabIndex = 51;
            this.addlectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // addlectBindingNavigatorSaveItem
            // 
            this.addlectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addlectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("addlectBindingNavigatorSaveItem.Image")));
            this.addlectBindingNavigatorSaveItem.Name = "addlectBindingNavigatorSaveItem";
            this.addlectBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.addlectBindingNavigatorSaveItem.Text = "Save Data";
            this.addlectBindingNavigatorSaveItem.Click += new System.EventHandler(this.addlectBindingNavigatorSaveItem_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(emIdLabel);
            this.panel3.Controls.Add(this.emIdTextBox);
            this.panel3.Controls.Add(fnameLabel);
            this.panel3.Controls.Add(this.fnameTextBox);
            this.panel3.Controls.Add(fanameLabel);
            this.panel3.Controls.Add(this.fanameTextBox);
            this.panel3.Controls.Add(depnameLabel);
            this.panel3.Controls.Add(this.depnameTextBox);
            this.panel3.Controls.Add(centerLabel);
            this.panel3.Controls.Add(this.centerTextBox);
            this.panel3.Controls.Add(buildingLabel);
            this.panel3.Controls.Add(this.buildingTextBox);
            this.panel3.Controls.Add(lvlLabel);
            this.panel3.Controls.Add(this.lvlTextBox);
            this.panel3.Controls.Add(lrankLabel);
            this.panel3.Controls.Add(this.lrankTextBox);
            this.panel3.Controls.Add(this.addlectDataGridView);
            this.panel3.Location = new System.Drawing.Point(12, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 456);
            this.panel3.TabIndex = 52;
            // 
            // emIdLabel
            // 
            emIdLabel.AutoSize = true;
            emIdLabel.Location = new System.Drawing.Point(4, 229);
            emIdLabel.Name = "emIdLabel";
            emIdLabel.Size = new System.Drawing.Size(46, 17);
            emIdLabel.TabIndex = 67;
            emIdLabel.Text = "em Id:";
            // 
            // emIdTextBox
            // 
            this.emIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addlectBindingSource, "emId", true));
            this.emIdTextBox.Location = new System.Drawing.Point(99, 226);
            this.emIdTextBox.Name = "emIdTextBox";
            this.emIdTextBox.Size = new System.Drawing.Size(520, 22);
            this.emIdTextBox.TabIndex = 69;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new System.Drawing.Point(4, 257);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(51, 17);
            fnameLabel.TabIndex = 70;
            fnameLabel.Text = "fname:";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addlectBindingSource, "fname", true));
            this.fnameTextBox.Location = new System.Drawing.Point(99, 254);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(520, 22);
            this.fnameTextBox.TabIndex = 71;
            // 
            // fanameLabel
            // 
            fanameLabel.AutoSize = true;
            fanameLabel.Location = new System.Drawing.Point(4, 285);
            fanameLabel.Name = "fanameLabel";
            fanameLabel.Size = new System.Drawing.Size(59, 17);
            fanameLabel.TabIndex = 72;
            fanameLabel.Text = "faname:";
            // 
            // fanameTextBox
            // 
            this.fanameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addlectBindingSource, "faname", true));
            this.fanameTextBox.Location = new System.Drawing.Point(99, 282);
            this.fanameTextBox.Name = "fanameTextBox";
            this.fanameTextBox.Size = new System.Drawing.Size(520, 22);
            this.fanameTextBox.TabIndex = 73;
            // 
            // depnameLabel
            // 
            depnameLabel.AutoSize = true;
            depnameLabel.Location = new System.Drawing.Point(4, 313);
            depnameLabel.Name = "depnameLabel";
            depnameLabel.Size = new System.Drawing.Size(71, 17);
            depnameLabel.TabIndex = 74;
            depnameLabel.Text = "depname:";
            // 
            // depnameTextBox
            // 
            this.depnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addlectBindingSource, "depname", true));
            this.depnameTextBox.Location = new System.Drawing.Point(99, 310);
            this.depnameTextBox.Name = "depnameTextBox";
            this.depnameTextBox.Size = new System.Drawing.Size(520, 22);
            this.depnameTextBox.TabIndex = 75;
            // 
            // centerLabel
            // 
            centerLabel.AutoSize = true;
            centerLabel.Location = new System.Drawing.Point(4, 341);
            centerLabel.Name = "centerLabel";
            centerLabel.Size = new System.Drawing.Size(52, 17);
            centerLabel.TabIndex = 76;
            centerLabel.Text = "center:";
            // 
            // centerTextBox
            // 
            this.centerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addlectBindingSource, "center", true));
            this.centerTextBox.Location = new System.Drawing.Point(99, 338);
            this.centerTextBox.Name = "centerTextBox";
            this.centerTextBox.Size = new System.Drawing.Size(520, 22);
            this.centerTextBox.TabIndex = 77;
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.Location = new System.Drawing.Point(4, 369);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new System.Drawing.Size(61, 17);
            buildingLabel.TabIndex = 78;
            buildingLabel.Text = "building:";
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addlectBindingSource, "building", true));
            this.buildingTextBox.Location = new System.Drawing.Point(99, 366);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(520, 22);
            this.buildingTextBox.TabIndex = 79;
            // 
            // lvlLabel
            // 
            lvlLabel.AutoSize = true;
            lvlLabel.Location = new System.Drawing.Point(4, 397);
            lvlLabel.Name = "lvlLabel";
            lvlLabel.Size = new System.Drawing.Size(25, 17);
            lvlLabel.TabIndex = 80;
            lvlLabel.Text = "lvl:";
            // 
            // lvlTextBox
            // 
            this.lvlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addlectBindingSource, "lvl", true));
            this.lvlTextBox.Location = new System.Drawing.Point(99, 394);
            this.lvlTextBox.Name = "lvlTextBox";
            this.lvlTextBox.Size = new System.Drawing.Size(520, 22);
            this.lvlTextBox.TabIndex = 81;
            // 
            // lrankLabel
            // 
            lrankLabel.AutoSize = true;
            lrankLabel.Location = new System.Drawing.Point(4, 425);
            lrankLabel.Name = "lrankLabel";
            lrankLabel.Size = new System.Drawing.Size(43, 17);
            lrankLabel.TabIndex = 82;
            lrankLabel.Text = "lrank:";
            // 
            // lrankTextBox
            // 
            this.lrankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addlectBindingSource, "lrank", true));
            this.lrankTextBox.Location = new System.Drawing.Point(99, 422);
            this.lrankTextBox.Name = "lrankTextBox";
            this.lrankTextBox.Size = new System.Drawing.Size(520, 22);
            this.lrankTextBox.TabIndex = 83;
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
            this.addlectDataGridView.Location = new System.Drawing.Point(7, 20);
            this.addlectDataGridView.Name = "addlectDataGridView";
            this.addlectDataGridView.RowHeadersWidth = 51;
            this.addlectDataGridView.RowTemplate.Height = 24;
            this.addlectDataGridView.Size = new System.Drawing.Size(610, 195);
            this.addlectDataGridView.TabIndex = 68;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "emId";
            this.dataGridViewTextBoxColumn1.HeaderText = "emId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fname";
            this.dataGridViewTextBoxColumn2.HeaderText = "fname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "faname";
            this.dataGridViewTextBoxColumn3.HeaderText = "faname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "depname";
            this.dataGridViewTextBoxColumn4.HeaderText = "depname";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "center";
            this.dataGridViewTextBoxColumn5.HeaderText = "center";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "building";
            this.dataGridViewTextBoxColumn6.HeaderText = "building";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "lvl";
            this.dataGridViewTextBoxColumn7.HeaderText = "lvl";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "lrank";
            this.dataGridViewTextBoxColumn8.HeaderText = "lrank";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // recordsbtn
            // 
            this.recordsbtn.BackColor = System.Drawing.Color.DarkGray;
            this.recordsbtn.Location = new System.Drawing.Point(263, 615);
            this.recordsbtn.Name = "recordsbtn";
            this.recordsbtn.Size = new System.Drawing.Size(158, 51);
            this.recordsbtn.TabIndex = 53;
            this.recordsbtn.Text = "Records";
            this.recordsbtn.UseVisualStyleBackColor = false;
            this.recordsbtn.Click += new System.EventHandler(this.recordsbtn_Click);
            // 
            // aDDLECBindingSource
            // 
            this.aDDLECBindingSource.DataSource = typeof(ITPM.ADDLEC);
            // 
            // PrintLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 717);
            this.Controls.Add(this.recordsbtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addlectBindingNavigator);
            this.Controls.Add(this.print);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PrintLecturer";
            this.Text = "Print Lecturer Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addlectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addlectBindingNavigator)).EndInit();
            this.addlectBindingNavigator.ResumeLayout(false);
            this.addlectBindingNavigator.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addlectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDLECBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtReceipt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button print;
        private lectDataSet lectDataSet;
        private System.Windows.Forms.BindingSource addlectBindingSource;
        private lectDataSetTableAdapters.addlectTableAdapter addlectTableAdapter;
        private lectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator addlectBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton addlectBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource aDDLECBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox emIdTextBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox fanameTextBox;
        private System.Windows.Forms.TextBox depnameTextBox;
        private System.Windows.Forms.TextBox centerTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox lvlTextBox;
        private System.Windows.Forms.TextBox lrankTextBox;
        private System.Windows.Forms.DataGridView addlectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button recordsbtn;
    }
}