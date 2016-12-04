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
    public partial class FrmMain : Comm.FrmBase
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //标题居中
            dgv_member.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_order.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_back.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //第一列不显示
            dgv_member.RowHeadersVisible = false;
            dgv_order.RowHeadersVisible = false;
            dgv_back.RowHeadersVisible = false;
            //不可改变行高
            dgv_member.AllowUserToResizeRows = false;
            dgv_member.RowTemplate.Height = 30;
            dgv_member.Font = new Font("黑体", 9);

            dgv_order.AllowUserToResizeRows = false;
            dgv_order.RowTemplate.Height = 30;
            dgv_order.Font = new Font("黑体", 9);

            dgv_back.AllowUserToResizeRows = false;
            dgv_back.RowTemplate.Height = 30;
            dgv_back.Font = new Font("黑体", 9);

            //填充数据
            for (int i = 0; i < 15; i++)
            {
                int index = dgv_member.Rows.Add();
                dgv_member.Rows[index].Cells[0].Value = "TEST" + (index+1).ToString();
                dgv_member.Rows[index].Cells[1].Value = "Swiminwater" + (index + 1).ToString();
                dgv_member.Rows[index].Cells[9].Value = "立即连接";
                //dataGridView.Rows[index].Cells["ITEM_NAME2"].Value = row["ITEM_NAME"];
                //dataGridView.Rows[index].Cells["INPUT_CODE2"].Value = row["INPUT_CODE"];
            }
            //填充数据
            for (int i = 0; i < 15; i++)
            {
                int index = dgv_order.Rows.Add();
                dgv_order.Rows[index].Cells[0].Value = "TEST" + (index + 1).ToString();
                dgv_order.Rows[index].Cells[1].Value = "Swiminwater" + (index + 1).ToString();
                //dgv_order.Rows[index].Cells[9].Value = "立即连接";
            }

            //填充数据
            for (int i = 0; i < 15; i++)
            {
                int index = dgv_back.Rows.Add();
                dgv_back.Rows[index].Cells[0].Value = "TEST" + (index + 1).ToString();
                dgv_back.Rows[index].Cells[1].Value = "Swiminwater" + (index + 1).ToString();
                //dgv_order.Rows[index].Cells[9].Value = "立即连接";
            }
        }

        private void tsb_loginagain_Click(object sender, EventArgs e)
        {
            _closePopTip = false;  //设置关闭窗口不能有提示
            _closeExit = false;    //设置关闭窗口直接退出应用
            this.Close();
            _frmLogin.Visible = true;
        }

        private void tsb_loginoff_Click(object sender, EventArgs e)
        {
            _closePopTip = true;  //设置关闭窗口不能有提示
            _closeExit = true;    //设置关闭窗口直接退出应用
            this.Close();
        }

        private void tsb_about_Click(object sender, EventArgs e)
        {
            Frm.FrmAbout fa = new FrmAbout();
            fa.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm.FrmGongGao fgg = new FrmGongGao();
            fgg.ShowDialog();
        }

        private void btn_Store_Click(object sender, EventArgs e)
        {
            FrmStoreManager fsm = new FrmStoreManager();
            fsm.ShowDialog();
        }

        private void btn_Auth_Click(object sender, EventArgs e)
        {
            FrmAuthManager fam = new FrmAuthManager();
            fam.ShowDialog();
        }


    }
}
