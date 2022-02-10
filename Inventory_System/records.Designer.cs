namespace Inventory_System
{
    partial class records
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
            this.recordsTopPanel = new System.Windows.Forms.Panel();
            this.btnCloseRecords = new System.Windows.Forms.Button();
            this.recordsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchByDateGroup = new System.Windows.Forms.GroupBox();
            this.searchRecordsByDate = new System.Windows.Forms.PictureBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.endDateValue = new System.Windows.Forms.DateTimePicker();
            this.startDateValue = new System.Windows.Forms.DateTimePicker();
            this.recordsTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).BeginInit();
            this.searchByDateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchRecordsByDate)).BeginInit();
            this.SuspendLayout();
            // 
            // recordsTopPanel
            // 
            this.recordsTopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.recordsTopPanel.Controls.Add(this.btnCloseRecords);
            this.recordsTopPanel.Location = new System.Drawing.Point(-1, 0);
            this.recordsTopPanel.Name = "recordsTopPanel";
            this.recordsTopPanel.Size = new System.Drawing.Size(1228, 53);
            this.recordsTopPanel.TabIndex = 0;
            // 
            // btnCloseRecords
            // 
            this.btnCloseRecords.BackColor = System.Drawing.Color.Red;
            this.btnCloseRecords.FlatAppearance.BorderSize = 0;
            this.btnCloseRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseRecords.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseRecords.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseRecords.Location = new System.Drawing.Point(1176, 7);
            this.btnCloseRecords.Name = "btnCloseRecords";
            this.btnCloseRecords.Size = new System.Drawing.Size(51, 39);
            this.btnCloseRecords.TabIndex = 0;
            this.btnCloseRecords.Text = "x";
            this.btnCloseRecords.UseVisualStyleBackColor = false;
            this.btnCloseRecords.Click += new System.EventHandler(this.btnCloseRecords_Click);
            // 
            // recordsDataGridView
            // 
            this.recordsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.recordsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordsDataGridView.Location = new System.Drawing.Point(12, 124);
            this.recordsDataGridView.Name = "recordsDataGridView";
            this.recordsDataGridView.ReadOnly = true;
            this.recordsDataGridView.Size = new System.Drawing.Size(1176, 366);
            this.recordsDataGridView.TabIndex = 1;
            // 
            // searchByDateGroup
            // 
            this.searchByDateGroup.Controls.Add(this.searchRecordsByDate);
            this.searchByDateGroup.Controls.Add(this.lblEndDate);
            this.searchByDateGroup.Controls.Add(this.lblStartDate);
            this.searchByDateGroup.Controls.Add(this.endDateValue);
            this.searchByDateGroup.Controls.Add(this.startDateValue);
            this.searchByDateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDateGroup.Location = new System.Drawing.Point(243, 59);
            this.searchByDateGroup.Name = "searchByDateGroup";
            this.searchByDateGroup.Size = new System.Drawing.Size(726, 59);
            this.searchByDateGroup.TabIndex = 2;
            this.searchByDateGroup.TabStop = false;
            this.searchByDateGroup.Text = "Search By Date";
            // 
            // searchRecordsByDate
            // 
            this.searchRecordsByDate.Image = global::Inventory_System.Properties.Resources.search;
            this.searchRecordsByDate.Location = new System.Drawing.Point(673, 19);
            this.searchRecordsByDate.Name = "searchRecordsByDate";
            this.searchRecordsByDate.Size = new System.Drawing.Size(26, 27);
            this.searchRecordsByDate.TabIndex = 4;
            this.searchRecordsByDate.TabStop = false;
            this.searchRecordsByDate.Click += new System.EventHandler(this.searchRecordsByDate_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(380, 25);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(47, 16);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End At";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(51, 25);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 16);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start From";
            // 
            // endDateValue
            // 
            this.endDateValue.Location = new System.Drawing.Point(431, 21);
            this.endDateValue.Name = "endDateValue";
            this.endDateValue.Size = new System.Drawing.Size(236, 22);
            this.endDateValue.TabIndex = 1;
            // 
            // startDateValue
            // 
            this.startDateValue.Location = new System.Drawing.Point(124, 21);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(235, 22);
            this.startDateValue.TabIndex = 0;
            // 
            // records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 580);
            this.Controls.Add(this.searchByDateGroup);
            this.Controls.Add(this.recordsDataGridView);
            this.Controls.Add(this.recordsTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.Load += new System.EventHandler(this.records_Load);
            this.recordsTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).EndInit();
            this.searchByDateGroup.ResumeLayout(false);
            this.searchByDateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchRecordsByDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel recordsTopPanel;
        private System.Windows.Forms.DataGridView recordsDataGridView;
        private System.Windows.Forms.GroupBox searchByDateGroup;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker endDateValue;
        private System.Windows.Forms.DateTimePicker startDateValue;
        private System.Windows.Forms.PictureBox searchRecordsByDate;
        private System.Windows.Forms.Button btnCloseRecords;
    }
}