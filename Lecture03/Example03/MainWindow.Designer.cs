namespace Example03
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PokemonPowerUp = new System.Windows.Forms.Button();
            this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
            this.PokemonCPLabel = new System.Windows.Forms.Label();
            this.PokemonNameLabel = new System.Windows.Forms.Label();
            this.PokemonHeightLabel = new System.Windows.Forms.Label();
            this.PokemonWeightLabel = new System.Windows.Forms.Label();
            this.PokemonHPLabel = new System.Windows.Forms.Label();
            this.PokemonTypeLabel = new System.Windows.Forms.Label();
            this.PlayerStardustLabel = new System.Windows.Forms.Label();
            this.PlayerCandyLabel = new System.Windows.Forms.Label();
            this.PowerUpNeedsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PokemonPowerUp
            // 
            this.PokemonPowerUp.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokemonPowerUp.Location = new System.Drawing.Point(112, 653);
            this.PokemonPowerUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PokemonPowerUp.Name = "PokemonPowerUp";
            this.PokemonPowerUp.Size = new System.Drawing.Size(130, 59);
            this.PokemonPowerUp.TabIndex = 0;
            this.PokemonPowerUp.Text = "強化";
            this.PokemonPowerUp.UseVisualStyleBackColor = true;
            this.PokemonPowerUp.Click += new System.EventHandler(this.PokemonPowerUp_Click);
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PokemonPictureBox.Image")));
            this.PokemonPictureBox.Location = new System.Drawing.Point(156, 14);
            this.PokemonPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PokemonPictureBox.Name = "PokemonPictureBox";
            this.PokemonPictureBox.Size = new System.Drawing.Size(357, 287);
            this.PokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PokemonPictureBox.TabIndex = 1;
            this.PokemonPictureBox.TabStop = false;
            // 
            // PokemonCPLabel
            // 
            this.PokemonCPLabel.AutoSize = true;
            this.PokemonCPLabel.Location = new System.Drawing.Point(110, 345);
            this.PokemonCPLabel.Name = "PokemonCPLabel";
            this.PokemonCPLabel.Size = new System.Drawing.Size(59, 25);
            this.PokemonCPLabel.TabIndex = 2;
            this.PokemonCPLabel.Text = "CP: 0";
            // 
            // PokemonNameLabel
            // 
            this.PokemonNameLabel.AutoSize = true;
            this.PokemonNameLabel.Location = new System.Drawing.Point(110, 393);
            this.PokemonNameLabel.Name = "PokemonNameLabel";
            this.PokemonNameLabel.Size = new System.Drawing.Size(179, 25);
            this.PokemonNameLabel.TabIndex = 3;
            this.PokemonNameLabel.Text = "Name: 寶可夢名稱";
            // 
            // PokemonHeightLabel
            // 
            this.PokemonHeightLabel.AutoSize = true;
            this.PokemonHeightLabel.Location = new System.Drawing.Point(110, 452);
            this.PokemonHeightLabel.Name = "PokemonHeightLabel";
            this.PokemonHeightLabel.Size = new System.Drawing.Size(93, 25);
            this.PokemonHeightLabel.TabIndex = 4;
            this.PokemonHeightLabel.Text = "身高: 0m";
            // 
            // PokemonWeightLabel
            // 
            this.PokemonWeightLabel.AutoSize = true;
            this.PokemonWeightLabel.Location = new System.Drawing.Point(295, 452);
            this.PokemonWeightLabel.Name = "PokemonWeightLabel";
            this.PokemonWeightLabel.Size = new System.Drawing.Size(98, 25);
            this.PokemonWeightLabel.TabIndex = 5;
            this.PokemonWeightLabel.Text = "體重: 0kg";
            // 
            // PokemonHPLabel
            // 
            this.PokemonHPLabel.AutoSize = true;
            this.PokemonHPLabel.Location = new System.Drawing.Point(110, 518);
            this.PokemonHPLabel.Name = "PokemonHPLabel";
            this.PokemonHPLabel.Size = new System.Drawing.Size(81, 25);
            this.PokemonHPLabel.TabIndex = 6;
            this.PokemonHPLabel.Text = "HP: 0/0";
            // 
            // PokemonTypeLabel
            // 
            this.PokemonTypeLabel.AutoSize = true;
            this.PokemonTypeLabel.Location = new System.Drawing.Point(295, 518);
            this.PokemonTypeLabel.Name = "PokemonTypeLabel";
            this.PokemonTypeLabel.Size = new System.Drawing.Size(72, 25);
            this.PokemonTypeLabel.TabIndex = 7;
            this.PokemonTypeLabel.Text = "類型: ?";
            // 
            // PlayerStardustLabel
            // 
            this.PlayerStardustLabel.AutoSize = true;
            this.PlayerStardustLabel.Location = new System.Drawing.Point(110, 586);
            this.PlayerStardustLabel.Name = "PlayerStardustLabel";
            this.PlayerStardustLabel.Size = new System.Drawing.Size(114, 25);
            this.PlayerStardustLabel.TabIndex = 8;
            this.PlayerStardustLabel.Text = "星星沙子: 0";
            // 
            // PlayerCandyLabel
            // 
            this.PlayerCandyLabel.AutoSize = true;
            this.PlayerCandyLabel.Location = new System.Drawing.Point(295, 586);
            this.PlayerCandyLabel.Name = "PlayerCandyLabel";
            this.PlayerCandyLabel.Size = new System.Drawing.Size(134, 25);
            this.PlayerCandyLabel.TabIndex = 9;
            this.PlayerCandyLabel.Text = "寶可夢糖果: 0";
            // 
            // PowerUpNeedsLabel
            // 
            this.PowerUpNeedsLabel.AutoSize = true;
            this.PowerUpNeedsLabel.Location = new System.Drawing.Point(274, 687);
            this.PowerUpNeedsLabel.Name = "PowerUpNeedsLabel";
            this.PowerUpNeedsLabel.Size = new System.Drawing.Size(246, 25);
            this.PowerUpNeedsLabel.TabIndex = 10;
            this.PowerUpNeedsLabel.Text = "星星沙子: 0, 寶可夢糖果: 0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 812);
            this.Controls.Add(this.PowerUpNeedsLabel);
            this.Controls.Add(this.PlayerCandyLabel);
            this.Controls.Add(this.PlayerStardustLabel);
            this.Controls.Add(this.PokemonTypeLabel);
            this.Controls.Add(this.PokemonHPLabel);
            this.Controls.Add(this.PokemonWeightLabel);
            this.Controls.Add(this.PokemonHeightLabel);
            this.Controls.Add(this.PokemonNameLabel);
            this.Controls.Add(this.PokemonCPLabel);
            this.Controls.Add(this.PokemonPictureBox);
            this.Controls.Add(this.PokemonPowerUp);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Pokemon GO GO";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PokemonPowerUp;
        private System.Windows.Forms.PictureBox PokemonPictureBox;
        private System.Windows.Forms.Label PokemonCPLabel;
        private System.Windows.Forms.Label PokemonNameLabel;
        private System.Windows.Forms.Label PokemonHeightLabel;
        private System.Windows.Forms.Label PokemonWeightLabel;
        private System.Windows.Forms.Label PokemonHPLabel;
        private System.Windows.Forms.Label PokemonTypeLabel;
        private System.Windows.Forms.Label PlayerStardustLabel;
        private System.Windows.Forms.Label PlayerCandyLabel;
        private System.Windows.Forms.Label PowerUpNeedsLabel;
    }
}

