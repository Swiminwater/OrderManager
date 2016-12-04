using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderMotor.Comm;
using OrderMotor.Frm;

namespace OrderMotor
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
            fm.frmLogin = this;
            this.Visible = false;
            fm.ShowDialog();
        }
    }
}
