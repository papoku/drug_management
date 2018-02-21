using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_Class
    {
        public static int insertdata(tbl_login entry)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    db.tbl_logins.InsertOnSubmit(entry);
                    db.SubmitChanges();
                    return entry.login_sn;
                }
                catch 
                {
                    return 0;
                }
            }
        }

        public static tbl_login getsingle_record(int id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_logins
                          where p.login_sn == id
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
        }
        public static int Update_tbl_login(tbl_login id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_logins
                          where p.login_sn == id.login_sn
                          select p;
                
                foreach (tbl_login item in qry)
                {
                    item.login_sn = id.login_sn;
                    item.User_Id = id.User_Id;
                    item.User_Type = id.User_Type;
                    item.Password = id.Password;
                }
                try
                {
                    db.SubmitChanges();
                    return id.login_sn;
                }
                catch 
                {
                    return 0;
                }
            }
        }
       
    }
}
