using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PharmecyMgt;



namespace PharmecyMgt
{
   
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            globalvariable.button_txt = bt_create.Name.ToString();
            Frm_report_viewer obj = new Frm_report_viewer();
            obj.Show();
            
        }


        private void bt_daily_sale_Click(object sender, EventArgs e)
        {
            globalvariable.button_txt = bt_daily_sale.Name.ToString();
            globalvariable.ReportType = "Daily Sale Report";
            Frm_report_viewer obj = new Frm_report_viewer();
            obj.Show();
        }

        private void dtp_sale2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

        }

        private void bt_specific_sale_Click(object sender, EventArgs e)
        {
            globalvariable.firstdate = dtp_sale1.Value.Date;
            globalvariable.lastdate = dtp_sale2.Value.Date;
            globalvariable.button_txt = bt_specific_sale.Name.ToString();
            globalvariable.ReportType = "Date To Date Sale Report";
            Frm_report_viewer obj = new Frm_report_viewer();
            obj.Show();
        }

        private void FrmReport_FormClosing(object sender, FormClosingEventArgs e)
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

      
        private void btn_dbd_ex_Click(object sender, EventArgs e)
        {
            globalvariable.firstdate = dtp_ex1.Value.Date;
            globalvariable.lastdate = dtp_ex2.Value.Date;
            globalvariable.ReportType = "Date To Date Expenditure";
            globalvariable.button_txt = btn_dbd_ex.Name.ToString();
            Frm_report_viewer obj = new Frm_report_viewer();
            obj.Show();
        }


        private void bt_buy_order_Click(object sender, EventArgs e)
        {
            globalvariable.firstdate = dtp_buy1.Value.Date;
            globalvariable.lastdate = dtp_buy2.Value.Date;
            globalvariable.ReportType = "Date To Date Buy Order.";
            globalvariable.button_txt = bt_buy_order.Name.ToString();
            Frm_report_viewer obj = new Frm_report_viewer();
            obj.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
 
    public static class globalvariable
    {
        public static string button_txt;
        public static string ReportType;
        public static string con = "Data Source=PAUL-PC\\SQLEXPRESS;Initial Catalog=Pharmecy Mgt.;Integrated Security=True";
        
        public static DateTime firstdate;
        public static DateTime lastdate;

        //public static bool flag = true;
    }
    
}
