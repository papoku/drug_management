using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_report
    {
        public static List<tbl_sell> Get_sale_data()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {

                var qry = from p in db.tbl_sells
                          select p;

                if (qry.Count() != 0)
                {
                    return qry.ToList();
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }

        public static List<view_sell> Get_sale()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {

                var now = DateTime.Now;
                var qry = from p in db.view_sells
                          //join pname in db.tbl_products on p.product_sn equals pname.product_sn
                          where p.date == now.Date
                          //orderby p.date
                          select p;

                if (qry.Count() != 0)
                {
                    return qry.ToList();
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }

        public static double buy_order_paid()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {
                var qry = (from buy in db.tbl_orders
                           where buy.date_time >= globalvariable.firstdate && buy.date_time <= globalvariable.lastdate
                           && buy.payment_type == "Paid"
                           select buy.price).Sum();

                return qry;
            }
            catch { return 0; }
            
        }

        public static double buy_order_partial()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {
                var qry = (from buy in db.tbl_orders
                           where buy.date_time >= globalvariable.firstdate && buy.date_time <= globalvariable.lastdate
                           && buy.payment_type == "Partial"
                           select buy.paid_amount).Sum();

                return qry;
            }
            catch { return 0; }

        }

        public static double DateToDateSalePrice()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {
                var qry = (from sell in db.tbl_sells
                           orderby sell.date ascending
                           where sell.date >= globalvariable.firstdate && sell.date <= globalvariable.lastdate
                           select sell.price).Sum();

                return qry;
            }
            catch { return 0; }

        }

        public static double salary_expense()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {
                var qry = (from sell in db.tbl_withdrawls
                           where sell.date >= globalvariable.firstdate && sell.date <= globalvariable.lastdate
                           && sell.withdraw_type == "Salary"
                           select sell.amount).Sum();

                return qry;
            }
            catch { return 0; }

        }

        public static double miscelleneaous_expense()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {
                var qry = (from sell in db.tbl_withdrawls
                           orderby sell.date ascending
                           where sell.date >= globalvariable.firstdate && sell.date <= globalvariable.lastdate
                           && sell.withdraw_type == "Miscellaneous"
                           select sell.amount).Sum();

                return qry;
            }
            catch { return 0; }

        }

        public static List<View_order_product> all_buy_order()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {
                var qry = from buy in db.View_order_products
                           where buy.date_time >= globalvariable.firstdate && buy.date_time <= globalvariable.lastdate
                           && buy.order_type == "Buy"
                           select buy;
                
                return qry.ToList();
            }
            catch { return null; }
        }
    }
}
