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
    public partial class FrmStaff : Form
    {
        private int staffid = 0;
        private string str = null;

        public FrmStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void fieldblank()
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_gender.Text = "";
            txt_age.Text = "";
            txt_joindate.Text = "";
            txt_salary.Text = "";
            txt_qualification.Text = "";
        }
        private void ChangeHeader()
        {
            dg_staff.Columns[1].HeaderText = "Staff Name";
            dg_staff.Columns[2].HeaderText = "Age";
            dg_staff.Columns[3].HeaderText = "Gender";
            dg_staff.Columns[4].HeaderText = "Address";
            dg_staff.Columns[5].HeaderText = "Join Date";
            dg_staff.Columns[6].HeaderText = "Qulaification";
            dg_staff.Columns[7].HeaderText = "Salary";
            
        }
        
        private void LoadStaffData()
        {
            List<tbl_staffinfo> AllStaffData = cls_staff.GetAllStaffData();

            if (AllStaffData != null)
            {
                dg_staff.DataSource = AllStaffData;
                dg_staff.Columns[0].Visible = false;
            }
            else
                dg_staff.DataSource = AllStaffData;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Save.Text == "Save")
            {
                try
                {
                    tbl_staffinfo obj = new tbl_staffinfo();
                    obj.name = txt_name.Text.Trim().ToString();
                    obj.age = int.Parse(txt_age.Text.Trim());
                    obj.gender = txt_gender.Text.Trim().ToString();
                    obj.address = txt_address.Text.Trim().ToString();
                    obj.joindate = DateTime.Parse(txt_joindate.Text.Trim().ToString());
                    obj.qualification = txt_qualification.Text.Trim().ToString();
                    obj.salary = float.Parse(txt_salary.Text.Trim().ToString());

                    int chk = 0;
                    chk = cls_staff.InsertOnStaff(obj);

                    if (chk > 0)
                    {
                        MessageBox.Show("Information Saved !!");
                        LoadStaffData();
                        fieldblank();
                    }
                    else
                        MessageBox.Show("Insertion failed !!");
                }
                catch { MessageBox.Show("Error !! Please make sure, you provide valid input."); }
            }
            else
            {
                try
                {
                    tbl_staffinfo obj = new tbl_staffinfo();

                    obj.sid = staffid;
                    obj.name = txt_name.Text.Trim().ToString();
                    obj.age = int.Parse(txt_age.Text.Trim());
                    obj.gender = txt_gender.Text.Trim().ToString();
                    obj.address = txt_address.Text.Trim().ToString();
                    obj.joindate = DateTime.Parse(txt_joindate.Text.Trim().ToString());
                    obj.qualification = txt_qualification.Text.Trim().ToString();
                    obj.salary = float.Parse(txt_salary.Text.Trim().ToString());

                    int chk = cls_staff.Update_tbl_Staffinfo(obj);
                    if (chk > 0)
                    {
                        MessageBox.Show("Updated !!");
                        Save.Text = "Save";
                        fieldblank();
                        LoadStaffData();
                    }
                    else
                    {
                        MessageBox.Show("Update failed!!");
                    }
                }
                catch { MessageBox.Show("Error !! Please make sure, you provide valid input."); }
            }
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            LoadStaffData();
            ChangeHeader();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int chk = cls_staff.Delete_from_Staff(staffid);
            if (chk > 0)
            {
                MessageBox.Show("Deleted !!");
                LoadStaffData();
                fieldblank();
            }
            else
            {
                MessageBox.Show("No Match found !!");
            }
        }


        private void dg_staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                staffid = int.Parse(dg_staff.SelectedRows[0].Cells[0].Value.ToString());
                Save.Text = "Update";
                IQueryable<tbl_staffinfo> info = cls_staff.GetsingleStaffData(staffid);

                if (info != null)
                {
                    foreach (tbl_staffinfo item in info)
                    {
                        txt_name.Text = item.name.ToString();
                        txt_age.Text = item.age.ToString();
                        txt_gender.Text = item.gender.ToString();
                        txt_address.Text = item.address.ToString();
                        txt_joindate.Text = item.joindate.ToString();
                        txt_qualification.Text = item.qualification.ToString();
                        txt_salary.Text = item.salary.ToString();
                    }
                }
            }
            catch { MessageBox.Show("Parse Error !! Please check you did not let any field empty."); }
        }

        private void bt_delete_dg_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_staff.SelectedRows.Count != 0)
                {
                    staffid = int.Parse(dg_staff.SelectedRows[0].Cells[0].Value.ToString());

                    int chk = cls_staff.Delete_from_Staff(staffid);
                    if (chk > 0)
                    {
                        MessageBox.Show("Deleted !!");
                        LoadStaffData();
                        staffid = 0;
                    }
                    else
                    {
                        MessageBox.Show("No Match found !!");
                    }
                }
            }
            catch { MessageBox.Show("Parse Error !!"); }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStaff_FormClosing(object sender, FormClosingEventArgs e)
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
                        case "salary":
                            MessageBox.Show("Invalid Salary Input !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;

                        case "age":
                            MessageBox.Show("Invalid Age Input !!\nPlease Provide Numeric Value.");
                            temp = false;
                            break;

                    }

                }
            }
            return temp;

        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_age.Text.Trim(), "age"))
            {
                txt_age.Text = str.ToString();
                txt_age.Focus();
            }
        }

        private void txt_salary_TextChanged(object sender, EventArgs e)
        {
            if (!checkfield(txt_salary.Text.Trim(), "salary"))
            {
                txt_salary.Text = str.ToString();
                txt_salary.Focus();
            }
        }



    }
}
