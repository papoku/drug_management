namespace PharmecyMgt
{
    partial class Frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmadmin));
            this.bt_exit = new System.Windows.Forms.Button();
            this.gb_admin = new System.Windows.Forms.GroupBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.txt_rpass = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLogin = new System.Windows.Forms.DataGridView();
            this.bt_logoff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.webBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashWithdrawalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.Image")));
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(421, 388);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(84, 27);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.Text = "Exit";
            this.bt_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // gb_admin
            // 
            this.gb_admin.Controls.Add(this.bt_delete);
            this.gb_admin.Controls.Add(this.bt_save);
            this.gb_admin.Controls.Add(this.cmb_type);
            this.gb_admin.Controls.Add(this.txt_rpass);
            this.gb_admin.Controls.Add(this.txt_pass);
            this.gb_admin.Controls.Add(this.txt_userid);
            this.gb_admin.Controls.Add(this.label4);
            this.gb_admin.Controls.Add(this.label3);
            this.gb_admin.Controls.Add(this.label2);
            this.gb_admin.Controls.Add(this.label1);
            this.gb_admin.Location = new System.Drawing.Point(80, 40);
            this.gb_admin.Name = "gb_admin";
            this.gb_admin.Size = new System.Drawing.Size(450, 176);
            this.gb_admin.TabIndex = 1;
            this.gb_admin.TabStop = false;
            this.gb_admin.Text = "User Info";
            this.gb_admin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete.Image")));
            this.bt_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_delete.Location = new System.Drawing.Point(354, 142);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(87, 26);
            this.bt_delete.TabIndex = 7;
            this.bt_delete.Text = "Delete";
            this.bt_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Image = ((System.Drawing.Image)(resources.GetObject("bt_save.Image")));
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_save.Location = new System.Drawing.Point(269, 142);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(82, 26);
            this.bt_save.TabIndex = 5;
            this.bt_save.Text = "Save";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmb_type.Location = new System.Drawing.Point(190, 45);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(118, 21);
            this.cmb_type.TabIndex = 2;
            // 
            // txt_rpass
            // 
            this.txt_rpass.Location = new System.Drawing.Point(190, 96);
            this.txt_rpass.Name = "txt_rpass";
            this.txt_rpass.PasswordChar = '*';
            this.txt_rpass.Size = new System.Drawing.Size(172, 20);
            this.txt_rpass.TabIndex = 4;
            this.txt_rpass.TextChanged += new System.EventHandler(this.txt_rpass_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(190, 71);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(172, 20);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(190, 19);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(201, 20);
            this.txt_userid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Retype Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // dgLogin
            // 
            this.dgLogin.AllowUserToAddRows = false;
            this.dgLogin.AllowUserToDeleteRows = false;
            this.dgLogin.AllowUserToResizeColumns = false;
            this.dgLogin.AllowUserToResizeRows = false;
            this.dgLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogin.Location = new System.Drawing.Point(33, 30);
            this.dgLogin.Name = "dgLogin";
            this.dgLogin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLogin.Size = new System.Drawing.Size(358, 113);
            this.dgLogin.TabIndex = 2;
            this.dgLogin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLogin_CellDoubleClick);
            this.dgLogin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_logoff
            // 
            this.bt_logoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logoff.Image = ((System.Drawing.Image)(resources.GetObject("bt_logoff.Image")));
            this.bt_logoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logoff.Location = new System.Drawing.Point(517, 388);
            this.bt_logoff.Name = "bt_logoff";
            this.bt_logoff.Size = new System.Drawing.Size(94, 27);
            this.bt_logoff.TabIndex = 3;
            this.bt_logoff.Text = "Log Off";
            this.bt_logoff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_logoff.UseVisualStyleBackColor = true;
            this.bt_logoff.Click += new System.EventHandler(this.bt_logoff_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reportingToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fiToolStripMenuItem
            // 
            this.fiToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.toolStripSeparator1,
            this.webBrowserToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            this.fiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fiToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // webBrowserToolStripMenuItem
            // 
            this.webBrowserToolStripMenuItem.Name = "webBrowserToolStripMenuItem";
            this.webBrowserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.webBrowserToolStripMenuItem.Text = "Web Browser";
            this.webBrowserToolStripMenuItem.Click += new System.EventHandler(this.webBrowserToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.orderFormToolStripMenuItem,
            this.productSellToolStripMenuItem,
            this.productReturnToolStripMenuItem,
            this.cashWithdrawalToolStripMenuItem,
            this.staffManagementToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Form";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem2.Text = "Product Entry";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // orderFormToolStripMenuItem
            // 
            this.orderFormToolStripMenuItem.Name = "orderFormToolStripMenuItem";
            this.orderFormToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.orderFormToolStripMenuItem.Text = "Order Form";
            this.orderFormToolStripMenuItem.Click += new System.EventHandler(this.orderFormToolStripMenuItem_Click);
            // 
            // productSellToolStripMenuItem
            // 
            this.productSellToolStripMenuItem.Name = "productSellToolStripMenuItem";
            this.productSellToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.productSellToolStripMenuItem.Text = "Product sell";
            this.productSellToolStripMenuItem.Click += new System.EventHandler(this.productSellToolStripMenuItem_Click);
            // 
            // productReturnToolStripMenuItem
            // 
            this.productReturnToolStripMenuItem.Name = "productReturnToolStripMenuItem";
            this.productReturnToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.productReturnToolStripMenuItem.Text = "Product Return";
            this.productReturnToolStripMenuItem.Click += new System.EventHandler(this.productReturnToolStripMenuItem_Click);
            // 
            // cashWithdrawalToolStripMenuItem
            // 
            this.cashWithdrawalToolStripMenuItem.Name = "cashWithdrawalToolStripMenuItem";
            this.cashWithdrawalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cashWithdrawalToolStripMenuItem.Text = "Cash Withdrawal";
            this.cashWithdrawalToolStripMenuItem.Click += new System.EventHandler(this.cashWithdrawalToolStripMenuItem_Click);
            // 
            // staffManagementToolStripMenuItem
            // 
            this.staffManagementToolStripMenuItem.Name = "staffManagementToolStripMenuItem";
            this.staffManagementToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.staffManagementToolStripMenuItem.Text = "Staff Management";
            this.staffManagementToolStripMenuItem.Click += new System.EventHandler(this.staffManagementToolStripMenuItem_Click);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportFormToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reportingToolStripMenuItem.Text = "Reporting";
            // 
            // reportFormToolStripMenuItem
            // 
            this.reportFormToolStripMenuItem.Name = "reportFormToolStripMenuItem";
            this.reportFormToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.reportFormToolStripMenuItem.Text = "Report Form";
            this.reportFormToolStripMenuItem.Click += new System.EventHandler(this.reportFormToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgLogin);
            this.groupBox1.Location = new System.Drawing.Point(80, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 148);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing User Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // Frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_logoff);
            this.Controls.Add(this.gb_admin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bt_exit);
            this.Name = "Frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmadmin";
            this.Load += new System.EventHandler(this.Frmadmin_Load);
            this.gb_admin.ResumeLayout(false);
            this.gb_admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.GroupBox gb_admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rpass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.DataGridView dgLogin;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Button bt_logoff;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem orderFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSellToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem productReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashWithdrawalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
    }
}