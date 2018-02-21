using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmecyMgt
{
    class cls_staff
    {
        public static int InsertOnStaff(tbl_staffinfo obj)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                try
                {
                    db.tbl_staffinfos.InsertOnSubmit(obj);
                    db.SubmitChanges();
                    return obj.sid;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public static List<tbl_staffinfo> GetAllStaffData()
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_staffinfos
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
        }

        public static int Delete_from_Staff(int id)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_staffinfos
                          where p.sid == id
                          select p;

                foreach (tbl_staffinfo sn in qry)
                {
                    db.tbl_staffinfos.DeleteOnSubmit(sn);
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

        public static IQueryable<tbl_staffinfo> GetsingleStaffData(int id)
        {
            PharmecyMgtDataContext db = new PharmecyMgtDataContext();


            var qry = from p in db.tbl_staffinfos
                      where p.sid == id
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



        public static int Update_tbl_Staffinfo(tbl_staffinfo obj)
        {
            using (PharmecyMgtDataContext db = new PharmecyMgtDataContext())
            {
                var qry = from p in db.tbl_staffinfos
                          where p.sid == obj.sid
                          select p;

                foreach (tbl_staffinfo item in qry)
                {
                    item.name = obj.name;
                    item.age = obj.age;
                    item.gender = obj.gender;
                    item.address = obj.address;
                    item.joindate = obj.joindate;
                    item.qualification = obj.qualification;
                    item.salary = obj.salary;
                }
                try
                {
                    db.SubmitChanges();
                    return obj.sid;
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
