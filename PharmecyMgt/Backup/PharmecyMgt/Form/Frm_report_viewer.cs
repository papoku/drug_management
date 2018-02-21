using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using PharmecyMgt;
using PharmecyMgt.Report;

namespace PharmecyMgt
{
    public partial class Frm_report_viewer : Form
    {
        public Frm_report_viewer()
        {
            InitializeComponent();
            //reportcreation();
            
        }
        

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
          
        }

        private void Frm_report_viewer_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(x.ToString());
            reportcreation();
        }

        private void reportcreation()
        {
            
            Crp_Daily_sale dsl = new Crp_Daily_sale();
            ReportDocument doc = new ReportDocument();
            string pathrpt;
            SqlConnection cnn = new SqlConnection(globalvariable.con);
            SqlCommand command;
            SqlDataAdapter dad;
            DataSet ds = new DataSet();
            switch (globalvariable.button_txt.ToString())
            {
                   
                case "bt_daily_sale":
                    try
                    {
                        command = new SqlCommand("SELECT * FROM view_sell WHERE date=@dt", cnn);
                        command.Parameters.Add("@dt", SqlDbType.DateTime).Value = DateTime.Now.Date;
                        dad = new SqlDataAdapter(command);
                        dad.Fill(ds, "view_sell");
                        dsl.Load("@Crp_Daily_sale.rpt");
                        dsl.SetDataSource(ds);
                        dsl.SetParameterValue("rpt_type", globalvariable.ReportType.ToString());                     
                        crystalReportViewer1.ReportSource = dsl;
                    }
                    catch { MessageBox.Show("Sql Error Occured !! Try again please."); }
                    break;                   

                case "bt_specific_sale":
                    try
                    {
                        command = new SqlCommand("SELECT * FROM view_sell WHERE date BETWEEN @fd AND @ld", cnn);
                        command.Parameters.Add("@fd", SqlDbType.DateTime).Value = globalvariable.firstdate;
                        command.Parameters.Add("@ld", SqlDbType.DateTime).Value = globalvariable.lastdate;
                        dad = new SqlDataAdapter(command);
                        dad.Fill(ds, "view_sell");
                        dsl.Load("@Crp_Daily_sale.rpt");
                        dsl.SetDataSource(ds);
                        dsl.SetParameterValue("rpt_type", globalvariable.ReportType.ToString());
                        crystalReportViewer1.ReportSource = dsl;
                    }
                    catch { MessageBox.Show("Sql Error Occured !! Try again please."); }
                    break;

                case "bt_create":
                    try
                    {
                        List<tbl_product> data = cls_product.GetAllProductData();
                        pathrpt = System.IO.Path.GetFullPath("..//..//Report//") + "Crp_current_stock.rpt";
                        doc.Load(pathrpt);
                        doc.SetDataSource(data);
                        crystalReportViewer1.ReportSource = doc;
                    }
                    catch { MessageBox.Show("Sql Error Occured !! Try again please."); }
                    break;


                case "btn_dbd_ex":
                    try
                    {
                        
                        using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
                        {
                            double datetodatesale = cls_report.DateToDateSalePrice();  

                            double order_paid = cls_report.buy_order_paid();
                            double order_partial = cls_report.buy_order_partial();
                            double SalaryExpense = cls_report.salary_expense();
                            double miscelleneaous = cls_report.miscelleneaous_expense();
                            double total_expense = order_paid + order_partial + SalaryExpense + miscelleneaous;


                            Crp_expenditure expand = new Crp_expenditure();
                            //obj.SetDataSource();
                            //pathrpt = System.IO.Path.GetFullPath("..//..//Report//") + "Crp_expenditure.rpt";
                            //obj.Load(pathrpt);
                            expand.Load("@Crp_expenditure.rpt");
                            expand.SetParameterValue("report_type", globalvariable.ReportType.ToString());
                            expand.SetParameterValue("total_sale", datetodatesale.ToString());
                            expand.SetParameterValue("total_expense", total_expense.ToString());
                            expand.SetParameterValue("net_cash", (datetodatesale-total_expense).ToString());
                            expand.SetParameterValue("buy_order", (order_paid + order_partial).ToString());
                            expand.SetParameterValue("salary_expns", SalaryExpense.ToString());
                            expand.SetParameterValue("mis_expns", miscelleneaous.ToString());
                            expand.SetParameterValue("fd", globalvariable.firstdate.ToString());
                            expand.SetParameterValue("ld", globalvariable.lastdate.ToString());
                            crystalReportViewer1.ReportSource = expand;
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sorry !! No data available within This date range." + "\n\n" + ex.ToString());
                    }

                    break;

                case "bt_buy_order":
                    try 
                    {
                        List<View_order_product> buyorders = cls_report.all_buy_order();
                        Crp_buy_order objct = new Crp_buy_order();
                        objct.Load("@Crp_buy_order.rpt");
                        objct.SetDataSource(buyorders);
                        objct.SetParameterValue("report_type", globalvariable.ReportType.ToString());
                        objct.SetParameterValue("fd", globalvariable.firstdate.ToString());
                        objct.SetParameterValue("ld", globalvariable.lastdate.ToString());
                        crystalReportViewer1.ReportSource = objct;
 
                    }
                    catch { MessageBox.Show("Sql Error Occured !! Try again please."); }
                    break;


            }
        }
    }
}
