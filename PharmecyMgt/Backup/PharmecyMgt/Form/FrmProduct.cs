using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmecyMgt
{
    public partial class FrmProduct : Form
    {
        int productid = 0;
        int index = 0;
        private string str = null;

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FieldBlankProduct()
        {
            cmb_product_name.Text = "";
            txt_product_group.Text = "";
            txt_quantity_per_box.Text = "";
            txt_company_name.Text = "";
            txt_price_per_box.Text = "";
            txt_comission_rate.Text = "";
        }

        private void LoadProductDataOnDatagrid()
        {
            List<tbl_product> AllProductData = cls_product.GetAllProductData();

            if (AllProductData != null)
            {
                dg_product.DataSource= AllProductData;
                //dg_product.Columns[0].Visible = false;
                dg_product.Columns[0].HeaderText = "Serial No.";
                dg_product.Columns[1].HeaderText = "Product Name";
                dg_product.Columns[2].HeaderText = "Product Group";
                dg_product.Columns[3].HeaderText = "Quantity Per Box";
                dg_product.Columns[4].HeaderText = "Company Name";
                dg_product.Columns[5].HeaderText = "Price Per Box";
                dg_product.Columns[6].HeaderText = "Comission";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void gb_product_entry_Enter(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (bt_save.Text != "Update")
                {
                    tbl_product product = new tbl_product();
                    product.product_name = cmb_product_name.Text.Trim();
                    product.product_group = txt_product_group.Text.Trim();
                    product.quantity_per_box = float.Parse(txt_quantity_per_box.Text.Trim());
                    product.company_name = txt_company_name.Text.Trim();
                    product.price_per_box = float.Parse(txt_price_per_box.Text.Trim());
                    product.comission_rate_percentege = float.Parse(txt_comission_rate.Text.Trim());

                    int check = 0;
                    check = cls_product.insertOnProduct(product);

                    if (check > 0)
                    {
                        MessageBox.Show("New Drug Inserted !!");

                        LoadProductNameOnCombobox();
                        LoadProductDataOnDatagrid();
                        FieldBlankProduct();
                        cmb_product_name.Focus();
                    }


                }
                else
                {
                    tbl_product obj = new tbl_product();
                    obj.product_sn = productid;
                    obj.product_name = cmb_product_name.Text.ToString();
                    obj.product_group = txt_product_group.Text.ToString();
                    obj.quantity_per_box = float.Parse(txt_quantity_per_box.Text.ToString());
                    obj.company_name = txt_company_name.Text.ToString();
                    obj.price_per_box = float.Parse(txt_price_per_box.Text.ToString());
                    obj.comission_rate_percentege = float.Parse(txt_comission_rate.Text.ToString());

                    int chk = cls_product.Update_tbl_Product(obj);
                    if (chk > 0)
                    {
                        MessageBox.Show("Product Updated");
                        LoadProductDataOnDatagrid();
                        dg_product.FirstDisplayedScrollingRowIndex = index;
                        dg_product.Rows[index].Selected = true;
                        FieldBlankProduct();
                    }
                    else
                        MessageBox.Show("Product Update Failed !!");
                }
            }
            catch { MessageBox.Show("Please Check Field are not empty!!"); }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadProductDataOnDatagrid();
            LoadProductNameOnCombobox();
            
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmlogin obj = new Frmlogin();
            obj.Show();
        }

        private void btproduct_Click(object sender, EventArgs e)
        {
            Frmadmin obj = new Frmadmin();
            obj.Show();
            this.Close();
        }

        private void cmb_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    var qry = from p in db.tbl_products
                              select p;


                    if (qry.Count() != 0)
                    {
                        foreach (tbl_product item in qry)
                        {
                            if (cmb_product_name.Text == item.product_name)
                            {
                                txt_product_group.Text = item.product_group;
                                txt_quantity_per_box.Text = item.quantity_per_box.ToString();
                                txt_company_name.Text = item.company_name;
                                txt_price_per_box.Text = item.price_per_box.ToString();
                                txt_comission_rate.Text = item.comission_rate_percentege.ToString();
                                bt_save.Text = "Update";
                            }

                        }
                    }
                }
                catch { MessageBox.Show("Product List Might Empty !!"); }
            }
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            FieldBlankProduct();
            bt_save.Text = "Save";
            productid = 0;
        }

        private void LoadProductNameOnCombobox()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {
                var qry = from p in db.tbl_products
                          select p;

                foreach (tbl_product pname in qry)
                {
                    cmb_product_name.Items.Add(pname.product_name);
                }
            }
            catch { MessageBox.Show("Product List Might Be Empty !!"); }

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (productid > 0)
            {
                int product = cls_product.Delete_from_product(productid);
                if (product > 0)
                {
                    MessageBox.Show("Product Deleted !!");
                    LoadProductDataOnDatagrid();
                    FieldBlankProduct();
                    productid = 0;
                }
                else { MessageBox.Show("Delete Operation Failed !!"); }
            }
            else { MessageBox.Show("Nothing To Delete !!"); }
        }

        private void dg_product_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = dg_product.SelectedRows[0].Index;
                productid = int.Parse(dg_product.SelectedRows[0].Cells[0].Value.ToString());
                //MessageBox.Show(productid.ToString());
                tbl_product product = cls_product.get_singlerecord_product(productid);
                cmb_product_name.Text = product.product_name.ToString();
                txt_product_group.Text = product.product_group.ToString();
                txt_quantity_per_box.Text = product.quantity_per_box.ToString();
                txt_company_name.Text = product.company_name.ToString();
                txt_price_per_box.Text = product.price_per_box.ToString();
                txt_comission_rate.Text = product.comission_rate_percentege.ToString();
            }
            catch { MessageBox.Show("Parse Error !!"); }
        }

        private void FrmProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult key = MessageBox.Show("Want to quit ??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (key == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                Frmadmin obj = new Frmadmin();
                obj.Show();
            }
            
        }

        private bool checkfield(string pstr, string i)
        {
            bool temp = true;

            if (pstr != "")
            {
                try
                {
                    float.Parse(pstr);
                    str = pstr;
                }
                catch
                {
                    switch (i)
                    {
                        case "price":
                            MessageBox.Show("Invalid Price Input !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;

                        case "comission":
                            MessageBox.Show("Invalid Input !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;

                        case "qty":
                            MessageBox.Show("Invalid Quantity !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;


                    }

                }
            }
            return temp;

        }

        private void txt_price_per_box_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_price_per_box.Text.Trim(),"price"))
            {
                txt_price_per_box.Text = str.ToString();
                txt_price_per_box.Focus();
            }
        }

        private void txt_quantity_per_box_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_quantity_per_box.Text.Trim(), "qty"))
            {
                txt_quantity_per_box.Text = str.ToString();
                txt_quantity_per_box.Focus();
            }
        }

        private void txt_comission_rate_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_comission_rate.Text.Trim(), "comission"))
            {
                txt_comission_rate.Text = str.ToString();
                txt_comission_rate.Focus();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



    }
        
       
        
    }
