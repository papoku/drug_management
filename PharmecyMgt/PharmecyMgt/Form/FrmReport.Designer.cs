namespace PharmecyMgt
{
    partial class FrmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.tct_report = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_create = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_specific_sale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_sale2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_sale1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_daily_sale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabpage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_ex2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_ex1 = new System.Windows.Forms.DateTimePicker();
            this.btn_dbd_ex = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_buy2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_buy1 = new System.Windows.Forms.DateTimePicker();
            this.bt_buy_order = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tct_report.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabpage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tct_report
            // 
            this.tct_report.Controls.Add(this.tabPage1);
            this.tct_report.Controls.Add(this.tabPage2);
            this.tct_report.Controls.Add(this.tabpage3);
            this.tct_report.Controls.Add(this.tabPage4);
            this.tct_report.Location = new System.Drawing.Point(19, 20);
            this.tct_report.Name = "tct_report";
            this.tct_report.SelectedIndex = 0;
            this.tct_report.Size = new System.Drawing.Size(566, 500);
            this.tct_report.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_create);
            this.groupBox1.Location = new System.Drawing.Point(15, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate a list of all product with its details. Click on \"Create\" button to get " +
                "the list. ";
            // 
            // bt_create
            // 
            this.bt_create.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_create.Image = ((System.Drawing.Image)(resources.GetObject("bt_create.Image")));
            this.bt_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_create.Location = new System.Drawing.Point(383, 100);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(96, 29);
            this.bt_create.TabIndex = 0;
            this.bt_create.Text = "Create";
            this.bt_create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sale";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_specific_sale);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dtp_sale2);
            this.groupBox4.Controls.Add(this.dtp_sale1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(33, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 166);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Specific Period";
            // 
            // bt_specific_sale
            // 
            this.bt_specific_sale.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_specific_sale.Image = ((System.Drawing.Image)(resources.GetObject("bt_specific_sale.Image")));
            this.bt_specific_sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_specific_sale.Location = new System.Drawing.Point(352, 128);
            this.bt_specific_sale.Name = "bt_specific_sale";
            this.bt_specific_sale.Size = new System.Drawing.Size(92, 28);
            this.bt_specific_sale.TabIndex = 6;
            this.bt_specific_sale.Text = "Create";
            this.bt_specific_sale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_specific_sale.UseVisualStyleBackColor = true;
            this.bt_specific_sale.Click += new System.EventHandler(this.bt_specific_sale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "To";
            // 
            // dtp_sale2
            // 
            this.dtp_sale2.Location = new System.Drawing.Point(241, 77);
            this.dtp_sale2.Name = "dtp_sale2";
            this.dtp_sale2.Size = new System.Drawing.Size(143, 20);
            this.dtp_sale2.TabIndex = 4;
            this.dtp_sale2.Value = new System.DateTime(2012, 8, 1, 12, 0, 0, 0);
            this.dtp_sale2.ValueChanged += new System.EventHandler(this.dtp_sale2_ValueChanged);
            // 
            // dtp_sale1
            // 
            this.dtp_sale1.Location = new System.Drawing.Point(55, 77);
            this.dtp_sale1.Name = "dtp_sale1";
            this.dtp_sale1.Size = new System.Drawing.Size(143, 20);
            this.dtp_sale1.TabIndex = 3;
            this.dtp_sale1.Value = new System.DateTime(2012, 8, 1, 12, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Provide The Time Period, You Want To Generate The Report.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_daily_sale);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(33, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 117);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daily Sale Report";
            // 
            // bt_daily_sale
            // 
            this.bt_daily_sale.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_daily_sale.Image = ((System.Drawing.Image)(resources.GetObject("bt_daily_sale.Image")));
            this.bt_daily_sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_daily_sale.Location = new System.Drawing.Point(352, 81);
            this.bt_daily_sale.Name = "bt_daily_sale";
            this.bt_daily_sale.Size = new System.Drawing.Size(92, 28);
            this.bt_daily_sale.TabIndex = 1;
            this.bt_daily_sale.Text = "Create";
            this.bt_daily_sale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_daily_sale.UseVisualStyleBackColor = true;
            this.bt_daily_sale.Click += new System.EventHandler(this.bt_daily_sale_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create A Sale Report including full details of Today\'s Sales.";
            // 
            // tabpage3
            // 
            this.tabpage3.Controls.Add(this.groupBox5);
            this.tabpage3.Location = new System.Drawing.Point(4, 22);
            this.tabpage3.Name = "tabpage3";
            this.tabpage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage3.Size = new System.Drawing.Size(558, 474);
            this.tabpage3.TabIndex = 2;
            this.tabpage3.Text = "Expenditure";
            this.tabpage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.dtp_ex2);
            this.groupBox5.Controls.Add(this.dtp_ex1);
            this.groupBox5.Controls.Add(this.btn_dbd_ex);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(20, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 183);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date To Date Expenditure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "To";
            // 
            // dtp_ex2
            // 
            this.dtp_ex2.Location = new System.Drawing.Point(221, 88);
            this.dtp_ex2.Name = "dtp_ex2";
            this.dtp_ex2.Size = new System.Drawing.Size(136, 20);
            this.dtp_ex2.TabIndex = 5;
            // 
            // dtp_ex1
            // 
            this.dtp_ex1.Location = new System.Drawing.Point(34, 88);
            this.dtp_ex1.Name = "dtp_ex1";
            this.dtp_ex1.Size = new System.Drawing.Size(136, 20);
            this.dtp_ex1.TabIndex = 4;
            // 
            // btn_dbd_ex
            // 
            this.btn_dbd_ex.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dbd_ex.Image = ((System.Drawing.Image)(resources.GetObject("btn_dbd_ex.Image")));
            this.btn_dbd_ex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dbd_ex.Location = new System.Drawing.Point(299, 140);
            this.btn_dbd_ex.Name = "btn_dbd_ex";
            this.btn_dbd_ex.Size = new System.Drawing.Size(96, 28);
            this.btn_dbd_ex.TabIndex = 3;
            this.btn_dbd_ex.Text = "Create";
            this.btn_dbd_ex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dbd_ex.UseVisualStyleBackColor = true;
            this.btn_dbd_ex.Click += new System.EventHandler(this.btn_dbd_ex_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Create a Date To Date Expenditure Report.";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(558, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buy Order";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtp_buy2);
            this.groupBox3.Controls.Add(this.dtp_buy1);
            this.groupBox3.Controls.Add(this.bt_buy_order);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(21, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 183);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date To Date Expenditure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "To";
            // 
            // dtp_buy2
            // 
            this.dtp_buy2.Location = new System.Drawing.Point(221, 88);
            this.dtp_buy2.Name = "dtp_buy2";
            this.dtp_buy2.Size = new System.Drawing.Size(136, 20);
            this.dtp_buy2.TabIndex = 5;
            // 
            // dtp_buy1
            // 
            this.dtp_buy1.Location = new System.Drawing.Point(34, 88);
            this.dtp_buy1.Name = "dtp_buy1";
            this.dtp_buy1.Size = new System.Drawing.Size(136, 20);
            this.dtp_buy1.TabIndex = 4;
            // 
            // bt_buy_order
            // 
            this.bt_buy_order.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buy_order.Image = ((System.Drawing.Image)(resources.GetObject("bt_buy_order.Image")));
            this.bt_buy_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buy_order.Location = new System.Drawing.Point(303, 140);
            this.bt_buy_order.Name = "bt_buy_order";
            this.bt_buy_order.Size = new System.Drawing.Size(92, 28);
            this.bt_buy_order.TabIndex = 3;
            this.bt_buy_order.Text = "Create";
            this.bt_buy_order.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buy_order.UseVisualStyleBackColor = true;
            this.bt_buy_order.Click += new System.EventHandler(this.bt_buy_order_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Create a Date To Date Expenditure Report.";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 532);
            this.Controls.Add(this.tct_report);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReport_FormClosing);
            this.tct_report.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabpage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tct_report;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_daily_sale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_sale2;
        private System.Windows.Forms.DateTimePicker dtp_sale1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_specific_sale;
        private System.Windows.Forms.TabPage tabpage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_dbd_ex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_ex2;
        private System.Windows.Forms.DateTimePicker dtp_ex1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_buy2;
        private System.Windows.Forms.DateTimePicker dtp_buy1;
        private System.Windows.Forms.Button bt_buy_order;
        private System.Windows.Forms.Label label8;

    }
}