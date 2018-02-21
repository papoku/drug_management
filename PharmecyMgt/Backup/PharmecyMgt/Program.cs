using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PharmecyMgt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frmlogin());
            //Application.Run(new Frmorder());
            //Application.Run(new FrmStaff());
           //Application.Run(new FrmReport());
            //Application.Run(new FrmReturn());
            //Application.Run(new FrmWeb());
            //Application.Run(new Frmsell());
            //Application.Run(new Frm_withdrawal());

        }
    }
}
