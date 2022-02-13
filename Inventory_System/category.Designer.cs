namespace Inventory_System
{
    partial class category
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
            this.categoryTopPanel = new System.Windows.Forms.Panel();
            this.btnCloseCategory = new System.Windows.Forms.Button();
            this.categoryTextPanel = new System.Windows.Forms.Panel();
            this.categorySearchIcon = new System.Windows.Forms.PictureBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblSearchMsg = new System.Windows.Forms.Label();
            this.categoryTopPanel.SuspendLayout();
            this.categoryTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorySearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryTopPanel
            // 
            this.categoryTopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.categoryTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoryTopPanel.Controls.Add(this.btnCloseCategory);
            this.categoryTopPanel.Location = new System.Drawing.Point(-2, -1);
            this.categoryTopPanel.Name = "categoryTopPanel";
            this.categoryTopPanel.Size = new System.Drawing.Size(753, 53);
            this.categoryTopPanel.TabIndex = 0;
            // 
            // btnCloseCategory
            // 
            this.btnCloseCategory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCloseCategory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCategory.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseCategory.Location = new System.Drawing.Point(716, 9);
            this.btnCloseCategory.Name = "btnCloseCategory";
            this.btnCloseCategory.Size = new System.Drawing.Size(30, 30);
            this.btnCloseCategory.TabIndex = 0;
            this.btnCloseCategory.Text = "x";
            this.btnCloseCategory.UseVisualStyleBackColor = false;
            this.btnCloseCategory.Click += new System.EventHandler(this.btnCloseCategory_Click);
            // 
            // categoryTextPanel
            // 
            this.categoryTextPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.categoryTextPanel.Controls.Add(this.categorySearchIcon);
            this.categoryTextPanel.Controls.Add(this.txtCategory);
            this.categoryTextPanel.Location = new System.Drawing.Point(46, 90);
            this.categoryTextPanel.Name = "categoryTextPanel";
            this.categoryTextPanel.Size = new System.Drawing.Size(650, 60);
            this.categoryTextPanel.TabIndex = 1;
            // 
            // categorySearchIcon
            // 
            this.categorySearchIcon.Image = global::Inventory_System.Properties.Resources.search;
            this.categorySearchIcon.Location = new System.Drawing.Point(602, 17);
            this.categorySearchIcon.Name = "categorySearchIcon";
            this.categorySearchIcon.Size = new System.Drawing.Size(35, 24);
            this.categorySearchIcon.TabIndex = 1;
            this.categorySearchIcon.TabStop = false;
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(19, 17);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(581, 24);
            this.txtCategory.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(65, 171);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(618, 59);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblSearchMsg
            // 
            this.lblSearchMsg.AutoSize = true;
            this.lblSearchMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSearchMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMsg.ForeColor = System.Drawing.Color.Green;
            this.lblSearchMsg.Location = new System.Drawing.Point(49, 71);
            this.lblSearchMsg.Name = "lblSearchMsg";
            this.lblSearchMsg.Size = new System.Drawing.Size(0, 16);
            this.lblSearchMsg.TabIndex = 3;
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.lblSearchMsg);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.categoryTextPanel);
            this.Controls.Add(this.categoryTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.category_Load);
            this.categoryTopPanel.ResumeLayout(false);
            this.categoryTextPanel.ResumeLayout(false);
            this.categoryTextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorySearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel categoryTopPanel;
        private System.Windows.Forms.Panel categoryTextPanel;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.PictureBox categorySearchIcon;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblSearchMsg;
        private System.Windows.Forms.Button btnCloseCategory;
    }
}