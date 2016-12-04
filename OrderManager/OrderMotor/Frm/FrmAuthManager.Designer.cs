namespace OrderMotor.Frm
{
    partial class FrmAuthManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_dp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddStore = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店铺状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_dp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 217);
            this.panel2.TabIndex = 1;
            // 
            // dgv_dp
            // 
            this.dgv_dp.AllowUserToAddRows = false;
            this.dgv_dp.AllowUserToDeleteRows = false;
            this.dgv_dp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column4,
            this.店铺状态,
            this.Column8});
            this.dgv_dp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dp.Location = new System.Drawing.Point(0, 0);
            this.dgv_dp.Name = "dgv_dp";
            this.dgv_dp.ReadOnly = true;
            this.dgv_dp.RowTemplate.Height = 23;
            this.dgv_dp.Size = new System.Drawing.Size(846, 217);
            this.dgv_dp.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_AddStore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 42);
            this.panel1.TabIndex = 0;
            // 
            // btn_AddStore
            // 
            this.btn_AddStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStore.Font = new System.Drawing.Font("黑体", 9F);
            this.btn_AddStore.Location = new System.Drawing.Point(46, 10);
            this.btn_AddStore.Name = "btn_AddStore";
            this.btn_AddStore.Size = new System.Drawing.Size(75, 23);
            this.btn_AddStore.TabIndex = 19;
            this.btn_AddStore.Text = "添加小号";
            this.btn_AddStore.UseVisualStyleBackColor = true;
            this.btn_AddStore.Click += new System.EventHandler(this.btn_AddStore_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "账号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column7
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.HeaderText = "银行卡号";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "开户行地址";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 342;
            // 
            // 店铺状态
            // 
            this.店铺状态.HeaderText = "状态";
            this.店铺状态.Name = "店铺状态";
            this.店铺状态.ReadOnly = true;
            this.店铺状态.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "操作";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // FrmAuthManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 259);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("黑体", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAuthManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "认证资料管理";
            this.Load += new System.EventHandler(this.FrmStoreManager_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_dp;
        private System.Windows.Forms.Button btn_AddStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店铺状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}