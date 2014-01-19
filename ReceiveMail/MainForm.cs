using LumiSoft.Net;
using LumiSoft.Net.Mail;
using LumiSoft.Net.Mime;
using LumiSoft.Net.MIME;
using LumiSoft.Net.POP3.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiveMail
{
    /// <summary>
    /// author:fujaz
    /// create:2013-5-10
    /// edit:2014-1-19
    /// copy:anyway
    /// contact:fujazbug@gmail.com
    /// github:https://github.com/Fujaz/csharp-receive_e_mail
    /// 
    ///
    /// 关于本程序的介绍请查看我的blog页面：http://fujaz.info/post/73775832118/receive-e-mail
    /// 关于c#线程和线程访问UI组件也请查看我的blog页面：http://fujaz.info/post/73776139653/csharp-thread-ui
    /// </summary>
    public partial class MainForm : Form
    {
        //邮件ID列表
        List<string> mailsID = new List<string>();
        //邮件列表
        List<MailInfo> mails = new List<MailInfo>();
        //接收线程
        Thread thread = null;
        //设置数据源
        delegate void SetDatasource();
        //设置登录进度信息
        delegate void SendInfoDelegate(string info);
        //是否继续接收邮件，用于Stop按钮
        bool continueReceive = true;

        public MainForm()
        {
            InitializeComponent();
            //设置双击事件
            this.dataGridView1.DoubleClick += gridView1_DoubleClick;
            //设置退出程序事件
            this.FormClosed += MainForm_FormClosed;

            //设置表格选中为行模式
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //初始化线程
            thread = new Thread(new ThreadStart(Start));
            thread.IsBackground = true;
            thread.Name = "ReceiveThread";

        }

        /// <summary>
        /// 接收线程
        /// </summary>
        private void Start()
        {
            using (POP3_Client c = new POP3_Client())
            {
                Invoke(new SendInfoDelegate(sendInfo), "尝试登录...");
                //连接
                //c.Connect(txtPOP3.Text, WellKnownPorts.POP3);
                c.Connect(txtPOP3.Text, Convert.ToInt32(txtPort.Text));

                Invoke(new SendInfoDelegate(sendInfo), "登录成功...");
                //登录
                c.Login(txtAddress.Text, txtPassword.Text);

                if (c.Messages.Count < 0)
                {
                    Invoke(new SendInfoDelegate(sendInfo), "无邮件信息！");
                    return;
                }

                //this.Cursor = Cursors.WaitCursor;
                Invoke(new SendInfoDelegate(sendInfo), "开始接收...");
                //总共邮件数量
                int mailCount = c.Messages.Count;
                //已经接收的邮件数量
                int receivedMails = 0;

                for (   int i = 0; 
                        i < c.Messages.Count && continueReceive; 
                        i++)
                {
                    //m是邮件对象
                    Mail_Message m = Mail_Message.ParseFromByte(c.Messages[i].MessageToByte());

                    //检查是否已经有这封邮件，用MessageID判断
                    if (mailsID.Contains(m.MessageID)) continue;

                    //Mail_Message转换到MailInfo对象
                    MailInfo mInfo = new MailInfo();
                    mInfo.From = m.From.ToString();
                    mInfo.To = m.To.ToString();
                    mInfo.Subject = m.Subject;
                    mInfo.Date = m.Date;

                    //是否是HTML邮件
                    if (m.BodyHtmlText != null)
                        mInfo.Content = m.BodyHtmlText;
                    else
                        mInfo.Content = m.BodyText;

                    mInfo.AttachmentsLength = m.Attachments.Length;
                    mInfo.Size = c.Messages[i].MessageToByte().Length;

                    mails.Add(mInfo);
                    mailsID.Add(m.MessageID);
                    receivedMails++;

                    Invoke(new SendInfoDelegate(sendInfo), i + "/" + mailCount + " 正在接收...");

                    Invoke(new SetDatasource(setDataSource));
                }

                Invoke(new SendInfoDelegate(sendInfo), " 您成功接收了 + " + receivedMails + "封新邮件");

            }
        }

        /// <summary>
        /// 双击转移到内容展示页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            if (row == null)
            {
                MessageBox.Show("请选中数据行!");
                return;
            }
            
            ShowContent form = new ShowContent();
            form.Text = row.Cells["Subject"].Value.ToString();
            form.html = row.Cells["Content"].Value.ToString();
            form.Show();
        }

        /// <summary>
        /// 更新接收进度信息
        /// </summary>
        /// <param name="info"></param>
        private void sendInfo(string info)
        {
            this.labInfo.Text = info;
        }

        // 设置数据源
        private void setDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();
            this.dataGridView1.DataSource = mails;
        }
        
        /// <summary>
        /// 开始接收邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.mails = new List<MailInfo>();
            this.mailsID = new List<string>();

            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();

            continueReceive = true;
            if (thread.IsAlive)
                thread.Abort();
            thread = new Thread(new ThreadStart(Start));
            thread.Start();
            btnReceive.Enabled = false;
        }

        /// <summary>
        /// 停止接收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopReceive_Click_1(object sender, EventArgs e)
        {
            continueReceive = false;
            btnReceive.Enabled = true;
        }

        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread != null && thread.IsAlive)
                thread.Abort();
        }
    }
}
