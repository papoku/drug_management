namespace PharmecyMgt
{
    partial class Frmorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmorder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_order = new System.Windows.Forms.GroupBox();
            this.txt_uniq_order_id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_order_post = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.cmborderstatus = new System.Windows.Forms.ComboBox();
            this.cmbpayment = new System.Windows.Forms.ComboBox();
            this.gbdue = new System.Windows.Forms.GroupBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtorderedperson = new System.Windows.Forms.TextBox();
            this.lbl_ordered_by = new System.Windows.Forms.Label();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.cmb_order_type = new System.Windows.Forms.ComboBox();
            this.cmb_order_pdct_name = new System.Windows.Forms.ComboBox();
            this.bt_enter = new System.Windows.Forms.Button();
            this.txt_bonus_product = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_order_quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_order = new System.Windows.Forms.DataGridView();
            this.dg_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_bonus_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_DueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_OrderedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unqorderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.pnl_command_order = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_select_operation = new System.Windows.Forms.ComboBox();
            this.dg_order_searchlist = new System.Windows.Forms.DataGridView();
            this.clm_chkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmUniqueOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_order = new System.Windows.Forms.DateTimePicker();
            this.pnl__command_srchlist = new System.Windows.Forms.Panel();
            this.bt_dlt_searchlist = new System.Windows.Forms.Button();
            this.bt_updt_searchlist = new System.Windows.Forms.Button();
            this.gb_order.SuspendLayout();
            this.gbdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_order)).BeginInit();
            this.pnl_command_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_order_searchlist)).BeginInit();
            this.gb_search.SuspendLayout();
            this.pnl__command_srchlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // gb_order
            // 
            this.gb_order.Controls.Add(this.txt_uniq_order_id);
            this.gb_order.Controls.Add(this.label14);
            this.gb_order.Controls.Add(this.dtp_order_post);
            this.gb_order.Controls.Add(this.label13);
            this.gb_order.Controls.Add(this.bt_refresh);
            this.gb_order.Controls.Add(this.cmborderstatus);
            this.gb_order.Controls.Add(this.cmbpayment);
            this.gb_order.Controls.Add(this.gbdue);
            this.gb_order.Controls.Add(this.cmb_order_type);
            this.gb_order.Controls.Add(this.cmb_order_pdct_name);
            this.gb_order.Controls.Add(this.bt_enter);
            this.gb_order.Controls.Add(this.txt_bonus_product);
            this.gb_order.Controls.Add(this.txt_price);
            this.gb_order.Controls.Add(this.txt_order_quantity);
            this.gb_order.Controls.Add(this.label5);
            this.gb_order.Controls.Add(this.label10);
            this.gb_order.Controls.Add(this.label11);
            this.gb_order.Controls.Add(this.label4);
            this.gb_order.Controls.Add(this.label3);
            this.gb_order.Controls.Add(this.label2);
            this.gb_order.Controls.Add(this.label1);
            this.gb_order.Location = new System.Drawing.Point(37, 48);
            this.gb_order.Name = "gb_order";
            this.gb_order.Size = new System.Drawing.Size(680, 273);
            this.gb_order.TabIndex = 3;
            this.gb_order.TabStop = false;
            this.gb_order.Text = "Order Details";
            this.gb_order.Enter += new System.EventHandler(this.gb_order_Enter);
            // 
            // txt_uniq_order_id
            // 
            this.txt_uniq_order_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uniq_order_id.Location = new System.Drawing.Point(564, 10);
            this.txt_uniq_order_id.Name = "txt_uniq_order_id";
            this.txt_uniq_order_id.Size = new System.Drawing.Size(110, 20);
            this.txt_uniq_order_id.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(454, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Unique Order ID:";
            // 
            // dtp_order_post
            // 
            this.dtp_order_post.Location = new System.Drawing.Point(458, 51);
            this.dtp_order_post.Name = "dtp_order_post";
            this.dtp_order_post.Size = new System.Drawing.Size(133, 20);
            this.dtp_order_post.TabIndex = 19;
            this.dtp_order_post.Value = new System.DateTime(2012, 5, 20, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(456, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Date";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_refresh.Image")));
            this.bt_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_refresh.Location = new System.Drawing.Point(569, 233);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(105, 28);
            this.bt_refresh.TabIndex = 17;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // cmborderstatus
            // 
            this.cmborderstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmborderstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmborderstatus.FormattingEnabled = true;
            this.cmborderstatus.Items.AddRange(new object[] {
            "Received",
            "Not Received"});
            this.cmborderstatus.Location = new System.Drawing.Point(121, 191);
            this.cmborderstatus.Name = "cmborderstatus";
            this.cmborderstatus.Size = new System.Drawing.Size(220, 21);
            this.cmborderstatus.TabIndex = 16;
            this.cmborderstatus.SelectedIndexChanged += new System.EventHandler(this.cmborderstatus_SelectedIndexChanged);
            // 
            // cmbpayment
            // 
            this.cmbpayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbpayment.FormattingEnabled = true;
            this.cmbpayment.Items.AddRange(new object[] {
            "Paid",
            "Due",
            "Partial"});
            this.cmbpayment.Location = new System.Drawing.Point(121, 123);
            this.cmbpayment.Name = "cmbpayment";
            this.cmbpayment.Size = new System.Drawing.Size(188, 21);
            this.cmbpayment.TabIndex = 13;
            this.cmbpayment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbdue
            // 
            this.gbdue.Controls.Add(this.txtcontact);
            this.gbdue.Controls.Add(this.label9);
            this.gbdue.Controls.Add(this.txtdue);
            this.gbdue.Controls.Add(this.label6);
            this.gbdue.Controls.Add(this.label7);
            this.gbdue.Controls.Add(this.txtorderedperson);
            this.gbdue.Controls.Add(this.lbl_ordered_by);
            this.gbdue.Controls.Add(this.txtpaid);
            this.gbdue.Location = new System.Drawing.Point(366, 87);
            this.gbdue.Name = "gbdue";
            this.gbdue.Size = new System.Drawing.Size(308, 133);
            this.gbdue.TabIndex = 12;
            this.gbdue.TabStop = false;
            this.gbdue.Text = "Due Info";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(155, 103);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(137, 20);
            this.txtcontact.TabIndex = 9;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(153, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Contact No:";
            // 
            // txtdue
            // 
            this.txtdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdue.Location = new System.Drawing.Point(8, 103);
            this.txtdue.Name = "txtdue";
            this.txtdue.Size = new System.Drawing.Size(137, 21);
            this.txtdue.TabIndex = 1;
            this.txtdue.Text = "0";
            this.txtdue.TextChanged += new System.EventHandler(this.txtdue_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Paid Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Due Amount:";
            // 
            // txtorderedperson
            // 
            this.txtorderedperson.Location = new System.Drawing.Point(154, 45);
            this.txtorderedperson.Name = "txtorderedperson";
            this.txtorderedperson.Size = new System.Drawing.Size(137, 20);
            this.txtorderedperson.TabIndex = 6;
            // 
            // lbl_ordered_by
            // 
            this.lbl_ordered_by.AutoSize = true;
            this.lbl_ordered_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordered_by.Location = new System.Drawing.Point(153, 24);
            this.lbl_ordered_by.Name = "lbl_ordered_by";
            this.lbl_ordered_by.Size = new System.Drawing.Size(81, 16);
            this.lbl_ordered_by.TabIndex = 0;
            this.lbl_ordered_by.Text = "Ordered To:";
            // 
            // txtpaid
            // 
            this.txtpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaid.Location = new System.Drawing.Point(8, 45);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(137, 21);
            this.txtpaid.TabIndex = 5;
            this.txtpaid.Text = "0";
            this.txtpaid.TextChanged += new System.EventHandler(this.txtpaid_TextChanged);
            this.txtpaid.Leave += new System.EventHandler(this.txtpaid_Leave);
            // 
            // cmb_order_type
            // 
            this.cmb_order_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_order_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_order_type.FormattingEnabled = true;
            this.cmb_order_type.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.cmb_order_type.Location = new System.Drawing.Point(121, 50);
            this.cmb_order_type.Name = "cmb_order_type";
            this.cmb_order_type.Size = new System.Drawing.Size(89, 21);
            this.cmb_order_type.TabIndex = 1;
            this.cmb_order_type.SelectedIndexChanged += new System.EventHandler(this.cmb_order_type_SelectedIndexChanged);
            // 
            // cmb_order_pdct_name
            // 
            this.cmb_order_pdct_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_order_pdct_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_order_pdct_name.FormattingEnabled = true;
            this.cmb_order_pdct_name.Location = new System.Drawing.Point(121, 25);
            this.cmb_order_pdct_name.Name = "cmb_order_pdct_name";
            this.cmb_order_pdct_name.Size = new System.Drawing.Size(299, 21);
            this.cmb_order_pdct_name.TabIndex = 0;
            this.cmb_order_pdct_name.SelectedIndexChanged += new System.EventHandler(this.cmb_order_pdct_name_SelectedIndexChanged);
            // 
            // bt_enter
            // 
            this.bt_enter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_enter.Image = ((System.Drawing.Image)(resources.GetObject("bt_enter.Image")));
            this.bt_enter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_enter.Location = new System.Drawing.Point(467, 233);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(92, 28);
            this.bt_enter.TabIndex = 4;
            this.bt_enter.Text = "Enter";
            this.bt_enter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_enter.UseVisualStyleBackColor = true;
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // txt_bonus_product
            // 
            this.txt_bonus_product.Location = new System.Drawing.Point(121, 99);
            this.txt_bonus_product.Name = "txt_bonus_product";
            this.txt_bonus_product.Size = new System.Drawing.Size(209, 20);
            this.txt_bonus_product.TabIndex = 3;
            this.txt_bonus_product.TextChanged += new System.EventHandler(this.txt_bonus_product_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(121, 165);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(209, 20);
            this.txt_price.TabIndex = 9;
            this.txt_price.Tag = "0";
            // 
            // txt_order_quantity
            // 
            this.txt_order_quantity.Location = new System.Drawing.Point(290, 51);
            this.txt_order_quantity.Name = "txt_order_quantity";
            this.txt_order_quantity.Size = new System.Drawing.Size(128, 20);
            this.txt_order_quantity.TabIndex = 2;
            this.txt_order_quantity.TextChanged += new System.EventHandler(this.txt_order_quantity_TextChanged);
            this.txt_order_quantity.Leave += new System.EventHandler(this.txt_order_quantity_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bonus Product:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Payment Mode:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Order Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Type:";
            // 
            // dg_order
            // 
            this.dg_order.AllowUserToResizeColumns = false;
            this.dg_order.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dg_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dg_order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dg_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_order_id,
            this.dg_order_ProductId,
            this.dg_order_product_name,
            this.dg_order_type,
            this.dg_order_quantity,
            this.dg_order_bonus_product,
            this.dg_order_Payment,
            this.dg_order_price,
            this.dg_order_PaidAmount,
            this.dg_order_DueAmount,
            this.dg_order_OrderedTo,
            this.dg_order_ContactNo,
            this.dg_order_status,
            this.dg_order_date,
            this.unqorderid});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_order.DefaultCellStyle = dataGridViewCellStyle13;
            this.dg_order.Location = new System.Drawing.Point(5, 314);
            this.dg_order.Name = "dg_order";
            this.dg_order.ReadOnly = true;
            this.dg_order.RowHeadersVisible = false;
            this.dg_order.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_order.Size = new System.Drawing.Size(1245, 236);
            this.dg_order.TabIndex = 2;
            this.dg_order.UseWaitCursor = true;
            this.dg_order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_order_CellDoubleClick);
            // 
            // dg_order_id
            // 
            this.dg_order_id.HeaderText = "Order Id";
            this.dg_order_id.Name = "dg_order_id";
            this.dg_order_id.ReadOnly = true;
            this.dg_order_id.Visible = false;
            // 
            // dg_order_ProductId
            // 
            this.dg_order_ProductId.HeaderText = "Product ID";
            this.dg_order_ProductId.Name = "dg_order_ProductId";
            this.dg_order_ProductId.ReadOnly = true;
            this.dg_order_ProductId.Visible = false;
            // 
            // dg_order_product_name
            // 
            this.dg_order_product_name.HeaderText = "Product Name";
            this.dg_order_product_name.Name = "dg_order_product_name";
            this.dg_order_product_name.ReadOnly = true;
            // 
            // dg_order_type
            // 
            this.dg_order_type.HeaderText = "Order Type";
            this.dg_order_type.Name = "dg_order_type";
            this.dg_order_type.ReadOnly = true;
            // 
            // dg_order_quantity
            // 
            this.dg_order_quantity.HeaderText = "Quantity";
            this.dg_order_quantity.Name = "dg_order_quantity";
            this.dg_order_quantity.ReadOnly = true;
            // 
            // dg_order_bonus_product
            // 
            this.dg_order_bonus_product.HeaderText = "Bonus Product";
            this.dg_order_bonus_product.Name = "dg_order_bonus_product";
            this.dg_order_bonus_product.ReadOnly = true;
            this.dg_order_bonus_product.Width = 101;
            // 
            // dg_order_Payment
            // 
            this.dg_order_Payment.HeaderText = "Payment Mode";
            this.dg_order_Payment.Name = "dg_order_Payment";
            this.dg_order_Payment.ReadOnly = true;
            // 
            // dg_order_price
            // 
            this.dg_order_price.HeaderText = "Price";
            this.dg_order_price.Name = "dg_order_price";
            this.dg_order_price.ReadOnly = true;
            // 
            // dg_order_PaidAmount
            // 
            this.dg_order_PaidAmount.HeaderText = "Paid Amount";
            this.dg_order_PaidAmount.Name = "dg_order_PaidAmount";
            this.dg_order_PaidAmount.ReadOnly = true;
            // 
            // dg_order_DueAmount
            // 
            this.dg_order_DueAmount.HeaderText = "Due Amount";
            this.dg_order_DueAmount.Name = "dg_order_DueAmount";
            this.dg_order_DueAmount.ReadOnly = true;
            // 
            // dg_order_OrderedTo
            // 
            this.dg_order_OrderedTo.HeaderText = "Ordered To";
            this.dg_order_OrderedTo.Name = "dg_order_OrderedTo";
            this.dg_order_OrderedTo.ReadOnly = true;
            // 
            // dg_order_ContactNo
            // 
            this.dg_order_ContactNo.HeaderText = "Contact No";
            this.dg_order_ContactNo.Name = "dg_order_ContactNo";
            this.dg_order_ContactNo.ReadOnly = true;
            this.dg_order_ContactNo.Width = 101;
            // 
            // dg_order_status
            // 
            this.dg_order_status.HeaderText = "Order Status";
            this.dg_order_status.Name = "dg_order_status";
            this.dg_order_status.ReadOnly = true;
            // 
            // dg_order_date
            // 
            this.dg_order_date.HeaderText = "Date/Time";
            this.dg_order_date.Name = "dg_order_date";
            this.dg_order_date.ReadOnly = true;
            // 
            // unqorderid
            // 
            this.unqorderid.HeaderText = "Unique Order Id";
            this.unqorderid.Name = "unqorderid";
            this.unqorderid.ReadOnly = true;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_save.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Image = ((System.Drawing.Image)(resources.GetObject("bt_save.Image")));
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(511, 10);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(92, 28);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Save";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_delete.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete.Image")));
            this.bt_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_delete.Location = new System.Drawing.Point(622, 10);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(95, 28);
            this.bt_delete.TabIndex = 8;
            this.bt_delete.Text = "Delete";
            this.bt_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // pnl_command_order
            // 
            this.pnl_command_order.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_command_order.Controls.Add(this.bt_delete);
            this.pnl_command_order.Controls.Add(this.bt_save);
            this.pnl_command_order.Location = new System.Drawing.Point(12, 556);
            this.pnl_command_order.Name = "pnl_command_order";
            this.pnl_command_order.Size = new System.Drawing.Size(1237, 46);
            this.pnl_command_order.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Please select Your Operation:";
            // 
            // cmb_select_operation
            // 
            this.cmb_select_operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_select_operation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_select_operation.FormattingEnabled = true;
            this.cmb_select_operation.Items.AddRange(new object[] {
            "Post New Order",
            "Update Posted Order",
            "Update Order Status"});
            this.cmb_select_operation.Location = new System.Drawing.Point(436, 21);
            this.cmb_select_operation.Name = "cmb_select_operation";
            this.cmb_select_operation.Size = new System.Drawing.Size(165, 21);
            this.cmb_select_operation.TabIndex = 13;
            this.cmb_select_operation.SelectedIndexChanged += new System.EventHandler(this.cmb_select_operation_SelectedIndexChanged);
            // 
            // dg_order_searchlist
            // 
            this.dg_order_searchlist.AllowUserToResizeColumns = false;
            this.dg_order_searchlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dg_order_searchlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dg_order_searchlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_order_searchlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_chkbox,
            this.clmUniqueOrderId,
            this.Order_id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dg_order_searchlist.Location = new System.Drawing.Point(723, 44);
            this.dg_order_searchlist.Name = "dg_order_searchlist";
            this.dg_order_searchlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_order_searchlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dg_order_searchlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_order_searchlist.Size = new System.Drawing.Size(431, 219);
            this.dg_order_searchlist.TabIndex = 14;
            this.dg_order_searchlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_order_searchlist_CellContentClick);
            // 
            // clm_chkbox
            // 
            this.clm_chkbox.HeaderText = "Chkbox";
            this.clm_chkbox.Name = "clm_chkbox";
            this.clm_chkbox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm_chkbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clm_chkbox.Width = 50;
            // 
            // clmUniqueOrderId
            // 
            this.clmUniqueOrderId.HeaderText = "Unique Order Id";
            this.clmUniqueOrderId.Name = "clmUniqueOrderId";
            // 
            // Order_id
            // 
            this.Order_id.HeaderText = "Order ID";
            this.Order_id.Name = "Order_id";
            this.Order_id.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Serial";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "product Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Order Type";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Bonus Product";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Payment Type";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Price";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Paid Amount";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Due Amount";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ordered To";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Contact No.";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Order Status";
            this.Column13.Name = "Column13";
            this.Column13.Width = 90;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Date / Time";
            this.Column14.Name = "Column14";
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.label12);
            this.gb_search.Controls.Add(this.dtp_order);
            this.gb_search.Location = new System.Drawing.Point(764, 78);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(320, 132);
            this.gb_search.TabIndex = 15;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Select Date";
            this.gb_search.Enter += new System.EventHandler(this.gb_search_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Please select Date To Search:";
            // 
            // dtp_order
            // 
            this.dtp_order.CustomFormat = "dd/MMM/yyyy";
            this.dtp_order.Location = new System.Drawing.Point(10, 55);
            this.dtp_order.Name = "dtp_order";
            this.dtp_order.Size = new System.Drawing.Size(200, 20);
            this.dtp_order.TabIndex = 0;
            this.dtp_order.Value = new System.DateTime(2012, 5, 17, 0, 0, 0, 0);
            this.dtp_order.ValueChanged += new System.EventHandler(this.dtp_order_ValueChanged);
            // 
            // pnl__command_srchlist
            // 
            this.pnl__command_srchlist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl__command_srchlist.Controls.Add(this.bt_dlt_searchlist);
            this.pnl__command_srchlist.Controls.Add(this.bt_updt_searchlist);
            this.pnl__command_srchlist.Location = new System.Drawing.Point(725, 264);
            this.pnl__command_srchlist.Name = "pnl__command_srchlist";
            this.pnl__command_srchlist.Size = new System.Drawing.Size(382, 39);
            this.pnl__command_srchlist.TabIndex = 16;
            this.pnl__command_srchlist.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl__command_srchlist_Paint);
            // 
            // bt_dlt_searchlist
            // 
            this.bt_dlt_searchlist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_dlt_searchlist.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dlt_searchlist.Image = ((System.Drawing.Image)(resources.GetObject("bt_dlt_searchlist.Image")));
            this.bt_dlt_searchlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dlt_searchlist.Location = new System.Drawing.Point(110, 3);
            this.bt_dlt_searchlist.Name = "bt_dlt_searchlist";
            this.bt_dlt_searchlist.Size = new System.Drawing.Size(98, 28);
            this.bt_dlt_searchlist.TabIndex = 10;
            this.bt_dlt_searchlist.Text = "Delete";
            this.bt_dlt_searchlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_dlt_searchlist.UseVisualStyleBackColor = false;
            this.bt_dlt_searchlist.Click += new System.EventHandler(this.bt_dlt_searchlist_Click);
            // 
            // bt_updt_searchlist
            // 
            this.bt_updt_searchlist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_updt_searchlist.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_updt_searchlist.Image = ((System.Drawing.Image)(resources.GetObject("bt_updt_searchlist.Image")));
            this.bt_updt_searchlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_updt_searchlist.Location = new System.Drawing.Point(12, 3);
            this.bt_updt_searchlist.Name = "bt_updt_searchlist";
            this.bt_updt_searchlist.Size = new System.Drawing.Size(98, 28);
            this.bt_updt_searchlist.TabIndex = 9;
            this.bt_updt_searchlist.Text = "Update";
            this.bt_updt_searchlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_updt_searchlist.UseVisualStyleBackColor = false;
            this.bt_updt_searchlist.Click += new System.EventHandler(this.bt_updt_searchlist_Click);
            // 
            // Frmorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1020, 602);
            this.Controls.Add(this.pnl__command_srchlist);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.dg_order_searchlist);
            this.Controls.Add(this.cmb_select_operation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnl_command_order);
            this.Controls.Add(this.dg_order);
            this.Controls.Add(this.gb_order);
            this.Name = "Frmorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmorder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmorder_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmorder_FormClosing);
            this.TextChanged += new System.EventHandler(this.Frmorder_TextChanged);
            this.gb_order.ResumeLayout(false);
            this.gb_order.PerformLayout();
            this.gbdue.ResumeLayout(false);
            this.gbdue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_order)).EndInit();
            this.pnl_command_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_order_searchlist)).EndInit();
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.pnl__command_srchlist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_order;
        private System.Windows.Forms.TextBox txt_bonus_product;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_order_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_order;
        private System.Windows.Forms.Button bt_enter;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Panel pnl_command_order;
        private System.Windows.Forms.ComboBox cmb_order_pdct_name;
        private System.Windows.Forms.ComboBox cmb_order_type;
        private System.Windows.Forms.GroupBox gbdue;
        private System.Windows.Forms.TextBox txtdue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtorderedperson;
        private System.Windows.Forms.Label lbl_ordered_by;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.ComboBox cmbpayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmborderstatus;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_select_operation;
        private System.Windows.Forms.DataGridView dg_order_searchlist;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_order;
        private System.Windows.Forms.Panel pnl__command_srchlist;
        private System.Windows.Forms.Button bt_dlt_searchlist;
        private System.Windows.Forms.Button bt_updt_searchlist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_order_post;
        private System.Windows.Forms.TextBox txt_uniq_order_id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_bonus_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_DueAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_OrderedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn unqorderid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clm_chkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUniqueOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}