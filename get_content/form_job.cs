using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_content
{
    public partial class form_job : Form
    {
        public form_job()
        {
            InitializeComponent();
            //web_ie.Navigate(txt_url.Text.ToString );
            if (String.IsNullOrEmpty(this.txt_url.Text))
            {
                MessageBox.Show("请输入网址!");
                return;
            }
            // 保存用户输入的Url,和追加模式设置
            Properties.Settings.Default.Save();

            this.web_ie.Navigate(this.txt_url.Text);
             

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            #region 算法
            // 进入列表页(参数 URL，下一页）
            // 请求API 保存此列表页
            //循环自动点击下一页
                // 请求API 保存此列表页
                // 自动点击下一页
            #endregion


        }

        private void web_ie_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
