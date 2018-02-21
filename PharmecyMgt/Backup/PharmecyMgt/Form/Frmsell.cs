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
    public partial class Frmsell : Form
    {
        public Frmsell()
        {
            InitializeComponent();
        }

        bool flag = true;
        int ProductId = 0;
        int IndexNo;
        private int sellid = 0;

        private void fieldchk()
        {
            if (cmb_product_name.Text.ToString() == string.Empty || txtqty.Text.ToString() == string.Empty || cmbpayment.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Required Field(*) Could Not Be Empty !!");
                flag = false;
            }
            if (cmbpayment.Text.ToString() == "Due" ||cmbpayment.Text.ToString() == "Partial")
            {
                if (txtcustname.Text.ToString() == string.Empty || txtcontact.Text.ToString() == string.Empty)
                {
                    MessageBox.Show("Please Provide The Customar Information !!");
                    txtcustname.Focus();
                    flag = false;
                }
            }
        }


        private void fieldblank()
        {
            cmb_product_name.Text = "";
            txtqty.Text = "";
            txtprice.Text = "";
            txtdate.Text = "";
            txtpaid.Text = "0";
            txtdue.Text = "0";
            txtcustname.Text = "";
            txtcontact.Text = "";
            lblqty.Text = "0";
            txtgrp.Text = "";
            lblcompany.Text = "None";
        }

        private void LoadAll_Tbl_sell_Data()
        {
            dgsell.Rows.Clear();
            IQueryable<tbl_sell> sell = cls_sell.getselldata();
            if (sell != null)
            {
                foreach (tbl_sell item in sell)
                {
                    dgsell.Rows.Add(item.tbl_product.product_name.ToString(), item.quantity.ToString(), item.price.ToString(), item.payment_mode.ToString(), item.date.ToString(), item.paid_amount.ToString(), item.due_amount.ToString(), item.customer_name.ToString(), item.contact_no.ToString(),item.product_sn.ToString(),item.sell_id.ToString());
                }                
            }
            else
                MessageBox.Show("No SellPost Exist !!");
        }


        private void pricecalculation()
        {
            try
            {
                using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
                {
                    IQueryable<tbl_product> product = cls_sell.allproduct();
                    foreach (tbl_product item in product)
                    {
                        if (cmb_product_name.Text == item.product_name)
                        {
                            float temp = float.Parse(txtqty.Text.Trim()) * (float.Parse(item.price_per_box.ToString()) / float.Parse(item.quantity_per_box.ToString()));
                            if (txt_dcnt.Text == "")
                            {
                                txtprice.Text = (temp - ((0 / 100) * temp)).ToString();
                            }
                            else 
                            {
                                txtprice.Text = (temp - ((float.Parse(txt_dcnt.Text.Trim()) / 100) * temp)).ToString();
                            }
                            if (cmbpayment.Text.Trim() == string.Empty)
                            {
                                cmbpayment.SelectedIndex = 0;
                            }
                            txtdate.Text = System.DateTime.Now.Date.ToString();
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("No Product Listed in Product database!!");
            }
         }

        private void AddToDatagrid()
        {
            string[] row = new string[] { cmb_product_name.Text.Trim(), txtqty.Text.Trim(), txtprice.Text.Trim(), cmbpayment.Text.Trim(), txtdate.Text.Trim(), txtpaid.Text.Trim(), txtdue.Text.Trim(), txtcustname.Text.Trim(), txtcontact.Text.Trim(), ProductId.ToString() };
            dgsell.Rows.Add(row);
            fieldblank();
        }

        private void LoadProductInfo()
        {
            try
            {
                using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
                {
                    IQueryable<tbl_product> drug = cls_sell.allproduct();
                    foreach (tbl_product item in drug)
                    {
                        if (cmb_product_name.Text == item.product_name)
                        {
                            ProductId = int.Parse( item.product_sn.ToString());
                            lblqty.Text = item.quantity_per_box.ToString();
                            txtgrp.Text = item.product_group.ToString();
                            lblcompany.Text = item.company_name.ToString();
                        }

                    }
                }

                if (txtqty.Text != string.Empty)
                {
                    pricecalculation();
                }
            }
            catch
            {
                MessageBox.Show("No Product Listed in Product database!!");
            }
        }
        

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void Frmsell_Load(object sender, EventArgs e)
        {
            
            LoadProductNameOnCombobox();
            cmb_select_operation.SelectedIndex = 0;
            txtprice.Enabled = false;
        }

        private void cmbpayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbpayment.Text == "Partial")
            {
                gbdue.Visible = true;
                txtdue.Enabled = true;
                txtpaid.Enabled = true;
                //btenter.Location = new Point(141,312);
                //btdelete.Location = new Point(229,312);
            }
            else if (cmbpayment.Text=="Due")
            {
                gbdue.Visible = true;
                txtdue.Enabled = false;
                txtpaid.Enabled = false;
                //btenter.Location = new Point(141,312);
                //btdelete.Location = new Point(229,312);
            }
            else if (cmbpayment.Text == "Paid")
            {
                gbdue.Visible = false;
                //btenter.Location = new Point(148,196);
                //btdelete.Location = new Point(237,196);
            }

        }

        private void LoadProductNameOnCombobox()
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {

                var qry = from p in db.tbl_products
                          select p;

                foreach (tbl_product pname in qry)
                {
                    cmb_product_name.Items.Add(pname.product_name);
                }

            }
        }

        private void cmb_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                if (dgsell.Rows.Count > 1)
                {
                    dgsell.ClearSelection();
                   
                    for (int i = 0; i < dgsell.Rows.Count - 1; i++)
                    {
                        if (cmb_product_name.Text == dgsell.Rows[i].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Item Already Existed In Datagrid. Please Update It Rather Than New Entry !!");
                            dgsell.Rows[i].Selected = true;
                            dgsell.FirstDisplayedScrollingRowIndex = i;
                            cmb_product_name.Text = "";

                        }
                        else
                        {
                            LoadProductInfo();
                        }
                       
                    }
                }
                else
                {
                    LoadProductInfo();
                }

            }
            if (cmb_select_operation.Text == "Update Posted Sell")
                LoadProductInfo();
            
            if (cmb_product_name.Text != "")
            {
                tbl_current_drug productexiist = cls_order.getsinglerecord(ProductId);
                if (productexiist == null)   //if this product does not exist in current product and order type is sell.
                {
                    MessageBox.Show("Sorry !! Selected Item For Sale Is Not In Stock.");
                    cmb_product_name.SelectedIndex = -1;
                    cmb_product_name.Focus();
                }
                else
                    txtqty.Focus();
            }
        }

        private void txtqty_Leave(object sender, EventArgs e)
        {
            //pricecalculation();
            if (txtqty.Text != string.Empty)
            {
                tbl_current_drug singlrecord = cls_order.getsinglerecord(ProductId);
                if (singlrecord != null)
                {
                    float presentqty = float.Parse(singlrecord.quantity.ToString());
                    float givenqty = float.Parse(txtqty.Text.Trim());
                    if (presentqty >= givenqty)
                    {
                        pricecalculation();
                    }
                    else
                    {
                        if (presentqty <= 0)
                        {
                            MessageBox.Show("Stock empty. Please Order Now!! ");
                            fieldblank();
                            cmb_product_name.Focus();
                        }
                        else if (presentqty < givenqty)
                        {
                            MessageBox.Show("Sell not possible. Sell Quantity is Bigger Than Existing !!");
                            txtqty.Focus();
                        }

                    }
                }
                else
                {
                    pricecalculation();
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btenter_Click(object sender, EventArgs e)
        {
            if (btenter.Text == "Enter")
            {
                fieldchk();
                if (flag)
                {
                    AddToDatagrid();
                }
                flag = true;
            }
            else if (btenter.Text == "Update" && cmb_select_operation.Text == "Update Posted Sell")
            {
                try
                {
                    tbl_sell obj = new tbl_sell();
                    obj.sell_id = sellid;
                    obj.product_sn = ProductId;
                    obj.quantity = float.Parse(txtqty.Text.ToString());
                    obj.price = float.Parse(txtprice.Text.ToString());
                    obj.payment_mode = cmbpayment.Text.ToString();
                    obj.date = DateTime.Parse(txtdate.Text.ToString());
                    obj.paid_amount = float.Parse(txtpaid.Text.ToString());
                    obj.due_amount = float.Parse(txtdue.Text.ToString());
                    obj.customer_name = txtcustname.Text.ToString();
                    obj.contact_no = int.Parse(txtcontact.Text.ToString());
                    
                    float existingquantity;
                    tbl_sell singlrecord = cls_sell.get_singlerecord_sell(sellid);
                    tbl_current_drug currentdrugsinglerecord = cls_order.getsinglerecord(int.Parse(singlrecord.product_sn.ToString()));

                    //MessageBox.Show(productid.ToString());
                    if (singlrecord != null && currentdrugsinglerecord != null)
                    {
                        int chkupdate = 0;
                        existingquantity = float.Parse(currentdrugsinglerecord.quantity.ToString());
                        tbl_current_drug cdrug = new tbl_current_drug();
                        cdrug.product_sn = int.Parse(singlrecord.product_sn.ToString());
                        if (singlrecord.quantity <= float.Parse(txtqty.Text.Trim()))
                        {
                            cdrug.quantity = float.Parse((existingquantity - (float.Parse(txtqty.Text.Trim()) - float.Parse(singlrecord.quantity.ToString()))).ToString());
                        }
                        else if (singlrecord.quantity >= float.Parse(txtqty.Text.Trim()))
                        {
                            cdrug.quantity = float.Parse((existingquantity + (float.Parse(singlrecord.quantity.ToString()) - float.Parse(txtqty.Text.Trim()))).ToString());
                        }
                        chkupdate = cls_order.Update_tbl_Currentdrug(cdrug);
                        int chk = cls_sell.Update_tbl_Sell(obj);
                        if (chk>0 && chkupdate > 0)
                        {
                            MessageBox.Show("Succesfully updated both in sale and Currentdrug!!");
                            LoadAll_Tbl_sell_Data();
                            fieldblank();
                            btenter.Text = "Enter";
                            cmb_product_name.Enabled = true;
                            btsave.Enabled = true;
                        }
                        else
                            MessageBox.Show("Update Failed !!");
                    }
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show("No Existance of This product found." +""+ ex.Message);
                }
            
            }
            else
            {
                fieldchk();
                if (flag)
                {
                    AddToDatagrid();
                    dgsell.Rows.RemoveAt(IndexNo);
                    cmb_product_name.Enabled = true;
                    dgsell.Rows[IndexNo].Selected = true;
                    dgsell.FirstDisplayedScrollingRowIndex = IndexNo;
                    btenter.Text = "Enter";
                    btsave.Enabled = true;
                }
                flag = true;
               
            }
        }

        private void txtpaid_Leave(object sender, EventArgs e)
        {
            txtdue.Text = (float.Parse(txtprice.Text.Trim().ToString()) - float.Parse( txtpaid.Text.Trim().ToString())).ToString();
        }

        private void dgsell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                flag = false;
                btsave.Enabled = false;
                
                if (cmb_select_operation.Text == "Update Posted Sell")
                {
                    sellid = int.Parse(dgsell.SelectedRows[0].Cells[10].Value.ToString());
                }
                
                IndexNo = dgsell.SelectedRows[0].Index;                 
                cmb_product_name.Text = dgsell.Rows[IndexNo].Cells[0].Value.ToString();
                txtqty.Text = dgsell.Rows[IndexNo].Cells[1].Value.ToString();
                txtprice.Text = dgsell.Rows[IndexNo].Cells[2].Value.ToString();
                cmbpayment.Text = dgsell.Rows[IndexNo].Cells[3].Value.ToString();
                txtdate.Text = dgsell.Rows[IndexNo].Cells[4].Value.ToString();
                txtpaid.Text = dgsell.Rows[IndexNo].Cells[5].Value.ToString();
                txtdue.Text = dgsell.Rows[IndexNo].Cells[6].Value.ToString();
                txtcustname.Text = dgsell.Rows[IndexNo].Cells[7].Value.ToString();
                txtcontact.Text = dgsell.Rows[IndexNo].Cells[8].Value.ToString();

                flag = true;
                btenter.Text = "Update";
                cmb_product_name.Enabled = false;
                
            }
            catch (NullReferenceException)
            {

            }
        }

       
       
        private void btsave_Click(object sender, EventArgs e)
        {
            if (dgsell.Rows.Count > 1)
            {
                try
                {

                    int chk = 0;
                    for (int i = 0; i < dgsell.Rows.Count - 1; i++)
                    {
                        tbl_sell sellitem = new tbl_sell();
                        sellitem.product_sn = int.Parse(dgsell.Rows[i].Cells[9].Value.ToString());
                        sellitem.quantity = float.Parse(dgsell.Rows[i].Cells[1].Value.ToString());
                        sellitem.price = float.Parse(dgsell.Rows[i].Cells[2].Value.ToString());
                        sellitem.payment_mode = dgsell.Rows[i].Cells[3].Value.ToString();
                        sellitem.due_amount = float.Parse(dgsell.Rows[i].Cells[6].Value.ToString());
                        sellitem.paid_amount = float.Parse(dgsell.Rows[i].Cells[5].Value.ToString());
                        sellitem.date = Convert.ToDateTime(dgsell.Rows[i].Cells[4].Value);
                        sellitem.customer_name = dgsell.Rows[i].Cells[7].Value.ToString();
                        sellitem.contact_no = (dgsell.Rows[i].Cells[8].Value.ToString() != string.Empty) ? int.Parse(dgsell.Rows[i].Cells[8].Value.ToString()) : 0;
                        chk = cls_sell.InsertOnSell(sellitem);
                        if (chk == 0)
                            break;

                        float existingquantity;
                        tbl_current_drug currentdrugsinglerecord = cls_order.getsinglerecord(int.Parse(dgsell.Rows[i].Cells[9].Value.ToString()));
                        existingquantity = float.Parse(currentdrugsinglerecord.quantity.ToString());
                        tbl_current_drug cdrug = new tbl_current_drug();
                        cdrug.product_sn = int.Parse(currentdrugsinglerecord.product_sn.ToString());
                        cdrug.quantity = existingquantity - float.Parse(dgsell.Rows[i].Cells[1].Value.ToString());

                        chk = cls_order.Update_tbl_Currentdrug(cdrug);
                        if (chk == 0)
                            break;

                    }
                    if (chk > 0)
                    {
                        MessageBox.Show("Product Successfully Selled And Updated in Current Drug!!");
                        dgsell.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Product Does not selled !!");
                    }
                }
                catch { MessageBox.Show("Parse Error!! Please check your input."); }

            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (cmb_product_name.Text != string.Empty)
            {
                if (cmb_select_operation.Text != "Update Posted Sell")
                {
                    dgsell.Rows.RemoveAt(IndexNo);
                    fieldblank();
                    cmb_product_name.Enabled = true;
                    btenter.Text = "Enter";
                }
                else
                {
                    if (MessageBox.Show("Are u sure, u want to delete this item", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int chk = cls_sell.Delete_from_sell(sellid);
                        if (chk > 0)
                        {
                            MessageBox.Show("Delete Successful !!");
                            LoadAll_Tbl_sell_Data();
                        }
                        else
                            MessageBox.Show("Delete Failed !!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing To Delete !!");
            }
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            fieldblank();
            cmb_product_name.Enabled = true;
            btenter.Text = "Enter";
            btsave.Enabled = true;
        }

        private void btadmin_Click(object sender, EventArgs e)
        {
            Frmadmin obj = new Frmadmin();
            obj.Show();
            this.Close();
        }

        private void cmb_select_operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_select_operation.Text.Trim())
            {
                case "Post New Sell":
                    gbdue.Visible = false;
                    //btenter.Location = new Point(148, 196);
                    //btdelete.Location = new Point(237, 196);
                    btenter.Text = "Enter";
                    cmb_product_name.Enabled = true;
                    fieldblank();
                    dgsell.Rows.Clear();
                    break;
                
                case "Update Posted Sell":
                    btenter.Text = "Update";
                    dgsell.Rows.Clear();
                    LoadAll_Tbl_sell_Data();
                    break;
            }
        }

        private void bt_dlt_sell_Click(object sender, EventArgs e)
        {
            switch (cmb_select_operation.Text.Trim())
            {
                case "Update Posted Sell":
                    if (dgsell.SelectedRows.Count >= 1)
                    {
                        if (MessageBox.Show("Are You Sure, You Want To Delete This Item", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int chk = 0;
                            int count = dgsell.SelectedRows.Count - 1;
                            for (int i = 0; i <= count; i++)
                            {
                                int rowindex = dgsell.SelectedRows[0].Index;
                                sellid = int.Parse(dgsell.Rows[rowindex].Cells[10].Value.ToString());
                                chk = cls_sell.Delete_from_sell(sellid);
                                if (chk != 0)
                                {
                                    dgsell.Rows.RemoveAt(rowindex);
                                }
                                else
                                {
                                    MessageBox.Show("Item Couldn't Delete From Sell , Something is Wrong !!");
                                    break;
                                }
                            }

                            if (chk > 0)
                            {
                                MessageBox.Show("Successfully Deleted " + count + " Items From Sell Table.");
                                LoadAll_Tbl_sell_Data();
                            }
                            else
                                MessageBox.Show("Delete operation Failed !!");
                        }
                    }
                    else
                        MessageBox.Show("No Rows selected !!");
                    break;

                case "Post New Sell":
                    if (dgsell.SelectedRows.Count >= 1)
                    {
                        int count = dgsell.SelectedRows.Count - 1;
                        try
                        {
                            for (int i = 0; i <= count; i++)
                            {
                                dgsell.Rows.RemoveAt(dgsell.SelectedRows[0].Index);
                            }
                        }
                        catch { MessageBox.Show("Please Make Sure You Are Not Trying To Delete Blank Rows !!"); }
                    }
                    else
                        MessageBox.Show("No Rows selected !!");
                    break;

            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Frmsell_FormClosing(object sender, FormClosingEventArgs e)
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

        private void gbdetail_Enter(object sender, EventArgs e)
        {

        }

        private void txt_dcnt_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_dcnt.Text.Trim(), "discount"))
            {
                txt_dcnt.Text = str.ToString();
                txt_dcnt.Focus();
                if (txtqty.Text != "")
                {
                    pricecalculation();
                }
                str = null;
            }
            if (txtqty.Text != "")
            {
                pricecalculation();
            }
        }

        string str = null;
        private bool checkfield(string pstr,string x)
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
                    switch (x)
                    {
                        case "qty":
                            MessageBox.Show("Invalid Quantity Input !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;

                        case "discount":
                            MessageBox.Show("Invalid Discount Input !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;
                    }
                }
            }
            return temp;

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txtqty.Text.Trim(), "qty"))
            {
                txtqty.Text = str.ToString();
                txtqty.Focus();
                str = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
