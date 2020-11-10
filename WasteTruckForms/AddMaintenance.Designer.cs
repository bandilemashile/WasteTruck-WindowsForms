namespace WasteTruckForms
{
    partial class AddMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMaintenance));
            System.Windows.Forms.Label vehicleLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label lastServiceLabel;
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maintenanceTableAdapter = new WasteTruckForms.WasteTruckDataSetTableAdapters.MaintenanceTableAdapter();
            this.tableAdapterManager = new WasteTruckForms.WasteTruckDataSetTableAdapters.TableAdapterManager();
            this.maintenanceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.maintenanceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.wasteTruckDataSet = new WasteTruckForms.WasteTruckDataSet();
            this.maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wasteTruckDataSet1 = new WasteTruckForms.WasteTruckDataSet1();
            this.maintenanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceTableAdapter1 = new WasteTruckForms.WasteTruckDataSet1TableAdapters.MaintenanceTableAdapter();
            this.tableAdapterManager1 = new WasteTruckForms.WasteTruckDataSet1TableAdapters.TableAdapterManager();
            this.vehicleTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.lastServiceTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            vehicleLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            lastServiceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingNavigator)).BeginInit();
            this.maintenanceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wasteTruckDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wasteTruckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.OrangeRed;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(99, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 31);
            this.button6.TabIndex = 50;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(265, 402);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 31);
            this.button5.TabIndex = 49;
            this.button5.Text = "Submit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(197, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(324, 32);
            this.title.TabIndex = 38;
            this.title.Text = "Create A Maintenance Plan";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-6, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 35);
            this.panel2.TabIndex = 35;
            // 
            // maintenanceTableAdapter
            // 
            this.maintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.MaintenanceTableAdapter = this.maintenanceTableAdapter;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WasteTruckForms.WasteTruckDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // maintenanceBindingNavigator
            // 
            this.maintenanceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.maintenanceBindingNavigator.BindingSource = this.maintenanceBindingSource;
            this.maintenanceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.maintenanceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.maintenanceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.maintenanceBindingNavigatorSaveItem});
            this.maintenanceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.maintenanceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.maintenanceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.maintenanceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.maintenanceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.maintenanceBindingNavigator.Name = "maintenanceBindingNavigator";
            this.maintenanceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.maintenanceBindingNavigator.Size = new System.Drawing.Size(682, 25);
            this.maintenanceBindingNavigator.TabIndex = 51;
            this.maintenanceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // maintenanceBindingNavigatorSaveItem
            // 
            this.maintenanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maintenanceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("maintenanceBindingNavigatorSaveItem.Image")));
            this.maintenanceBindingNavigatorSaveItem.Name = "maintenanceBindingNavigatorSaveItem";
            this.maintenanceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.maintenanceBindingNavigatorSaveItem.Text = "Save Data";
            this.maintenanceBindingNavigatorSaveItem.Click += new System.EventHandler(this.maintenanceBindingNavigatorSaveItem_Click);
            // 
            // wasteTruckDataSet
            // 
            this.wasteTruckDataSet.DataSetName = "WasteTruckDataSet";
            this.wasteTruckDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintenanceBindingSource
            // 
            this.maintenanceBindingSource.DataMember = "Maintenance";
            // 
            // wasteTruckDataSet1
            // 
            this.wasteTruckDataSet1.DataSetName = "WasteTruckDataSet1";
            this.wasteTruckDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintenanceBindingSource1
            // 
            this.maintenanceBindingSource1.DataMember = "Maintenance";
            this.maintenanceBindingSource1.DataSource = this.wasteTruckDataSet1;
            // 
            // maintenanceTableAdapter1
            // 
            this.maintenanceTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DriverTableAdapter = null;
            this.tableAdapterManager1.MaintenanceTableAdapter = this.maintenanceTableAdapter1;
            this.tableAdapterManager1.ScheduleTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WasteTruckForms.WasteTruckDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VehicleTableAdapter = null;
            // 
            // vehicleLabel
            // 
            vehicleLabel.AutoSize = true;
            vehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vehicleLabel.Location = new System.Drawing.Point(57, 109);
            vehicleLabel.Name = "vehicleLabel";
            vehicleLabel.Size = new System.Drawing.Size(97, 20);
            vehicleLabel.TabIndex = 51;
            vehicleLabel.Text = "Vehicle ID:";
            // 
            // vehicleTextBox
            // 
            this.vehicleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource1, "Vehicle", true));
            this.vehicleTextBox.Location = new System.Drawing.Point(177, 108);
            this.vehicleTextBox.Name = "vehicleTextBox";
            this.vehicleTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleTextBox.TabIndex = 52;
            this.vehicleTextBox.TextChanged += new System.EventHandler(this.vehicleTextBox_TextChanged_1);
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brandLabel.Location = new System.Drawing.Point(57, 154);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(95, 20);
            brandLabel.TabIndex = 53;
            brandLabel.Text = "Car Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource1, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(177, 153);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 54;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelLabel.Location = new System.Drawing.Point(57, 203);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(62, 20);
            modelLabel.TabIndex = 55;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource1, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(177, 202);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 56;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costLabel.Location = new System.Drawing.Point(57, 252);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(115, 20);
            costLabel.TabIndex = 57;
            costLabel.Text = "Service Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource1, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(177, 251);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 58;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            durationLabel.Location = new System.Drawing.Point(57, 304);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(83, 20);
            durationLabel.TabIndex = 59;
            durationLabel.Text = "Duration:";
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource1, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(177, 303);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 60;
            // 
            // lastServiceLabel
            // 
            lastServiceLabel.AutoSize = true;
            lastServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastServiceLabel.Location = new System.Drawing.Point(57, 353);
            lastServiceLabel.Name = "lastServiceLabel";
            lastServiceLabel.Size = new System.Drawing.Size(113, 20);
            lastServiceLabel.TabIndex = 61;
            lastServiceLabel.Text = "Last Service:";
            // 
            // lastServiceTextBox
            // 
            this.lastServiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceBindingSource1, "LastService", true));
            this.lastServiceTextBox.Location = new System.Drawing.Point(177, 352);
            this.lastServiceTextBox.Name = "lastServiceTextBox";
            this.lastServiceTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastServiceTextBox.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 242);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // AddMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(682, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(vehicleLabel);
            this.Controls.Add(this.vehicleTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(lastServiceLabel);
            this.Controls.Add(this.lastServiceTextBox);
            this.Controls.Add(this.maintenanceBindingNavigator);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel2);
            this.Name = "AddMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMaintenance";
            this.Load += new System.EventHandler(this.AddMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingNavigator)).EndInit();
            this.maintenanceBindingNavigator.ResumeLayout(false);
            this.maintenanceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wasteTruckDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wasteTruckDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource maintenanceBindingSource;
        private WasteTruckDataSetTableAdapters.MaintenanceTableAdapter maintenanceTableAdapter;
        private WasteTruckDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator maintenanceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton maintenanceBindingNavigatorSaveItem;
        private WasteTruckDataSet wasteTruckDataSet;
        private WasteTruckDataSet1 wasteTruckDataSet1;
        private System.Windows.Forms.BindingSource maintenanceBindingSource1;
        private WasteTruckDataSet1TableAdapters.MaintenanceTableAdapter maintenanceTableAdapter1;
        private WasteTruckDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox vehicleTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox lastServiceTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}