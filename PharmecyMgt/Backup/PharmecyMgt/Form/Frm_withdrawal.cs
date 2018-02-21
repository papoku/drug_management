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
    public partial class Frm_withdrawal : Form
    {
        public Frm_withdrawal()
        {
            InitializeComponent();
        }

        int serial = 0;
        private string str = null;

        private void fieldblank()
        {
            txt_name.Text = "";
            txt_amount.Text = "";
            cmb_reason.SelectedIndex = -1;
            txt_description.Text = "";
        }

        private void LoadwithdrawalData()
        {
            List<tbl_withdrawl> AllwithdrawalData = cls_withdraw.GetAllWithdrawalData();

            if (AllwithdrawalData != null)
            {
                dg_withdrawwal.DataSource = AllwithdrawalData;
                //dg_withdrawwal.Columns[0].Visible = false;
            }
        }

        private void Frm_withdrawal_Load(object sender, EventArgs e)
        {
            LoadwithdrawalData();
        }

        private tbl_withdrawl objectcreation(tbl_withdrawl obj)
        {
            try
            {
                obj.withdrawer_name = txt_name.Text.Trim();
                obj.amount = float.Parse(txt_amount.Text.Trim());
                obj.withdraw_type = cmb_reason.Text.Trim();
                obj.description = txt_description.Text.Trim();
                obj.date = DateTime.Parse(dtp_withdraw.Value.Date.ToString());
            }
            catch { MessageBox.Show("Parse Error!!"); }
            return obj;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            int chk = 0;
            if (bt_save.Text == "Save")
            {
                tbl_withdrawl obj = new tbl_withdrawl();                
                chk = cls_withdraw.InsertOnWithdraw(objectcreation(obj));

                if (chk > 0)
                {
                    MessageBox.Show("Information Saved !!");
                    LoadwithdrawalData();
                    fieldblank();
                }
                else
                    MessageBox.Show("Insertion failed !!");
            }
            else 
            {
                tbl_withdrawl obj = new tbl_withdrawl();                
                chk = cls_withdraw.Update_tbl_withdraw(objectcreation(obj),serial);
                if (chk > 0)
                {
                    MessageBox.Show("Data Updated !!");
                    bt_save.Text = "Save";
                    LoadwithdrawalData();
                    fieldblank();
                    serial = 0;
                }
            }
        }


        private void cmb_reason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_reason.Text == "Salary")
                txt_description.Enabled = false;
            else
                txt_description.Enabled = true;
        }

        private void dg_withdrawwal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                serial = int.Parse(dg_withdrawwal.SelectedRows[0].Cells[0].Value.ToString());
                bt_save.Text = "Update";
                IQueryable<tbl_withdrawl> info = cls_withdraw.GetsingleWithdrawalData(serial);

                if (info != null)
                {
                    foreach (tbl_withdrawl item in info)
                    {
                        txt_name.Text = item.withdrawer_name.ToString();
                        txt_amount.Text = item.amount.ToString();
                        cmb_reason.Text = item.withdraw_type.ToString();
                        txt_description.Text = item.description.ToString();
                        dtp_withdraw.Value = DateTime.Parse(item.date.ToString());
                    }
                }
            }
            catch { MessageBox.Show("Parse Error!!"); }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int chk = 0;
            chk = cls_withdraw.Delete_from_withdrawal(serial);
            if (chk > 0)
            {
                MessageBox.Show("Deleted !!");
                LoadwithdrawalData();
                fieldblank();
                serial = 0;
            }
            else
            {
                MessageBox.Show("No Match found !!");
            }
        }

        private bool checkfield(string pstr)
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
                    MessageBox.Show("Invalid Price Input !!");
                    temp = false;
                }
            }
            return temp;

        }
        
        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_amount.Text.Trim()))
            {
                txt_amount.Text = str.ToString();
                txt_amount.Focus();
            }
        }

        private void Frm_withdrawal_FormClosing(object sender, FormClosingEventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
