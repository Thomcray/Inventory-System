namespace Inventory_System
{
    partial class addItems
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseAddItems = new System.Windows.Forms.Button();
            this.addsItemGroup = new System.Windows.Forms.GroupBox();
            this.txtNewBrand = new System.Windows.Forms.TextBox();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.lblNewBrand = new System.Windows.Forms.Label();
            this.lblNewQty = new System.Windows.Forms.Label();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.lblNewDesc = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.addItemMsgPanel = new System.Windows.Forms.Panel();
            this.lblAddItemMsg = new System.Windows.Forms.Label();
            this.txtNewCategoryCombo = new System.Windows.Forms.ComboBox();
            this.btnAddNewItems = new System.Windows.Forms.Button();
            this.newDateAdded = new System.Windows.Forms.DateTimePicker();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.intNewQty = new System.Windows.Forms.NumericUpDown();
            this.txtNewItemName = new System.Windows.Forms.TextBox();
            this.txtNewItemDesc = new System.Windows.Forms.TextBox();
            this.txtNewItemID = new System.Windows.Forms.TextBox();
            this.updateItemView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateupdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new Inventory_System.InventoryDataSet();
            this.updItemsGroup = new System.Windows.Forms.GroupBox();
            this.updMsgPanel = new System.Windows.Forms.Panel();
            this.lblUpdMsg = new System.Windows.Forms.Label();
            this.stockTableAdapter = new Inventory_System.InventoryDataSetTableAdapters.stockTableAdapter();
            this.panel1.SuspendLayout();
            this.addsItemGroup.SuspendLayout();
            this.addItemMsgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intNewQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateItemView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            this.updItemsGroup.SuspendLayout();
            this.updMsgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCloseAddItems);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseAddItems
            // 
            this.btnCloseAddItems.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseAddItems.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCloseAddItems.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseAddItems.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddItems.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAddItems.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseAddItems.Location = new System.Drawing.Point(1228, 9);
            this.btnCloseAddItems.Name = "btnCloseAddItems";
            this.btnCloseAddItems.Size = new System.Drawing.Size(30, 30);
            this.btnCloseAddItems.TabIndex = 0;
            this.btnCloseAddItems.Text = "x";
            this.btnCloseAddItems.UseVisualStyleBackColor = false;
            this.btnCloseAddItems.Click += new System.EventHandler(this.btnCloseAddItems_Click);
            // 
            // addsItemGroup
            // 
            this.addsItemGroup.Controls.Add(this.txtNewBrand);
            this.addsItemGroup.Controls.Add(this.lblNewDate);
            this.addsItemGroup.Controls.Add(this.lblNewPrice);
            this.addsItemGroup.Controls.Add(this.lblNewBrand);
            this.addsItemGroup.Controls.Add(this.lblNewQty);
            this.addsItemGroup.Controls.Add(this.lblNewCategory);
            this.addsItemGroup.Controls.Add(this.lblNewDesc);
            this.addsItemGroup.Controls.Add(this.lblItemName);
            this.addsItemGroup.Controls.Add(this.lblItemID);
            this.addsItemGroup.Controls.Add(this.addItemMsgPanel);
            this.addsItemGroup.Controls.Add(this.txtNewCategoryCombo);
            this.addsItemGroup.Controls.Add(this.btnAddNewItems);
            this.addsItemGroup.Controls.Add(this.newDateAdded);
            this.addsItemGroup.Controls.Add(this.txtNewPrice);
            this.addsItemGroup.Controls.Add(this.intNewQty);
            this.addsItemGroup.Controls.Add(this.txtNewItemName);
            this.addsItemGroup.Controls.Add(this.txtNewItemDesc);
            this.addsItemGroup.Controls.Add(this.txtNewItemID);
            this.addsItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsItemGroup.Location = new System.Drawing.Point(22, 77);
            this.addsItemGroup.Name = "addsItemGroup";
            this.addsItemGroup.Size = new System.Drawing.Size(570, 376);
            this.addsItemGroup.TabIndex = 1;
            this.addsItemGroup.TabStop = false;
            this.addsItemGroup.Text = "Add New Item";
            // 
            // txtNewBrand
            // 
            this.txtNewBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewBrand.Location = new System.Drawing.Point(323, 160);
            this.txtNewBrand.Name = "txtNewBrand";
            this.txtNewBrand.Size = new System.Drawing.Size(236, 26);
            this.txtNewBrand.TabIndex = 20;
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.Location = new System.Drawing.Point(320, 199);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(81, 16);
            this.lblNewDate.TabIndex = 18;
            this.lblNewDate.Text = "Date Added";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(5, 195);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(39, 16);
            this.lblNewPrice.TabIndex = 17;
            this.lblNewPrice.Text = "Price";
            // 
            // lblNewBrand
            // 
            this.lblNewBrand.AutoSize = true;
            this.lblNewBrand.Location = new System.Drawing.Point(320, 139);
            this.lblNewBrand.Name = "lblNewBrand";
            this.lblNewBrand.Size = new System.Drawing.Size(82, 16);
            this.lblNewBrand.TabIndex = 16;
            this.lblNewBrand.Text = "Brand/Label";
            // 
            // lblNewQty
            // 
            this.lblNewQty.AutoSize = true;
            this.lblNewQty.Location = new System.Drawing.Point(5, 139);
            this.lblNewQty.Name = "lblNewQty";
            this.lblNewQty.Size = new System.Drawing.Size(65, 16);
            this.lblNewQty.TabIndex = 15;
            this.lblNewQty.Text = "Available";
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(320, 81);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(63, 16);
            this.lblNewCategory.TabIndex = 14;
            this.lblNewCategory.Text = "Category";
            // 
            // lblNewDesc
            // 
            this.lblNewDesc.AutoSize = true;
            this.lblNewDesc.Location = new System.Drawing.Point(5, 81);
            this.lblNewDesc.Name = "lblNewDesc";
            this.lblNewDesc.Size = new System.Drawing.Size(76, 16);
            this.lblNewDesc.TabIndex = 13;
            this.lblNewDesc.Text = "Description";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(320, 22);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(73, 16);
            this.lblItemName.TabIndex = 12;
            this.lblItemName.Text = "Item Name";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(5, 22);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(46, 16);
            this.lblItemID.TabIndex = 11;
            this.lblItemID.Text = "ItemID";
            // 
            // addItemMsgPanel
            // 
            this.addItemMsgPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addItemMsgPanel.Controls.Add(this.lblAddItemMsg);
            this.addItemMsgPanel.Location = new System.Drawing.Point(5, 253);
            this.addItemMsgPanel.Name = "addItemMsgPanel";
            this.addItemMsgPanel.Size = new System.Drawing.Size(540, 44);
            this.addItemMsgPanel.TabIndex = 10;
            // 
            // lblAddItemMsg
            // 
            this.lblAddItemMsg.AutoSize = true;
            this.lblAddItemMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemMsg.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAddItemMsg.Location = new System.Drawing.Point(3, 13);
            this.lblAddItemMsg.Name = "lblAddItemMsg";
            this.lblAddItemMsg.Size = new System.Drawing.Size(0, 20);
            this.lblAddItemMsg.TabIndex = 0;
            // 
            // txtNewCategoryCombo
            // 
            this.txtNewCategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNewCategoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCategoryCombo.FormattingEnabled = true;
            this.txtNewCategoryCombo.Location = new System.Drawing.Point(323, 98);
            this.txtNewCategoryCombo.Name = "txtNewCategoryCombo";
            this.txtNewCategoryCombo.Size = new System.Drawing.Size(236, 28);
            this.txtNewCategoryCombo.TabIndex = 9;
            // 
            // btnAddNewItems
            // 
            this.btnAddNewItems.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddNewItems.FlatAppearance.BorderSize = 0;
            this.btnAddNewItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItems.Location = new System.Drawing.Point(6, 303);
            this.btnAddNewItems.Name = "btnAddNewItems";
            this.btnAddNewItems.Size = new System.Drawing.Size(551, 56);
            this.btnAddNewItems.TabIndex = 8;
            this.btnAddNewItems.Text = "Add New Item";
            this.btnAddNewItems.UseVisualStyleBackColor = false;
            this.btnAddNewItems.Click += new System.EventHandler(this.btnAddNewItems_Click);
            // 
            // newDateAdded
            // 
            this.newDateAdded.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDateAdded.Location = new System.Drawing.Point(323, 218);
            this.newDateAdded.Name = "newDateAdded";
            this.newDateAdded.Size = new System.Drawing.Size(236, 22);
            this.newDateAdded.TabIndex = 7;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPrice.Location = new System.Drawing.Point(8, 214);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(236, 26);
            this.txtNewPrice.TabIndex = 6;
            // 
            // intNewQty
            // 
            this.intNewQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intNewQty.Location = new System.Drawing.Point(8, 158);
            this.intNewQty.Name = "intNewQty";
            this.intNewQty.Size = new System.Drawing.Size(236, 26);
            this.intNewQty.TabIndex = 4;
            // 
            // txtNewItemName
            // 
            this.txtNewItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewItemName.Location = new System.Drawing.Point(323, 41);
            this.txtNewItemName.Name = "txtNewItemName";
            this.txtNewItemName.Size = new System.Drawing.Size(236, 26);
            this.txtNewItemName.TabIndex = 2;
            // 
            // txtNewItemDesc
            // 
            this.txtNewItemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewItemDesc.Location = new System.Drawing.Point(8, 100);
            this.txtNewItemDesc.Name = "txtNewItemDesc";
            this.txtNewItemDesc.Size = new System.Drawing.Size(236, 26);
            this.txtNewItemDesc.TabIndex = 1;
            // 
            // txtNewItemID
            // 
            this.txtNewItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewItemID.Location = new System.Drawing.Point(8, 41);
            this.txtNewItemID.Name = "txtNewItemID";
            this.txtNewItemID.Size = new System.Drawing.Size(236, 26);
            this.txtNewItemID.TabIndex = 0;
            // 
            // updateItemView
            // 
            this.updateItemView.AllowUserToAddRows = false;
            this.updateItemView.AutoGenerateColumns = false;
            this.updateItemView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.updateItemView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateItemView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.updateItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateItemView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dateupdatedDataGridViewTextBoxColumn,
            this.Update});
            this.updateItemView.DataSource = this.stockBindingSource;
            this.updateItemView.Location = new System.Drawing.Point(8, 51);
            this.updateItemView.Name = "updateItemView";
            this.updateItemView.RowHeadersVisible = false;
            this.updateItemView.Size = new System.Drawing.Size(643, 319);
            this.updateItemView.TabIndex = 3;
            this.updateItemView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateItemView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "itemid";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "iname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name*";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty*";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 42;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price*";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date_added";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date Added";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dateupdatedDataGridViewTextBoxColumn
            // 
            this.dateupdatedDataGridViewTextBoxColumn.DataPropertyName = "date_updated";
            this.dateupdatedDataGridViewTextBoxColumn.HeaderText = "Date Updated";
            this.dateupdatedDataGridViewTextBoxColumn.Name = "dateupdatedDataGridViewTextBoxColumn";
            this.dateupdatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateupdatedDataGridViewTextBoxColumn.Width = 120;
            // 
            // Update
            // 
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.HeaderText = "Action";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updItemsGroup
            // 
            this.updItemsGroup.Controls.Add(this.updMsgPanel);
            this.updItemsGroup.Controls.Add(this.updateItemView);
            this.updItemsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updItemsGroup.Location = new System.Drawing.Point(598, 77);
            this.updItemsGroup.Name = "updItemsGroup";
            this.updItemsGroup.Size = new System.Drawing.Size(659, 376);
            this.updItemsGroup.TabIndex = 4;
            this.updItemsGroup.TabStop = false;
            this.updItemsGroup.Text = "Update Items";
            // 
            // updMsgPanel
            // 
            this.updMsgPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.updMsgPanel.Controls.Add(this.lblUpdMsg);
            this.updMsgPanel.Location = new System.Drawing.Point(8, 18);
            this.updMsgPanel.Name = "updMsgPanel";
            this.updMsgPanel.Size = new System.Drawing.Size(643, 32);
            this.updMsgPanel.TabIndex = 4;
            // 
            // lblUpdMsg
            // 
            this.lblUpdMsg.AutoSize = true;
            this.lblUpdMsg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUpdMsg.Location = new System.Drawing.Point(3, 6);
            this.lblUpdMsg.Name = "lblUpdMsg";
            this.lblUpdMsg.Size = new System.Drawing.Size(533, 17);
            this.lblUpdMsg.TabIndex = 0;
            this.lblUpdMsg.Text = "Columns with asterisk (*) are editable. Ensure to press update button after editi" +
    "ng";
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // addItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 493);
            this.Controls.Add(this.updItemsGroup);
            this.Controls.Add(this.addsItemGroup);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Items";
            this.Load += new System.EventHandler(this.addItems_Load);
            this.panel1.ResumeLayout(false);
            this.addsItemGroup.ResumeLayout(false);
            this.addsItemGroup.PerformLayout();
            this.addItemMsgPanel.ResumeLayout(false);
            this.addItemMsgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intNewQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateItemView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            this.updItemsGroup.ResumeLayout(false);
            this.updMsgPanel.ResumeLayout(false);
            this.updMsgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox addsItemGroup;
        private System.Windows.Forms.NumericUpDown intNewQty;
        private System.Windows.Forms.TextBox txtNewItemName;
        private System.Windows.Forms.TextBox txtNewItemDesc;
        private System.Windows.Forms.TextBox txtNewItemID;
        private System.Windows.Forms.DateTimePicker newDateAdded;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Button btnAddNewItems;
        private System.Windows.Forms.ComboBox txtNewCategoryCombo;
        private System.Windows.Forms.Panel addItemMsgPanel;
        private System.Windows.Forms.Label lblAddItemMsg;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblNewDate;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.Label lblNewBrand;
        private System.Windows.Forms.Label lblNewQty;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.Label lblNewDesc;
        private System.Windows.Forms.Button btnCloseAddItems;
        private System.Windows.Forms.TextBox txtNewBrand;
        private System.Windows.Forms.DataGridView updateItemView;
        //private InventoryDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.GroupBox updItemsGroup;
        private System.Windows.Forms.Panel updMsgPanel;
        private System.Windows.Forms.Label lblUpdMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateaddedDataGridViewTextBoxColumn;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private InventoryDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateupdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}