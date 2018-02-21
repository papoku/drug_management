using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_order
    {
        private int _unique_Order_Id;

        public int unique_Order_Id
        {
            get { return _unique_Order_Id; }
            set { _unique_Order_Id = value; }
        }
        
        public static int? getuniqueorderid()
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    int? qry = (from p in db.tbl_orders
                               orderby p.unq_orderid descending
                               select p.unq_orderid).First();

                    if (qry.HasValue)
                    {
                        return (int?)qry;
                    }
                    else
                        return 0;
                }
                catch
                {
                    return 0;
                }
            
            }
        }

        public static int InsertOnOrder(tbl_order obj)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    db.tbl_orders.InsertOnSubmit(obj);
                    db.SubmitChanges();
                    return obj.order_id;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static int Delete_from_order(int id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_orders
                          where p.order_id == id
                          select p;

                foreach (tbl_order sn in qry)
                {
                    db.tbl_orders.DeleteOnSubmit(sn);
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

        public static IQueryable<tbl_order> getorderdata()
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {

                var qry = from p in db.tbl_orders
                          join pname in db.tbl_products on p.product_sn equals pname.product_sn
                          orderby p.date_time
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
            catch { return null; }
            
        }

        public static int Update_tbl_Order(tbl_order obj)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_orders
                          where p.order_id == obj.order_id
                          select p;

                foreach (tbl_order item in qry)
                {
                    item.product_sn = obj.product_sn;
                    item.order_type = obj.order_type;
                    item.quantity = obj.quantity;
                    item.bonus_product = obj.bonus_product;
                    item.payment_type = obj.payment_type;
                    item.price = obj.price;
                    item.paid_amount = obj.paid_amount;
                    item.due_amount = obj.due_amount;
                    item.ordered_to = obj.ordered_to;
                    item.contact_no = obj.contact_no;
                    item.order_status = obj.order_status;
                    item.date_time = obj.date_time;
                    item.unq_orderid = obj.unq_orderid;
                   
                }
                try
                {
                    db.SubmitChanges();
                    return obj.order_id;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static int InsertOnCurrentDrug(tbl_current_drug obj)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    db.tbl_current_drugs.InsertOnSubmit(obj);
                    db.SubmitChanges();
                    return obj.drug_sn;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static tbl_order get_singlerecord_order(int orderid)
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();
            try
            {

                var qry = from p in db.tbl_orders
                          where p.order_id == orderid
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

        public static tbl_current_drug getsinglerecord(int productid)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    var qry = from p in db.tbl_current_drugs
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

        }

        public static int Update_tbl_Currentdrug(tbl_current_drug id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_current_drugs
                          where p.product_sn == id.product_sn
                          select p;

                foreach (tbl_current_drug item in qry)
                {
                    //item.drug_sn = id.drug_sn;
                    //item.product_sn = id.product_sn;
                    item.quantity = id.quantity;
                }
                try
                {
                    db.SubmitChanges();
                    return id.product_sn;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static IQueryable<tbl_order> GetSearchedOrderData(DateTime date)
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();

            try
            {
                var qry = from p in db.tbl_orders
                          join pname in db.tbl_products on p.product_sn equals pname.product_sn
                          where p.date_time == date
                          orderby p.date_time
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
            catch { return null; }
                
        }

        
        
    }
}
