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
    public partial class Frmadmin : Form
    {
        public Frmadmin()
        {
            InitializeComponent();
        }

        int autoid = 0;

        private void fieldblank()
        {
            txt_userid.Text = "";
            cmb_type.Text = "";
            txt_pass.Text = "";
            txt_rpass.Text = "";
        }

        private bool checkfield()
        {
            if (txt_userid.Text != string.Empty && cmb_type.Text != string.Empty && txt_pass.Text != string.Empty)
            {
                return true;
            }
            else
                return false;
        }

        private void LoadLoginData()
        {
            List<tbl_login> AllLoginData = cls_admin.GetAllLoginData();

            if (AllLoginData != null)
            {
                dgLogin.DataSource = AllLoginData;
                dgLogin.Columns[0].Visible = false;
            }
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_logoff_Click(object sender, EventArgs e)
        {
            Frmlogin obj = new Frmlogin();
            obj.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmadmin_Load(object sender, EventArgs e)
        {
            LoadLoginData();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (bt_save.Text == "Save")
            {
                if (checkfield())
                {
                    if (txt_pass.Text.Trim() == txt_rpass.Text.Trim())
                    {
                        tbl_login login = new tbl_login();
                        login.User_Id = txt_userid.Text.Trim();
                        login.User_Type = cmb_type.Text.Trim();
                        login.Password = txt_pass.Text.Trim();

                        int check = 0;
                        check = cls_Class.insertdata(login);

                        if (check > 0)
                        {
                            MessageBox.Show("Successfully User Created !!");

                            //make the field blank after data insertion.
                            fieldblank();
                        }
                        else
                        {
                            MessageBox.Show("User Creation Unsuccessfull !!");
                        }

                        LoadLoginData(); //Load all user data again after new insertion.
                    }
                    else
                    {
                        MessageBox.Show("Password do not match !!");
                    }

                }
                else
                {
                    MessageBox.Show("You couldn't let any field empty !!");
                }
            }
            else
            {
                if (txt_pass.Text.Trim() == txt_rpass.Text.Trim())
                {
                    tbl_login entry = new tbl_login();
                    entry.login_sn = autoid;
                    entry.User_Id = txt_userid.Text.Trim();
                    entry.User_Type = cmb_type.Text.Trim();
                    entry.Password = txt_pass.Text.Trim();


                    int chk = 0;
                    chk = cls_Class.Update_tbl_login(entry);
                    if (chk > 0)
                    {
                        MessageBox.Show("Login data successfully updated !!");
                    }
                    else
                    {
                        MessageBox.Show("Login data updated failed !!");
                    }

                    bt_save.Text = "Save";
                    // bt_delete.Enabled = false;

                    LoadLoginData();
                    fieldblank();
                }
                else
                {
                    MessageBox.Show("Password do not match !!");
                }
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            fieldblank();
        }

        
        private void dgLogin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                autoid = int.Parse(dgLogin.SelectedRows[0].Cells[0].Value.ToString());
                tbl_login singlerecord = cls_Class.getsingle_record(autoid);

                txt_userid.Text = singlerecord.User_Id.ToString();
                cmb_type.Text = singlerecord.User_Type.ToString();
                txt_pass.Text = singlerecord.Password.ToString();
                
                bt_save.Text = "Update";
            }
            catch 
            {

            }
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_product_Click(object sender, EventArgs e)
        {
            FrmProduct obj = new FrmProduct();
            obj.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProduct obj = new FrmProduct();
            obj.Show();
            this.Hide();
        }

        private void orderFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmorder obj = new Frmorder();
            obj.Show();
            this.Hide();
        }

        private void productSellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsell obj = new Frmsell();
            obj.Show();
            this.Close();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }

        private void productReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReturn obj = new FrmReturn();
            obj.Show();
            this.Close();

        }

        private void staffManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStaff obj = new FrmStaff();
            obj.Show();
            this.Close();
        }

        private void reportFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport obj = new FrmReport();
            obj.Show();
            this.Close();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWeb obj = new FrmWeb();
            obj.Show();
            this.Close();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmlogin obj = new Frmlogin();
            obj.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cashWithdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_withdrawal obj = new Frm_withdrawal();
            obj.Show();
            this.Close();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
