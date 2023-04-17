
namespace WindowsFormsApp1
{
    partial class Form_First
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DarkSoul = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button0320 = new System.Windows.Forms.Button();
            this.button0327 = new System.Windows.Forms.Button();
            this.button_TextBox = new System.Windows.Forms.Button();
            this.button0417 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DarkSoul
            // 
            this.DarkSoul.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DarkSoul.Location = new System.Drawing.Point(49, 38);
            this.DarkSoul.Name = "DarkSoul";
            this.DarkSoul.Size = new System.Drawing.Size(245, 62);
            this.DarkSoul.TabIndex = 0;
            this.DarkSoul.Text = "DarkSoul";
            this.DarkSoul.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "button0313";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button0320
            // 
            this.button0320.Location = new System.Drawing.Point(185, 115);
            this.button0320.Name = "button0320";
            this.button0320.Size = new System.Drawing.Size(109, 44);
            this.button0320.TabIndex = 2;
            this.button0320.Text = "button0320";
            this.button0320.UseVisualStyleBackColor = true;
            this.button0320.Click += new System.EventHandler(this.button1_Click);
            // 
            // button0327
            // 
            this.button0327.Location = new System.Drawing.Point(323, 115);
            this.button0327.Name = "button0327";
            this.button0327.Size = new System.Drawing.Size(92, 43);
            this.button0327.TabIndex = 3;
            this.button0327.Text = "button0327";
            this.button0327.UseVisualStyleBackColor = true;
            this.button0327.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_TextBox
            // 
            this.button_TextBox.Location = new System.Drawing.Point(447, 115);
            this.button_TextBox.Name = "button_TextBox";
            this.button_TextBox.Size = new System.Drawing.Size(102, 44);
            this.button_TextBox.TabIndex = 4;
            this.button_TextBox.Text = "button0410";
            this.button_TextBox.UseVisualStyleBackColor = true;
            this.button_TextBox.Click += new System.EventHandler(this.button2_Click);
            // 
            // button0417
            // 
            this.button0417.Location = new System.Drawing.Point(60, 203);
            this.button0417.Name = "button0417";
            this.button0417.Size = new System.Drawing.Size(234, 42);
            this.button0417.TabIndex = 5;
            this.button0417.Text = "期中考0417-攝氏轉華氏";
            this.button0417.UseVisualStyleBackColor = true;
            this.button0417.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form_First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button0417);
            this.Controls.Add(this.button_TextBox);
            this.Controls.Add(this.button0327);
            this.Controls.Add(this.button0320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DarkSoul);
            this.Name = "Form_First";
            this.Text = "Form_First";
            this.Load += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DarkSoul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0320;
        private System.Windows.Forms.Button button0327;
        private System.Windows.Forms.Button button_TextBox;
        private System.Windows.Forms.Button button0417;
    }
}

