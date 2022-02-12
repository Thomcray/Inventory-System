namespace Inventory_System
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.settingsIcon = new System.Windows.Forms.PictureBox();
            this.itemStockIcon = new System.Windows.Forms.PictureBox();
            this.recordsIcon = new System.Windows.Forms.PictureBox();
            this.salesIcon = new System.Windows.Forms.PictureBox();
            this.categoryIcon = new System.Windows.Forms.PictureBox();
            this.addItemsIcon = new System.Windows.Forms.PictureBox();
            this.dashboardIcon = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnMenuItem = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.loggedUserPanel = new System.Windows.Forms.Panel();
            this.btnCloseMain = new System.Windows.Forms.Button();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.btnTotalSalesT = new System.Windows.Forms.Button();
            this.btnTotalItems = new System.Windows.Forms.Button();
            this.btnTotalRecords = new System.Windows.Forms.Button();
            this.btnTotalSales = new System.Windows.Forms.Button();
            this.totalSaleTPanel = new System.Windows.Forms.Panel();
            this.sumSaleToday = new System.Windows.Forms.Label();
            this.TotalItemsPanel = new System.Windows.Forms.Panel();
            this.sumTotalItems = new System.Windows.Forms.Label();
            this.totalRecordsPanel = new System.Windows.Forms.Panel();
            this.countRecords = new System.Windows.Forms.Label();
            this.totalSalesPanel = new System.Windows.Forms.Panel();
            this.sumTotalSale = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.lblDateTimeNow = new System.Windows.Forms.Label();
            this.dashLogOutIcon = new System.Windows.Forms.PictureBox();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.dashRefreshIcon = new System.Windows.Forms.PictureBox();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardIcon)).BeginInit();
            this.loggedUserPanel.SuspendLayout();
            this.totalSaleTPanel.SuspendLayout();
            this.TotalItemsPanel.SuspendLayout();
            this.totalRecordsPanel.SuspendLayout();
            this.totalSalesPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashLogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashRefreshIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.settingsIcon);
            this.menuPanel.Controls.Add(this.itemStockIcon);
            this.menuPanel.Controls.Add(this.recordsIcon);
            this.menuPanel.Controls.Add(this.salesIcon);
            this.menuPanel.Controls.Add(this.categoryIcon);
            this.menuPanel.Controls.Add(this.addItemsIcon);
            this.menuPanel.Controls.Add(this.dashboardIcon);
            this.menuPanel.Controls.Add(this.btnSettings);
            this.menuPanel.Controls.Add(this.btnStock);
            this.menuPanel.Controls.Add(this.btnRecords);
            this.menuPanel.Controls.Add(this.btnSales);
            this.menuPanel.Controls.Add(this.btnCategory);
            this.menuPanel.Controls.Add(this.btnMenuItem);
            this.menuPanel.Controls.Add(this.btnDashboard);
            this.menuPanel.Location = new System.Drawing.Point(0, 49);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(234, 701);
            this.menuPanel.TabIndex = 0;
            // 
            // settingsIcon
            // 
            this.settingsIcon.Image = ((System.Drawing.Image)(resources.GetObject("settingsIcon.Image")));
            this.settingsIcon.Location = new System.Drawing.Point(55, 636);
            this.settingsIcon.Name = "settingsIcon";
            this.settingsIcon.Size = new System.Drawing.Size(26, 27);
            this.settingsIcon.TabIndex = 1;
            this.settingsIcon.TabStop = false;
            // 
            // itemStockIcon
            // 
            this.itemStockIcon.Image = ((System.Drawing.Image)(resources.GetObject("itemStockIcon.Image")));
            this.itemStockIcon.Location = new System.Drawing.Point(55, 319);
            this.itemStockIcon.Name = "itemStockIcon";
            this.itemStockIcon.Size = new System.Drawing.Size(26, 27);
            this.itemStockIcon.TabIndex = 1;
            this.itemStockIcon.TabStop = false;
            // 
            // recordsIcon
            // 
            this.recordsIcon.Image = ((System.Drawing.Image)(resources.GetObject("recordsIcon.Image")));
            this.recordsIcon.Location = new System.Drawing.Point(55, 273);
            this.recordsIcon.Name = "recordsIcon";
            this.recordsIcon.Size = new System.Drawing.Size(26, 27);
            this.recordsIcon.TabIndex = 1;
            this.recordsIcon.TabStop = false;
            // 
            // salesIcon
            // 
            this.salesIcon.Image = ((System.Drawing.Image)(resources.GetObject("salesIcon.Image")));
            this.salesIcon.Location = new System.Drawing.Point(55, 227);
            this.salesIcon.Name = "salesIcon";
            this.salesIcon.Size = new System.Drawing.Size(26, 27);
            this.salesIcon.TabIndex = 1;
            this.salesIcon.TabStop = false;
            // 
            // categoryIcon
            // 
            this.categoryIcon.Image = ((System.Drawing.Image)(resources.GetObject("categoryIcon.Image")));
            this.categoryIcon.Location = new System.Drawing.Point(55, 182);
            this.categoryIcon.Name = "categoryIcon";
            this.categoryIcon.Size = new System.Drawing.Size(26, 27);
            this.categoryIcon.TabIndex = 1;
            this.categoryIcon.TabStop = false;
            // 
            // addItemsIcon
            // 
            this.addItemsIcon.Image = ((System.Drawing.Image)(resources.GetObject("addItemsIcon.Image")));
            this.addItemsIcon.Location = new System.Drawing.Point(55, 137);
            this.addItemsIcon.Name = "addItemsIcon";
            this.addItemsIcon.Size = new System.Drawing.Size(26, 27);
            this.addItemsIcon.TabIndex = 1;
            this.addItemsIcon.TabStop = false;
            // 
            // dashboardIcon
            // 
            this.dashboardIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardIcon.Image = ((System.Drawing.Image)(resources.GetObject("dashboardIcon.Image")));
            this.dashboardIcon.Location = new System.Drawing.Point(55, 93);
            this.dashboardIcon.Name = "dashboardIcon";
            this.dashboardIcon.Size = new System.Drawing.Size(26, 29);
            this.dashboardIcon.TabIndex = 12;
            this.dashboardIcon.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSettings.Location = new System.Drawing.Point(87, 632);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(147, 40);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStock.Location = new System.Drawing.Point(87, 314);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(147, 40);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Item in Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecords.Location = new System.Drawing.Point(87, 268);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(147, 40);
            this.btnRecords.TabIndex = 1;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSales.Location = new System.Drawing.Point(87, 222);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(147, 40);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCategory.Location = new System.Drawing.Point(87, 176);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(147, 40);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnMenuItem
            // 
            this.btnMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuItem.FlatAppearance.BorderSize = 0;
            this.btnMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuItem.Location = new System.Drawing.Point(87, 130);
            this.btnMenuItem.Name = "btnMenuItem";
            this.btnMenuItem.Size = new System.Drawing.Size(147, 40);
            this.btnMenuItem.TabIndex = 1;
            this.btnMenuItem.Text = "Add Items";
            this.btnMenuItem.UseVisualStyleBackColor = false;
            this.btnMenuItem.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 84);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(234, 40);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // loggedUserPanel
            // 
            this.loggedUserPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loggedUserPanel.Controls.Add(this.btnCloseMain);
            this.loggedUserPanel.Controls.Add(this.lblLoggedUser);
            this.loggedUserPanel.Location = new System.Drawing.Point(0, -1);
            this.loggedUserPanel.Name = "loggedUserPanel";
            this.loggedUserPanel.Size = new System.Drawing.Size(1388, 53);
            this.loggedUserPanel.TabIndex = 2;
            // 
            // btnCloseMain
            // 
            this.btnCloseMain.BackColor = System.Drawing.Color.Red;
            this.btnCloseMain.FlatAppearance.BorderSize = 0;
            this.btnCloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMain.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseMain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseMain.Location = new System.Drawing.Point(1292, 10);
            this.btnCloseMain.Name = "btnCloseMain";
            this.btnCloseMain.Size = new System.Drawing.Size(51, 39);
            this.btnCloseMain.TabIndex = 1;
            this.btnCloseMain.Text = "x";
            this.btnCloseMain.UseVisualStyleBackColor = false;
            this.btnCloseMain.Click += new System.EventHandler(this.btnMenuItem_Click);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 21);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(0, 16);
            this.lblLoggedUser.TabIndex = 0;
            // 
            // btnTotalSalesT
            // 
            this.btnTotalSalesT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTotalSalesT.FlatAppearance.BorderSize = 0;
            this.btnTotalSalesT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalSalesT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSalesT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTotalSalesT.Location = new System.Drawing.Point(262, 66);
            this.btnTotalSalesT.Name = "btnTotalSalesT";
            this.btnTotalSalesT.Size = new System.Drawing.Size(265, 120);
            this.btnTotalSalesT.TabIndex = 3;
            this.btnTotalSalesT.Text = "Total Sales Today";
            this.btnTotalSalesT.UseVisualStyleBackColor = false;
            // 
            // btnTotalItems
            // 
            this.btnTotalItems.BackColor = System.Drawing.Color.IndianRed;
            this.btnTotalItems.FlatAppearance.BorderSize = 0;
            this.btnTotalItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalItems.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTotalItems.Location = new System.Drawing.Point(533, 66);
            this.btnTotalItems.Name = "btnTotalItems";
            this.btnTotalItems.Size = new System.Drawing.Size(265, 120);
            this.btnTotalItems.TabIndex = 4;
            this.btnTotalItems.Text = "Total Items";
            this.btnTotalItems.UseVisualStyleBackColor = false;
            // 
            // btnTotalRecords
            // 
            this.btnTotalRecords.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTotalRecords.FlatAppearance.BorderSize = 0;
            this.btnTotalRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalRecords.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalRecords.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTotalRecords.Location = new System.Drawing.Point(804, 66);
            this.btnTotalRecords.Name = "btnTotalRecords";
            this.btnTotalRecords.Size = new System.Drawing.Size(265, 120);
            this.btnTotalRecords.TabIndex = 5;
            this.btnTotalRecords.Text = "Total Records";
            this.btnTotalRecords.UseVisualStyleBackColor = false;
            // 
            // btnTotalSales
            // 
            this.btnTotalSales.BackColor = System.Drawing.Color.Goldenrod;
            this.btnTotalSales.FlatAppearance.BorderSize = 0;
            this.btnTotalSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSales.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTotalSales.Location = new System.Drawing.Point(1075, 66);
            this.btnTotalSales.Name = "btnTotalSales";
            this.btnTotalSales.Size = new System.Drawing.Size(265, 120);
            this.btnTotalSales.TabIndex = 6;
            this.btnTotalSales.Text = "Total Sales";
            this.btnTotalSales.UseVisualStyleBackColor = false;
            // 
            // totalSaleTPanel
            // 
            this.totalSaleTPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.totalSaleTPanel.Controls.Add(this.sumSaleToday);
            this.totalSaleTPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSaleTPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totalSaleTPanel.Location = new System.Drawing.Point(262, 66);
            this.totalSaleTPanel.Name = "totalSaleTPanel";
            this.totalSaleTPanel.Size = new System.Drawing.Size(148, 30);
            this.totalSaleTPanel.TabIndex = 7;
            // 
            // sumSaleToday
            // 
            this.sumSaleToday.AutoSize = true;
            this.sumSaleToday.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sumSaleToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumSaleToday.ForeColor = System.Drawing.SystemColors.Control;
            this.sumSaleToday.Location = new System.Drawing.Point(3, 4);
            this.sumSaleToday.Name = "sumSaleToday";
            this.sumSaleToday.Size = new System.Drawing.Size(60, 24);
            this.sumSaleToday.TabIndex = 8;
            this.sumSaleToday.Text = "10000";
            // 
            // TotalItemsPanel
            // 
            this.TotalItemsPanel.BackColor = System.Drawing.Color.IndianRed;
            this.TotalItemsPanel.Controls.Add(this.sumTotalItems);
            this.TotalItemsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TotalItemsPanel.Location = new System.Drawing.Point(533, 66);
            this.TotalItemsPanel.Name = "TotalItemsPanel";
            this.TotalItemsPanel.Size = new System.Drawing.Size(148, 30);
            this.TotalItemsPanel.TabIndex = 8;
            // 
            // sumTotalItems
            // 
            this.sumTotalItems.AutoSize = true;
            this.sumTotalItems.BackColor = System.Drawing.Color.IndianRed;
            this.sumTotalItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumTotalItems.ForeColor = System.Drawing.SystemColors.Control;
            this.sumTotalItems.Location = new System.Drawing.Point(3, 4);
            this.sumTotalItems.Name = "sumTotalItems";
            this.sumTotalItems.Size = new System.Drawing.Size(30, 24);
            this.sumTotalItems.TabIndex = 0;
            this.sumTotalItems.Text = "50";
            // 
            // totalRecordsPanel
            // 
            this.totalRecordsPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.totalRecordsPanel.Controls.Add(this.countRecords);
            this.totalRecordsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRecordsPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totalRecordsPanel.Location = new System.Drawing.Point(804, 66);
            this.totalRecordsPanel.Name = "totalRecordsPanel";
            this.totalRecordsPanel.Size = new System.Drawing.Size(148, 30);
            this.totalRecordsPanel.TabIndex = 9;
            // 
            // countRecords
            // 
            this.countRecords.AutoSize = true;
            this.countRecords.BackColor = System.Drawing.Color.SeaGreen;
            this.countRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countRecords.ForeColor = System.Drawing.SystemColors.Control;
            this.countRecords.Location = new System.Drawing.Point(3, 4);
            this.countRecords.Name = "countRecords";
            this.countRecords.Size = new System.Drawing.Size(40, 24);
            this.countRecords.TabIndex = 0;
            this.countRecords.Text = "200";
            // 
            // totalSalesPanel
            // 
            this.totalSalesPanel.BackColor = System.Drawing.Color.Goldenrod;
            this.totalSalesPanel.Controls.Add(this.sumTotalSale);
            this.totalSalesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalSalesPanel.Location = new System.Drawing.Point(1075, 66);
            this.totalSalesPanel.Name = "totalSalesPanel";
            this.totalSalesPanel.Size = new System.Drawing.Size(148, 30);
            this.totalSalesPanel.TabIndex = 10;
            // 
            // sumTotalSale
            // 
            this.sumTotalSale.AutoSize = true;
            this.sumTotalSale.BackColor = System.Drawing.Color.Goldenrod;
            this.sumTotalSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumTotalSale.ForeColor = System.Drawing.SystemColors.Control;
            this.sumTotalSale.Location = new System.Drawing.Point(3, 4);
            this.sumTotalSale.Name = "sumTotalSale";
            this.sumTotalSale.Size = new System.Drawing.Size(60, 24);
            this.sumTotalSale.TabIndex = 0;
            this.sumTotalSale.Text = "50000";
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.lblDateTimeNow);
            this.footerPanel.Controls.Add(this.dashLogOutIcon);
            this.footerPanel.Controls.Add(this.lblManageUsers);
            this.footerPanel.Controls.Add(this.lblLogOut);
            this.footerPanel.Location = new System.Drawing.Point(240, 698);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1100, 40);
            this.footerPanel.TabIndex = 11;
            // 
            // lblDateTimeNow
            // 
            this.lblDateTimeNow.AutoSize = true;
            this.lblDateTimeNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateTimeNow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeNow.Location = new System.Drawing.Point(3, 14);
            this.lblDateTimeNow.Name = "lblDateTimeNow";
            this.lblDateTimeNow.Size = new System.Drawing.Size(25, 17);
            this.lblDateTimeNow.TabIndex = 3;
            this.lblDateTimeNow.Text = "{?}";
            // 
            // dashLogOutIcon
            // 
            this.dashLogOutIcon.Image = global::Inventory_System.Properties.Resources.logout_red;
            this.dashLogOutIcon.Location = new System.Drawing.Point(1017, 10);
            this.dashLogOutIcon.Name = "dashLogOutIcon";
            this.dashLogOutIcon.Size = new System.Drawing.Size(26, 27);
            this.dashLogOutIcon.TabIndex = 2;
            this.dashLogOutIcon.TabStop = false;
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblManageUsers.Location = new System.Drawing.Point(907, 14);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(96, 17);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "Manage Users";
            this.lblManageUsers.Click += new System.EventHandler(this.lblItems);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.Red;
            this.lblLogOut.Location = new System.Drawing.Point(1041, 14);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(54, 16);
            this.lblLogOut.TabIndex = 0;
            this.lblLogOut.Text = "LogOut";
            this.lblLogOut.Click += new System.EventHandler(this.lblItems);
            // 
            // dashRefreshIcon
            // 
            this.dashRefreshIcon.Image = global::Inventory_System.Properties.Resources.refresh_small;
            this.dashRefreshIcon.Location = new System.Drawing.Point(238, 66);
            this.dashRefreshIcon.Name = "dashRefreshIcon";
            this.dashRefreshIcon.Size = new System.Drawing.Size(21, 25);
            this.dashRefreshIcon.TabIndex = 12;
            this.dashRefreshIcon.TabStop = false;
            this.dashRefreshIcon.Click += new System.EventHandler(this.dashRefreshIcon_Click);
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1344, 750);
            this.Controls.Add(this.dashRefreshIcon);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.totalSalesPanel);
            this.Controls.Add(this.totalRecordsPanel);
            this.Controls.Add(this.TotalItemsPanel);
            this.Controls.Add(this.totalSaleTPanel);
            this.Controls.Add(this.btnTotalSales);
            this.Controls.Add(this.btnTotalRecords);
            this.Controls.Add(this.btnTotalItems);
            this.Controls.Add(this.btnTotalSalesT);
            this.Controls.Add(this.loggedUserPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardIcon)).EndInit();
            this.loggedUserPanel.ResumeLayout(false);
            this.loggedUserPanel.PerformLayout();
            this.totalSaleTPanel.ResumeLayout(false);
            this.totalSaleTPanel.PerformLayout();
            this.TotalItemsPanel.ResumeLayout(false);
            this.TotalItemsPanel.PerformLayout();
            this.totalRecordsPanel.ResumeLayout(false);
            this.totalRecordsPanel.PerformLayout();
            this.totalSalesPanel.ResumeLayout(false);
            this.totalSalesPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashLogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashRefreshIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnMenuItem;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Panel loggedUserPanel;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Button btnTotalSalesT;
        private System.Windows.Forms.Button btnTotalItems;
        private System.Windows.Forms.Button btnTotalRecords;
        private System.Windows.Forms.Button btnTotalSales;
        private System.Windows.Forms.Panel totalSaleTPanel;
        private System.Windows.Forms.Label sumSaleToday;
        private System.Windows.Forms.Panel TotalItemsPanel;
        private System.Windows.Forms.Label sumTotalItems;
        private System.Windows.Forms.Panel totalRecordsPanel;
        private System.Windows.Forms.Label countRecords;
        private System.Windows.Forms.Panel totalSalesPanel;
        private System.Windows.Forms.Label sumTotalSale;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.PictureBox dashboardIcon;

        public mainWindow()
        {
        }

        private System.Windows.Forms.PictureBox addItemsIcon;
        private System.Windows.Forms.PictureBox categoryIcon;
        private System.Windows.Forms.PictureBox salesIcon;
        private System.Windows.Forms.PictureBox recordsIcon;
        private System.Windows.Forms.PictureBox itemStockIcon;
        private System.Windows.Forms.PictureBox settingsIcon;
        private System.Windows.Forms.PictureBox dashRefreshIcon;
        private System.Windows.Forms.PictureBox dashLogOutIcon;
        private System.Windows.Forms.Button btnCloseMain;
        private System.Windows.Forms.Timer timerDateAndTime;
        private System.Windows.Forms.Label lblDateTimeNow;
    }
}