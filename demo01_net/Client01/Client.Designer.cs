
namespace Client01
{
    partial class Client
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
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(44, 61);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(160, 21);
            this.txt_ip.TabIndex = 0;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(220, 61);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(60, 21);
            this.txt_port.TabIndex = 1;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(375, 59);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(96, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(44, 101);
            this.txt_show.Multiline = true;
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(427, 119);
            this.txt_show.TabIndex = 3;
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(44, 237);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(427, 92);
            this.txt_Msg.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(375, 350);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(96, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "发送消息";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.Button btn_send;
    }
}

