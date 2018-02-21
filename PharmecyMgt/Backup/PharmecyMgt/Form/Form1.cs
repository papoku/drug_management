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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_login singlerecord = cls_login.getsinglerecord(txt_id.Text.Trim(), cmb_type.Text.Trim(), txt_pass.Text.Trim());

                if (singlerecord != null)
                {
                    if (cmb_type.Text == "Admin")
                    {
                        Frmadmin obj = new Frmadmin();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmProduct obj = new FrmProduct();
                        obj.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Unauthorized Access !!");
                }
            }
            catch { MessageBox.Show("Unauthorized Access !!"); }
        }


        private void Frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
