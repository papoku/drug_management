using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmecyMgt
{
    public partial class FrmWeb : Form
    {
        public FrmWeb()
        {
            InitializeComponent();
        }

        private void FrmWeb_Load(object sender, EventArgs e)
        {

        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            //webBrowser.Navigate(txt_address.Text.Trim());
            System.Net.WebRequest req = System.Net.HttpWebRequest.Create("http://www.google.com");
            req.Method = "HEAD";
            System.Net.WebResponse response = req.GetResponse();
            long length = response.ContentLength;
            MessageBox.Show(length.ToString());
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            System.Net.WebRequest req = System.Net.HttpWebRequest.Create(txt_address.Text.Trim());
            req.Method = "HEAD";
            System.Net.WebResponse response = req.GetResponse();
            long length = response.ContentLength;
            MessageBox.Show(length.ToString());
            
            
	    // if it's done or not going, we don't want it visible.
        //    progressBar.Visible = (!(e.CurrentProgress<=0 || e.CurrentProgress==e.MaximumProgress));
        //if (progressBar.Visible) {
        //    progressBar.Value += ((int)e.CurrentProgress/(int)e.MaximumProgress) * 100;
        //    //progressBar.Value = int.Parse(((float)e.CurrentProgress/(float)e.MaximumProgress).ToString()) * 100;
        //    //MessageBox.Show(progressBar.Value.ToString());
        //    progressBar.PerformStep();
            
        //} else {	        // this is probably complete redundant, since we don't see it
        //    progressBar.Value = 0;
        //}

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void FrmWeb_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult key = MessageBox.Show("Want to quit ??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (key == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                Frmadmin obj = new Frmadmin();
                obj.Show();
            }
        }
    }
}
