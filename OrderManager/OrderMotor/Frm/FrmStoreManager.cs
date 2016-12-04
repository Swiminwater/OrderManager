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

namespace OrderMotor.Frm
{
    public partial class FrmStoreManager : FrmBase
    {
        public FrmStoreManager()
        {
            InitializeComponent();
        }

        private void btn_AddStore_Click(object sender, EventArgs e)
        {
            FrmStoreInfo fsi = new FrmStoreInfo();
            fsi.ShowDialog();
        }

        private void FrmStoreManager_Load(object sender, EventArgs e)
        {
            //标题居中
            dgv_dp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
