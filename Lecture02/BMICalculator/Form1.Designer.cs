namespace BMICalculator
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
            this.WeightLabel = new System.Windows.Forms.Label();
            this.calcubutton = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.resultRichTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(152, 111);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(49, 20);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "體重";
            this.WeightLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // calcubutton
            // 
            this.calcubutton.Location = new System.Drawing.Point(278, 212);
            this.calcubutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcubutton.Name = "calcubutton";
            this.calcubutton.Size = new System.Drawing.Size(262, 40);
            this.calcubutton.TabIndex = 1;
            this.calcubutton.Text = "計算BMI";
            this.calcubutton.UseVisualStyleBackColor = true;
            this.calcubutton.Click += new System.EventHandler(this.Calcubutton_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(152, 41);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(49, 20);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "身高";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(278, 38);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightTextBox.Multiline = true;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(262, 42);
            this.heightTextBox.TabIndex = 3;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(278, 108);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weightTextBox.Multiline = true;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.PasswordChar = '-';
            this.weightTextBox.Size = new System.Drawing.Size(262, 40);
            this.weightTextBox.TabIndex = 4;
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(278, 316);
            this.resultRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultRichTextBox.Multiline = true;
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(262, 139);
            this.resultRichTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 613);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.calcubutton);
            this.Controls.Add(this.WeightLabel);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button calcubutton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox resultRichTextBox;
    }
}

