using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderServer.Comm;
using OrderServer.Frm;

namespace OrderServer
{
    public partial class Login : FrmBase
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FrmMain fm = new FrmMain();
            this.Visible = false;
            fm.ShowDialog();
        }
    }
}
