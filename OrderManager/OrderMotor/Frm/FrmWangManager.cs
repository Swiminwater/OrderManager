using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMotor.Frm
{
    public partial class FrmWangManager : Form
    {
        public FrmWangManager()
        {
            InitializeComponent();
        }

        private void btn_AddStore_Click(object sender, EventArgs e)
        {
            FrmWangInfo fwi = new FrmWangInfo();
            fwi.ShowDialog();
        }
    }
}
