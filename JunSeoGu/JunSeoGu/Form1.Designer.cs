namespace JunSeoGu
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_files = new System.Windows.Forms.ListBox();
            this.bu_Connect = new System.Windows.Forms.Button();
            this.bu_Down = new System.Windows.Forms.Button();
            this.lb_Notice = new System.Windows.Forms.Label();
            this.bu_DownAndUnCompress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_files
            // 
            this.lb_files.FormattingEnabled = true;
            this.lb_files.ItemHeight = 12;
            this.lb_files.Location = new System.Drawing.Point(12, 71);
            this.lb_files.Name = "lb_files";
            this.lb_files.Size = new System.Drawing.Size(260, 136);
            this.lb_files.TabIndex = 0;
            // 
            // bu_Connect
            // 
            this.bu_Connect.Location = new System.Drawing.Point(12, 25);
            this.bu_Connect.Name = "bu_Connect";
            this.bu_Connect.Size = new System.Drawing.Size(260, 40);
            this.bu_Connect.TabIndex = 1;
            this.bu_Connect.Text = "접속하기";
            this.bu_Connect.UseVisualStyleBackColor = true;
            this.bu_Connect.Click += new System.EventHandler(this.bu_Connect_Click);
            // 
            // bu_Down
            // 
            this.bu_Down.Location = new System.Drawing.Point(12, 214);
            this.bu_Down.Name = "bu_Down";
            this.bu_Down.Size = new System.Drawing.Size(260, 36);
            this.bu_Down.TabIndex = 3;
            this.bu_Down.Text = "다운받기";
            this.bu_Down.UseVisualStyleBackColor = true;
            this.bu_Down.Click += new System.EventHandler(this.bu_Down_Click);
            // 
            // lb_Notice
            // 
            this.lb_Notice.AutoSize = true;
            this.lb_Notice.Location = new System.Drawing.Point(12, 7);
            this.lb_Notice.Name = "lb_Notice";
            this.lb_Notice.Size = new System.Drawing.Size(0, 12);
            this.lb_Notice.TabIndex = 4;
            // 
            // bu_DownAndUnCompress
            // 
            this.bu_DownAndUnCompress.Location = new System.Drawing.Point(12, 257);
            this.bu_DownAndUnCompress.Name = "bu_DownAndUnCompress";
            this.bu_DownAndUnCompress.Size = new System.Drawing.Size(260, 34);
            this.bu_DownAndUnCompress.TabIndex = 5;
            this.bu_DownAndUnCompress.Text = "다운 받고 압축 풀기";
            this.bu_DownAndUnCompress.UseVisualStyleBackColor = true;
            this.bu_DownAndUnCompress.Click += new System.EventHandler(this.bu_DownAndUnCompress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 302);
            this.Controls.Add(this.bu_DownAndUnCompress);
            this.Controls.Add(this.lb_Notice);
            this.Controls.Add(this.bu_Down);
            this.Controls.Add(this.bu_Connect);
            this.Controls.Add(this.lb_files);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_files;
        private System.Windows.Forms.Button bu_Connect;
        private System.Windows.Forms.Button bu_Down;
        private System.Windows.Forms.Label lb_Notice;
        private System.Windows.Forms.Button bu_DownAndUnCompress;
    }
}

