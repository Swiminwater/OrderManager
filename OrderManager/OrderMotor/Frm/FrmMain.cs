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
    public partial class FrmMain : FrmBase
    {
        #region  窗口自定义属性
        private Login _frmLogin;
        /// <summary>
        /// 存储登陆窗口
        /// </summary>
        public Login frmLogin
        {
            set
            {
                _frmLogin = value;
            }
        }

        private bool _closePopTip = true;
        //关闭窗口是否有提示
        public bool closePopTip
        {
            set
            {
                _closePopTip = value;
            }
        }

        private bool _closeExit = true;
        //关闭窗口是否退出应用程序
        public bool closeExit
        {
            set
            {
                _closePopTip = value;
            }
        }
        #endregion
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_closePopTip)
            {
                if (MessageBox.Show("确认退出<" + this.Text + ">?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }



        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_closeExit)
                Application.Exit();
        }

        private void btn_wang_Click(object sender, EventArgs e)
        {
            //FrmWangManager fwm = new FrmWangManager();
            //fwm.ShowDialog();
            FrmWangInfo fwi = new FrmWangInfo();
            fwi.ShowDialog();
        }

        private void btn_harvest_Click(object sender, EventArgs e)
        {
            FrmHarvest fh = new FrmHarvest();
            fh.ShowDialog();
        }

        private void btn_rentou_Click(object sender, EventArgs e)
        {
            Frm.FrmRenTou frt = new FrmRenTou();
            frt.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //标题居中
            dgv_member.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //不可改变行高
            dgv_member.AllowUserToResizeRows = false;
            dgv_member.RowTemplate.Height = 30;
            dgv_member.Font = new Font("黑体", 9);

            //填充数据
            for (int i = 0; i < 7; i++)
            {
                int index = dgv_member.Rows.Add();
                dgv_member.Rows[index].Cells[0].Value = "TEST" + (index + 1).ToString();
                dgv_member.Rows[index].Cells[1].Value = "Swiminwater" + (index + 1).ToString();
                dgv_member.Rows[index].Cells[2].Value = "立即连接";
                //dataGridView.Rows[index].Cells["ITEM_NAME2"].Value = row["ITEM_NAME"];
                //dataGridView.Rows[index].Cells["INPUT_CODE2"].Value = row["INPUT_CODE"];
            }
        }

        private void btn_Kard_Click(object sender, EventArgs e)
        {
            FrmKardManager fkm = new FrmKardManager();
            fkm.ShowDialog();
        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            FrmAuthManager fam = new FrmAuthManager();
            fam.ShowDialog();
        }

    }
}
