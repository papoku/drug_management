namespace PharmecyMgt
{
    partial class FrmReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_productname = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rd_update = new System.Windows.Forms.RadioButton();
            this.rd_buy = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cutback = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_enter = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.dg_return = new System.Windows.Forms.DataGridView();
            this.product_sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webpageFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_return)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cutback Rate(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Net Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date";
            // 
            // cmb_productname
            // 
            this.cmb_productname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_productname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_productname.FormattingEnabled = true;
            this.cmb_productname.Location = new System.Drawing.Point(128, 27);
            this.cmb_productname.Name = "cmb_productname";
            this.cmb_productname.Size = new System.Drawing.Size(244, 21);
            this.cmb_productname.TabIndex = 1;
            this.cmb_productname.SelectedIndexChanged += new System.EventHandler(this.cmb_productname_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_update);
            this.panel2.Controls.Add(this.rd_buy);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(538, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 97);
            this.panel2.TabIndex = 2;
            // 
            // rd_update
            // 
            this.rd_update.AutoSize = true;
            this.rd_update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_update.Location = new System.Drawing.Point(21, 66);
            this.rd_update.Name = "rd_update";
            this.rd_update.Size = new System.Drawing.Size(232, 22);
            this.rd_update.TabIndex = 0;
            this.rd_update.TabStop = true;
            this.rd_update.Text = "Update Returned Product";
            this.rd_update.UseVisualStyleBackColor = true;
            this.rd_update.CheckedChanged += new System.EventHandler(this.rd_update_CheckedChanged);
            // 
            // rd_buy
            // 
            this.rd_buy.AutoSize = true;
            this.rd_buy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_buy.Location = new System.Drawing.Point(21, 43);
            this.rd_buy.Name = "rd_buy";
            this.rd_buy.Size = new System.Drawing.Size(177, 22);
            this.rd_buy.TabIndex = 0;
            this.rd_buy.TabStop = true;
            this.rd_buy.Text = "Buy Retail Product";
            this.rd_buy.UseVisualStyleBackColor = true;
            this.rd_buy.CheckedChanged += new System.EventHandler(this.rd_buy_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(21, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Please Select Operation";
            // 
            // txt_cutback
            // 
            this.txt_cutback.Location = new System.Drawing.Point(128, 99);
            this.txt_cutback.Name = "txt_cutback";
            this.txt_cutback.Size = new System.Drawing.Size(54, 20);
            this.txt_cutback.TabIndex = 3;
            this.txt_cutback.TextChanged += new System.EventHandler(this.txt_cutback_TextChanged);
            this.txt_cutback.Leave += new System.EventHandler(this.txt_cutback_Leave);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(128, 51);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 3;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.Leave += new System.EventHandler(this.txt_qty_Leave);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(128, 123);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(136, 20);
            this.txt_price.TabIndex = 3;
            // 
            // dtp_return
            // 
            this.dtp_return.Location = new System.Drawing.Point(128, 148);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(200, 20);
            this.dtp_return.TabIndex = 4;
            this.dtp_return.UseWaitCursor = true;
            this.dtp_return.Value = new System.DateTime(2012, 6, 7, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_refresh);
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bt_enter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cutback);
            this.groupBox1.Controls.Add(this.txt_qty);
            this.groupBox1.Controls.Add(this.dtp_return);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_productname);
            this.groupBox1.Location = new System.Drawing.Point(40, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 240);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_refresh.Image")));
            this.bt_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_refresh.Location = new System.Drawing.Point(326, 203);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(100, 28);
            this.bt_refresh.TabIndex = 8;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(303, 56);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 14);
            this.lbl_total.TabIndex = 7;
            this.lbl_total.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Actual Price:";
            // 
            // bt_enter
            // 
            this.bt_enter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enter.Image = ((System.Drawing.Image)(resources.GetObject("bt_enter.Image")));
            this.bt_enter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_enter.Location = new System.Drawing.Point(231, 203);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(89, 28);
            this.bt_enter.TabIndex = 5;
            this.bt_enter.Text = "Enter";
            this.bt_enter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_enter.UseVisualStyleBackColor = true;
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete.Image")));
            this.bt_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_delete.Location = new System.Drawing.Point(727, 556);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(84, 28);
            this.bt_delete.TabIndex = 5;
            this.bt_delete.Text = "Delete";
            this.bt_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // dg_return
            // 
            this.dg_return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_return.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_sn,
            this.productname,
            this.qty,
            this.cutback,
            this.price,
            this.datetime});
            this.dg_return.Location = new System.Drawing.Point(168, 340);
            this.dg_return.Name = "dg_return";
            this.dg_return.Size = new System.Drawing.Size(643, 210);
            this.dg_return.TabIndex = 6;
            this.dg_return.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_return_CellDoubleClick);
            // 
            // product_sn
            // 
            this.product_sn.HeaderText = "Product SN";
            this.product_sn.Name = "product_sn";
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // cutback
            // 
            this.cutback.HeaderText = "Cutback Rate";
            this.cutback.Name = "cutback";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // datetime
            // 
            this.datetime.HeaderText = "Date & Time";
            this.datetime.Name = "datetime";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Product Entry";
            // 
            // orderFormToolStripMenuItem
            // 
            this.orderFormToolStripMenuItem.Name = "orderFormToolStripMenuItem";
            this.orderFormToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.orderFormToolStripMenuItem.Text = "Order Form";
            // 
            // productSellToolStripMenuItem
            // 
            this.productSellToolStripMenuItem.Name = "productSellToolStripMenuItem";
            this.productSellToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.productSellToolStripMenuItem.Text = "Product sell";
            // 
            // productReturnToolStripMenuItem
            // 
            this.productReturnToolStripMenuItem.Name = "productReturnToolStripMenuItem";
            this.productReturnToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.productReturnToolStripMenuItem.Text = "Product Return";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderFormToolStripMenuItem1,
            this.productFormToolStripMenuItem,
            this.productSeToolStripMenuItem,
            this.webpageFormToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formToolStripMenuItem.Text = "Forms";
            // 
            // orderFormToolStripMenuItem1
            // 
            this.orderFormToolStripMenuItem1.Name = "orderFormToolStripMenuItem1";
            this.orderFormToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.orderFormToolStripMenuItem1.Text = "Order Form";
            this.orderFormToolStripMenuItem1.Click += new System.EventHandler(this.orderFormToolStripMenuItem1_Click);
            // 
            // productFormToolStripMenuItem
            // 
            this.productFormToolStripMenuItem.Name = "productFormToolStripMenuItem";
            this.productFormToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.productFormToolStripMenuItem.Text = "Product Entry Form";
            this.productFormToolStripMenuItem.Click += new System.EventHandler(this.productFormToolStripMenuItem_Click);
            // 
            // productSeToolStripMenuItem
            // 
            this.productSeToolStripMenuItem.Name = "productSeToolStripMenuItem";
            this.productSeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.productSeToolStripMenuItem.Text = "Product Sell Form";
            this.productSeToolStripMenuItem.Click += new System.EventHandler(this.productSeToolStripMenuItem_Click);
            // 
            // webpageFormToolStripMenuItem
            // 
            this.webpageFormToolStripMenuItem.Name = "webpageFormToolStripMenuItem";
            this.webpageFormToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.webpageFormToolStripMenuItem.Text = "Webpage Form";
            this.webpageFormToolStripMenuItem.Click += new System.EventHandler(this.webpageFormToolStripMenuItem_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(642, 556);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 28);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FrmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 602);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dg_return);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReturn";
            this.Load += new System.EventHandler(this.FrmReturn_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReturn_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_return)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_productname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rd_update;
        private System.Windows.Forms.RadioButton rd_buy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cutback;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.DateTimePicker dtp_return;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_enter;
        private System.Windows.Forms.DataGridView dg_return;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem orderFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productReturnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderFormToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webpageFormToolStripMenuItem;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutback;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.Button bt_refresh;
    }
}