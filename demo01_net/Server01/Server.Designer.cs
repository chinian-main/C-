
namespace Server01
{
    partial class Server
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
            this.btn_listen = new System.Windows.Forms.Button();
            this.cbb_user = new System.Windows.Forms.ComboBox();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnShock = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(43, 52);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(143, 21);
            this.txt_ip.TabIndex = 0;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(192, 51);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(50, 21);
            this.txt_port.TabIndex = 1;
            // 
            // btn_listen
            // 
            this.btn_listen.Location = new System.Drawing.Point(351, 49);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(79, 23);
            this.btn_listen.TabIndex = 2;
            this.btn_listen.Text = "开始监听";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // cbb_user
            // 
            this.cbb_user.FormattingEnabled = true;
            this.cbb_user.Location = new System.Drawing.Point(436, 49);
            this.cbb_user.Name = "cbb_user";
            this.cbb_user.Size = new System.Drawing.Size(121, 20);
            this.cbb_user.TabIndex = 3;
            this.cbb_user.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(43, 88);
            this.txt_show.Multiline = true;
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(514, 113);
            this.txt_show.TabIndex = 4;
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(43, 216);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(514, 69);
            this.txt_Msg.TabIndex = 4;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(43, 332);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(336, 21);
            this.txt_path.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(394, 303);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnShock
            // 
            this.btnShock.Location = new System.Drawing.Point(482, 303);
            this.btnShock.Name = "btnShock";
            this.btnShock.Size = new System.Drawing.Size(75, 23);
            this.btnShock.TabIndex = 9;
            this.btnShock.Text = "震动";
            this.btnShock.UseVisualStyleBackColor = true;
            this.btnShock.Click += new System.EventHandler(this.btnShock_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(394, 332);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "选择文件";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(482, 330);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 25);
            this.btnFile.TabIndex = 11;
            this.btnFile.Text = "发送文件";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnShock);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.cbb_user);
            this.Controls.Add(this.btn_listen);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.ComboBox cbb_user;
        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnShock;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnFile;
    }
}

