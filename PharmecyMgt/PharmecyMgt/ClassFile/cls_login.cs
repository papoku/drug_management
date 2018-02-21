using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_login
    {
        public static tbl_login getsinglerecord(string userid, string usertype, string pass)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    var qry = from p in db.tbl_logins
                              where p.User_Id == userid && p.User_Type == usertype && p.Password == pass
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
    }
}
