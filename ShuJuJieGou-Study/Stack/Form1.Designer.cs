namespace Stack
{
    partial class Form1
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
            this.KuoHaoPiPei = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KuoHaoPiPei
            // 
            this.KuoHaoPiPei.Location = new System.Drawing.Point(268, 209);
            this.KuoHaoPiPei.Name = "KuoHaoPiPei";
            this.KuoHaoPiPei.Size = new System.Drawing.Size(75, 23);
            this.KuoHaoPiPei.TabIndex = 0;
            this.KuoHaoPiPei.Text = "([{括号匹配";
            this.KuoHaoPiPei.UseVisualStyleBackColor = true;
            this.KuoHaoPiPei.Click += new System.EventHandler(this.KuoHaoPiPei_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 363);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KuoHaoPiPei);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KuoHaoPiPei;
        private System.Windows.Forms.TextBox textBox1;
    }
}

