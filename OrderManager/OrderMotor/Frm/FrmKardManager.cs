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
    public partial class FrmKardManager : FrmBase
    {
        public FrmKardManager()
        {
            InitializeComponent();
        }

        private void FrmStoreManager_Load(object sender, EventArgs e)
        {
            //标题居中
            dgv_kard.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //填充数据
            for (int i = 0; i < 7; i++)
            {
                int index = dgv_kard.Rows.Add();
                dgv_kard.Rows[index].Cells[0].Value = "TEST" + (index + 1).ToString();
                dgv_kard.Rows[index].Cells[1].Value = "Swiminwater" + (index + 1).ToString();
                dgv_kard.Rows[index].Cells[2].Value = "立即连接";
                dgv_kard.Rows[index].Cells[5].Value = "0123 4567 8912 3456 789";
                //dataGridView.Rows[index].Cells["ITEM_NAME2"].Value = row["ITEM_NAME"];
                //dataGridView.Rows[index].Cells["INPUT_CODE2"].Value = row["INPUT_CODE"];
            }
        }

        private void btn_AddKard_Click(object sender, EventArgs e)
        {
            FrmKardInfo fsi = new FrmKardInfo();
            fsi.ShowDialog();
        }
    }
}
