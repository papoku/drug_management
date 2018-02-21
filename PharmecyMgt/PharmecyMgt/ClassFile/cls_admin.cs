using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_admin
    {
        public static List<tbl_login> GetAllLoginData()
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    var qry = from p in db.tbl_logins
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
