namespace Inventory_System
{
    partial class inStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inStock));
            this.iStockTopPanel = new System.Windows.Forms.Panel();
            this.btnCloseStock = new System.Windows.Forms.Button();
            this.inStockDataView = new System.Windows.Forms.DataGridView();
            this.sbdGroupIS = new System.Windows.Forms.GroupBox();
            this.dateSearchIconIS = new System.Windows.Forms.PictureBox();
            this.lblEndAtDate = new System.Windows.Forms.Label();
            this.endAtISDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartFromIS = new System.Windows.Forms.Label();
            this.startFromISDate = new System.Windows.Forms.DateTimePicker();
            this.sbinGroupIS = new System.Windows.Forms.GroupBox();
            this.txtSearchItemIconIS = new System.Windows.Forms.PictureBox();
            this.txtItemNameIS = new System.Windows.Forms.TextBox();
            this.iStockBottomPanel = new System.Windows.Forms.Panel();
            this.lblAddNewItem = new System.Windows.Forms.Label();
            this.inStockRefreshIcon = new System.Windows.Forms.PictureBox();
            this.iStockTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStockDataView)).BeginInit();
            this.sbdGroupIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchIconIS)).BeginInit();
            this.sbinGroupIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchItemIconIS)).BeginInit();
            this.iStockBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStockRefreshIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // iStockTopPanel
            // 
            this.iStockTopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iStockTopPanel.Controls.Add(this.btnCloseStock);
            this.iStockTopPanel.Location = new System.Drawing.Point(0, 0);
            this.iStockTopPanel.Name = "iStockTopPanel";
            this.iStockTopPanel.Size = new System.Drawing.Size(1135, 53);
            this.iStockTopPanel.TabIndex = 0;
            // 
            // btnCloseStock
            // 
            this.btnCloseStock.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseStock.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCloseStock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseStock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseStock.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseStock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseStock.Location = new System.Drawing.Point(1102, 11);
            this.btnCloseStock.Name = "btnCloseStock";
            this.btnCloseStock.Size = new System.Drawing.Size(30, 30);
            this.btnCloseStock.TabIndex = 0;
            this.btnCloseStock.Text = "x";
            this.btnCloseStock.UseVisualStyleBackColor = false;
            this.btnCloseStock.Click += new System.EventHandler(this.btnCloseStock_Click);
            // 
            // inStockDataView
            // 
            this.inStockDataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.inStockDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inStockDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inStockDataView.Location = new System.Drawing.Point(15, 124);
            this.inStockDataView.Name = "inStockDataView";
            this.inStockDataView.ReadOnly = true;
            this.inStockDataView.Size = new System.Drawing.Size(1073, 345);
            this.inStockDataView.TabIndex = 1;
            // 
            // sbdGroupIS
            // 
            this.sbdGroupIS.Controls.Add(this.dateSearchIconIS);
            this.sbdGroupIS.Controls.Add(this.lblEndAtDate);
            this.sbdGroupIS.Controls.Add(this.endAtISDate);
            this.sbdGroupIS.Controls.Add(this.lblStartFromIS);
            this.sbdGroupIS.Controls.Add(this.startFromISDate);
            this.sbdGroupIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbdGroupIS.Location = new System.Drawing.Point(12, 59);
            this.sbdGroupIS.Name = "sbdGroupIS";
            this.sbdGroupIS.Size = new System.Drawing.Size(749, 59);
            this.sbdGroupIS.TabIndex = 2;
            this.sbdGroupIS.TabStop = false;
            this.sbdGroupIS.Text = "Search By Date";
            // 
            // dateSearchIconIS
            // 
            this.dateSearchIconIS.Image = ((System.Drawing.Image)(resources.GetObject("dateSearchIconIS.Image")));
            this.dateSearchIconIS.Location = new System.Drawing.Point(680, 19);
            this.dateSearchIconIS.Name = "dateSearchIconIS";
            this.dateSearchIconIS.Size = new System.Drawing.Size(26, 27);
            this.dateSearchIconIS.TabIndex = 4;
            this.dateSearchIconIS.TabStop = false;
            this.dateSearchIconIS.Click += new System.EventHandler(this.dateSearchIconIS_Click);
            // 
            // lblEndAtDate
            // 
            this.lblEndAtDate.AutoSize = true;
            this.lblEndAtDate.Location = new System.Drawing.Point(391, 25);
            this.lblEndAtDate.Name = "lblEndAtDate";
            this.lblEndAtDate.Size = new System.Drawing.Size(47, 16);
            this.lblEndAtDate.TabIndex = 3;
            this.lblEndAtDate.Text = "End At";
            // 
            // endAtISDate
            // 
            this.endAtISDate.Location = new System.Drawing.Point(441, 21);
            this.endAtISDate.Name = "endAtISDate";
            this.endAtISDate.Size = new System.Drawing.Size(238, 22);
            this.endAtISDate.TabIndex = 2;
            // 
            // lblStartFromIS
            // 
            this.lblStartFromIS.AutoSize = true;
            this.lblStartFromIS.Location = new System.Drawing.Point(39, 25);
            this.lblStartFromIS.Name = "lblStartFromIS";
            this.lblStartFromIS.Size = new System.Drawing.Size(69, 16);
            this.lblStartFromIS.TabIndex = 1;
            this.lblStartFromIS.Text = "Start From";
            // 
            // startFromISDate
            // 
            this.startFromISDate.Location = new System.Drawing.Point(111, 21);
            this.startFromISDate.Name = "startFromISDate";
            this.startFromISDate.Size = new System.Drawing.Size(235, 22);
            this.startFromISDate.TabIndex = 0;
            // 
            // sbinGroupIS
            // 
            this.sbinGroupIS.Controls.Add(this.txtSearchItemIconIS);
            this.sbinGroupIS.Controls.Add(this.txtItemNameIS);
            this.sbinGroupIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbinGroupIS.Location = new System.Drawing.Point(803, 59);
            this.sbinGroupIS.Name = "sbinGroupIS";
            this.sbinGroupIS.Size = new System.Drawing.Size(285, 59);
            this.sbinGroupIS.TabIndex = 3;
            this.sbinGroupIS.TabStop = false;
            this.sbinGroupIS.Text = "Search By Item Name";
            // 
            // txtSearchItemIconIS
            // 
            this.txtSearchItemIconIS.Image = ((System.Drawing.Image)(resources.GetObject("txtSearchItemIconIS.Image")));
            this.txtSearchItemIconIS.Location = new System.Drawing.Point(237, 19);
            this.txtSearchItemIconIS.Name = "txtSearchItemIconIS";
            this.txtSearchItemIconIS.Size = new System.Drawing.Size(26, 27);
            this.txtSearchItemIconIS.TabIndex = 1;
            this.txtSearchItemIconIS.TabStop = false;
            this.txtSearchItemIconIS.Click += new System.EventHandler(this.txtSearchItemIconIS_Click);
            // 
            // txtItemNameIS
            // 
            this.txtItemNameIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNameIS.Location = new System.Drawing.Point(6, 21);
            this.txtItemNameIS.Name = "txtItemNameIS";
            this.txtItemNameIS.Size = new System.Drawing.Size(230, 22);
            this.txtItemNameIS.TabIndex = 0;
            this.txtItemNameIS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemNameIS_KeyUp);
            // 
            // iStockBottomPanel
            // 
            this.iStockBottomPanel.Controls.Add(this.lblAddNewItem);
            this.iStockBottomPanel.Location = new System.Drawing.Point(135, 486);
            this.iStockBottomPanel.Name = "iStockBottomPanel";
            this.iStockBottomPanel.Size = new System.Drawing.Size(953, 53);
            this.iStockBottomPanel.TabIndex = 4;
            // 
            // lblAddNewItem
            // 
            this.lblAddNewItem.AutoSize = true;
            this.lblAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAddNewItem.Location = new System.Drawing.Point(859, 20);
            this.lblAddNewItem.Name = "lblAddNewItem";
            this.lblAddNewItem.Size = new System.Drawing.Size(91, 16);
            this.lblAddNewItem.TabIndex = 0;
            this.lblAddNewItem.Text = "Add New Item";
            this.lblAddNewItem.Click += new System.EventHandler(this.lblAddNewItem_Click);
            // 
            // inStockRefreshIcon
            // 
            this.inStockRefreshIcon.Image = global::Inventory_System.Properties.Resources.refresh;
            this.inStockRefreshIcon.Location = new System.Drawing.Point(1091, 124);
            this.inStockRefreshIcon.Name = "inStockRefreshIcon";
            this.inStockRefreshIcon.Size = new System.Drawing.Size(26, 27);
            this.inStockRefreshIcon.TabIndex = 5;
            this.inStockRefreshIcon.TabStop = false;
            this.inStockRefreshIcon.Click += new System.EventHandler(this.inStockRefreshIcon_Click);
            // 
            // inStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 580);
            this.Controls.Add(this.inStockRefreshIcon);
            this.Controls.Add(this.iStockBottomPanel);
            this.Controls.Add(this.sbinGroupIS);
            this.Controls.Add(this.sbdGroupIS);
            this.Controls.Add(this.inStockDataView);
            this.Controls.Add(this.iStockTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item in Stock";
            this.Load += new System.EventHandler(this.inStock_Load);
            this.iStockTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inStockDataView)).EndInit();
            this.sbdGroupIS.ResumeLayout(false);
            this.sbdGroupIS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchIconIS)).EndInit();
            this.sbinGroupIS.ResumeLayout(false);
            this.sbinGroupIS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchItemIconIS)).EndInit();
            this.iStockBottomPanel.ResumeLayout(false);
            this.iStockBottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStockRefreshIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel iStockTopPanel;
        private System.Windows.Forms.DataGridView inStockDataView;
        private System.Windows.Forms.GroupBox sbdGroupIS;
        private System.Windows.Forms.Label lblStartFromIS;
        private System.Windows.Forms.DateTimePicker startFromISDate;
        private System.Windows.Forms.DateTimePicker endAtISDate;
        private System.Windows.Forms.Label lblEndAtDate;
        private System.Windows.Forms.GroupBox sbinGroupIS;
        private System.Windows.Forms.PictureBox txtSearchItemIconIS;
        private System.Windows.Forms.TextBox txtItemNameIS;
        private System.Windows.Forms.Panel iStockBottomPanel;
        private System.Windows.Forms.Label lblAddNewItem;
        private System.Windows.Forms.PictureBox dateSearchIconIS;
        private System.Windows.Forms.PictureBox inStockRefreshIcon;
        private System.Windows.Forms.Button btnCloseStock;
    }
}