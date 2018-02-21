namespace PharmecyMgt
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.gb_product_entry = new System.Windows.Forms.GroupBox();
            this.btrefresh = new System.Windows.Forms.Button();
            this.txt_comission_rate = new System.Windows.Forms.TextBox();
            this.cmb_product_name = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.txt_price_per_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_product_group = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_company_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_quantity_per_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_product = new System.Windows.Forms.DataGridView();
            this.gb_product_entry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_product_entry
            // 
            this.gb_product_entry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_product_entry.Controls.Add(this.btrefresh);
            this.gb_product_entry.Controls.Add(this.txt_comission_rate);
            this.gb_product_entry.Controls.Add(this.cmb_product_name);
            this.gb_product_entry.Controls.Add(this.label8);
            this.gb_product_entry.Controls.Add(this.bt_delete);
            this.gb_product_entry.Controls.Add(this.label7);
            this.gb_product_entry.Controls.Add(this.bt_save);
            this.gb_product_entry.Controls.Add(this.txt_price_per_box);
            this.gb_product_entry.Controls.Add(this.label6);
            this.gb_product_entry.Controls.Add(this.txt_product_group);
            this.gb_product_entry.Controls.Add(this.label5);
            this.gb_product_entry.Controls.Add(this.txt_company_name);
            this.gb_product_entry.Controls.Add(this.label4);
            this.gb_product_entry.Controls.Add(this.txt_quantity_per_box);
            this.gb_product_entry.Controls.Add(this.label2);
            this.gb_product_entry.Controls.Add(this.label1);
            this.gb_product_entry.Location = new System.Drawing.Point(54, 12);
            this.gb_product_entry.Name = "gb_product_entry";
            this.gb_product_entry.Size = new System.Drawing.Size(607, 248);
            this.gb_product_entry.TabIndex = 0;
            this.gb_product_entry.TabStop = false;
            this.gb_product_entry.Text = "Product Entry";
            this.gb_product_entry.Enter += new System.EventHandler(this.gb_product_entry_Enter);
            // 
            // btrefresh
            // 
            this.btrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btrefresh.Image")));
            this.btrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btrefresh.Location = new System.Drawing.Point(504, 208);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(94, 28);
            this.btrefresh.TabIndex = 10;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // txt_comission_rate
            // 
            this.txt_comission_rate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_comission_rate.Location = new System.Drawing.Point(449, 15);
            this.txt_comission_rate.Name = "txt_comission_rate";
            this.txt_comission_rate.Size = new System.Drawing.Size(77, 20);
            this.txt_comission_rate.TabIndex = 5;
            this.txt_comission_rate.TextChanged += new System.EventHandler(this.txt_comission_rate_TextChanged);
            // 
            // cmb_product_name
            // 
            this.cmb_product_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_product_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_product_name.FormattingEnabled = true;
            this.cmb_product_name.Location = new System.Drawing.Point(155, 53);
            this.cmb_product_name.Name = "cmb_product_name";
            this.cmb_product_name.Size = new System.Drawing.Size(372, 21);
            this.cmb_product_name.TabIndex = 0;
            this.cmb_product_name.SelectedIndexChanged += new System.EventHandler(this.cmb_product_name_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Comission Rate:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete.Image")));
            this.bt_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_delete.Location = new System.Drawing.Point(407, 208);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(89, 28);
            this.bt_delete.TabIndex = 7;
            this.bt_delete.Text = "Delete";
            this.bt_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price Per Box:";
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Image = ((System.Drawing.Image)(resources.GetObject("bt_save.Image")));
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(319, 208);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(82, 28);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Save";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // txt_price_per_box
            // 
            this.txt_price_per_box.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_price_per_box.Location = new System.Drawing.Point(155, 138);
            this.txt_price_per_box.Name = "txt_price_per_box";
            this.txt_price_per_box.Size = new System.Drawing.Size(172, 20);
            this.txt_price_per_box.TabIndex = 4;
            this.txt_price_per_box.TextChanged += new System.EventHandler(this.txt_price_per_box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Company Name:";
            // 
            // txt_product_group
            // 
            this.txt_product_group.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_product_group.Location = new System.Drawing.Point(155, 80);
            this.txt_product_group.Name = "txt_product_group";
            this.txt_product_group.Size = new System.Drawing.Size(228, 20);
            this.txt_product_group.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity Per Box:";
            // 
            // txt_company_name
            // 
            this.txt_company_name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_company_name.Location = new System.Drawing.Point(155, 103);
            this.txt_company_name.Name = "txt_company_name";
            this.txt_company_name.Size = new System.Drawing.Size(228, 20);
            this.txt_company_name.TabIndex = 3;
            this.txt_company_name.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product Group:";
            // 
            // txt_quantity_per_box
            // 
            this.txt_quantity_per_box.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_quantity_per_box.Location = new System.Drawing.Point(408, 103);
            this.txt_quantity_per_box.Name = "txt_quantity_per_box";
            this.txt_quantity_per_box.Size = new System.Drawing.Size(122, 20);
            this.txt_quantity_per_box.TabIndex = 2;
            this.txt_quantity_per_box.TextChanged += new System.EventHandler(this.txt_quantity_per_box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, -22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dg_product
            // 
            this.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_product.Location = new System.Drawing.Point(12, 292);
            this.dg_product.Name = "dg_product";
            this.dg_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_product.Size = new System.Drawing.Size(777, 180);
            this.dg_product.TabIndex = 2;
            this.dg_product.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_product_CellDoubleClick);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 486);
            this.Controls.Add(this.dg_product);
            this.Controls.Add(this.gb_product_entry);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Entry";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProduct_FormClosing);
            this.gb_product_entry.ResumeLayout(false);
            this.gb_product_entry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_product_entry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_product_group;
        private System.Windows.Forms.TextBox txt_quantity_per_box;
        private System.Windows.Forms.TextBox txt_company_name;
        private System.Windows.Forms.TextBox txt_price_per_box;
        private System.Windows.Forms.TextBox txt_comission_rate;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.DataGridView dg_product;
        private System.Windows.Forms.ComboBox cmb_product_name;
        private System.Windows.Forms.Button btrefresh;
    }
}