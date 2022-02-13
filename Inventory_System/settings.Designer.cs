namespace Inventory_System
{
    partial class settings
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
            this.settingsTopPanel = new System.Windows.Forms.Panel();
            this.btnCloseSettings = new System.Windows.Forms.Button();
            this.lblCreateCoupon = new System.Windows.Forms.Label();
            this.panelHR1 = new System.Windows.Forms.Panel();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.btnCreateCoupon = new System.Windows.Forms.Button();
            this.couponValue = new System.Windows.Forms.NumericUpDown();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblCouponName = new System.Windows.Forms.Label();
            this.lblCouponValue = new System.Windows.Forms.Label();
            this.lblDateExpiry = new System.Windows.Forms.Label();
            this.couponDetailsGrid = new System.Windows.Forms.DataGridView();
            this.couponExpiryDay = new System.Windows.Forms.NumericUpDown();
            this.lbldayExpiry = new System.Windows.Forms.Label();
            this.couponMsgPanel = new System.Windows.Forms.Panel();
            this.couponMsg = new System.Windows.Forms.Label();
            this.settingsTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.couponValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponExpiryDay)).BeginInit();
            this.couponMsgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTopPanel
            // 
            this.settingsTopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.settingsTopPanel.Controls.Add(this.btnCloseSettings);
            this.settingsTopPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsTopPanel.Name = "settingsTopPanel";
            this.settingsTopPanel.Size = new System.Drawing.Size(839, 53);
            this.settingsTopPanel.TabIndex = 0;
            // 
            // btnCloseSettings
            // 
            this.btnCloseSettings.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCloseSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSettings.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseSettings.Location = new System.Drawing.Point(803, 8);
            this.btnCloseSettings.Name = "btnCloseSettings";
            this.btnCloseSettings.Size = new System.Drawing.Size(30, 30);
            this.btnCloseSettings.TabIndex = 0;
            this.btnCloseSettings.Text = "x";
            this.btnCloseSettings.UseVisualStyleBackColor = false;
            this.btnCloseSettings.Click += new System.EventHandler(this.btnCloseSettings_Click_1);
            // 
            // lblCreateCoupon
            // 
            this.lblCreateCoupon.AutoSize = true;
            this.lblCreateCoupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateCoupon.Location = new System.Drawing.Point(12, 70);
            this.lblCreateCoupon.Name = "lblCreateCoupon";
            this.lblCreateCoupon.Size = new System.Drawing.Size(98, 16);
            this.lblCreateCoupon.TabIndex = 1;
            this.lblCreateCoupon.Text = "Create Coupon";
            // 
            // panelHR1
            // 
            this.panelHR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHR1.Location = new System.Drawing.Point(0, 89);
            this.panelHR1.Name = "panelHR1";
            this.panelHR1.Size = new System.Drawing.Size(837, 2);
            this.panelHR1.TabIndex = 2;
            // 
            // txtCoupon
            // 
            this.txtCoupon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoupon.Location = new System.Drawing.Point(15, 120);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(187, 19);
            this.txtCoupon.TabIndex = 3;
            // 
            // btnCreateCoupon
            // 
            this.btnCreateCoupon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateCoupon.FlatAppearance.BorderSize = 0;
            this.btnCreateCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCoupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCoupon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateCoupon.Location = new System.Drawing.Point(460, 112);
            this.btnCreateCoupon.Name = "btnCreateCoupon";
            this.btnCreateCoupon.Size = new System.Drawing.Size(75, 30);
            this.btnCreateCoupon.TabIndex = 5;
            this.btnCreateCoupon.Text = "Create";
            this.btnCreateCoupon.UseVisualStyleBackColor = false;
            this.btnCreateCoupon.Click += new System.EventHandler(this.btnCreateCoupon_Click);
            // 
            // couponValue
            // 
            this.couponValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.couponValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponValue.Location = new System.Drawing.Point(208, 119);
            this.couponValue.Name = "couponValue";
            this.couponValue.Size = new System.Drawing.Size(72, 20);
            this.couponValue.TabIndex = 6;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(280, 119);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(23, 20);
            this.lblPercent.TabIndex = 7;
            this.lblPercent.Text = "%";
            // 
            // lblCouponName
            // 
            this.lblCouponName.AutoSize = true;
            this.lblCouponName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouponName.Location = new System.Drawing.Point(12, 96);
            this.lblCouponName.Name = "lblCouponName";
            this.lblCouponName.Size = new System.Drawing.Size(95, 16);
            this.lblCouponName.TabIndex = 9;
            this.lblCouponName.Text = "Coupon Name";
            // 
            // lblCouponValue
            // 
            this.lblCouponValue.AutoSize = true;
            this.lblCouponValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouponValue.Location = new System.Drawing.Point(205, 96);
            this.lblCouponValue.Name = "lblCouponValue";
            this.lblCouponValue.Size = new System.Drawing.Size(43, 16);
            this.lblCouponValue.TabIndex = 10;
            this.lblCouponValue.Text = "Value";
            // 
            // lblDateExpiry
            // 
            this.lblDateExpiry.AutoSize = true;
            this.lblDateExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExpiry.Location = new System.Drawing.Point(329, 96);
            this.lblDateExpiry.Name = "lblDateExpiry";
            this.lblDateExpiry.Size = new System.Drawing.Size(102, 16);
            this.lblDateExpiry.TabIndex = 12;
            this.lblDateExpiry.Text = "Expire in Day(s)";
            // 
            // couponDetailsGrid
            // 
            this.couponDetailsGrid.AllowUserToAddRows = false;
            this.couponDetailsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.couponDetailsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.couponDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couponDetailsGrid.Location = new System.Drawing.Point(12, 145);
            this.couponDetailsGrid.Name = "couponDetailsGrid";
            this.couponDetailsGrid.ReadOnly = true;
            this.couponDetailsGrid.Size = new System.Drawing.Size(743, 202);
            this.couponDetailsGrid.TabIndex = 13;
            // 
            // couponExpiryDay
            // 
            this.couponExpiryDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.couponExpiryDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponExpiryDay.Location = new System.Drawing.Point(332, 119);
            this.couponExpiryDay.Name = "couponExpiryDay";
            this.couponExpiryDay.Size = new System.Drawing.Size(72, 20);
            this.couponExpiryDay.TabIndex = 14;
            // 
            // lbldayExpiry
            // 
            this.lbldayExpiry.AutoSize = true;
            this.lbldayExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayExpiry.Location = new System.Drawing.Point(406, 118);
            this.lbldayExpiry.Name = "lbldayExpiry";
            this.lbldayExpiry.Size = new System.Drawing.Size(48, 16);
            this.lbldayExpiry.TabIndex = 15;
            this.lbldayExpiry.Text = "Day(s)";
            // 
            // couponMsgPanel
            // 
            this.couponMsgPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.couponMsgPanel.Controls.Add(this.couponMsg);
            this.couponMsgPanel.Location = new System.Drawing.Point(12, 350);
            this.couponMsgPanel.Name = "couponMsgPanel";
            this.couponMsgPanel.Size = new System.Drawing.Size(743, 53);
            this.couponMsgPanel.TabIndex = 16;
            // 
            // couponMsg
            // 
            this.couponMsg.AutoSize = true;
            this.couponMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponMsg.ForeColor = System.Drawing.SystemColors.Control;
            this.couponMsg.Location = new System.Drawing.Point(1, 17);
            this.couponMsg.Name = "couponMsg";
            this.couponMsg.Size = new System.Drawing.Size(0, 18);
            this.couponMsg.TabIndex = 0;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 498);
            this.Controls.Add(this.couponMsgPanel);
            this.Controls.Add(this.lbldayExpiry);
            this.Controls.Add(this.couponExpiryDay);
            this.Controls.Add(this.couponDetailsGrid);
            this.Controls.Add(this.lblDateExpiry);
            this.Controls.Add(this.lblCouponValue);
            this.Controls.Add(this.lblCouponName);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.couponValue);
            this.Controls.Add(this.btnCreateCoupon);
            this.Controls.Add(this.txtCoupon);
            this.Controls.Add(this.panelHR1);
            this.Controls.Add(this.lblCreateCoupon);
            this.Controls.Add(this.settingsTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.settingsTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.couponValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponExpiryDay)).EndInit();
            this.couponMsgPanel.ResumeLayout(false);
            this.couponMsgPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel settingsTopPanel;
        private System.Windows.Forms.Label lblCreateCoupon;
        private System.Windows.Forms.Panel panelHR1;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Button btnCreateCoupon;
        private System.Windows.Forms.NumericUpDown couponValue;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblCouponName;
        private System.Windows.Forms.Label lblCouponValue;
        private System.Windows.Forms.Label lblDateExpiry;
        private System.Windows.Forms.DataGridView couponDetailsGrid;
        private System.Windows.Forms.NumericUpDown couponExpiryDay;
        private System.Windows.Forms.Label lbldayExpiry;
        private System.Windows.Forms.Panel couponMsgPanel;
        private System.Windows.Forms.Label couponMsg;
        private System.Windows.Forms.Button btnCloseSettings;
    }
}