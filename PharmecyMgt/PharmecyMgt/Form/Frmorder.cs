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
    public partial class Frmorder : Form
    {
        int productid;
        int AutoOrderId = 0;
        int IndexNo = 0;

        private string str = null;

        public Frmorder()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void UniqueOrderId()
        {
            int? uid = cls_order.getuniqueorderid();
            if (uid != 0)
            {
                txt_uniq_order_id.Text = (++uid).ToString();
            }
            else
                txt_uniq_order_id.Text = (100).ToString();
        }

        private void AddDataToDatagrid()
        {
            //if( tabControl1.SelectedTab.na==)
            string[] row1 = new string[] {string.Empty, productid.ToString(), cmb_order_pdct_name.Text.Trim(), cmb_order_type.Text.Trim(), txt_order_quantity.Text.Trim(), txt_bonus_product.Text.Trim(), cmbpayment.Text.Trim(), txt_price.Text.Trim(), txtpaid.Text.Trim(), txtdue.Text.Trim(), txtorderedperson.Text.Trim(), txtcontact.Text.Trim(), cmborderstatus.Text.Trim(), dtp_order_post.Value.ToString(),txt_uniq_order_id.Text.ToString() };
            dg_order.Rows.Add(row1);
            fieldblank_order();
            cmbpayment.SelectedIndex = 0;
            cmborderstatus.SelectedIndex = 0;
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
                        if (cmb_order_pdct_name.Text == item.product_name)
                        {
                            txt_price.Text = (float.Parse(txt_order_quantity.Text.Trim()) * (float.Parse(item.price_per_box.ToString()) / float.Parse(item.quantity_per_box.ToString()))).ToString();
                        }
                            
                    }
                }
            }
            catch
            {
                MessageBox.Show("No Product Listed in Product database or Parse Error!!");
            }
        }

        private void fieldblank_order()
        {
            cmb_order_pdct_name.Text = "";
            cmb_order_type.Text = "";
            txt_order_quantity.Text = "";
            txt_price.Text = "";
            txt_bonus_product.Text = "";
            txt_price.Text = "";
            txtpaid.Text = "0";
            txtdue.Text = "0";
            txtorderedperson.Text = "";
            txtcontact.Text = "";
            dtp_order_post.Value = System.DateTime.Today;
        }

        private void LoadAllOrderData()
        {
            dg_order.Rows.Clear();
            IQueryable<tbl_order> orders = cls_order.getorderdata();
            if (orders != null)
            {
                foreach (tbl_order item in orders)
                {
                    dg_order.Rows.Add(item.order_id.ToString(),item.product_sn.ToString(), item.tbl_product.product_name.ToString(), item.order_type.ToString(), item.quantity.ToString(), item.bonus_product.ToString(), item.payment_type.ToString(), item.price.ToString(), item.paid_amount.ToString(), item.due_amount.ToString(), item.ordered_to.ToString(), item.contact_no.ToString(), item.order_status.ToString(), item.date_time.ToString(),item.unq_orderid.ToString());
                }
            }
            else
                MessageBox.Show("No Order found !!");
        }



        private void LoadSearchedOrderData()
        {
            IQueryable<tbl_order> data = cls_order.GetSearchedOrderData(dtp_order.Value);            
           
            if (data != null)
            {
                foreach (tbl_order item in data)
                {
                    dg_order_searchlist.Rows.Add(1 ,item.unq_orderid.ToString(), item.order_id.ToString(), item.product_sn.ToString(),item.tbl_product.product_name.ToString(),item.order_type.ToString(),item.quantity.ToString(),item.bonus_product.ToString(),item.payment_type.ToString(),item.price.ToString(),item.paid_amount.ToString(),item.due_amount.ToString(),item.ordered_to.ToString(),item.contact_no.ToString(),item.order_status.ToString(),item.date_time.ToString());
                }
            }
            else
                MessageBox.Show("No Matching Found !!");
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
                        cmb_order_pdct_name.Items.Add(pname.product_name);
                    }
                }
                catch { MessageBox.Show("Product List Empty !!"); }
            }
        }


        private void bt_enter_Click(object sender, EventArgs e)
        {
            try
            {

                if (bt_enter.Text != "Update")
                {
                    if (cmb_order_pdct_name.Text == string.Empty && cmb_order_type.Text == string.Empty && txt_order_quantity.Text == string.Empty)
                    {
                        MessageBox.Show("One Or More Field Empty. Please Fiil up !!");
                    }
                    else if (cmbpayment.Text == "Partial" && txtpaid.Text == string.Empty)
                    {
                        MessageBox.Show("Paid Amount Cannot be Empty !!");
                        txtpaid.Focus();
                    }
                    else if (cmbpayment.Text == "Due" && txtorderedperson.Text == string.Empty || txtorderedperson.Text == string.Empty)
                    {
                        MessageBox.Show("Please FillUp The Name Of Company or Person, Ordered By !!");
                        txtorderedperson.Focus();
                    }
                    else
                    {
                        AddDataToDatagrid();
                        cmborderstatus.Enabled = true;
                        lbl_ordered_by.Text = "Ordered To:";
                        cmborderstatus.Items.Clear();
                        string[] itms = new string[] { "Received", "Not Received" };
                        cmborderstatus.Items.AddRange(itms);
                        cmborderstatus.SelectedIndex = 0;
                    }
                }

                else if (bt_enter.Text == "Update" && cmb_select_operation.Text == "Post New Order")
                {
                    AddDataToDatagrid();
                    dg_order.Rows.RemoveAt(IndexNo);
                    dg_order.Rows[IndexNo].Selected = true;
                    dg_order.FirstDisplayedScrollingRowIndex = IndexNo;
                    bt_enter.Text = "Enter";
                    UniqueOrderId();
                    bt_delete.Enabled = true;
                    bt_save.Enabled = true;

                }
                else
                {

                    tbl_order order = new tbl_order();

                    order.order_id = AutoOrderId;
                    order.product_sn = productid;
                    order.order_type = cmb_order_type.Text.ToString();
                    order.quantity = float.Parse(txt_order_quantity.Text.ToString());
                    order.bonus_product = float.Parse(txt_bonus_product.Text.ToString());
                    order.payment_type = cmbpayment.Text.ToString();
                    order.price = float.Parse(txt_price.Text.ToString());
                    order.paid_amount = float.Parse(txtpaid.Text.ToString());
                    order.due_amount = float.Parse(txtdue.Text.ToString());
                    order.ordered_to = txtorderedperson.Text.ToString();
                    order.contact_no = int.Parse(txtcontact.Text.ToString());
                    order.order_status = cmborderstatus.Text.ToString();
                    order.date_time = DateTime.Parse(dtp_order_post.Value.ToString());
                    order.unq_orderid = int.Parse(txt_uniq_order_id.Text.ToString());


                    float existingquantity;
                    tbl_current_drug currentdrugsinglerecord = cls_order.getsinglerecord(productid);
                    tbl_order singlrecord = cls_order.get_singlerecord_order(AutoOrderId);
                    //MessageBox.Show(productid.ToString());
                    if (singlrecord != null && currentdrugsinglerecord != null)
                    {
                        int chkupdate = 0;
                        if (singlrecord.order_type.ToString() == "Buy" && singlrecord.order_type.ToString() == cmb_order_type.Text.ToString() && cmborderstatus.Text == "Received")
                        {
                            existingquantity = float.Parse(currentdrugsinglerecord.quantity.ToString());
                            tbl_current_drug obj = new tbl_current_drug();
                            obj.product_sn = productid;
                            if (singlrecord.quantity <= float.Parse(txt_order_quantity.Text.Trim()))
                            {
                                obj.quantity = float.Parse((existingquantity + (float.Parse(txt_order_quantity.Text.Trim()) - float.Parse(singlrecord.quantity.ToString()))).ToString());
                            }
                            else if (singlrecord.quantity >= float.Parse(txt_order_quantity.Text.Trim()))
                            {
                                obj.quantity = float.Parse((existingquantity - (float.Parse(singlrecord.quantity.ToString()) - float.Parse(txt_order_quantity.Text.Trim()))).ToString());
                            }
                            chkupdate = cls_order.Update_tbl_Currentdrug(obj);

                        }
                        else if (singlrecord.order_type.ToString() == "Buy" && singlrecord.order_type.ToString() != cmb_order_type.Text.ToString())
                        {
                            existingquantity = float.Parse(currentdrugsinglerecord.quantity.ToString());
                            tbl_current_drug obj = new tbl_current_drug();
                            obj.product_sn = productid;
                            obj.quantity = float.Parse((existingquantity - float.Parse(txt_order_quantity.Text.Trim())).ToString());
                            chkupdate = cls_order.Update_tbl_Currentdrug(obj);


                        }
                        else if (singlrecord.order_type.ToString() == "Sell" && singlrecord.order_type.ToString() != cmb_order_type.Text.ToString() && cmborderstatus.Text == "Received")
                        {
                            existingquantity = float.Parse(currentdrugsinglerecord.quantity.ToString());
                            tbl_current_drug obj = new tbl_current_drug();
                            obj.product_sn = productid;
                            obj.quantity = float.Parse((existingquantity + float.Parse(txt_order_quantity.Text.Trim())).ToString());
                            chkupdate = cls_order.Update_tbl_Currentdrug(obj);

                        }
                        else if (singlrecord.order_type.ToString() == "Sell" && singlrecord.order_type.ToString() == cmb_order_type.Text.ToString())
                        {
                            existingquantity = float.Parse(currentdrugsinglerecord.quantity.ToString());
                            tbl_current_drug obj = new tbl_current_drug();
                            obj.product_sn = productid;
                            if (singlrecord.quantity <= float.Parse(txt_order_quantity.Text.Trim()))
                            {
                                obj.quantity = float.Parse((existingquantity - (float.Parse(txt_order_quantity.Text.Trim()) - float.Parse(singlrecord.quantity.ToString()))).ToString());
                            }
                            else if (singlrecord.quantity >= float.Parse(txt_order_quantity.Text.Trim()))
                            {
                                obj.quantity = float.Parse((existingquantity + (float.Parse(singlrecord.quantity.ToString()) - float.Parse(txt_order_quantity.Text.Trim()))).ToString());
                            }
                            chkupdate = cls_order.Update_tbl_Currentdrug(obj);

                        }

                        int chk = cls_order.Update_tbl_Order(order);

                        if (chk > 0 && chkupdate > 0)
                        {
                            MessageBox.Show("Update Succesful in Current Product and order Table !!");
                        }
                        else
                            MessageBox.Show("Update failed !!");
                    }

                    dtp_order_post.Value = System.DateTime.Today;
                    bt_enter.Text = "Enter";
                    LoadAllOrderData();
                    fieldblank_order();
                    dg_order.ClearSelection();
                    txt_uniq_order_id.Text = "";
                    bt_delete.Enabled = true;
                    for (int j = 0; j < dg_order.Rows.Count - 1; j++)
                    {
                        if (int.Parse(dg_order.Rows[j].Cells[0].Value.ToString()) == AutoOrderId)
                        {
                            dg_order.Rows[j].Selected = true;
                            dg_order.FirstDisplayedScrollingRowIndex = j;
                            break;
                        }
                    }

                }
            }
            catch { MessageBox.Show("An Unknown Error Occured !!"); }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (dg_order.Rows.Count > 1)
            {
                int chkorder;
                int chkcurrentdrug;
                int chkupdate;

                try
                {

                    for (int i = 0; i < dg_order.Rows.Count - 1; i++)
                    {
                        chkorder = 0;
                        chkcurrentdrug = 0;
                        chkupdate = 0;

                        tbl_order orderitem = new tbl_order();
                        int prid = int.Parse(dg_order.Rows[i].Cells[1].Value.ToString());
                        orderitem.product_sn = prid;
                        string ordertype = dg_order.Rows[i].Cells[3].Value.ToString();
                        orderitem.order_type = ordertype;
                        float quantity = float.Parse(dg_order.Rows[i].Cells[4].Value.ToString());
                        orderitem.quantity = quantity;
                        orderitem.bonus_product = float.Parse(((dg_order.Rows[i].Cells[5].Value.ToString() != string.Empty) ? int.Parse(dg_order.Rows[i].Cells[5].Value.ToString()) : 0).ToString());
                        orderitem.payment_type = dg_order.Rows[i].Cells[6].Value.ToString();
                        orderitem.price = float.Parse(dg_order.Rows[i].Cells[7].Value.ToString());
                        orderitem.paid_amount = float.Parse(dg_order.Rows[i].Cells[8].Value.ToString());
                        orderitem.due_amount = float.Parse(dg_order.Rows[i].Cells[9].Value.ToString());
                        orderitem.ordered_to = dg_order.Rows[i].Cells[10].Value.ToString();
                        orderitem.contact_no = (dg_order.Rows[i].Cells[11].Value.ToString() != string.Empty) ? int.Parse(dg_order.Rows[i].Cells[11].Value.ToString()) : 0;
                        string status = dg_order.Rows[i].Cells[12].Value.ToString();
                        orderitem.order_status = status;
                        orderitem.date_time = DateTime.Parse(dg_order.Rows[i].Cells[13].Value.ToString());
                        orderitem.unq_orderid = int.Parse(txt_uniq_order_id.Text.ToString());
                        chkorder = cls_order.InsertOnOrder(orderitem);
                        if (chkorder == 0)
                            break;

                        float existingquantity;
                        tbl_current_drug singlrecord = cls_order.getsinglerecord(prid);


                        if (singlrecord != null && ordertype == "Buy" && status == "Received")
                        {
                            existingquantity = float.Parse(singlrecord.quantity.ToString());
                            tbl_current_drug obj = new tbl_current_drug();
                            obj.product_sn = int.Parse(dg_order.Rows[i].Cells[1].Value.ToString());
                            obj.quantity = float.Parse((existingquantity + ((dg_order.Rows[i].Cells[4].Value.ToString() != string.Empty) ? float.Parse(dg_order.Rows[i].Cells[4].Value.ToString()) : 0)).ToString());
                            chkupdate = cls_order.Update_tbl_Currentdrug(obj);
                            if (chkupdate == 0)
                                break;

                        }
                        else if (singlrecord != null && ordertype == "Sell")
                        {
                            existingquantity = float.Parse(singlrecord.quantity.ToString());
                            tbl_current_drug obj = new tbl_current_drug();
                            obj.product_sn = int.Parse(dg_order.Rows[i].Cells[1].Value.ToString());
                            obj.quantity = float.Parse((existingquantity - ((dg_order.Rows[i].Cells[4].Value.ToString() != string.Empty) ? float.Parse(dg_order.Rows[i].Cells[4].Value.ToString()) : 0)).ToString());
                            chkupdate = cls_order.Update_tbl_Currentdrug(obj);
                            if (chkupdate == 0)
                                break;
                        }
                        else                //To insert a new entry, if product is not available in current_drug
                        {
                            if (status == "Received")
                            {
                                tbl_current_drug currentitem = new tbl_current_drug();
                                currentitem.product_sn = int.Parse(dg_order.Rows[i].Cells[1].Value.ToString());
                                currentitem.quantity = (dg_order.Rows[i].Cells[4].Value.ToString() != string.Empty) ? float.Parse(dg_order.Rows[i].Cells[4].Value.ToString()) : 0;
                                chkcurrentdrug = cls_order.InsertOnCurrentDrug(currentitem);
                                if (chkcurrentdrug == 0)
                                    break;
                            }
                        }


                        if (chkorder > 0 && chkcurrentdrug > 0)
                        {
                            MessageBox.Show("Order Successfully Posted and Inserted into current Drug !!");
                            dg_order.Rows.Clear();
                        }
                        else if (chkorder > 0 && chkupdate > 0)
                        {
                            MessageBox.Show("Order Successfully Posted and Data Updated In current Drug !!");
                            dg_order.Rows.Clear();
                        }
                        else if (chkorder > 0)
                        {
                            MessageBox.Show("Only order posting succesful, current drug not updated !!");
                        }
                        else if (chkupdate > 0)
                        {
                            MessageBox.Show("Only current drug Updated !! Order posting failed.");
                        }
                        else if (chkcurrentdrug > 0)
                        {
                            MessageBox.Show("Only current drug Inserted !! Order posting failed.");
                        }
                        else
                        {
                            MessageBox.Show("Order Posting and current drug update both failed !!");
                        }
                    }
                    
                    UniqueOrderId();
                }
                catch { }

            }
            else
                MessageBox.Show("No Rows selected In Datagrid !!");
        }

        private void Frmorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btadmin_Click(object sender, EventArgs e)
        {
            Frmadmin obj = new Frmadmin();
            obj.Show();
            this.Close();
        }


        private void Frmorder_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(dtp_order_post.Value.ToString());
            LoadProductNameOnCombobox();
            cmborderstatus.SelectedIndex = 0;
            cmbpayment.SelectedIndex = 0;
            txtpaid.Enabled = false;
            txtdue.Enabled = false;
            cmb_select_operation.SelectedIndex = 0;
            dg_order_searchlist.Hide();
            gb_search.Hide();
            pnl__command_srchlist.Hide();
            dtp_order_post.Value = System.DateTime.Today;
            dg_order.ClearSelection();
            txt_price.Enabled = false;
            //int uid = cls_order.getuniqueorderid();
            //MessageBox.Show(uid.ToString());
        }



        private void cmb_order_pdct_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_order_quantity.Text != string.Empty)
            { pricecalculation(); }
                      
            
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                IQueryable<tbl_product> drug = cls_sell.allproduct();
                try
                {
                    foreach (tbl_product item in drug)
                    {
                        if (cmb_order_pdct_name.Text == item.product_name)
                            productid = int.Parse(item.product_sn.ToString());
                    }
                }
                catch { }
            }
            cmb_order_type.SelectedIndex = -1;
            cmb_order_type.Focus();
            
        }

        private void txt_order_quantity_Leave(object sender, EventArgs e)
        {
            if (txt_order_quantity.Text != string.Empty)
            {
                tbl_current_drug singlrecord = cls_order.getsinglerecord(productid);
                if (singlrecord != null)
                {
                    float presentqty = float.Parse(singlrecord.quantity.ToString());
                    float givenqty = float.Parse(txt_order_quantity.Text.Trim().ToString());
                    if ((presentqty >= givenqty && cmb_order_type.Text == "Sell") || cmb_order_type.Text == "Buy")
                    {
                        pricecalculation();
                    }
                    else
                    {
                        if (presentqty <= 0)
                        {
                            MessageBox.Show("Stock empty. Please Order Now!! ");
                            fieldblank_order();
                            cmb_order_pdct_name.Focus();
                        }
                        else if (presentqty < givenqty)
                        {
                            MessageBox.Show("Sell not possible. Sell Quantity is Bigger Than Existing !!");
                            txt_order_quantity.Focus();
                        }

                    }
                }
                else
                {
                    pricecalculation();
                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbpayment.Text == "Partial")
            {
                txtpaid.Enabled = true;
            }
            else if (cmbpayment.Text == "Due")
            {
                txtdue.Enabled = false;
                txtpaid.Enabled = false;
                
            }
            else if(cmbpayment.Text=="Paid")
            {
                txtpaid.Enabled = false;
                txtdue.Enabled = false;
            }
          
        }


        private void dg_order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (cmb_select_operation.Text.Trim().ToString() == "Update Posted Order")
            {
                try
                {
                    AutoOrderId = int.Parse(dg_order.SelectedRows[0].Cells[0].Value.ToString());
                    tbl_order singlerecord = cls_order.get_singlerecord_order(AutoOrderId);

                    cmb_order_pdct_name.Text = singlerecord.tbl_product.product_name.ToString();
                    cmb_order_type.Text = singlerecord.order_type.ToString();
                    txt_order_quantity.Text = singlerecord.quantity.ToString();
                    txt_bonus_product.Text = singlerecord.bonus_product.ToString();
                    cmbpayment.Text = singlerecord.payment_type.ToString();
                    txt_price.Text = singlerecord.price.ToString();
                    cmborderstatus.Text = singlerecord.order_status.ToString();
                    txtpaid.Text = singlerecord.paid_amount.ToString();
                    txtdue.Text = singlerecord.due_amount.ToString();
                    txtorderedperson.Text = singlerecord.ordered_to.ToString();
                    txtcontact.Text = singlerecord.contact_no.ToString();
                    dtp_order_post.Value = DateTime.Parse(singlerecord.date_time.ToString());
                    txt_uniq_order_id.Text = singlerecord.unq_orderid.ToString();

                    bt_enter.Text = "Update";
                    bt_delete.Enabled = false;
                    
                }
                catch
                {
                    MessageBox.Show("Parse Error In Datagrid !!");
                }

            }
            else
            {
                try
                {
                    IndexNo = dg_order.SelectedRows[0].Index;
                    cmb_order_pdct_name.Text = dg_order.Rows[IndexNo].Cells[2].Value.ToString();
                    cmb_order_type.Text = dg_order.Rows[IndexNo].Cells[3].Value.ToString();
                    txt_order_quantity.Text = dg_order.Rows[IndexNo].Cells[4].Value.ToString();
                    txt_bonus_product.Text = dg_order.Rows[IndexNo].Cells[5].Value.ToString();
                    cmbpayment.Text = dg_order.Rows[IndexNo].Cells[6].Value.ToString();
                    txt_price.Text = dg_order.Rows[IndexNo].Cells[7].Value.ToString();
                    txtpaid.Text = dg_order.Rows[IndexNo].Cells[8].Value.ToString();
                    txtdue.Text = dg_order.Rows[IndexNo].Cells[9].Value.ToString();
                    txtorderedperson.Text = dg_order.Rows[IndexNo].Cells[10].Value.ToString();
                    txtcontact.Text = dg_order.Rows[IndexNo].Cells[11].Value.ToString();
                    cmborderstatus.Text = dg_order.Rows[IndexNo].Cells[12].Value.ToString();
                    dtp_order_post.Value = DateTime.Parse(dg_order.Rows[IndexNo].Cells[13].Value.ToString());
                    
                    //flag = true;
                    bt_enter.Text = "Update";
                    bt_delete.Enabled = false;
                    bt_save.Enabled = false;
                    //cmb_product_name.Enabled = false;
                }
                catch
                {
                   
                }
            }

        }
      

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            fieldblank_order();
            bt_enter.Text = "Enter";
            bt_delete.Enabled = true;
            if (cmb_select_operation.Text.Trim() != "Update Posted Order")
                bt_save.Enabled = true;
        }


        private void bt_delete_Click(object sender, EventArgs e)
        {
            switch (cmb_select_operation.Text.Trim())
            {
                case "Update Posted Order":
                    if (dg_order.SelectedRows.Count >= 1)
                    {
                        if (MessageBox.Show("Are You Sure, You Want To Delete This Selected Item ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int chk = 0;
                            int count = dg_order.SelectedRows.Count;
                            for (int i = 0; i <= count - 1; i++)
                            {
                                int rowindex = dg_order.SelectedRows[0].Index;
                                AutoOrderId = int.Parse(dg_order.Rows[rowindex].Cells[0].Value.ToString());
                                chk = cls_order.Delete_from_order(AutoOrderId);
                                if (chk != 0)
                                {
                                    dg_order.Rows.RemoveAt(rowindex);
                                    AutoOrderId = 0;
                                }
                                else
                                {
                                    MessageBox.Show("Item Couldn't Delete From Order , Something is Wrong !!");
                                    break;
                                }
                            }

                            if (chk > 0)
                            {
                                MessageBox.Show("Successfully Deleted " + count + " Items From Order Table.");
                                LoadAllOrderData();
                            }
                            else
                                MessageBox.Show("Delete operation Failed !!");
                        }
                        else
                            dg_order.ClearSelection();
                    }
                    else
                        MessageBox.Show("No Rows selected !!");
                    break;

                case "Post New Order":
                    if (dg_order.SelectedRows.Count >= 1)
                    {
                        if (MessageBox.Show("Are You Sure, You Want To Delete This Selected Item ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int count = dg_order.SelectedRows.Count - 1;
                            for (int i = 0; i <= count; i++)
                            {
                                try
                                {
                                    dg_order.Rows.RemoveAt(dg_order.SelectedRows[0].Index);
                                }
                                catch { MessageBox.Show("No Data Exist To Delete!!"); }
                            }
                        }
                        else
                            dg_order.ClearSelection();
                    }
                    else
                        MessageBox.Show("No Rows selected To Delete!!");
                    break;
            }

        }


        private void cmb_order_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_order_type.Text != "")
            {
                tbl_current_drug productexiist = cls_order.getsinglerecord(productid);
                if (productexiist == null && cmb_order_type.Text == "Sell")   //if this product does not exist in current product and order type is sell.
                {
                    MessageBox.Show("Sorry !! Selected Item For Sale Is Not In Stock.");
                    //fieldblank_order();
                    //cmb_order_pdct_name.Focus();
                    cmb_order_type.SelectedIndex = -1;
                    cmb_order_type.Focus();
                }
                else
                    txt_order_quantity.Focus();
            }

            if (dg_order.Rows.Count > 1)
            {
                dg_order.ClearSelection();
                for (int i = 0; i < dg_order.Rows.Count - 1; i++)
                {
                    if (cmb_order_pdct_name.Text == dg_order.Rows[i].Cells[1].Value.ToString() && cmb_order_type.Text == dg_order.Rows[i].Cells[2].Value.ToString())
                    {
                        MessageBox.Show("Item Already Existed In Datagrid. Please Update It Rather Than New Entry !!");
                        dg_order.Rows[i].Selected = true;
                        dg_order.FirstDisplayedScrollingRowIndex = i;
                        cmb_order_pdct_name.Text = "";
                        cmb_order_type.SelectedIndex = -1;
                        cmb_order_type.Focus();
                    }

                }
            }

            if (cmb_order_type.Text == "Sell")
            {
                //cmborderstatus.Enabled = false;
                cmborderstatus.SelectedIndex = -1;
                lbl_ordered_by.Text = "Ordered By:";
                cmborderstatus.Items.Clear();
                string[] itms = new string[] { "Delivered", "NotDelivered" };
                cmborderstatus.Items.AddRange(itms);
                cmborderstatus.Text = "";
                cmborderstatus.SelectedIndex = 0;
            }
            else
            {
                lbl_ordered_by.Text = "Ordered To:";
                cmborderstatus.Items.Clear();
                string[] itms = new string[] { "Received", "Not Received" };
                cmborderstatus.Items.AddRange(itms);
                cmborderstatus.Text = "";
                cmborderstatus.SelectedIndex = 0;
            }
        }


        private void dtp_order_ValueChanged(object sender, EventArgs e)
        {
            dg_order_searchlist.Rows.Clear();
            LoadSearchedOrderData();
        }

       

        private void bt_updt_searchlist_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_order_searchlist.Rows.Count > 1)
                {
                    int chkupdate = 0;
                    int chkcurrentdrug = 0;
                    for (int i = 0; i < dg_order_searchlist.Rows.Count - 1; i++)
                    {
                        if (Convert.ToBoolean(dg_order_searchlist.Rows[i].Cells[0].Value) == true)
                        //if (int.Parse(dg_order_searchlist.Rows[i].Cells[0].Value.ToString()) == 1)
                        {
                            int productid = int.Parse(dg_order_searchlist.Rows[i].Cells[3].Value.ToString());
                            int orderid = int.Parse(dg_order_searchlist.Rows[i].Cells[2].Value.ToString());

                            tbl_order srecord = cls_order.get_singlerecord_order(orderid);
                            string odrtype = dg_order_searchlist.Rows[i].Cells[5].Value.ToString();
                            string sts = dg_order_searchlist.Rows[i].Cells[14].Value.ToString();

                            tbl_order obj = new tbl_order();
                            obj.order_id = orderid;
                            obj.product_sn = int.Parse(srecord.product_sn.ToString());
                            obj.order_type = srecord.order_type.ToString();
                            obj.quantity = float.Parse(srecord.quantity.ToString());
                            obj.bonus_product = float.Parse(srecord.bonus_product.ToString());
                            obj.payment_type = srecord.payment_type.ToString();
                            obj.price = float.Parse(srecord.price.ToString());
                            obj.paid_amount = float.Parse(srecord.paid_amount.ToString());
                            obj.due_amount = float.Parse(srecord.due_amount.ToString());
                            obj.ordered_to = srecord.ordered_to.ToString();
                            obj.contact_no = int.Parse(srecord.contact_no.ToString());
                            obj.date_time = DateTime.Parse(srecord.date_time.ToString());
                            string stts = srecord.order_type.ToString() != "Sell" ? "Received" : "Delivered";
                            obj.order_status = stts;
                            obj.unq_orderid = int.Parse(srecord.unq_orderid.ToString());

                            int chkstatusupdate = cls_order.Update_tbl_Order(obj);
                            if (chkstatusupdate > 0)
                            {
                                srecord = cls_order.get_singlerecord_order(orderid);
                                float existingquantity;

                                tbl_current_drug singlrecord = cls_order.getsinglerecord(productid);
                                if (singlrecord != null && srecord.order_type.ToString() == "Buy" && srecord.order_status.ToString() == "Received")
                                {
                                    existingquantity = float.Parse(singlrecord.quantity.ToString());
                                    tbl_current_drug objt = new tbl_current_drug();
                                    objt.product_sn = int.Parse(dg_order_searchlist.Rows[i].Cells[3].Value.ToString());
                                    objt.quantity = float.Parse((existingquantity + ((dg_order_searchlist.Rows[i].Cells[6].Value.ToString() != string.Empty) ? float.Parse(dg_order_searchlist.Rows[i].Cells[6].Value.ToString()) : 0)).ToString());
                                    chkupdate = cls_order.Update_tbl_Currentdrug(objt);
                                    if (chkupdate == 0)
                                        break;

                                }
                                else if (singlrecord != null && srecord.order_type.ToString() == "Sell" && srecord.order_status.ToString() == "Delivered")
                                {
                                    existingquantity = float.Parse(singlrecord.quantity.ToString());
                                    tbl_current_drug objt = new tbl_current_drug();
                                    objt.product_sn = int.Parse(dg_order_searchlist.Rows[i].Cells[3].Value.ToString());
                                    objt.quantity = float.Parse((existingquantity - ((dg_order_searchlist.Rows[i].Cells[6].Value.ToString() != string.Empty) ? float.Parse(dg_order_searchlist.Rows[i].Cells[6].Value.ToString()) : 0)).ToString());
                                    chkupdate = cls_order.Update_tbl_Currentdrug(objt);
                                    if (chkupdate == 0)
                                        break;
                                }

                                else                //To insert a new entry, if product is not available in current_drug
                                {
                                    if (srecord.order_type.ToString() == "Buy" && srecord.order_status.ToString() == "Received")
                                    {
                                        tbl_current_drug currentitem = new tbl_current_drug();
                                        currentitem.product_sn = int.Parse(dg_order.Rows[i].Cells[3].Value.ToString());
                                        currentitem.quantity = (dg_order_searchlist.Rows[i].Cells[6].Value.ToString() != string.Empty) ? float.Parse(dg_order_searchlist.Rows[i].Cells[6].Value.ToString()) : 0;
                                        chkcurrentdrug = cls_order.InsertOnCurrentDrug(currentitem);
                                        if (chkcurrentdrug == 0)
                                            break;
                                    }
                                }

                            }
                            else
                                MessageBox.Show("Order Status Update Failed !!");
                        }

                    }
                    if (chkupdate > 0)
                    {
                        MessageBox.Show("Product Updated In stock !!");
                    }
                    else if (chkcurrentdrug > 0)
                    {
                        MessageBox.Show("Product Inserted into stock !!");
                    }
                    else
                    {
                        MessageBox.Show("Product Update or insert in stock failed !!");
                    }
                }
                else
                    MessageBox.Show("No Rows Seleected To Update !!");
            }
            catch { MessageBox.Show("An Error Occcured !!"); }
        }

        private void cmb_select_operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_select_operation.Text.Trim())
            {
                case "Update Order Status":
                    bt_enter.Text = "Update";
                    dg_order.Hide();
                    pnl_command_order.Hide();
                    gb_order.Hide();
                    gb_search.Show();
                    gb_search.Location = new Point(37, 110);
                    dg_order_searchlist.Size = new Size(1225, 330);
                    dg_order_searchlist.Location = new Point(20, 280);
                    dg_order_searchlist.Show();
                    pnl__command_srchlist.Size = new Size(1225,40);
                    pnl__command_srchlist.Location = new Point(20, 615);
                    pnl__command_srchlist.Show();
                    break;

                case "Post New Order":
                    bt_enter.Text = "Enter";
                    dg_order.Rows.Clear();
                    dg_order.Show();
                    dg_order.Size = new Size(1265, 310);
                    dg_order.Location = new Point(8, 340);
                    pnl_command_order.Location = new Point(12,660);
                    pnl_command_order.Show();
                    gb_order.Show();
                    gb_search.Hide();
                    dg_order_searchlist.Hide();
                    pnl__command_srchlist.Hide();
                    fieldblank_order();
                    UniqueOrderId();
                    txt_uniq_order_id.Enabled = false;
                    bt_save.Enabled = true;
                    break;

                case "Update Posted Order":
                    LoadAllOrderData();
                    bt_enter.Text = "Update";
                    dg_order.Show();
                    dg_order.Location = new Point(8,310);
                    dg_order.Size = new Size(1265,350);
                    pnl_command_order.Show();
                    gb_order.Show();
                    gb_search.Hide();
                    dg_order_searchlist.Hide();
                    pnl__command_srchlist.Hide();
                    fieldblank_order();
                    bt_save.Enabled = false;
                    txt_uniq_order_id.Text = "";
                    break;


            }
        }

        private void txtpaid_Leave(object sender, EventArgs e)
        {
            try
            {
                txtdue.Text = (float.Parse(txt_price.Text.Trim().ToString()) - float.Parse(txtpaid.Text.Trim().ToString())).ToString();
            }
            catch { MessageBox.Show("Parse Error !!"); }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {

        }

        private void bt_dlt_searchlist_Click(object sender, EventArgs e)
        {

        }

        private void Frmorder_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtpaid_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txtpaid.Text.Trim(),"paid"))
            {
                txtpaid.Text = str.ToString();
                txtpaid.Focus();
            }
        }
       
        private bool checkfield(string pstr,string i)
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
                        case "paid":
                            MessageBox.Show("Invalid Input !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;

                        case "contact":
                            MessageBox.Show("Invalid Contact !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;

                        case "qty":
                            MessageBox.Show("Invalid Quantity !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;

                        case "bonus":
                            MessageBox.Show("Invalid Bonus Input !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;

                    }

                }
            }
            return temp;

        }

        private void txtdue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txtcontact.Text.Trim(), "contact"))
            {
                txtcontact.Text = str.ToString();
                txtcontact.Focus();
            }
        }

        private void txt_order_quantity_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_order_quantity.Text.Trim(), "qty"))
            {
                txt_order_quantity.Text = str.ToString();
                txt_order_quantity.Focus();
            }
        }

        private void txt_bonus_product_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_bonus_product.Text.Trim(), "bonus"))
            {
                txt_bonus_product.Text = str.ToString();
                txt_bonus_product.Focus();
            }
        }

        private void dg_order_searchlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gb_search_Enter(object sender, EventArgs e)
        {

        }

        private void pnl__command_srchlist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gb_order_Enter(object sender, EventArgs e)
        {

        }

        private void cmborderstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
       

    }
}
