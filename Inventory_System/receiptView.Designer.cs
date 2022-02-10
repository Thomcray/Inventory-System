namespace Inventory_System
{
    partial class receiptView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receiptView));
            this.panelPrint = new System.Windows.Forms.Panel();
            this.receipDGView = new System.Windows.Forms.DataGridView();
            this.lblTotal_ = new System.Windows.Forms.Label();
            this.lblDiscount_ = new System.Windows.Forms.Label();
            this.lblSubtotal_ = new System.Windows.Forms.Label();
            this.lblAttendant_ = new System.Windows.Forms.Label();
            this.lblRNumber = new System.Windows.Forms.Label();
            this.lblTotalR = new System.Windows.Forms.Label();
            this.lblDiscountR = new System.Windows.Forms.Label();
            this.lblSubTotalR = new System.Windows.Forms.Label();
            this.lblAttendant = new System.Windows.Forms.Label();
            this.lblCompanyNameR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRDate = new System.Windows.Forms.Label();
            this.printIcon = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrint
            // 
            this.panelPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPrint.BackColor = System.Drawing.Color.White;
            this.panelPrint.Controls.Add(this.receipDGView);
            this.panelPrint.Controls.Add(this.lblTotal_);
            this.panelPrint.Controls.Add(this.lblDiscount_);
            this.panelPrint.Controls.Add(this.lblSubtotal_);
            this.panelPrint.Controls.Add(this.lblAttendant_);
            this.panelPrint.Controls.Add(this.lblRNumber);
            this.panelPrint.Controls.Add(this.lblTotalR);
            this.panelPrint.Controls.Add(this.lblDiscountR);
            this.panelPrint.Controls.Add(this.lblSubTotalR);
            this.panelPrint.Controls.Add(this.lblAttendant);
            this.panelPrint.Controls.Add(this.lblCompanyNameR);
            this.panelPrint.Controls.Add(this.label2);
            this.panelPrint.Controls.Add(this.lblRDate);
            this.panelPrint.Location = new System.Drawing.Point(14, 36);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(535, 321);
            this.panelPrint.TabIndex = 0;
            // 
            // receipDGView
            // 
            this.receipDGView.AllowUserToAddRows = false;
            this.receipDGView.BackgroundColor = System.Drawing.Color.White;
            this.receipDGView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receipDGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.receipDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receipDGView.GridColor = System.Drawing.Color.White;
            this.receipDGView.Location = new System.Drawing.Point(34, 102);
            this.receipDGView.Name = "receipDGView";
            this.receipDGView.ReadOnly = true;
            this.receipDGView.RowHeadersVisible = false;
            this.receipDGView.Size = new System.Drawing.Size(482, 131);
            this.receipDGView.TabIndex = 20;
            // 
            // lblTotal_
            // 
            this.lblTotal_.AutoSize = true;
            this.lblTotal_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal_.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_.Location = new System.Drawing.Point(371, 288);
            this.lblTotal_.Name = "lblTotal_";
            this.lblTotal_.Size = new System.Drawing.Size(16, 18);
            this.lblTotal_.TabIndex = 19;
            this.lblTotal_.Text = "?";
            // 
            // lblDiscount_
            // 
            this.lblDiscount_.AutoSize = true;
            this.lblDiscount_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiscount_.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount_.Location = new System.Drawing.Point(371, 259);
            this.lblDiscount_.Name = "lblDiscount_";
            this.lblDiscount_.Size = new System.Drawing.Size(16, 18);
            this.lblDiscount_.TabIndex = 18;
            this.lblDiscount_.Text = "?";
            // 
            // lblSubtotal_
            // 
            this.lblSubtotal_.AutoSize = true;
            this.lblSubtotal_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubtotal_.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal_.Location = new System.Drawing.Point(371, 236);
            this.lblSubtotal_.Name = "lblSubtotal_";
            this.lblSubtotal_.Size = new System.Drawing.Size(16, 18);
            this.lblSubtotal_.TabIndex = 17;
            this.lblSubtotal_.Text = "?";
            // 
            // lblAttendant_
            // 
            this.lblAttendant_.AutoSize = true;
            this.lblAttendant_.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendant_.Location = new System.Drawing.Point(117, 79);
            this.lblAttendant_.Name = "lblAttendant_";
            this.lblAttendant_.Size = new System.Drawing.Size(16, 18);
            this.lblAttendant_.TabIndex = 12;
            this.lblAttendant_.Text = "?";
            // 
            // lblRNumber
            // 
            this.lblRNumber.AutoSize = true;
            this.lblRNumber.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNumber.Location = new System.Drawing.Point(468, 12);
            this.lblRNumber.Name = "lblRNumber";
            this.lblRNumber.Size = new System.Drawing.Size(16, 18);
            this.lblRNumber.TabIndex = 11;
            this.lblRNumber.Text = "?";
            // 
            // lblTotalR
            // 
            this.lblTotalR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalR.AutoSize = true;
            this.lblTotalR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalR.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalR.Location = new System.Drawing.Point(266, 288);
            this.lblTotalR.Name = "lblTotalR";
            this.lblTotalR.Size = new System.Drawing.Size(56, 18);
            this.lblTotalR.TabIndex = 10;
            this.lblTotalR.Text = "Total:";
            // 
            // lblDiscountR
            // 
            this.lblDiscountR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiscountR.AutoSize = true;
            this.lblDiscountR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiscountR.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountR.Location = new System.Drawing.Point(266, 259);
            this.lblDiscountR.Name = "lblDiscountR";
            this.lblDiscountR.Size = new System.Drawing.Size(80, 18);
            this.lblDiscountR.TabIndex = 9;
            this.lblDiscountR.Text = "Discount:";
            // 
            // lblSubTotalR
            // 
            this.lblSubTotalR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubTotalR.AutoSize = true;
            this.lblSubTotalR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubTotalR.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalR.Location = new System.Drawing.Point(266, 236);
            this.lblSubTotalR.Name = "lblSubTotalR";
            this.lblSubTotalR.Size = new System.Drawing.Size(88, 18);
            this.lblSubTotalR.TabIndex = 8;
            this.lblSubTotalR.Text = "Sub Total:";
            // 
            // lblAttendant
            // 
            this.lblAttendant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAttendant.AutoSize = true;
            this.lblAttendant.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendant.Location = new System.Drawing.Point(30, 79);
            this.lblAttendant.Name = "lblAttendant";
            this.lblAttendant.Size = new System.Drawing.Size(88, 18);
            this.lblAttendant.TabIndex = 3;
            this.lblAttendant.Text = "Attendant:";
            // 
            // lblCompanyNameR
            // 
            this.lblCompanyNameR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyNameR.AutoSize = true;
            this.lblCompanyNameR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyNameR.Location = new System.Drawing.Point(210, 53);
            this.lblCompanyNameR.Name = "lblCompanyNameR";
            this.lblCompanyNameR.Size = new System.Drawing.Size(117, 19);
            this.lblCompanyNameR.TabIndex = 2;
            this.lblCompanyNameR.Text = "COMPANY NAME";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receipt No:";
            // 
            // lblRDate
            // 
            this.lblRDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRDate.AutoSize = true;
            this.lblRDate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDate.Location = new System.Drawing.Point(3, 12);
            this.lblRDate.Name = "lblRDate";
            this.lblRDate.Size = new System.Drawing.Size(16, 18);
            this.lblRDate.TabIndex = 0;
            this.lblRDate.Text = "?";
            // 
            // printIcon
            // 
            this.printIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.printIcon.Image = global::Inventory_System.Properties.Resources.print;
            this.printIcon.Location = new System.Drawing.Point(523, 8);
            this.printIcon.Name = "printIcon";
            this.printIcon.Size = new System.Drawing.Size(26, 27);
            this.printIcon.TabIndex = 1;
            this.printIcon.TabStop = false;
            this.printIcon.Click += new System.EventHandler(this.printIcon_Click);
            this.printIcon.MouseHover += new System.EventHandler(this.printIcon_MouseHover);
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
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // receiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 364);
            this.Controls.Add(this.printIcon);
            this.Controls.Add(this.panelPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "receiptView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt View";
            this.Load += new System.EventHandler(this.receiptView_Load);
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.PictureBox printIcon;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblCompanyNameR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRDate;
        private System.Windows.Forms.Label lblAttendant;
        private System.Windows.Forms.Label lblDiscountR;
        private System.Windows.Forms.Label lblSubTotalR;
        private System.Windows.Forms.Label lblTotalR;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblRNumber;
        private System.Windows.Forms.Label lblAttendant_;
        private System.Windows.Forms.Label lblDiscount_;
        private System.Windows.Forms.Label lblSubtotal_;
        private System.Windows.Forms.Label lblTotal_;
        private System.Windows.Forms.DataGridView receipDGView;
    }
}