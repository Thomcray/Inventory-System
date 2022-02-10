namespace Inventory_System
{
    partial class sales
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
            this.saleTopPanel = new System.Windows.Forms.Panel();
            this.btnCloseSale = new System.Windows.Forms.Button();
            this.saleSearchPanel = new System.Windows.Forms.Panel();
            this.searchSaleIcon = new System.Windows.Forms.PictureBox();
            this.txtSearchSale = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.saleTextBoxGroup = new System.Windows.Forms.GroupBox();
            this.lblItemAvailable = new System.Windows.Forms.Label();
            this.txtItemAvailable = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.btnAddSaleList = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtBrandlabel = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.saleQty = new System.Windows.Forms.NumericUpDown();
            this.searchResultView = new System.Windows.Forms.DataGridView();
            this.listViewTable = new System.Windows.Forms.DataGridView();
            this.lblTotalListItem = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnPaymentMethod = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.lblSalesMsgs = new System.Windows.Forms.Label();
            this.salesMgsPanel = new System.Windows.Forms.Panel();
            this.lblSaleDiscount = new System.Windows.Forms.Label();
            this.btnPaymentPOS = new System.Windows.Forms.Button();
            this.txtSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscountName = new System.Windows.Forms.Label();
            this.lblSuTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.discountMsgPanel = new System.Windows.Forms.Panel();
            this.btnRemoveDMP = new System.Windows.Forms.Button();
            this.lblDBExpiryDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTxnID = new System.Windows.Forms.TextBox();
            this.lblTxnID = new System.Windows.Forms.Label();
            this.removeListItemIcon = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saleTopPanel.SuspendLayout();
            this.saleSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchSaleIcon)).BeginInit();
            this.saleTextBoxGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewTable)).BeginInit();
            this.salesMgsPanel.SuspendLayout();
            this.discountMsgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeListItemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // saleTopPanel
            // 
            this.saleTopPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.saleTopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saleTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saleTopPanel.Controls.Add(this.btnCloseSale);
            this.saleTopPanel.Location = new System.Drawing.Point(-1, -1);
            this.saleTopPanel.Name = "saleTopPanel";
            this.saleTopPanel.Size = new System.Drawing.Size(943, 53);
            this.saleTopPanel.TabIndex = 0;
            // 
            // btnCloseSale
            // 
            this.btnCloseSale.BackColor = System.Drawing.Color.Red;
            this.btnCloseSale.FlatAppearance.BorderSize = 0;
            this.btnCloseSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSale.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseSale.Location = new System.Drawing.Point(890, 3);
            this.btnCloseSale.Name = "btnCloseSale";
            this.btnCloseSale.Size = new System.Drawing.Size(51, 39);
            this.btnCloseSale.TabIndex = 0;
            this.btnCloseSale.Text = "x";
            this.btnCloseSale.UseVisualStyleBackColor = false;
            this.btnCloseSale.Click += new System.EventHandler(this.btnCloseSale_Click);
            // 
            // saleSearchPanel
            // 
            this.saleSearchPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saleSearchPanel.Controls.Add(this.searchSaleIcon);
            this.saleSearchPanel.Controls.Add(this.txtSearchSale);
            this.saleSearchPanel.Location = new System.Drawing.Point(12, 59);
            this.saleSearchPanel.Name = "saleSearchPanel";
            this.saleSearchPanel.Size = new System.Drawing.Size(746, 56);
            this.saleSearchPanel.TabIndex = 1;
            // 
            // searchSaleIcon
            // 
            this.searchSaleIcon.Image = global::Inventory_System.Properties.Resources.search;
            this.searchSaleIcon.Location = new System.Drawing.Point(669, 17);
            this.searchSaleIcon.Name = "searchSaleIcon";
            this.searchSaleIcon.Size = new System.Drawing.Size(37, 28);
            this.searchSaleIcon.TabIndex = 1;
            this.searchSaleIcon.TabStop = false;
            // 
            // txtSearchSale
            // 
            this.txtSearchSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSale.Location = new System.Drawing.Point(12, 17);
            this.txtSearchSale.Name = "txtSearchSale";
            this.txtSearchSale.Size = new System.Drawing.Size(654, 22);
            this.txtSearchSale.TabIndex = 0;
            this.txtSearchSale.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchSale_KeyUp);
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(20, 35);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(92, 15);
            this.txtItemID.TabIndex = 2;
            // 
            // saleTextBoxGroup
            // 
            this.saleTextBoxGroup.Controls.Add(this.lblItemAvailable);
            this.saleTextBoxGroup.Controls.Add(this.txtItemAvailable);
            this.saleTextBoxGroup.Controls.Add(this.lblCost);
            this.saleTextBoxGroup.Controls.Add(this.lblUnitPrice);
            this.saleTextBoxGroup.Controls.Add(this.lblBrand);
            this.saleTextBoxGroup.Controls.Add(this.lblDescription);
            this.saleTextBoxGroup.Controls.Add(this.lblItemName);
            this.saleTextBoxGroup.Controls.Add(this.lblQty);
            this.saleTextBoxGroup.Controls.Add(this.lblItemID);
            this.saleTextBoxGroup.Controls.Add(this.btnAddSaleList);
            this.saleTextBoxGroup.Controls.Add(this.txtCost);
            this.saleTextBoxGroup.Controls.Add(this.txtUnitPrice);
            this.saleTextBoxGroup.Controls.Add(this.txtBrandlabel);
            this.saleTextBoxGroup.Controls.Add(this.txtDescription);
            this.saleTextBoxGroup.Controls.Add(this.txtItemName);
            this.saleTextBoxGroup.Controls.Add(this.saleQty);
            this.saleTextBoxGroup.Controls.Add(this.txtItemID);
            this.saleTextBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleTextBoxGroup.Location = new System.Drawing.Point(12, 151);
            this.saleTextBoxGroup.Name = "saleTextBoxGroup";
            this.saleTextBoxGroup.Size = new System.Drawing.Size(876, 60);
            this.saleTextBoxGroup.TabIndex = 3;
            this.saleTextBoxGroup.TabStop = false;
            this.saleTextBoxGroup.Text = "Fields";
            // 
            // lblItemAvailable
            // 
            this.lblItemAvailable.AutoSize = true;
            this.lblItemAvailable.Location = new System.Drawing.Point(199, 18);
            this.lblItemAvailable.Name = "lblItemAvailable";
            this.lblItemAvailable.Size = new System.Drawing.Size(65, 16);
            this.lblItemAvailable.TabIndex = 18;
            this.lblItemAvailable.Text = "Available";
            // 
            // txtItemAvailable
            // 
            this.txtItemAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemAvailable.Location = new System.Drawing.Point(202, 35);
            this.txtItemAvailable.Name = "txtItemAvailable";
            this.txtItemAvailable.Size = new System.Drawing.Size(62, 15);
            this.txtItemAvailable.TabIndex = 17;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(686, 18);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 16);
            this.lblCost.TabIndex = 16;
            this.lblCost.Text = "Cost";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(583, 18);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(65, 16);
            this.lblUnitPrice.TabIndex = 15;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(478, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(44, 16);
            this.lblBrand.TabIndex = 14;
            this.lblBrand.Text = "Brand";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(375, 18);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(271, 18);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(73, 16);
            this.lblItemName.TabIndex = 12;
            this.lblItemName.Text = "Item Name";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(125, 14);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(28, 16);
            this.lblQty.TabIndex = 11;
            this.lblQty.Text = "Qty";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(21, 18);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(46, 16);
            this.lblItemID.TabIndex = 10;
            this.lblItemID.Text = "ItemID";
            // 
            // btnAddSaleList
            // 
            this.btnAddSaleList.Location = new System.Drawing.Point(793, 32);
            this.btnAddSaleList.Name = "btnAddSaleList";
            this.btnAddSaleList.Size = new System.Drawing.Size(78, 22);
            this.btnAddSaleList.TabIndex = 9;
            this.btnAddSaleList.Text = "Add to List";
            this.btnAddSaleList.UseVisualStyleBackColor = true;
            this.btnAddSaleList.Click += new System.EventHandler(this.btnAddSaleList_Click);
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(689, 35);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 15);
            this.txtCost.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(586, 35);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(92, 15);
            this.txtUnitPrice.TabIndex = 7;
            // 
            // txtBrandlabel
            // 
            this.txtBrandlabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrandlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandlabel.Location = new System.Drawing.Point(481, 35);
            this.txtBrandlabel.Name = "txtBrandlabel";
            this.txtBrandlabel.Size = new System.Drawing.Size(92, 15);
            this.txtBrandlabel.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(378, 35);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(92, 15);
            this.txtDescription.TabIndex = 5;
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(274, 35);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(92, 15);
            this.txtItemName.TabIndex = 4;
            // 
            // saleQty
            // 
            this.saleQty.Location = new System.Drawing.Point(128, 30);
            this.saleQty.Name = "saleQty";
            this.saleQty.Size = new System.Drawing.Size(66, 22);
            this.saleQty.TabIndex = 3;
            this.saleQty.ValueChanged += new System.EventHandler(this.saleQty_ValueChanged);
            // 
            // searchResultView
            // 
            this.searchResultView.AllowUserToAddRows = false;
            this.searchResultView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.searchResultView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultView.Location = new System.Drawing.Point(19, 99);
            this.searchResultView.Name = "searchResultView";
            this.searchResultView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResultView.Size = new System.Drawing.Size(660, 64);
            this.searchResultView.TabIndex = 4;
            this.searchResultView.SelectionChanged += new System.EventHandler(this.searchResultView_SelectionChanged);
            // 
            // listViewTable
            // 
            this.listViewTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listViewTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listViewTable.Location = new System.Drawing.Point(12, 214);
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.ReadOnly = true;
            this.listViewTable.Size = new System.Drawing.Size(743, 250);
            this.listViewTable.TabIndex = 5;
            // 
            // lblTotalListItem
            // 
            this.lblTotalListItem.AutoSize = true;
            this.lblTotalListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalListItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTotalListItem.Location = new System.Drawing.Point(669, 497);
            this.lblTotalListItem.Name = "lblTotalListItem";
            this.lblTotalListItem.Size = new System.Drawing.Size(18, 20);
            this.lblTotalListItem.TabIndex = 6;
            this.lblTotalListItem.Text = "0";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(655, 467);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubTotal.TabIndex = 7;
            // 
            // btnPaymentMethod
            // 
            this.btnPaymentMethod.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPaymentMethod.FlatAppearance.BorderSize = 0;
            this.btnPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentMethod.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPaymentMethod.Location = new System.Drawing.Point(431, 619);
            this.btnPaymentMethod.Name = "btnPaymentMethod";
            this.btnPaymentMethod.Size = new System.Drawing.Size(117, 32);
            this.btnPaymentMethod.TabIndex = 9;
            this.btnPaymentMethod.Text = "Cash/Cheque";
            this.btnPaymentMethod.UseVisualStyleBackColor = false;
            this.btnPaymentMethod.Click += new System.EventHandler(this.btnPaymentMethod_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnpayment.FlatAppearance.BorderSize = 2;
            this.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.Location = new System.Drawing.Point(567, 619);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(85, 32);
            this.btnpayment.TabIndex = 10;
            this.btnpayment.Text = "Transfer";
            this.btnpayment.UseVisualStyleBackColor = true;
            this.btnpayment.Click += new System.EventHandler(this.btnPaymentMethod_Click);
            // 
            // lblSalesMsgs
            // 
            this.lblSalesMsgs.AutoSize = true;
            this.lblSalesMsgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesMsgs.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSalesMsgs.Location = new System.Drawing.Point(3, 7);
            this.lblSalesMsgs.Name = "lblSalesMsgs";
            this.lblSalesMsgs.Size = new System.Drawing.Size(0, 20);
            this.lblSalesMsgs.TabIndex = 11;
            // 
            // salesMgsPanel
            // 
            this.salesMgsPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.salesMgsPanel.Controls.Add(this.lblSalesMsgs);
            this.salesMgsPanel.Location = new System.Drawing.Point(9, 657);
            this.salesMgsPanel.Name = "salesMgsPanel";
            this.salesMgsPanel.Size = new System.Drawing.Size(744, 35);
            this.salesMgsPanel.TabIndex = 12;
            // 
            // lblSaleDiscount
            // 
            this.lblSaleDiscount.AutoSize = true;
            this.lblSaleDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDiscount.Location = new System.Drawing.Point(634, 529);
            this.lblSaleDiscount.Name = "lblSaleDiscount";
            this.lblSaleDiscount.Size = new System.Drawing.Size(60, 16);
            this.lblSaleDiscount.TabIndex = 14;
            this.lblSaleDiscount.Text = "Discount";
            // 
            // btnPaymentPOS
            // 
            this.btnPaymentPOS.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPaymentPOS.FlatAppearance.BorderSize = 0;
            this.btnPaymentPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentPOS.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPaymentPOS.Location = new System.Drawing.Point(670, 620);
            this.btnPaymentPOS.Name = "btnPaymentPOS";
            this.btnPaymentPOS.Size = new System.Drawing.Size(85, 32);
            this.btnPaymentPOS.TabIndex = 16;
            this.btnPaymentPOS.Text = "POS";
            this.btnPaymentPOS.UseVisualStyleBackColor = false;
            this.btnPaymentPOS.Click += new System.EventHandler(this.btnPaymentMethod_Click);
            // 
            // txtSaleDiscount
            // 
            this.txtSaleDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleDiscount.Location = new System.Drawing.Point(697, 526);
            this.txtSaleDiscount.Name = "txtSaleDiscount";
            this.txtSaleDiscount.Size = new System.Drawing.Size(58, 22);
            this.txtSaleDiscount.TabIndex = 17;
            // 
            // lblDiscountName
            // 
            this.lblDiscountName.AutoSize = true;
            this.lblDiscountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountName.ForeColor = System.Drawing.Color.Maroon;
            this.lblDiscountName.Location = new System.Drawing.Point(636, 552);
            this.lblDiscountName.Name = "lblDiscountName";
            this.lblDiscountName.Size = new System.Drawing.Size(0, 16);
            this.lblDiscountName.TabIndex = 19;
            // 
            // lblSuTotal
            // 
            this.lblSuTotal.AutoSize = true;
            this.lblSuTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuTotal.Location = new System.Drawing.Point(586, 470);
            this.lblSuTotal.Name = "lblSuTotal";
            this.lblSuTotal.Size = new System.Drawing.Size(66, 16);
            this.lblSuTotal.TabIndex = 20;
            this.lblSuTotal.Text = "Sub Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total";
            // 
            // discountMsgPanel
            // 
            this.discountMsgPanel.BackColor = System.Drawing.Color.IndianRed;
            this.discountMsgPanel.Controls.Add(this.btnRemoveDMP);
            this.discountMsgPanel.Controls.Add(this.lblDBExpiryDate);
            this.discountMsgPanel.Controls.Add(this.label2);
            this.discountMsgPanel.Location = new System.Drawing.Point(139, 572);
            this.discountMsgPanel.Name = "discountMsgPanel";
            this.discountMsgPanel.Size = new System.Drawing.Size(616, 35);
            this.discountMsgPanel.TabIndex = 22;
            // 
            // btnRemoveDMP
            // 
            this.btnRemoveDMP.FlatAppearance.BorderSize = 0;
            this.btnRemoveDMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDMP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveDMP.Location = new System.Drawing.Point(582, 4);
            this.btnRemoveDMP.Name = "btnRemoveDMP";
            this.btnRemoveDMP.Size = new System.Drawing.Size(31, 26);
            this.btnRemoveDMP.TabIndex = 2;
            this.btnRemoveDMP.Text = "x";
            this.btnRemoveDMP.UseVisualStyleBackColor = true;
            this.btnRemoveDMP.Click += new System.EventHandler(this.btnRemoveDMP_Click);
            // 
            // lblDBExpiryDate
            // 
            this.lblDBExpiryDate.AutoSize = true;
            this.lblDBExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBExpiryDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDBExpiryDate.Location = new System.Drawing.Point(191, 11);
            this.lblDBExpiryDate.Name = "lblDBExpiryDate";
            this.lblDBExpiryDate.Size = new System.Drawing.Size(0, 18);
            this.lblDBExpiryDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coupon will expiry on ::  ";
            // 
            // txtTxnID
            // 
            this.txtTxnID.BackColor = System.Drawing.SystemColors.Control;
            this.txtTxnID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTxnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTxnID.Location = new System.Drawing.Point(110, 473);
            this.txtTxnID.Name = "txtTxnID";
            this.txtTxnID.Size = new System.Drawing.Size(153, 15);
            this.txtTxnID.TabIndex = 23;
            // 
            // lblTxnID
            // 
            this.lblTxnID.AutoSize = true;
            this.lblTxnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxnID.Location = new System.Drawing.Point(9, 472);
            this.lblTxnID.Name = "lblTxnID";
            this.lblTxnID.Size = new System.Drawing.Size(95, 16);
            this.lblTxnID.TabIndex = 24;
            this.lblTxnID.Text = "Transaction ID";
            // 
            // removeListItemIcon
            // 
            this.removeListItemIcon.Image = global::Inventory_System.Properties.Resources.trash_bin;
            this.removeListItemIcon.Location = new System.Drawing.Point(761, 214);
            this.removeListItemIcon.Name = "removeListItemIcon";
            this.removeListItemIcon.Size = new System.Drawing.Size(26, 27);
            this.removeListItemIcon.TabIndex = 8;
            this.removeListItemIcon.TabStop = false;
            this.removeListItemIcon.Click += new System.EventHandler(this.removeListItemIcon_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 711);
            this.Controls.Add(this.lblTxnID);
            this.Controls.Add(this.txtTxnID);
            this.Controls.Add(this.discountMsgPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDiscountName);
            this.Controls.Add(this.lblSuTotal);
            this.Controls.Add(this.txtSaleDiscount);
            this.Controls.Add(this.btnPaymentPOS);
            this.Controls.Add(this.lblSaleDiscount);
            this.Controls.Add(this.salesMgsPanel);
            this.Controls.Add(this.btnpayment);
            this.Controls.Add(this.btnPaymentMethod);
            this.Controls.Add(this.removeListItemIcon);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblTotalListItem);
            this.Controls.Add(this.listViewTable);
            this.Controls.Add(this.searchResultView);
            this.Controls.Add(this.saleTextBoxGroup);
            this.Controls.Add(this.saleSearchPanel);
            this.Controls.Add(this.saleTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.sales_Load);
            this.saleTopPanel.ResumeLayout(false);
            this.saleSearchPanel.ResumeLayout(false);
            this.saleSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchSaleIcon)).EndInit();
            this.saleTextBoxGroup.ResumeLayout(false);
            this.saleTextBoxGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewTable)).EndInit();
            this.salesMgsPanel.ResumeLayout(false);
            this.salesMgsPanel.PerformLayout();
            this.discountMsgPanel.ResumeLayout(false);
            this.discountMsgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeListItemIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel saleTopPanel;
        private System.Windows.Forms.Panel saleSearchPanel;
        private System.Windows.Forms.PictureBox searchSaleIcon;
        private System.Windows.Forms.TextBox txtSearchSale;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.GroupBox saleTextBoxGroup;
        private System.Windows.Forms.NumericUpDown saleQty;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtBrandlabel;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnAddSaleList;
        private System.Windows.Forms.DataGridView searchResultView;
        private System.Windows.Forms.DataGridView listViewTable;
        private System.Windows.Forms.Label lblTotalListItem;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.PictureBox removeListItemIcon;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Button btnPaymentMethod;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Label lblSalesMsgs;
        private System.Windows.Forms.Panel salesMgsPanel;
        private System.Windows.Forms.Label lblSaleDiscount;
        private System.Windows.Forms.Button btnPaymentPOS;
        private System.Windows.Forms.TextBox txtItemAvailable;
        private System.Windows.Forms.Label lblItemAvailable;
        private System.Windows.Forms.Button btnCloseSale;
        private System.Windows.Forms.TextBox txtSaleDiscount;
        private System.Windows.Forms.Label lblDiscountName;
        private System.Windows.Forms.Label lblSuTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel discountMsgPanel;
        private System.Windows.Forms.Label lblDBExpiryDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveDMP;
        private System.Windows.Forms.TextBox txtTxnID;
        private System.Windows.Forms.Label lblTxnID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}