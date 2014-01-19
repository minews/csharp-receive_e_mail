namespace ReceiveMail
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnStopReceive = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPOP3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.发件人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收件人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大小 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.附件数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labInfo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.btnStopReceive);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnReceive);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPOP3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 61);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.ForeColor = System.Drawing.Color.Red;
            this.labInfo.Location = new System.Drawing.Point(717, 22);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(95, 12);
            this.labInfo.TabIndex = 12;
            this.labInfo.Text = "单击Connect接收";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(225, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(115, 21);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Text = "byunting@163.com";
            // 
            // btnStopReceive
            // 
            this.btnStopReceive.Location = new System.Drawing.Point(848, 15);
            this.btnStopReceive.Name = "btnStopReceive";
            this.btnStopReceive.Size = new System.Drawing.Size(75, 23);
            this.btnStopReceive.TabIndex = 11;
            this.btnStopReceive.Text = "Stop";
            this.btnStopReceive.UseVisualStyleBackColor = true;
            this.btnStopReceive.Click += new System.EventHandler(this.btnStopReceive_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(408, 20);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(115, 21);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "nothing#107629";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(636, 17);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 11;
            this.btnReceive.Text = "Connect";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port";
            // 
            // txtPOP3
            // 
            this.txtPOP3.Location = new System.Drawing.Point(51, 17);
            this.txtPOP3.Name = "txtPOP3";
            this.txtPOP3.Size = new System.Drawing.Size(100, 21);
            this.txtPOP3.TabIndex = 10;
            this.txtPOP3.Text = "pop3.163.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "POP3";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(564, 20);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(52, 21);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "110";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.发件人,
            this.收件人,
            this.主题,
            this.日期,
            this.大小,
            this.附件数,
            this.内容});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(932, 286);
            this.dataGridView1.TabIndex = 16;
            // 
            // 发件人
            // 
            this.发件人.DataPropertyName = "From";
            this.发件人.HeaderText = "发件人";
            this.发件人.Name = "发件人";
            this.发件人.ReadOnly = true;
            // 
            // 收件人
            // 
            this.收件人.DataPropertyName = "To";
            this.收件人.HeaderText = "收件人";
            this.收件人.Name = "收件人";
            this.收件人.ReadOnly = true;
            // 
            // 主题
            // 
            this.主题.DataPropertyName = "Subject";
            this.主题.HeaderText = "主题";
            this.主题.Name = "主题";
            this.主题.ReadOnly = true;
            // 
            // 日期
            // 
            this.日期.DataPropertyName = "Date";
            this.日期.HeaderText = "日期";
            this.日期.Name = "日期";
            this.日期.ReadOnly = true;
            // 
            // 大小
            // 
            this.大小.DataPropertyName = "Size";
            this.大小.HeaderText = "大小";
            this.大小.Name = "大小";
            this.大小.ReadOnly = true;
            // 
            // 附件数
            // 
            this.附件数.DataPropertyName = "AttachmentsLength";
            this.附件数.HeaderText = "附件数";
            this.附件数.Name = "附件数";
            this.附件数.ReadOnly = true;
            // 
            // 内容
            // 
            this.内容.DataPropertyName = "Content";
            this.内容.HeaderText = "内容";
            this.内容.Name = "内容";
            this.内容.ReadOnly = true;
            this.内容.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 347);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.Text = "Receive E-Mail code by fujaz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnStopReceive;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPOP3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发件人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收件人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 主题;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 大小;
        private System.Windows.Forms.DataGridViewTextBoxColumn 附件数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内容;


    }
}

