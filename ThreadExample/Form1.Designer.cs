namespace ThreadExample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Thread1 = new System.Windows.Forms.Button();
            this.textBox_Thread1 = new System.Windows.Forms.TextBox();
            this.textBox_Thread2 = new System.Windows.Forms.TextBox();
            this.button_Thread2 = new System.Windows.Forms.Button();
            this.textBox_BackgroundWorker = new System.Windows.Forms.TextBox();
            this.button_BackgroundWorker = new System.Windows.Forms.Button();
            this.textBox_InputInt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Thread1
            // 
            this.button_Thread1.Location = new System.Drawing.Point(12, 12);
            this.button_Thread1.Name = "button_Thread1";
            this.button_Thread1.Size = new System.Drawing.Size(134, 49);
            this.button_Thread1.TabIndex = 0;
            this.button_Thread1.Text = "Thread 1";
            this.button_Thread1.UseVisualStyleBackColor = true;
            this.button_Thread1.Click += new System.EventHandler(this.button_Thread1_Click);
            // 
            // textBox_Thread1
            // 
            this.textBox_Thread1.Location = new System.Drawing.Point(12, 67);
            this.textBox_Thread1.Multiline = true;
            this.textBox_Thread1.Name = "textBox_Thread1";
            this.textBox_Thread1.Size = new System.Drawing.Size(134, 236);
            this.textBox_Thread1.TabIndex = 1;
            // 
            // textBox_Thread2
            // 
            this.textBox_Thread2.Location = new System.Drawing.Point(152, 106);
            this.textBox_Thread2.Multiline = true;
            this.textBox_Thread2.Name = "textBox_Thread2";
            this.textBox_Thread2.Size = new System.Drawing.Size(134, 197);
            this.textBox_Thread2.TabIndex = 3;
            // 
            // button_Thread2
            // 
            this.button_Thread2.Location = new System.Drawing.Point(152, 12);
            this.button_Thread2.Name = "button_Thread2";
            this.button_Thread2.Size = new System.Drawing.Size(134, 49);
            this.button_Thread2.TabIndex = 2;
            this.button_Thread2.Text = "Thread 2";
            this.button_Thread2.UseVisualStyleBackColor = true;
            this.button_Thread2.Click += new System.EventHandler(this.button_Thread2_Click);
            // 
            // textBox_BackgroundWorker
            // 
            this.textBox_BackgroundWorker.Location = new System.Drawing.Point(292, 67);
            this.textBox_BackgroundWorker.Multiline = true;
            this.textBox_BackgroundWorker.Name = "textBox_BackgroundWorker";
            this.textBox_BackgroundWorker.Size = new System.Drawing.Size(134, 236);
            this.textBox_BackgroundWorker.TabIndex = 5;
            // 
            // button_BackgroundWorker
            // 
            this.button_BackgroundWorker.Location = new System.Drawing.Point(292, 12);
            this.button_BackgroundWorker.Name = "button_BackgroundWorker";
            this.button_BackgroundWorker.Size = new System.Drawing.Size(134, 49);
            this.button_BackgroundWorker.TabIndex = 4;
            this.button_BackgroundWorker.Text = "BG Worker";
            this.button_BackgroundWorker.UseVisualStyleBackColor = true;
            this.button_BackgroundWorker.Click += new System.EventHandler(this.button_BackgroundWorker_Click);
            // 
            // textBox_InputInt
            // 
            this.textBox_InputInt.Location = new System.Drawing.Point(211, 67);
            this.textBox_InputInt.Name = "textBox_InputInt";
            this.textBox_InputInt.Size = new System.Drawing.Size(75, 33);
            this.textBox_InputInt.TabIndex = 6;
            this.textBox_InputInt.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Int =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_InputInt);
            this.Controls.Add(this.textBox_BackgroundWorker);
            this.Controls.Add(this.button_BackgroundWorker);
            this.Controls.Add(this.textBox_Thread2);
            this.Controls.Add(this.button_Thread2);
            this.Controls.Add(this.textBox_Thread1);
            this.Controls.Add(this.button_Thread1);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Thread1;
        private System.Windows.Forms.TextBox textBox_Thread1;
        private System.Windows.Forms.TextBox textBox_Thread2;
        private System.Windows.Forms.Button button_Thread2;
        private System.Windows.Forms.TextBox textBox_BackgroundWorker;
        private System.Windows.Forms.Button button_BackgroundWorker;
        private System.Windows.Forms.TextBox textBox_InputInt;
        private System.Windows.Forms.Label label1;
    }
}

