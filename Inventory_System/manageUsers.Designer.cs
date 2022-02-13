namespace Inventory_System
{
    partial class manageUsers
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
            this.muTopPanel = new System.Windows.Forms.Panel();
            this.btnCloseMU = new System.Windows.Forms.Button();
            this.muDisplayGrid = new System.Windows.Forms.DataGridView();
            this.muGroupSearch = new System.Windows.Forms.GroupBox();
            this.muSearchIcon = new System.Windows.Forms.PictureBox();
            this.txtMUSearch = new System.Windows.Forms.TextBox();
            this.muPanel = new System.Windows.Forms.Panel();
            this.lblMUSuspended = new System.Windows.Forms.Label();
            this.lblMUCompany_ = new System.Windows.Forms.Label();
            this.lblMUPhone = new System.Windows.Forms.Label();
            this.lblMUName = new System.Windows.Forms.Label();
            this.lblMUUserRole = new System.Windows.Forms.Label();
            this.lblMUUserID = new System.Windows.Forms.Label();
            this.txtMUSuspended = new System.Windows.Forms.TextBox();
            this.txtMUCompany_ = new System.Windows.Forms.TextBox();
            this.txtMUPhone = new System.Windows.Forms.TextBox();
            this.txtMUName = new System.Windows.Forms.TextBox();
            this.txtMUUserRole = new System.Windows.Forms.TextBox();
            this.txtMUUserID = new System.Windows.Forms.TextBox();
            this.lblMUAddUser = new System.Windows.Forms.Label();
            this.MUNewUserGroup = new System.Windows.Forms.GroupBox();
            this.btnMUNewUser = new System.Windows.Forms.Button();
            this.msgNewUserPanel = new System.Windows.Forms.Panel();
            this.lblNewUserMsg = new System.Windows.Forms.Label();
            this.lblMUNewCPassword = new System.Windows.Forms.Label();
            this.lblMUNewPassword = new System.Windows.Forms.Label();
            this.lblMUNewCName = new System.Windows.Forms.Label();
            this.lblMUNewPhone = new System.Windows.Forms.Label();
            this.lblMUNewName = new System.Windows.Forms.Label();
            this.lblMUNewUser = new System.Windows.Forms.Label();
            this.txtMUNewCPassword = new System.Windows.Forms.TextBox();
            this.txtMUNewPassword = new System.Windows.Forms.TextBox();
            this.txtMUNewCName = new System.Windows.Forms.TextBox();
            this.txtMUNewPhone = new System.Windows.Forms.TextBox();
            this.txtMUNewName = new System.Windows.Forms.TextBox();
            this.txtMUNewUser = new System.Windows.Forms.TextBox();
            this.ActivateUserIcon = new System.Windows.Forms.PictureBox();
            this.MUNewUserIcon = new System.Windows.Forms.PictureBox();
            this.MUSuspUserIcon = new System.Windows.Forms.PictureBox();
            this.MURefreshIcon = new System.Windows.Forms.PictureBox();
            this.txtPasswordChange = new System.Windows.Forms.TextBox();
            this.txtCPasswordChange = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCNewPassword = new System.Windows.Forms.Label();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblMUChangePMsg = new System.Windows.Forms.Label();
            this.muTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muDisplayGrid)).BeginInit();
            this.muGroupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muSearchIcon)).BeginInit();
            this.muPanel.SuspendLayout();
            this.MUNewUserGroup.SuspendLayout();
            this.msgNewUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivateUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUNewUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSuspUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MURefreshIcon)).BeginInit();
            this.panelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // muTopPanel
            // 
            this.muTopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.muTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.muTopPanel.Controls.Add(this.btnCloseMU);
            this.muTopPanel.Location = new System.Drawing.Point(-1, 0);
            this.muTopPanel.Name = "muTopPanel";
            this.muTopPanel.Size = new System.Drawing.Size(944, 53);
            this.muTopPanel.TabIndex = 0;
            // 
            // btnCloseMU
            // 
            this.btnCloseMU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseMU.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCloseMU.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseMU.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCloseMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMU.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseMU.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseMU.Location = new System.Drawing.Point(909, 11);
            this.btnCloseMU.Name = "btnCloseMU";
            this.btnCloseMU.Size = new System.Drawing.Size(30, 30);
            this.btnCloseMU.TabIndex = 0;
            this.btnCloseMU.Text = "x";
            this.btnCloseMU.UseVisualStyleBackColor = false;
            this.btnCloseMU.Click += new System.EventHandler(this.btnCloseMU_Click);
            // 
            // muDisplayGrid
            // 
            this.muDisplayGrid.AllowUserToAddRows = false;
            this.muDisplayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muDisplayGrid.Location = new System.Drawing.Point(46, 129);
            this.muDisplayGrid.Name = "muDisplayGrid";
            this.muDisplayGrid.ReadOnly = true;
            this.muDisplayGrid.Size = new System.Drawing.Size(561, 270);
            this.muDisplayGrid.TabIndex = 1;
            this.muDisplayGrid.SelectionChanged += new System.EventHandler(this.muDisplayGrid_SelectionChanged);
            // 
            // muGroupSearch
            // 
            this.muGroupSearch.Controls.Add(this.muSearchIcon);
            this.muGroupSearch.Controls.Add(this.txtMUSearch);
            this.muGroupSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muGroupSearch.Location = new System.Drawing.Point(297, 64);
            this.muGroupSearch.Name = "muGroupSearch";
            this.muGroupSearch.Size = new System.Drawing.Size(357, 59);
            this.muGroupSearch.TabIndex = 2;
            this.muGroupSearch.TabStop = false;
            this.muGroupSearch.Text = "Search By User";
            // 
            // muSearchIcon
            // 
            this.muSearchIcon.Image = global::Inventory_System.Properties.Resources.search;
            this.muSearchIcon.Location = new System.Drawing.Point(316, 20);
            this.muSearchIcon.Name = "muSearchIcon";
            this.muSearchIcon.Size = new System.Drawing.Size(26, 27);
            this.muSearchIcon.TabIndex = 1;
            this.muSearchIcon.TabStop = false;
            // 
            // txtMUSearch
            // 
            this.txtMUSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMUSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMUSearch.Location = new System.Drawing.Point(27, 25);
            this.txtMUSearch.Name = "txtMUSearch";
            this.txtMUSearch.Size = new System.Drawing.Size(286, 19);
            this.txtMUSearch.TabIndex = 0;
            // 
            // muPanel
            // 
            this.muPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.muPanel.Controls.Add(this.lblMUSuspended);
            this.muPanel.Controls.Add(this.lblMUCompany_);
            this.muPanel.Controls.Add(this.lblMUPhone);
            this.muPanel.Controls.Add(this.lblMUName);
            this.muPanel.Controls.Add(this.lblMUUserRole);
            this.muPanel.Controls.Add(this.lblMUUserID);
            this.muPanel.Controls.Add(this.txtMUSuspended);
            this.muPanel.Controls.Add(this.txtMUCompany_);
            this.muPanel.Controls.Add(this.txtMUPhone);
            this.muPanel.Controls.Add(this.txtMUName);
            this.muPanel.Controls.Add(this.txtMUUserRole);
            this.muPanel.Controls.Add(this.txtMUUserID);
            this.muPanel.Location = new System.Drawing.Point(613, 129);
            this.muPanel.Name = "muPanel";
            this.muPanel.Size = new System.Drawing.Size(200, 270);
            this.muPanel.TabIndex = 3;
            // 
            // lblMUSuspended
            // 
            this.lblMUSuspended.AutoSize = true;
            this.lblMUSuspended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMUSuspended.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMUSuspended.Location = new System.Drawing.Point(9, 223);
            this.lblMUSuspended.Name = "lblMUSuspended";
            this.lblMUSuspended.Size = new System.Drawing.Size(87, 16);
            this.lblMUSuspended.TabIndex = 11;
            this.lblMUSuspended.Text = "Suspended";
            // 
            // lblMUCompany_
            // 
            this.lblMUCompany_.AutoSize = true;
            this.lblMUCompany_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMUCompany_.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMUCompany_.Location = new System.Drawing.Point(9, 179);
            this.lblMUCompany_.Name = "lblMUCompany_";
            this.lblMUCompany_.Size = new System.Drawing.Size(118, 16);
            this.lblMUCompany_.TabIndex = 10;
            this.lblMUCompany_.Text = "Company Name";
            // 
            // lblMUPhone
            // 
            this.lblMUPhone.AutoSize = true;
            this.lblMUPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMUPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMUPhone.Location = new System.Drawing.Point(9, 135);
            this.lblMUPhone.Name = "lblMUPhone";
            this.lblMUPhone.Size = new System.Drawing.Size(110, 16);
            this.lblMUPhone.TabIndex = 9;
            this.lblMUPhone.Text = "Phone Number";
            // 
            // lblMUName
            // 
            this.lblMUName.AutoSize = true;
            this.lblMUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMUName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMUName.Location = new System.Drawing.Point(9, 91);
            this.lblMUName.Name = "lblMUName";
            this.lblMUName.Size = new System.Drawing.Size(49, 16);
            this.lblMUName.TabIndex = 8;
            this.lblMUName.Text = "Name";
            // 
            // lblMUUserRole
            // 
            this.lblMUUserRole.AutoSize = true;
            this.lblMUUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMUUserRole.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMUUserRole.Location = new System.Drawing.Point(9, 47);
            this.lblMUUserRole.Name = "lblMUUserRole";
            this.lblMUUserRole.Size = new System.Drawing.Size(78, 16);
            this.lblMUUserRole.TabIndex = 7;
            this.lblMUUserRole.Text = "User Role";
            // 
            // lblMUUserID
            // 
            this.lblMUUserID.AutoSize = true;
            this.lblMUUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMUUserID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMUUserID.Location = new System.Drawing.Point(9, 3);
            this.lblMUUserID.Name = "lblMUUserID";
            this.lblMUUserID.Size = new System.Drawing.Size(56, 16);
            this.lblMUUserID.TabIndex = 6;
            this.lblMUUserID.Text = "UserID";
            // 
            // txtMUSuspended
            // 
            this.txtMUSuspended.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtMUSuspended.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMUSuspended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMUSuspended.Location = new System.Drawing.Point(12, 242);
            this.txtMUSuspended.Name = "txtMUSuspended";
            this.txtMUSuspended.Size = new System.Drawing.Size(172, 15);
            this.txtMUSuspended.TabIndex = 5;
            // 
            // txtMUCompany_
            // 
            this.txtMUCompany_.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtMUCompany_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMUCompany_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMUCompany_.Location = new System.Drawing.Point(12, 198);
            this.txtMUCompany_.Name = "txtMUCompany_";
            this.txtMUCompany_.Size = new System.Drawing.Size(172, 15);
            this.txtMUCompany_.TabIndex = 4;
            // 
            // txtMUPhone
            // 
            this.txtMUPhone.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtMUPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMUPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMUPhone.Location = new System.Drawing.Point(12, 154);
            this.txtMUPhone.Name = "txtMUPhone";
            this.txtMUPhone.Size = new System.Drawing.Size(172, 15);
            this.txtMUPhone.TabIndex = 3;
            // 
            // txtMUName
            // 
            this.txtMUName.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtMUName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMUName.Location = new System.Drawing.Point(12, 110);
            this.txtMUName.Name = "txtMUName";
            this.txtMUName.Size = new System.Drawing.Size(172, 15);
            this.txtMUName.TabIndex = 2;
            // 
            // txtMUUserRole
            // 
            this.txtMUUserRole.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtMUUserRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMUUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMUUserRole.Location = new System.Drawing.Point(12, 66);
            this.txtMUUserRole.Name = "txtMUUserRole";
            this.txtMUUserRole.Size = new System.Drawing.Size(172, 15);
            this.txtMUUserRole.TabIndex = 1;
            // 
            // txtMUUserID
            // 
            this.txtMUUserID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtMUUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMUUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMUUserID.Location = new System.Drawing.Point(12, 22);
            this.txtMUUserID.Name = "txtMUUserID";
            this.txtMUUserID.Size = new System.Drawing.Size(172, 15);
            this.txtMUUserID.TabIndex = 0;
            // 
            // lblMUAddUser
            // 
            this.lblMUAddUser.AutoSize = true;
            this.lblMUAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMUAddUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMUAddUser.Location = new System.Drawing.Point(72, 486);
            this.lblMUAddUser.Name = "lblMUAddUser";
            this.lblMUAddUser.Size = new System.Drawing.Size(103, 18);
            this.lblMUAddUser.TabIndex = 6;
            this.lblMUAddUser.Text = "Add New User";
            // 
            // MUNewUserGroup
            // 
            this.MUNewUserGroup.Controls.Add(this.btnMUNewUser);
            this.MUNewUserGroup.Controls.Add(this.msgNewUserPanel);
            this.MUNewUserGroup.Controls.Add(this.lblMUNewCPassword);
            this.MUNewUserGroup.Controls.Add(this.lblMUNewPassword);
            this.MUNewUserGroup.Controls.Add(this.lblMUNewCName);
            this.MUNewUserGroup.Controls.Add(this.lblMUNewPhone);
            this.MUNewUserGroup.Controls.Add(this.lblMUNewName);
            this.MUNewUserGroup.Controls.Add(this.lblMUNewUser);
            this.MUNewUserGroup.Controls.Add(this.txtMUNewCPassword);
            this.MUNewUserGroup.Controls.Add(this.txtMUNewPassword);
            this.MUNewUserGroup.Controls.Add(this.txtMUNewCName);
            this.MUNewUserGroup.Controls.Add(this.txtMUNewPhone);
            this.MUNewUserGroup.Controls.Add(this.txtMUNewName);
            this.MUNewUserGroup.Controls.Add(this.txtMUNewUser);
            this.MUNewUserGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUNewUserGroup.Location = new System.Drawing.Point(46, 510);
            this.MUNewUserGroup.Name = "MUNewUserGroup";
            this.MUNewUserGroup.Size = new System.Drawing.Size(767, 153);
            this.MUNewUserGroup.TabIndex = 8;
            this.MUNewUserGroup.TabStop = false;
            this.MUNewUserGroup.Text = "New User";
            // 
            // btnMUNewUser
            // 
            this.btnMUNewUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMUNewUser.FlatAppearance.BorderSize = 0;
            this.btnMUNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMUNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMUNewUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMUNewUser.Location = new System.Drawing.Point(638, 116);
            this.btnMUNewUser.Name = "btnMUNewUser";
            this.btnMUNewUser.Size = new System.Drawing.Size(91, 30);
            this.btnMUNewUser.TabIndex = 13;
            this.btnMUNewUser.Text = "Save";
            this.btnMUNewUser.UseVisualStyleBackColor = false;
            this.btnMUNewUser.Click += new System.EventHandler(this.btnMUNewUser_Click);
            // 
            // msgNewUserPanel
            // 
            this.msgNewUserPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.msgNewUserPanel.Controls.Add(this.lblNewUserMsg);
            this.msgNewUserPanel.Location = new System.Drawing.Point(17, 21);
            this.msgNewUserPanel.Name = "msgNewUserPanel";
            this.msgNewUserPanel.Size = new System.Drawing.Size(734, 32);
            this.msgNewUserPanel.TabIndex = 12;
            // 
            // lblNewUserMsg
            // 
            this.lblNewUserMsg.AutoSize = true;
            this.lblNewUserMsg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNewUserMsg.Location = new System.Drawing.Point(3, 8);
            this.lblNewUserMsg.Name = "lblNewUserMsg";
            this.lblNewUserMsg.Size = new System.Drawing.Size(0, 16);
            this.lblNewUserMsg.TabIndex = 0;
            // 
            // lblMUNewCPassword
            // 
            this.lblMUNewCPassword.AutoSize = true;
            this.lblMUNewCPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMUNewCPassword.Location = new System.Drawing.Point(442, 102);
            this.lblMUNewCPassword.Name = "lblMUNewCPassword";
            this.lblMUNewCPassword.Size = new System.Drawing.Size(116, 16);
            this.lblMUNewCPassword.TabIndex = 11;
            this.lblMUNewCPassword.Text = "Confirm Password";
            // 
            // lblMUNewPassword
            // 
            this.lblMUNewPassword.AutoSize = true;
            this.lblMUNewPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMUNewPassword.Location = new System.Drawing.Point(442, 54);
            this.lblMUNewPassword.Name = "lblMUNewPassword";
            this.lblMUNewPassword.Size = new System.Drawing.Size(68, 16);
            this.lblMUNewPassword.TabIndex = 10;
            this.lblMUNewPassword.Text = "Password";
            // 
            // lblMUNewCName
            // 
            this.lblMUNewCName.AutoSize = true;
            this.lblMUNewCName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMUNewCName.Location = new System.Drawing.Point(236, 102);
            this.lblMUNewCName.Name = "lblMUNewCName";
            this.lblMUNewCName.Size = new System.Drawing.Size(106, 16);
            this.lblMUNewCName.TabIndex = 9;
            this.lblMUNewCName.Text = "Company Name";
            // 
            // lblMUNewPhone
            // 
            this.lblMUNewPhone.AutoSize = true;
            this.lblMUNewPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMUNewPhone.Location = new System.Drawing.Point(236, 54);
            this.lblMUNewPhone.Name = "lblMUNewPhone";
            this.lblMUNewPhone.Size = new System.Drawing.Size(98, 16);
            this.lblMUNewPhone.TabIndex = 8;
            this.lblMUNewPhone.Text = "Phone Number";
            // 
            // lblMUNewName
            // 
            this.lblMUNewName.AutoSize = true;
            this.lblMUNewName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMUNewName.Location = new System.Drawing.Point(15, 101);
            this.lblMUNewName.Name = "lblMUNewName";
            this.lblMUNewName.Size = new System.Drawing.Size(45, 16);
            this.lblMUNewName.TabIndex = 7;
            this.lblMUNewName.Text = "Name";
            // 
            // lblMUNewUser
            // 
            this.lblMUNewUser.AutoSize = true;
            this.lblMUNewUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMUNewUser.Location = new System.Drawing.Point(15, 54);
            this.lblMUNewUser.Name = "lblMUNewUser";
            this.lblMUNewUser.Size = new System.Drawing.Size(69, 16);
            this.lblMUNewUser.TabIndex = 6;
            this.lblMUNewUser.Text = "User Role";
            // 
            // txtMUNewCPassword
            // 
            this.txtMUNewCPassword.Location = new System.Drawing.Point(445, 121);
            this.txtMUNewCPassword.Name = "txtMUNewCPassword";
            this.txtMUNewCPassword.Size = new System.Drawing.Size(187, 22);
            this.txtMUNewCPassword.TabIndex = 5;
            this.txtMUNewCPassword.UseSystemPasswordChar = true;
            this.txtMUNewCPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMUNewCPassword_KeyUp);
            // 
            // txtMUNewPassword
            // 
            this.txtMUNewPassword.Location = new System.Drawing.Point(445, 73);
            this.txtMUNewPassword.Name = "txtMUNewPassword";
            this.txtMUNewPassword.Size = new System.Drawing.Size(187, 22);
            this.txtMUNewPassword.TabIndex = 4;
            this.txtMUNewPassword.UseSystemPasswordChar = true;
            this.txtMUNewPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMUNewCPassword_KeyUp);
            // 
            // txtMUNewCName
            // 
            this.txtMUNewCName.Location = new System.Drawing.Point(239, 121);
            this.txtMUNewCName.Name = "txtMUNewCName";
            this.txtMUNewCName.Size = new System.Drawing.Size(187, 22);
            this.txtMUNewCName.TabIndex = 3;
            // 
            // txtMUNewPhone
            // 
            this.txtMUNewPhone.Location = new System.Drawing.Point(239, 73);
            this.txtMUNewPhone.Name = "txtMUNewPhone";
            this.txtMUNewPhone.Size = new System.Drawing.Size(187, 22);
            this.txtMUNewPhone.TabIndex = 2;
            // 
            // txtMUNewName
            // 
            this.txtMUNewName.Location = new System.Drawing.Point(18, 121);
            this.txtMUNewName.Name = "txtMUNewName";
            this.txtMUNewName.Size = new System.Drawing.Size(187, 22);
            this.txtMUNewName.TabIndex = 1;
            // 
            // txtMUNewUser
            // 
            this.txtMUNewUser.Location = new System.Drawing.Point(18, 73);
            this.txtMUNewUser.Name = "txtMUNewUser";
            this.txtMUNewUser.Size = new System.Drawing.Size(187, 22);
            this.txtMUNewUser.TabIndex = 0;
            // 
            // ActivateUserIcon
            // 
            this.ActivateUserIcon.Image = global::Inventory_System.Properties.Resources.activateUser;
            this.ActivateUserIcon.Location = new System.Drawing.Point(817, 162);
            this.ActivateUserIcon.Name = "ActivateUserIcon";
            this.ActivateUserIcon.Size = new System.Drawing.Size(26, 27);
            this.ActivateUserIcon.TabIndex = 9;
            this.ActivateUserIcon.TabStop = false;
            this.ActivateUserIcon.Click += new System.EventHandler(this.ActivateUserIcon_Click);
            // 
            // MUNewUserIcon
            // 
            this.MUNewUserIcon.Image = global::Inventory_System.Properties.Resources.plus_black;
            this.MUNewUserIcon.Location = new System.Drawing.Point(48, 482);
            this.MUNewUserIcon.Name = "MUNewUserIcon";
            this.MUNewUserIcon.Size = new System.Drawing.Size(26, 27);
            this.MUNewUserIcon.TabIndex = 7;
            this.MUNewUserIcon.TabStop = false;
            // 
            // MUSuspUserIcon
            // 
            this.MUSuspUserIcon.Image = global::Inventory_System.Properties.Resources.suspendUser;
            this.MUSuspUserIcon.Location = new System.Drawing.Point(817, 129);
            this.MUSuspUserIcon.Name = "MUSuspUserIcon";
            this.MUSuspUserIcon.Size = new System.Drawing.Size(26, 27);
            this.MUSuspUserIcon.TabIndex = 5;
            this.MUSuspUserIcon.TabStop = false;
            this.MUSuspUserIcon.Click += new System.EventHandler(this.MUSuspUserIcon_Click);
            // 
            // MURefreshIcon
            // 
            this.MURefreshIcon.Image = global::Inventory_System.Properties.Resources.refresh;
            this.MURefreshIcon.Location = new System.Drawing.Point(16, 129);
            this.MURefreshIcon.Name = "MURefreshIcon";
            this.MURefreshIcon.Size = new System.Drawing.Size(26, 27);
            this.MURefreshIcon.TabIndex = 10;
            this.MURefreshIcon.TabStop = false;
            this.MURefreshIcon.Click += new System.EventHandler(this.MURefreshIcon_Click);
            // 
            // txtPasswordChange
            // 
            this.txtPasswordChange.Location = new System.Drawing.Point(149, 5);
            this.txtPasswordChange.Name = "txtPasswordChange";
            this.txtPasswordChange.Size = new System.Drawing.Size(172, 20);
            this.txtPasswordChange.TabIndex = 11;
            // 
            // txtCPasswordChange
            // 
            this.txtCPasswordChange.Location = new System.Drawing.Point(149, 34);
            this.txtCPasswordChange.Name = "txtCPasswordChange";
            this.txtCPasswordChange.Size = new System.Drawing.Size(172, 20);
            this.txtCPasswordChange.TabIndex = 12;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNewPassword.Location = new System.Drawing.Point(30, 6);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(113, 16);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "Current Password";
            // 
            // lblCNewPassword
            // 
            this.lblCNewPassword.AutoSize = true;
            this.lblCNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNewPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCNewPassword.Location = new System.Drawing.Point(54, 35);
            this.lblCNewPassword.Name = "lblCNewPassword";
            this.lblCNewPassword.Size = new System.Drawing.Size(89, 16);
            this.lblCNewPassword.TabIndex = 14;
            this.lblCNewPassword.Text = "New Passord";
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChangePassword.Controls.Add(this.btnChangePassword);
            this.panelChangePassword.Controls.Add(this.txtPasswordChange);
            this.panelChangePassword.Controls.Add(this.lblCNewPassword);
            this.panelChangePassword.Controls.Add(this.txtCPasswordChange);
            this.panelChangePassword.Controls.Add(this.lblNewPassword);
            this.panelChangePassword.Location = new System.Drawing.Point(483, 405);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(330, 99);
            this.panelChangePassword.TabIndex = 15;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangePassword.Location = new System.Drawing.Point(8, 60);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(313, 30);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblMUChangePMsg
            // 
            this.lblMUChangePMsg.AutoSize = true;
            this.lblMUChangePMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMUChangePMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMUChangePMsg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMUChangePMsg.Location = new System.Drawing.Point(44, 412);
            this.lblMUChangePMsg.Name = "lblMUChangePMsg";
            this.lblMUChangePMsg.Size = new System.Drawing.Size(0, 16);
            this.lblMUChangePMsg.TabIndex = 16;
            // 
            // manageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 711);
            this.Controls.Add(this.lblMUChangePMsg);
            this.Controls.Add(this.panelChangePassword);
            this.Controls.Add(this.MURefreshIcon);
            this.Controls.Add(this.ActivateUserIcon);
            this.Controls.Add(this.MUNewUserGroup);
            this.Controls.Add(this.MUNewUserIcon);
            this.Controls.Add(this.lblMUAddUser);
            this.Controls.Add(this.MUSuspUserIcon);
            this.Controls.Add(this.muPanel);
            this.Controls.Add(this.muGroupSearch);
            this.Controls.Add(this.muDisplayGrid);
            this.Controls.Add(this.muTopPanel);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.manageUsers_Load);
            this.muTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.muDisplayGrid)).EndInit();
            this.muGroupSearch.ResumeLayout(false);
            this.muGroupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muSearchIcon)).EndInit();
            this.muPanel.ResumeLayout(false);
            this.muPanel.PerformLayout();
            this.MUNewUserGroup.ResumeLayout(false);
            this.MUNewUserGroup.PerformLayout();
            this.msgNewUserPanel.ResumeLayout(false);
            this.msgNewUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivateUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUNewUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSuspUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MURefreshIcon)).EndInit();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel muTopPanel;
        private System.Windows.Forms.DataGridView muDisplayGrid;
        private System.Windows.Forms.GroupBox muGroupSearch;
        private System.Windows.Forms.TextBox txtMUSearch;
        private System.Windows.Forms.PictureBox muSearchIcon;
        private System.Windows.Forms.Panel muPanel;
        private System.Windows.Forms.TextBox txtMUUserID;
        private System.Windows.Forms.TextBox txtMUSuspended;
        private System.Windows.Forms.TextBox txtMUCompany_;
        private System.Windows.Forms.TextBox txtMUPhone;
        private System.Windows.Forms.TextBox txtMUName;
        private System.Windows.Forms.TextBox txtMUUserRole;
        private System.Windows.Forms.PictureBox MUSuspUserIcon;
        private System.Windows.Forms.Label lblMUUserID;
        private System.Windows.Forms.Label lblMUSuspended;
        private System.Windows.Forms.Label lblMUCompany_;
        private System.Windows.Forms.Label lblMUPhone;
        private System.Windows.Forms.Label lblMUName;
        private System.Windows.Forms.Label lblMUUserRole;
        private System.Windows.Forms.Label lblMUAddUser;
        private System.Windows.Forms.PictureBox MUNewUserIcon;
        private System.Windows.Forms.GroupBox MUNewUserGroup;
        private System.Windows.Forms.Label lblMUNewPhone;
        private System.Windows.Forms.Label lblMUNewName;
        private System.Windows.Forms.Label lblMUNewUser;
        private System.Windows.Forms.TextBox txtMUNewCPassword;
        private System.Windows.Forms.TextBox txtMUNewPassword;
        private System.Windows.Forms.TextBox txtMUNewCName;
        private System.Windows.Forms.TextBox txtMUNewPhone;
        private System.Windows.Forms.TextBox txtMUNewName;
        private System.Windows.Forms.TextBox txtMUNewUser;
        private System.Windows.Forms.Label lblMUNewCName;
        private System.Windows.Forms.Label lblMUNewCPassword;
        private System.Windows.Forms.Label lblMUNewPassword;
        private System.Windows.Forms.Panel msgNewUserPanel;
        private System.Windows.Forms.Button btnMUNewUser;
        private System.Windows.Forms.Label lblNewUserMsg;
        private System.Windows.Forms.PictureBox ActivateUserIcon;
        private System.Windows.Forms.PictureBox MURefreshIcon;
        private System.Windows.Forms.Button btnCloseMU;
        private System.Windows.Forms.TextBox txtPasswordChange;
        private System.Windows.Forms.TextBox txtCPasswordChange;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCNewPassword;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblMUChangePMsg;
    }
}