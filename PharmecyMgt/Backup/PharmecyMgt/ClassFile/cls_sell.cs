using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_sell
    {
        public static IQueryable<tbl_product> allproduct()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            
                var qry = from p in db.tbl_products
                          select p;

                if (qry.Count() == 0)
                {
                    return null;
                }
                else
                {
                    return qry.AsQueryable();
                }
            
        }

        public static int InsertOnSell(tbl_sell obj)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    db.tbl_sells.InsertOnSubmit(obj);
                    db.SubmitChanges();
                    return obj.sell_id;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static int Update_tbl_Sell(tbl_sell obj)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_sells
                          where p.sell_id == obj.sell_id
                          select p;

                foreach (tbl_sell item in qry)
                {
                    item.sell_id =obj.sell_id;
                    item.product_sn =obj.product_sn;
                    item.quantity = obj.quantity;
                    item.price = obj.price;
                    item.payment_mode = obj.payment_mode;
                    item.date = obj.date;
                    item.paid_amount = obj.paid_amount;
                    item.due_amount = obj.due_amount;
                    item.customer_name = obj.customer_name;
                    item.contact_no = obj.contact_no;
                }
                try
                {
                    db.SubmitChanges();
                    return obj.sell_id;
                }
                catch
                {
                    return 0;
                }
            }
        }


        public static tbl_sell get_singlerecord_sell(int sellid)
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();

            var qry = from p in db.tbl_sells
                      where p.sell_id == sellid
                      select p;

            if (qry.Count() != 0)
            {
                return qry.Single();
            }
            else
            {
                return null;
            }

        }

        public static IQueryable<tbl_sell> getselldata()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();

            var qry = from p in db.tbl_sells
                      join pname in db.tbl_products on p.product_sn equals pname.product_sn
                      orderby p.date
                      select p;

            if (qry.Count() != 0)
            {
                return qry.AsQueryable();
            }
            else
            {
                return null;
            }

        }

        public static int Delete_from_sell(int id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_sells
                          where p.sell_id == id
                          select p;

                foreach (tbl_sell sn in qry)
                {
                    db.tbl_sells.DeleteOnSubmit(sn);
                }

                try
                {
                    db.SubmitChanges();
                    return id;
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
