using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_return
    {
        public static int insertdata(tbl_return dataentry)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    db.tbl_returns.InsertOnSubmit(dataentry);
                    db.SubmitChanges();
                    return dataentry.product_sn;
                }
                catch
                {
                    return 0;
                }
            }
        }


        public static int Update_tbl_return(tbl_return id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_returns
                          where p.return_sn == id.return_sn
                          select p;

                foreach (tbl_return item in qry)
                {
                    item.product_sn = id.product_sn;
                    item.product_name = id.product_name;
                    item.quantity = id.quantity;
                    item.cutback_rate = id.cutback_rate;
                    item.price = id.price;
                   
                }
                try
                {
                    db.SubmitChanges();
                    return id.return_sn;
                }
                catch
                {
                    return 0;
                }
            }
        }


        public static tbl_return get_singlerecord_return(int returnsn)
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();

            var qry = from p in db.tbl_returns
                      where p.return_sn == returnsn
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

        public static int Delete_from_return(int id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_returns
                          where p.return_sn == id
                          select p;

                foreach (tbl_return sn in qry)
                {
                    db.tbl_returns.DeleteOnSubmit(sn);
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

        public static List<tbl_return> all_return_table_data()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();

            var qry = from p in db.tbl_returns
                      select p;

            if (qry.Count() == 0)
            {
                return null;
            }
            else
            {
                return qry.ToList();
            }

        } 
    }
}
