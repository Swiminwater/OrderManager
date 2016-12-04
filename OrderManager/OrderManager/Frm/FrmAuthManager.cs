using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManager.Comm;

namespace OrderManager.Frm
{
    public partial class FrmAuthManager : FrmBase
    {
        public FrmAuthManager()
        {
            InitializeComponent();
        }

        private void btn_AddStore_Click(object sender, EventArgs e)
        {
            FrmAuth fa = new FrmAuth();
            fa.ShowDialog();
        }

        private void FrmStoreManager_Load(object sender, EventArgs e)
        {
            //标题居中
            dgv_dp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //不可改变行高
            dgv_dp.AllowUserToResizeRows = false;
            dgv_dp.RowTemplate.Height = 30;
            dgv_dp.Font = new Font("黑体", 9);
            //填充数据
            for (int i = 0; i < 4; i++)
            {
                int index = dgv_dp.Rows.Add();
                dgv_dp.Rows[index].Cells[0].Value = "TEST" + (index + 1).ToString();
                dgv_dp.Rows[index].Cells[1].Value = "Swiminwater" + (index + 1).ToString();
                dgv_dp.Rows[index].Cells[2].Value = "412322198410201521";
                dgv_dp.Rows[index].Cells[5].Value = "立即连接";
            }
        }
    }
}
