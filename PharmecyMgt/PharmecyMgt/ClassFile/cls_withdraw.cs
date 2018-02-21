using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_withdraw
    {
        public static int InsertOnWithdraw(tbl_withdrawl obj)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    db.tbl_withdrawls.InsertOnSubmit(obj);
                    db.SubmitChanges();
                    return obj.withdraw_id;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static List<tbl_withdrawl> GetAllWithdrawalData()
        {
                using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
                {
                    try
                    {
                        var qry = from p in db.tbl_withdrawls
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

        public static int Delete_from_withdrawal(int id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_withdrawls
                          where p.withdraw_id == id
                          select p;

                foreach (tbl_withdrawl sn in qry)
                {
                    db.tbl_withdrawls.DeleteOnSubmit(sn);
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

        public static int Update_tbl_withdraw(tbl_withdrawl obj,int i)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_withdrawls
                          where p.withdraw_id == i
                          select p;

                foreach (tbl_withdrawl item in qry)
                {
                    item.withdrawer_name = obj.withdrawer_name;
                    item.amount = obj.amount;
                    item.withdraw_type = obj.withdraw_type;
                    item.description = obj.description;
                    item.date = obj.date;
                }
                try
                {
                    db.SubmitChanges();
                    return i;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static IQueryable<tbl_withdrawl> GetsingleWithdrawalData(int id)
        {
            try
            {
                PharmecyMgtDataContext db = new PharmecyMgtDataContext();
                var qry = from p in db.tbl_withdrawls
                          where p.withdraw_id == id
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
