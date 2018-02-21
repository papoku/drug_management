using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_product
    {
        public static int insertOnProduct(tbl_product entry)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    db.tbl_products.InsertOnSubmit(entry);
                    db.SubmitChanges();
                    return entry.product_sn;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static int Update_tbl_Product(tbl_product obj)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_products
                          where p.product_sn == obj.product_sn
                          select p;

                foreach (tbl_product item in qry)
                {
                    item.product_sn = obj.product_sn;
                    item.product_name = obj.product_name;
                    item.product_group = obj.product_group;
                    item.quantity_per_box = obj.quantity_per_box;
                    item.company_name = obj.company_name;
                    item.price_per_box = obj.price_per_box;
                    item.comission_rate_percentege = obj.comission_rate_percentege;
                }
                try
                {
                    db.SubmitChanges();
                    return obj.product_sn;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static int Delete_from_product(int id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_products
                          where p.product_sn == id
                          select p;

                foreach (tbl_product sn in qry)
                {
                    db.tbl_products.DeleteOnSubmit(sn);
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


        public static tbl_product get_singlerecord_product(int productid)
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {
                var qry = from p in db.tbl_products
                          where p.product_sn == productid
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
            catch { return null; }
        }

        public static List<tbl_product> GetAllProductData()
        {
            using (PharmecyMgtDataContext db=new PharmecyMgtDataContext())
            {
                try
                {
                    var qry = from p in db.tbl_products
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
        }

       
    }
}
