namespace PharmecyMgt
{
    partial class Frmsell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsell));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.cmbpayment = new System.Windows.Forms.ComboBox();
            this.gbdetail = new System.Windows.Forms.GroupBox();
            this.txt_dcnt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_product_name = new System.Windows.Forms.ComboBox();
            this.gbdue = new System.Windows.Forms.GroupBox();
            this.txtdue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgsell = new System.Windows.Forms.DataGridView();
            this.ClmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProductSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsellid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcompany = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtgrp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btenter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btsave = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.bt_dlt_sell = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.cmb_select_operation = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbdetail.SuspendLayout();
            this.gbdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsell)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Payment Mode:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(148, 48);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(120, 20);
            this.txtqty.TabIndex = 1;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            this.txtqty.Leave += new System.EventHandler(this.txtqty_Leave);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(321, 46);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(136, 21);
            this.txtprice.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Paid Amount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(83, 113);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(43, 18);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Date:";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // txtpaid
            // 
            this.txtpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaid.Location = new System.Drawing.Point(8, 38);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(100, 21);
            this.txtpaid.TabIndex = 5;
            this.txtpaid.Text = "0";
            this.txtpaid.Leave += new System.EventHandler(this.txtpaid_Leave);
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(148, 112);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(164, 20);
            this.txtdate.TabIndex = 4;
            this.txtdate.TextChanged += new System.EventHandler(this.txtdate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(119, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contact No:";
            // 
            // txtcustname
            // 
            this.txtcustname.Location = new System.Drawing.Point(121, 38);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(120, 20);
            this.txtcustname.TabIndex = 6;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(121, 82);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(131, 20);
            this.txtcontact.TabIndex = 7;
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
            this.cmbpayment.Location = new System.Drawing.Point(148, 87);
            this.cmbpayment.Name = "cmbpayment";
            this.cmbpayment.Size = new System.Drawing.Size(164, 21);
            this.cmbpayment.TabIndex = 3;
            this.cmbpayment.SelectedIndexChanged += new System.EventHandler(this.cmbpayment_SelectedIndexChanged);
            // 
            // gbdetail
            // 
            this.gbdetail.Controls.Add(this.txt_dcnt);
            this.gbdetail.Controls.Add(this.label15);
            this.gbdetail.Controls.Add(this.cmb_product_name);
            this.gbdetail.Controls.Add(this.txtqty);
            this.gbdetail.Controls.Add(this.cmbpayment);
            this.gbdetail.Controls.Add(this.label1);
            this.gbdetail.Controls.Add(this.label2);
            this.gbdetail.Controls.Add(this.txtdate);
            this.gbdetail.Controls.Add(this.label3);
            this.gbdetail.Controls.Add(this.label4);
            this.gbdetail.Controls.Add(this.txtprice);
            this.gbdetail.Controls.Add(this.lbldate);
            this.gbdetail.Location = new System.Drawing.Point(21, 40);
            this.gbdetail.Name = "gbdetail";
            this.gbdetail.Size = new System.Drawing.Size(463, 145);
            this.gbdetail.TabIndex = 3;
            this.gbdetail.TabStop = false;
            this.gbdetail.Text = "Items Detail";
            this.gbdetail.Enter += new System.EventHandler(this.gbdetail_Enter);
            // 
            // txt_dcnt
            // 
            this.txt_dcnt.Location = new System.Drawing.Point(341, 110);
            this.txt_dcnt.Name = "txt_dcnt";
            this.txt_dcnt.Size = new System.Drawing.Size(100, 20);
            this.txt_dcnt.TabIndex = 6;
            this.txt_dcnt.TextChanged += new System.EventHandler(this.txt_dcnt_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(340, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 18);
            this.label15.TabIndex = 5;
            this.label15.Text = "Discount Rate:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // cmb_product_name
            // 
            this.cmb_product_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_product_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_product_name.FormattingEnabled = true;
            this.cmb_product_name.Location = new System.Drawing.Point(148, 24);
            this.cmb_product_name.Name = "cmb_product_name";
            this.cmb_product_name.Size = new System.Drawing.Size(309, 21);
            this.cmb_product_name.TabIndex = 0;
            this.cmb_product_name.SelectedIndexChanged += new System.EventHandler(this.cmb_product_name_SelectedIndexChanged);
            // 
            // gbdue
            // 
            this.gbdue.Controls.Add(this.txtdue);
            this.gbdue.Controls.Add(this.txtcontact);
            this.gbdue.Controls.Add(this.label6);
            this.gbdue.Controls.Add(this.label5);
            this.gbdue.Controls.Add(this.txtcustname);
            this.gbdue.Controls.Add(this.label8);
            this.gbdue.Controls.Add(this.txtpaid);
            this.gbdue.Controls.Add(this.label9);
            this.gbdue.Location = new System.Drawing.Point(21, 187);
            this.gbdue.Name = "gbdue";
            this.gbdue.Size = new System.Drawing.Size(263, 111);
            this.gbdue.TabIndex = 4;
            this.gbdue.TabStop = false;
            this.gbdue.Text = "Due Info";
            // 
            // txtdue
            // 
            this.txtdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdue.Location = new System.Drawing.Point(8, 81);
            this.txtdue.Name = "txtdue";
            this.txtdue.Size = new System.Drawing.Size(100, 21);
            this.txtdue.TabIndex = 1;
            this.txtdue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Due Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(506, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Product Sell";
            // 
            // dgsell
            // 
            this.dgsell.AllowUserToResizeColumns = false;
            this.dgsell.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgsell.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgsell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgsell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmProductName,
            this.ClmQuantity,
            this.ClmPrice,
            this.ClmPaymentType,
            this.ClmDate,
            this.ClmPaidAmount,
            this.ClmDueAmount,
            this.ClmCustomerName,
            this.ClmContact,
            this.ClmProductSerialNo,
            this.clmsellid});
            this.dgsell.Location = new System.Drawing.Point(1, 341);
            this.dgsell.Name = "dgsell";
            this.dgsell.ReadOnly = true;
            this.dgsell.RowHeadersVisible = false;
            this.dgsell.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgsell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsell.Size = new System.Drawing.Size(942, 155);
            this.dgsell.TabIndex = 6;
            this.dgsell.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsell_CellDoubleClick);
            this.dgsell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClmProductName
            // 
            this.ClmProductName.HeaderText = "Product Name";
            this.ClmProductName.Name = "ClmProductName";
            this.ClmProductName.ReadOnly = true;
            // 
            // ClmQuantity
            // 
            this.ClmQuantity.HeaderText = "Quantity";
            this.ClmQuantity.Name = "ClmQuantity";
            this.ClmQuantity.ReadOnly = true;
            // 
            // ClmPrice
            // 
            this.ClmPrice.HeaderText = "Price";
            this.ClmPrice.Name = "ClmPrice";
            this.ClmPrice.ReadOnly = true;
            // 
            // ClmPaymentType
            // 
            this.ClmPaymentType.HeaderText = "Payment Type";
            this.ClmPaymentType.Name = "ClmPaymentType";
            this.ClmPaymentType.ReadOnly = true;
            // 
            // ClmDate
            // 
            this.ClmDate.HeaderText = "Date";
            this.ClmDate.Name = "ClmDate";
            this.ClmDate.ReadOnly = true;
            // 
            // ClmPaidAmount
            // 
            this.ClmPaidAmount.HeaderText = "Paid Amount";
            this.ClmPaidAmount.Name = "ClmPaidAmount";
            this.ClmPaidAmount.ReadOnly = true;
            // 
            // ClmDueAmount
            // 
            this.ClmDueAmount.HeaderText = "Due Amount";
            this.ClmDueAmount.Name = "ClmDueAmount";
            this.ClmDueAmount.ReadOnly = true;
            // 
            // ClmCustomerName
            // 
            this.ClmCustomerName.HeaderText = "Customer Name";
            this.ClmCustomerName.Name = "ClmCustomerName";
            this.ClmCustomerName.ReadOnly = true;
            // 
            // ClmContact
            // 
            this.ClmContact.HeaderText = "Customer Contact";
            this.ClmContact.Name = "ClmContact";
            this.ClmContact.ReadOnly = true;
            // 
            // ClmProductSerialNo
            // 
            this.ClmProductSerialNo.HeaderText = "ProductSerialNo";
            this.ClmProductSerialNo.Name = "ClmProductSerialNo";
            this.ClmProductSerialNo.ReadOnly = true;
            this.ClmProductSerialNo.Visible = false;
            // 
            // clmsellid
            // 
            this.clmsellid.HeaderText = "Sell SN.";
            this.clmsellid.Name = "clmsellid";
            this.clmsellid.ReadOnly = true;
            this.clmsellid.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcompany);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblqty);
            this.groupBox1.Controls.Add(this.txtgrp);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(503, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drug Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblcompany
            // 
            this.lblcompany.AutoSize = true;
            this.lblcompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompany.Location = new System.Drawing.Point(139, 98);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(41, 14);
            this.lblcompany.TabIndex = 2;
            this.lblcompany.Text = "None";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(196, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Items";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(148, 78);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(16, 14);
            this.lblqty.TabIndex = 2;
            this.lblqty.Text = "0";
            // 
            // txtgrp
            // 
            this.txtgrp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrp.Location = new System.Drawing.Point(138, 28);
            this.txtgrp.Name = "txtgrp";
            this.txtgrp.Size = new System.Drawing.Size(132, 22);
            this.txtgrp.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Product Vendor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Per Box Include";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Product Group";
            // 
            // btenter
            // 
            this.btenter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btenter.Image = ((System.Drawing.Image)(resources.GetObject("btenter.Image")));
            this.btenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btenter.Location = new System.Drawing.Point(295, 221);
            this.btenter.Name = "btenter";
            this.btenter.Size = new System.Drawing.Size(85, 28);
            this.btenter.TabIndex = 8;
            this.btenter.Text = "Enter";
            this.btenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btenter.UseVisualStyleBackColor = true;
            this.btenter.Click += new System.EventHandler(this.btenter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btsave);
            this.panel1.Controls.Add(this.btexit);
            this.panel1.Controls.Add(this.bt_dlt_sell);
            this.panel1.Location = new System.Drawing.Point(572, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 37);
            this.panel1.TabIndex = 9;
            // 
            // btsave
            // 
            this.btsave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsave.Location = new System.Drawing.Point(47, 5);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(86, 28);
            this.btsave.TabIndex = 1;
            this.btsave.Text = "SAVE";
            this.btsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btexit.Image = ((System.Drawing.Image)(resources.GetObject("btexit.Image")));
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexit.Location = new System.Drawing.Point(253, 5);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(87, 28);
            this.btexit.TabIndex = 0;
            this.btexit.Text = "EXIT";
            this.btexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // bt_dlt_sell
            // 
            this.bt_dlt_sell.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dlt_sell.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_dlt_sell.Image = ((System.Drawing.Image)(resources.GetObject("bt_dlt_sell.Image")));
            this.bt_dlt_sell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dlt_sell.Location = new System.Drawing.Point(145, 5);
            this.bt_dlt_sell.Name = "bt_dlt_sell";
            this.bt_dlt_sell.Size = new System.Drawing.Size(102, 28);
            this.bt_dlt_sell.TabIndex = 0;
            this.bt_dlt_sell.Text = "DELETE";
            this.bt_dlt_sell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_dlt_sell.UseVisualStyleBackColor = true;
            this.bt_dlt_sell.Click += new System.EventHandler(this.bt_dlt_sell_Click);
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdelete.Location = new System.Drawing.Point(386, 221);
            this.btdelete.Name = "btdelete";
            this.btdelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btdelete.Size = new System.Drawing.Size(96, 28);
            this.btdelete.TabIndex = 10;
            this.btdelete.Text = "Delete";
            this.btdelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // s
            // 
            this.s.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.s.Image = ((System.Drawing.Image)(resources.GetObject("s.Image")));
            this.s.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.s.Location = new System.Drawing.Point(377, 257);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(105, 28);
            this.s.TabIndex = 11;
            this.s.Text = "Refresh";
            this.s.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.s.UseVisualStyleBackColor = true;
            this.s.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // cmb_select_operation
            // 
            this.cmb_select_operation.FormattingEnabled = true;
            this.cmb_select_operation.Items.AddRange(new object[] {
            "Post New Sell",
            "Update Posted Sell"});
            this.cmb_select_operation.Location = new System.Drawing.Point(249, 10);
            this.cmb_select_operation.Name = "cmb_select_operation";
            this.cmb_select_operation.Size = new System.Drawing.Size(165, 21);
            this.cmb_select_operation.TabIndex = 15;
            this.cmb_select_operation.SelectedIndexChanged += new System.EventHandler(this.cmb_select_operation_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Please select Your Operation:";
            // 
            // Frmsell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(955, 541);
            this.Controls.Add(this.cmb_select_operation);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.s);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btenter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgsell);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbdue);
            this.Controls.Add(this.gbdetail);
            this.Name = "Frmsell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Sell";
            this.Load += new System.EventHandler(this.Frmsell_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmsell_FormClosing);
            this.gbdetail.ResumeLayout(false);
            this.gbdetail.PerformLayout();
            this.gbdue.ResumeLayout(false);
            this.gbdue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsell)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.ComboBox cmbpayment;
        private System.Windows.Forms.GroupBox gbdetail;
        private System.Windows.Forms.GroupBox gbdue;
        private System.Windows.Forms.TextBox txtdue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_product_name;
        private System.Windows.Forms.DataGridView dgsell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtgrp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label lblcompany;
        private System.Windows.Forms.Button btenter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button bt_dlt_sell;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.ComboBox cmb_select_operation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDueAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProductSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsellid;
        private System.Windows.Forms.TextBox txt_dcnt;
        private System.Windows.Forms.Label label15;
    }
}