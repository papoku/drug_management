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
    public partial class FrmReturn : Form
    {
        private int AutoReturnSerial;
        private int product_serial;
        private int? rowindex;

        private string str = null;

        public FrmReturn()
        {
            InitializeComponent();
        }

        private void fieldblank()
        {
            cmb_productname.SelectedIndex = -1;
            txt_qty.Text = "";
            txt_cutback.Text = "";
            txt_price.Text = "";
            lbl_total.Text = "";
            bt_enter.Text = "Enter";
        }

        private void loadReturntbl()
        {
            try
            {
                dg_return.DataSource = null;
                List<tbl_return> returnitems = cls_return.all_return_table_data();
                dg_return.DataSource = returnitems;
                dg_return.Columns[6].Visible = false;
                //dg_return.Columns[6].Visible = false;
                dg_return.Columns[13].Visible = false;
                dg_return.Columns[7].HeaderText = "Product Serial";
                dg_return.Columns[8].HeaderText = "Product Name";
                dg_return.Columns[9].HeaderText = "Quantity";
                dg_return.Columns[10].HeaderText = "Cutback Rate";
                dg_return.Columns[11].HeaderText = "Price";
                dg_return.Columns[12].HeaderText = "Date";
            }
            catch { MessageBox.Show("Return Product List Empty !!"); }

        }




        private void AddDataToDatagrid()
        {
            //if( tabControl1.SelectedTab.na==)
            string[] row1 = new string[] { product_serial.ToString(), cmb_productname.Text.ToString(), txt_qty.Text.ToString(), txt_cutback.Text.ToString(), txt_price.Text.ToString(), dtp_return.Value.ToString() };
            dg_return.Rows.Add(row1);
            //fieldblank_order();
            //cmbpayment.SelectedIndex = 0;
            //cmborderstatus.SelectedIndex = 0;
        }

        private void LoadProductNameOnCombobox()
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    var qry = from p in db.tbl_products
                              select p;

                    foreach (tbl_product pname in qry)
                    {
                        cmb_productname.Items.Add(pname.product_name);
                    }
                }
                catch { MessageBox.Show("Product List Might Empty !!"); }
            }
        }

        private void pricecalculation()
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                tbl_product product = cls_product.get_singlerecord_product(product_serial);
                if (product != null)
                {
                    try
                    {
                        //total price of given quantity.
                        float total = float.Parse(txt_qty.Text.Trim()) * (float.Parse(product.price_per_box.ToString()) / float.Parse(product.quantity_per_box.ToString()));
                        lbl_total.Visible = true;
                        lbl_total.Text = total.ToString();

                        //product commision rate calculation.
                        txt_price.Text = (total - ((float.Parse(txt_cutback.Text.Trim()) / 100) * total)).ToString();
                    }
                    catch { MessageBox.Show("Parse Error !!"); }


                }
                else
                {
                    MessageBox.Show("Product List Empty !!");
                }
            }
           
        }

        private void FrmReturn_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(dtp_return.Value.ToString());
            LoadProductNameOnCombobox();
            rd_buy.Checked = true;
            dtp_return.Value = DateTime.Today;
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            //SaveFileDialog dlg = new SaveFileDialog();
            //dlg.ShowDialog();
            if (bt_enter.Text == "Enter")
            {
                try
                {
                    using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
                    {
                        tbl_product product = cls_product.get_singlerecord_product(product_serial);
                        if (product != null)
                        {
                            //total price of given quantity.
                            float total = float.Parse(txt_qty.Text.Trim()) * (float.Parse(product.price_per_box.ToString()) / float.Parse(product.quantity_per_box.ToString()));
                            //MessageBox.Show(total.ToString());
                            lbl_total.Visible = true;
                            lbl_total.Text = total.ToString();

                            //product commision rate calculation.
                            txt_price.Text = (total - ((float.Parse(txt_cutback.Text.Trim()) / 100) * total)).ToString();
                        }
                    }
                }
                catch
                {
                    // MessageBox.Show("empty field not allowd!!");
                }
                if (cmb_productname.Text == string.Empty && txt_qty.Text == string.Empty)
                    MessageBox.Show("Productname or Quantity Field empty !!");
                else if (txt_price.Text == string.Empty && txt_cutback.Text == string.Empty)
                    MessageBox.Show("price or cutback rate empty !!");
                else
                {
                    if (rowindex != null)
                    {
                        dg_return.Rows.RemoveAt(int.Parse(rowindex.ToString()));
                        rowindex = null;
                    }
                    AddDataToDatagrid();
                    fieldblank();
                }
            }
            else
            {
                tbl_return obj = new tbl_return();
                obj.return_sn = AutoReturnSerial;
                obj.product_sn = product_serial;
                obj.product_name = cmb_productname.Text.ToString();
                obj.quantity = float.Parse(txt_qty.Text.ToString());
                obj.cutback_rate = float.Parse(txt_cutback.Text.ToString());
                obj.price = float.Parse(txt_price.Text.ToString());
                obj.date_time = DateTime.Parse(dtp_return.Value.ToString());
                int chk = cls_return.Update_tbl_return(obj);

                if (chk != 0)
                {
                    MessageBox.Show("Data Updated :-)");
                    bt_enter.Text = "Update";
                    loadReturntbl();
                    fieldblank();
                }
                else
                    MessageBox.Show("Update Badly failed :P");
            }
        }

        private void FrmReturn_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txt_cutback_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_cutback.Text.Trim(), "cutback"))
            {
                txt_cutback.Text = str.ToString();
                txt_cutback.Focus();
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_return.SelectedRows.Count >= 1)
                {
                    if (MessageBox.Show("Are You Sure, You Want To Delete This Selected Item ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int chk = 0;
                        int count = dg_return.SelectedRows.Count;
                        foreach (DataGridViewRow row in dg_return.SelectedRows)
                        {

                            // DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                            int rowindex = dg_return.SelectedRows[0].Index;
                            AutoReturnSerial = int.Parse(dg_return.Rows[rowindex].Cells[6].Value.ToString());
                            product_serial = int.Parse(dg_return.Rows[rowindex].Cells[7].Value.ToString());
                            chk = cls_return.Delete_from_return(AutoReturnSerial);
                            if (chk == 0)
                                break;

                            tbl_current_drug singlrecord = cls_order.getsinglerecord(product_serial);
                            if (singlrecord != null)
                            {
                                float existingquantity = float.Parse(singlrecord.quantity.ToString());
                                tbl_current_drug obj = new tbl_current_drug();
                                obj.product_sn = product_serial;
                                obj.quantity = float.Parse((existingquantity - ((dg_return.CurrentRow.Cells[9].Value.ToString() != string.Empty) ? float.Parse(dg_return.CurrentRow.Cells[9].Value.ToString()) : 0)).ToString());
                                chk = cls_order.Update_tbl_Currentdrug(obj);
                                if (chk == 0)
                                    break;
                            }
                            else
                            {
                                MessageBox.Show("Something went wrong!!");
                            }

                        }
                        if (chk > 0)
                        {
                            MessageBox.Show("Successfully Deleted " + count + " Items From Return Table, and updated in current stock.");
                            //dg_return.Rows.Clear();
                            dg_return.DataBindings.Clear();
                            loadReturntbl();
                            product_serial = 0;
                        }
                        else
                            MessageBox.Show("Delete operation Failed !!");
                    }
                }
                else
                    MessageBox.Show("No Rows selected !!");
            }
            catch { MessageBox.Show("Please Make Sure You Are Not Trying To Delete Any Blank Row !!"); }

        }


        private void txt_cutback_Leave(object sender, EventArgs e)
        {
            pricecalculation();
        }

        private void cmb_productname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
                {
                    IQueryable<tbl_product> product = cls_sell.allproduct();
                    foreach (tbl_product item in product)
                    {
                        if (cmb_productname.Text.Trim().ToString() == item.product_name.ToString())
                        {
                            product_serial = (int)item.product_sn;
                        }
                        else
                            continue;
                    }
                }
            }
            catch
            {
                MessageBox.Show("No Product Listed in Product database!!");
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            int chk = 0;
            if (dg_return.Rows.Count > 1)
            {
                for (int i = 0; i < dg_return.Rows.Count - 1; i++)
                {

                    tbl_return returnitem = new tbl_return();
                    product_serial = int.Parse(dg_return.Rows[i].Cells[0].Value.ToString());
                    returnitem.product_sn = product_serial;
                    returnitem.product_name = (dg_return.Rows[i].Cells[1].Value.ToString());
                    returnitem.quantity = float.Parse(dg_return.Rows[i].Cells[2].Value.ToString());
                    returnitem.cutback_rate = float.Parse(dg_return.Rows[i].Cells[3].Value.ToString());
                    returnitem.price = float.Parse(dg_return.Rows[i].Cells[4].Value.ToString());
                    returnitem.date_time = DateTime.Parse(dg_return.Rows[i].Cells[5].Value.ToString());

                    chk = cls_return.insertdata(returnitem);
                    if (chk == 0)
                        break;

                    tbl_current_drug singlrecord = cls_order.getsinglerecord(product_serial);
                    if (singlrecord != null)
                    {
                        float existingquantity = float.Parse(singlrecord.quantity.ToString());
                        tbl_current_drug obj = new tbl_current_drug();
                        obj.product_sn = product_serial;
                        obj.quantity = float.Parse((existingquantity + ((dg_return.Rows[i].Cells[2].Value.ToString() != string.Empty) ? float.Parse(dg_return.Rows[i].Cells[2].Value.ToString()) : 0)).ToString());
                        chk = cls_order.Update_tbl_Currentdrug(obj);
                        if (chk == 0)
                            break;
                    }
                    else
                    {
                        tbl_current_drug obj = new tbl_current_drug();
                        obj.product_sn = product_serial;
                        obj.quantity = (dg_return.Rows[i].Cells[2].Value.ToString() != string.Empty) ? float.Parse(dg_return.Rows[i].Cells[2].Value.ToString()) : 0;
                        chk = cls_order.InsertOnCurrentDrug(obj);
                        if (chk == 0)
                            break;
                    }
                }
                if (chk != 0)
                {
                    MessageBox.Show("Data inserted And Updated in Current Stock!!");
                    product_serial = 0;
                }
                else
                    MessageBox.Show("Data insert Fail !!");

            }
        }

        private void rd_update_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_update.Checked == true)
            {
                product_sn.Visible = false;
                productname.Visible = false;
                qty.Visible = false;
                cutback.Visible = false;
                price.Visible = false;
                datetime.Visible = false;
                loadReturntbl();

            }
        }

        private void rd_buy_CheckedChanged(object sender, EventArgs e)
        {
            product_sn.Visible = true;
            productname.Visible = true;
            qty.Visible = true;
            cutback.Visible = true;
            price.Visible = true;
            datetime.Visible = true;
            dg_return.DataSource = null;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }



        private void dg_return_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_return.Rows.Count != 0)
            {
                try
                {
                    if (rd_update.Checked == true)
                    {
                        bt_enter.Text = "Update";
                        AutoReturnSerial = int.Parse(dg_return.SelectedRows[0].Cells[6].Value.ToString());
                        product_serial = int.Parse(dg_return.SelectedRows[0].Cells[7].Value.ToString());
                        tbl_return returnItems = cls_return.get_singlerecord_return(AutoReturnSerial);
                        if (returnItems != null)
                        {
                            cmb_productname.Text = returnItems.product_name.ToString();
                            txt_qty.Text = returnItems.quantity.ToString();
                            txt_cutback.Text = returnItems.cutback_rate.ToString();
                            txt_price.Text = returnItems.price.ToString();
                            dtp_return.Text = returnItems.date_time.ToString();

                        }

                        else
                        {
                            MessageBox.Show("Data not updated !");
                        }

                    }
                    else
                    {
                        rowindex = dg_return.SelectedRows[0].Index;
                        cmb_productname.Text = dg_return.SelectedRows[0].Cells[1].Value.ToString();
                        txt_qty.Text = dg_return.SelectedRows[0].Cells[2].Value.ToString();
                        txt_cutback.Text = dg_return.SelectedRows[0].Cells[3].Value.ToString();
                        txt_price.Text = dg_return.SelectedRows[0].Cells[4].Value.ToString();
                        dtp_return.Text = dg_return.SelectedRows[0].Cells[5].Value.ToString();
                    }
                }
                catch
                {

                }
            }
            else
                MessageBox.Show("Datagrid Empty!");
                    
        }


        private void txt_qty_Leave(object sender, EventArgs e)
        {
            if (txt_cutback.Text != String.Empty)
            {
                try
                {
                    using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
                    {
                        tbl_product product = cls_product.get_singlerecord_product(product_serial);
                        if (product != null)
                        {
                            //total price of given quantity.
                            float total = float.Parse(txt_qty.Text.Trim()) * (float.Parse(product.price_per_box.ToString()) / float.Parse(product.quantity_per_box.ToString()));
                            //MessageBox.Show(total.ToString());
                            lbl_total.Visible = true;
                            lbl_total.Text = total.ToString();

                            //product commision rate calculation.
                            txt_price.Text = (total - ((float.Parse(txt_cutback.Text.Trim()) / 100) * total)).ToString();
                        }
                    }
                }


                catch
                {
                    MessageBox.Show("Empty Quantity/Cutback rate field not allowd!!");
                }

            }
        }

        private void orderFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmorder obj = new Frmorder();
            obj.Show();
            this.Hide();
        }

        private void productSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsell obj = new Frmsell();
            obj.Show();
            this.Hide();
        }

        private void productFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduct obj = new FrmProduct();
            obj.Show();
            this.Hide();
        }

        private void webpageFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWeb obj = new FrmWeb();
            obj.Show();
            this.Hide();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            fieldblank();
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_qty.Text.Trim(), "qty"))
            {
                txt_qty.Text = str.ToString();
                txt_qty.Focus();
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

                        case "cutback":
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
        
       

