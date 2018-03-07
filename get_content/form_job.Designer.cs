namespace get_content
{
    partial class form_job
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_ie = new System.Windows.Forms.Panel();
            this.web_ie = new System.Windows.Forms.WebBrowser();
            this.panel_top = new System.Windows.Forms.Panel();
            this.txt_next = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_ie.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ie
            // 
            this.panel_ie.Controls.Add(this.pictureBox1);
            this.panel_ie.Controls.Add(this.web_ie);
            this.panel_ie.Location = new System.Drawing.Point(2, 55);
            this.panel_ie.Name = "panel_ie";
            this.panel_ie.Size = new System.Drawing.Size(825, 362);
            this.panel_ie.TabIndex = 0;
            // 
            // web_ie
            // 
            this.web_ie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_ie.Location = new System.Drawing.Point(0, 0);
            this.web_ie.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_ie.Name = "web_ie";
            this.web_ie.Size = new System.Drawing.Size(825, 362);
            this.web_ie.TabIndex = 0;
            this.web_ie.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_ie_DocumentCompleted);
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.txt_next);
            this.panel_top.Controls.Add(this.btn_enter);
            this.panel_top.Controls.Add(this.txt_url);
            this.panel_top.Location = new System.Drawing.Point(3, 1);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(823, 48);
            this.panel_top.TabIndex = 1;
            // 
            // txt_next
            // 
            this.txt_next.Location = new System.Drawing.Point(514, 3);
            this.txt_next.Name = "txt_next";
            this.txt_next.Size = new System.Drawing.Size(131, 21);
            this.txt_next.TabIndex = 2;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(651, 0);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(169, 45);
            this.btn_enter.TabIndex = 1;
            this.btn_enter.Text = "进入";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(3, 4);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(505, 21);
            this.txt_url.TabIndex = 0;
            this.txt_url.Text = "http://job.hainan.net/search/search-job.jsp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(540, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // form_job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 422);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_ie);
            this.Name = "form_job";
            this.Text = "Form1";
            this.panel_ie.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ie;
        private System.Windows.Forms.WebBrowser web_ie;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

