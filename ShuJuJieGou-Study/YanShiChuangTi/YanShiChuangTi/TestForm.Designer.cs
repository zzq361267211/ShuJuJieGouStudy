namespace ShuJuJieGouStudy
{
    partial class TestForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_LinkedListStack = new System.Windows.Forms.Button();
            this.btn_Array = new System.Windows.Forms.Button();
            this.btn_ArrayQuene = new System.Windows.Forms.Button();
            this.btn_ArrayStack = new System.Windows.Forms.Button();
            this.btn_KuoHaoPiPei = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "链表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_LinkedListStack
            // 
            this.btn_LinkedListStack.Location = new System.Drawing.Point(53, 318);
            this.btn_LinkedListStack.Name = "btn_LinkedListStack";
            this.btn_LinkedListStack.Size = new System.Drawing.Size(115, 46);
            this.btn_LinkedListStack.TabIndex = 1;
            this.btn_LinkedListStack.Text = "链表栈";
            this.btn_LinkedListStack.UseVisualStyleBackColor = true;
            this.btn_LinkedListStack.Click += new System.EventHandler(this.btn_LinkedListStack_Click);
            // 
            // btn_Array
            // 
            this.btn_Array.Location = new System.Drawing.Point(53, 157);
            this.btn_Array.Name = "btn_Array";
            this.btn_Array.Size = new System.Drawing.Size(115, 49);
            this.btn_Array.TabIndex = 2;
            this.btn_Array.Text = "动态数组示例";
            this.btn_Array.UseVisualStyleBackColor = true;
            this.btn_Array.Click += new System.EventHandler(this.btn_Array_Click);
            // 
            // btn_ArrayQuene
            // 
            this.btn_ArrayQuene.Location = new System.Drawing.Point(53, 94);
            this.btn_ArrayQuene.Name = "btn_ArrayQuene";
            this.btn_ArrayQuene.Size = new System.Drawing.Size(115, 42);
            this.btn_ArrayQuene.TabIndex = 3;
            this.btn_ArrayQuene.Text = "数组队列";
            this.btn_ArrayQuene.UseVisualStyleBackColor = true;
            this.btn_ArrayQuene.Click += new System.EventHandler(this.btn_ArrayQuene_Click);
            // 
            // btn_ArrayStack
            // 
            this.btn_ArrayStack.Location = new System.Drawing.Point(307, 66);
            this.btn_ArrayStack.Name = "btn_ArrayStack";
            this.btn_ArrayStack.Size = new System.Drawing.Size(96, 48);
            this.btn_ArrayStack.TabIndex = 4;
            this.btn_ArrayStack.Text = "数组栈";
            this.btn_ArrayStack.UseVisualStyleBackColor = true;
            this.btn_ArrayStack.Click += new System.EventHandler(this.btn_ArrayStack_Click);
            // 
            // btn_KuoHaoPiPei
            // 
            this.btn_KuoHaoPiPei.Location = new System.Drawing.Point(307, 158);
            this.btn_KuoHaoPiPei.Name = "btn_KuoHaoPiPei";
            this.btn_KuoHaoPiPei.Size = new System.Drawing.Size(139, 48);
            this.btn_KuoHaoPiPei.TabIndex = 5;
            this.btn_KuoHaoPiPei.Text = "括号匹配-力扣20";
            this.btn_KuoHaoPiPei.UseVisualStyleBackColor = true;
            this.btn_KuoHaoPiPei.Click += new System.EventHandler(this.btn_KuoHaoPiPei_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_KuoHaoPiPei);
            this.Controls.Add(this.btn_ArrayStack);
            this.Controls.Add(this.btn_ArrayQuene);
            this.Controls.Add(this.btn_Array);
            this.Controls.Add(this.btn_LinkedListStack);
            this.Controls.Add(this.button1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_LinkedListStack;
        private System.Windows.Forms.Button btn_Array;
        private System.Windows.Forms.Button btn_ArrayQuene;
        private System.Windows.Forms.Button btn_ArrayStack;
        private System.Windows.Forms.Button btn_KuoHaoPiPei;
        private System.Windows.Forms.TextBox textBox1;
    }
}

