namespace wumpus.forms
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.NumberOfCoinsLabel = new System.Windows.Forms.Label();
            this.NumberOfArrowsLabel = new System.Windows.Forms.Label();
            this.NorthRoomsLabel = new System.Windows.Forms.Label();
            this.NorthEastRoomsLabel = new System.Windows.Forms.Label();
            this.NorthWestRoomsLabel = new System.Windows.Forms.Label();
            this.SouthRoomsLabel = new System.Windows.Forms.Label();
            this.SouthEastRoomsLabel = new System.Windows.Forms.Label();
            this.SouthWestRoomsLabel = new System.Windows.Forms.Label();
            this.PurchaseArrowsButton = new System.Windows.Forms.Button();
            this.ShootArrowButton = new System.Windows.Forms.Button();
            this.PurchaseSecretButton = new System.Windows.Forms.Button();
            this.buySecretButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.laserPicture = new System.Windows.Forms.PictureBox();
            this.spaceshipPicture = new System.Windows.Forms.PictureBox();
            this.playAgain = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.viewHighscores = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.planetLabel = new System.Windows.Forms.Label();
            this.displayHelp = new System.Windows.Forms.Button();
            this.southEastButton = new RoundButton();
            this.southButton = new RoundButton();
            this.northWestButton = new RoundButton();
            this.southWestButton = new RoundButton();
            this.northEastButton = new RoundButton();
            this.northButton = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.laserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceshipPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfCoinsLabel
            // 
            this.NumberOfCoinsLabel.AutoSize = true;
            this.NumberOfCoinsLabel.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfCoinsLabel.Location = new System.Drawing.Point(2227, 19);
            this.NumberOfCoinsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NumberOfCoinsLabel.Name = "NumberOfCoinsLabel";
            this.NumberOfCoinsLabel.Size = new System.Drawing.Size(215, 28);
            this.NumberOfCoinsLabel.TabIndex = 6;
            this.NumberOfCoinsLabel.Text = "Number of Coins";
            // 
            // NumberOfArrowsLabel
            // 
            this.NumberOfArrowsLabel.AutoSize = true;
            this.NumberOfArrowsLabel.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfArrowsLabel.Location = new System.Drawing.Point(2213, 65);
            this.NumberOfArrowsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NumberOfArrowsLabel.Name = "NumberOfArrowsLabel";
            this.NumberOfArrowsLabel.Size = new System.Drawing.Size(229, 28);
            this.NumberOfArrowsLabel.TabIndex = 7;
            this.NumberOfArrowsLabel.Text = "Number of Lasers\r\n";
            // 
            // NorthRoomsLabel
            // 
            this.NorthRoomsLabel.AutoSize = true;
            this.NorthRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NorthRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.NorthRoomsLabel.Location = new System.Drawing.Point(1116, 65);
            this.NorthRoomsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NorthRoomsLabel.Name = "NorthRoomsLabel";
            this.NorthRoomsLabel.Size = new System.Drawing.Size(79, 53);
            this.NorthRoomsLabel.TabIndex = 8;
            this.NorthRoomsLabel.Text = "NN";
            // 
            // NorthEastRoomsLabel
            // 
            this.NorthEastRoomsLabel.AutoSize = true;
            this.NorthEastRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NorthEastRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthEastRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.NorthEastRoomsLabel.Location = new System.Drawing.Point(2244, 388);
            this.NorthEastRoomsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NorthEastRoomsLabel.Name = "NorthEastRoomsLabel";
            this.NorthEastRoomsLabel.Size = new System.Drawing.Size(76, 53);
            this.NorthEastRoomsLabel.TabIndex = 9;
            this.NorthEastRoomsLabel.Text = "NE";
            // 
            // NorthWestRoomsLabel
            // 
            this.NorthWestRoomsLabel.AutoSize = true;
            this.NorthWestRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NorthWestRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthWestRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.NorthWestRoomsLabel.Location = new System.Drawing.Point(136, 421);
            this.NorthWestRoomsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NorthWestRoomsLabel.Name = "NorthWestRoomsLabel";
            this.NorthWestRoomsLabel.Size = new System.Drawing.Size(97, 53);
            this.NorthWestRoomsLabel.TabIndex = 10;
            this.NorthWestRoomsLabel.Text = "NW";
            // 
            // SouthRoomsLabel
            // 
            this.SouthRoomsLabel.AutoSize = true;
            this.SouthRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SouthRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.SouthRoomsLabel.Location = new System.Drawing.Point(752, 940);
            this.SouthRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SouthRoomsLabel.Name = "SouthRoomsLabel";
            this.SouthRoomsLabel.Size = new System.Drawing.Size(67, 53);
            this.SouthRoomsLabel.TabIndex = 11;
            this.SouthRoomsLabel.Text = "SS";
            // 
            // SouthEastRoomsLabel
            // 
            this.SouthEastRoomsLabel.AutoSize = true;
            this.SouthEastRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SouthEastRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthEastRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.SouthEastRoomsLabel.Location = new System.Drawing.Point(2251, 738);
            this.SouthEastRoomsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SouthEastRoomsLabel.Name = "SouthEastRoomsLabel";
            this.SouthEastRoomsLabel.Size = new System.Drawing.Size(71, 53);
            this.SouthEastRoomsLabel.TabIndex = 12;
            this.SouthEastRoomsLabel.Text = "SE";
            // 
            // SouthWestRoomsLabel
            // 
            this.SouthWestRoomsLabel.AutoSize = true;
            this.SouthWestRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SouthWestRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthWestRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.SouthWestRoomsLabel.Location = new System.Drawing.Point(26, 585);
            this.SouthWestRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SouthWestRoomsLabel.Name = "SouthWestRoomsLabel";
            this.SouthWestRoomsLabel.Size = new System.Drawing.Size(92, 53);
            this.SouthWestRoomsLabel.TabIndex = 13;
            this.SouthWestRoomsLabel.Text = "SW";
            // 
            // PurchaseArrowsButton
            // 
            this.PurchaseArrowsButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseArrowsButton.Location = new System.Drawing.Point(2188, 115);
            this.PurchaseArrowsButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PurchaseArrowsButton.Name = "PurchaseArrowsButton";
            this.PurchaseArrowsButton.Size = new System.Drawing.Size(324, 44);
            this.PurchaseArrowsButton.TabIndex = 15;
            this.PurchaseArrowsButton.Text = "Purchase Lasers";
            this.PurchaseArrowsButton.UseVisualStyleBackColor = true;
            this.PurchaseArrowsButton.Click += new System.EventHandler(this.PurchaseArrowsButton_Click);
            // 
            // ShootArrowButton
            // 
            this.ShootArrowButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootArrowButton.Location = new System.Drawing.Point(2188, 162);
            this.ShootArrowButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ShootArrowButton.Name = "ShootArrowButton";
            this.ShootArrowButton.Size = new System.Drawing.Size(324, 44);
            this.ShootArrowButton.TabIndex = 16;
            this.ShootArrowButton.Text = "Shoot Lasers";
            this.ShootArrowButton.UseVisualStyleBackColor = true;
            this.ShootArrowButton.Click += new System.EventHandler(this.ShootArrowButton_Click);
            // 
            // PurchaseSecretButton
            // 
            this.PurchaseSecretButton.Location = new System.Drawing.Point(13, 23);
            this.PurchaseSecretButton.Name = "PurchaseSecretButton";
            this.PurchaseSecretButton.Size = new System.Drawing.Size(75, 23);
            this.PurchaseSecretButton.TabIndex = 17;
            this.PurchaseSecretButton.Text = "Purchase Secret ";
            this.PurchaseSecretButton.UseVisualStyleBackColor = true;
            // 
            // buySecretButton
            // 
            this.buySecretButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buySecretButton.Location = new System.Drawing.Point(2188, 212);
            this.buySecretButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buySecretButton.Name = "buySecretButton";
            this.buySecretButton.Size = new System.Drawing.Size(324, 44);
            this.buySecretButton.TabIndex = 17;
            this.buySecretButton.Text = "Purchase Secret";
            this.buySecretButton.UseVisualStyleBackColor = true;
            this.buySecretButton.Click += new System.EventHandler(this.buySecretButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer 2
            //
            //this.timer2.Interval = 20;
            //this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // laserPicture
            // 
            this.laserPicture.BackColor = System.Drawing.Color.Transparent;
            this.laserPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("laserPicture.ErrorImage")));
            this.laserPicture.Image = ((System.Drawing.Image)(resources.GetObject("laserPicture.Image")));
            this.laserPicture.Location = new System.Drawing.Point(1099, 388);
            this.laserPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laserPicture.Name = "laserPicture";
            this.laserPicture.Size = new System.Drawing.Size(101, 88);
            this.laserPicture.TabIndex = 20;
            this.laserPicture.TabStop = false;
            // 
            // spaceshipPicture
            // 
            this.spaceshipPicture.BackColor = System.Drawing.Color.Transparent;
            this.spaceshipPicture.Image = ((System.Drawing.Image)(resources.GetObject("spaceshipPicture.Image")));
            this.spaceshipPicture.Location = new System.Drawing.Point(1067, 500);
            this.spaceshipPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spaceshipPicture.Name = "spaceshipPicture";
            this.spaceshipPicture.Size = new System.Drawing.Size(244, 194);
            this.spaceshipPicture.TabIndex = 21;
            this.spaceshipPicture.TabStop = false;
            // 
            // playAgain
            // 
            this.playAgain.AutoSize = true;
            this.playAgain.BackColor = System.Drawing.Color.Transparent;
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgain.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.ForeColor = System.Drawing.Color.White;
            this.playAgain.Location = new System.Drawing.Point(680, 498);
            this.playAgain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(251, 100);
            this.playAgain.TabIndex = 22;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = true;
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(1547, 500);
            this.quitButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(251, 100);
            this.quitButton.TabIndex = 23;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // viewHighscores
            // 
            this.viewHighscores.AutoSize = true;
            this.viewHighscores.BackColor = System.Drawing.Color.Transparent;
            this.viewHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewHighscores.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewHighscores.ForeColor = System.Drawing.Color.White;
            this.viewHighscores.Location = new System.Drawing.Point(1109, 498);
            this.viewHighscores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewHighscores.Name = "viewHighscores";
            this.viewHighscores.Size = new System.Drawing.Size(332, 100);
            this.viewHighscores.TabIndex = 24;
            this.viewHighscores.Text = "View Highscores";
            this.viewHighscores.UseVisualStyleBackColor = false;
            this.viewHighscores.Click += new System.EventHandler(this.viewHighscores_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // planetLabel
            // 
            this.planetLabel.AutoSize = true;
            this.planetLabel.BackColor = System.Drawing.Color.Transparent;
            this.planetLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetLabel.ForeColor = System.Drawing.Color.White;
            this.planetLabel.Location = new System.Drawing.Point(35, 31);
            this.planetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.planetLabel.Name = "planetLabel";
            this.planetLabel.Size = new System.Drawing.Size(314, 53);
            this.planetLabel.TabIndex = 30;
            this.planetLabel.Text = "planetLabel";
            // 
            // displayHelp
            // 
            this.displayHelp.Font = new System.Drawing.Font("Showcard Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayHelp.Location = new System.Drawing.Point(2188, 260);
            this.displayHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayHelp.Name = "displayHelp";
            this.displayHelp.Size = new System.Drawing.Size(324, 44);
            this.displayHelp.TabIndex = 31;
            this.displayHelp.Text = "HELP";
            this.displayHelp.UseVisualStyleBackColor = true;
            this.displayHelp.Click += new System.EventHandler(this.displayHelp_Click);
            // 
            // southEastButton
            // 
            this.southEastButton.BackColor = System.Drawing.Color.Red;
            this.southEastButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.southEastButton.ForeColor = System.Drawing.Color.Transparent;
            this.southEastButton.Location = new System.Drawing.Point(1616, 254);
            this.southEastButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.southEastButton.Name = "southEastButton";
            this.southEastButton.Size = new System.Drawing.Size(613, 644);
            this.southEastButton.TabIndex = 19;
            this.southEastButton.UseVisualStyleBackColor = true;
            this.southEastButton.Click += new System.EventHandler(this.southEastButton_Click);
            // 
            // southButton
            // 
            this.southButton.BackColor = System.Drawing.Color.Red;
            this.southButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.southButton.ForeColor = System.Drawing.Color.Transparent;
            this.southButton.Location = new System.Drawing.Point(680, 588);
            this.southButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(736, 922);
            this.southButton.TabIndex = 19;
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // northWestButton
            // 
            this.northWestButton.BackColor = System.Drawing.Color.Red;
            this.northWestButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.northWestButton.ForeColor = System.Drawing.Color.Transparent;
            this.northWestButton.Location = new System.Drawing.Point(35, -60);
            this.northWestButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.northWestButton.Name = "northWestButton";
            this.northWestButton.Size = new System.Drawing.Size(635, 690);
            this.northWestButton.TabIndex = 19;
            this.northWestButton.UseVisualStyleBackColor = true;
            this.northWestButton.Click += new System.EventHandler(this.northWestButton_Click);
            // 
            // southWestButton
            // 
            this.southWestButton.BackColor = System.Drawing.Color.Red;
            this.southWestButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.southWestButton.ForeColor = System.Drawing.Color.Transparent;
            this.southWestButton.Location = new System.Drawing.Point(-37, 265);
            this.southWestButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.southWestButton.Name = "southWestButton";
            this.southWestButton.Size = new System.Drawing.Size(707, 619);
            this.southWestButton.TabIndex = 19;
            this.southWestButton.UseVisualStyleBackColor = true;
            this.southWestButton.Click += new System.EventHandler(this.southWestButton_Click);
            // 
            // northEastButton
            // 
            this.northEastButton.BackColor = System.Drawing.Color.Red;
            this.northEastButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.northEastButton.ForeColor = System.Drawing.Color.Transparent;
            this.northEastButton.Location = new System.Drawing.Point(1616, -81);
            this.northEastButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.northEastButton.Name = "northEastButton";
            this.northEastButton.Size = new System.Drawing.Size(708, 738);
            this.northEastButton.TabIndex = 19;
            this.northEastButton.UseVisualStyleBackColor = true;
            this.northEastButton.Click += new System.EventHandler(this.northEastButton_Click);
            // 
            // northButton
            // 
            this.northButton.BackColor = System.Drawing.Color.Red;
            this.northButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.northButton.ForeColor = System.Drawing.Color.Transparent;
            this.northButton.Location = new System.Drawing.Point(510, -195);
            this.northButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(659, 719);
            this.northButton.TabIndex = 19;
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // displayHelp
            // 
            this.displayHelp.Font = new System.Drawing.Font("Showcard Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayHelp.Location = new System.Drawing.Point(1641, 208);
            this.displayHelp.Margin = new System.Windows.Forms.Padding(2);
            this.displayHelp.Name = "displayHelp";
            this.displayHelp.Size = new System.Drawing.Size(243, 35);
            this.displayHelp.TabIndex = 31;
            this.displayHelp.Text = "HELP";
            this.displayHelp.UseVisualStyleBackColor = true;
            this.displayHelp.Click += new System.EventHandler(this.displayHelp_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wumpus.Properties.Resources.startBackgroundCrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.displayHelp);
            this.Controls.Add(this.planetLabel);
            this.Controls.Add(this.viewHighscores);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.laserPicture);
            this.Controls.Add(this.buySecretButton);
            this.Controls.Add(this.ShootArrowButton);
            this.Controls.Add(this.PurchaseArrowsButton);
            this.Controls.Add(this.SouthWestRoomsLabel);
            this.Controls.Add(this.SouthEastRoomsLabel);
            this.Controls.Add(this.SouthRoomsLabel);
            this.Controls.Add(this.NorthWestRoomsLabel);
            this.Controls.Add(this.NorthEastRoomsLabel);
            this.Controls.Add(this.NorthRoomsLabel);
            this.Controls.Add(this.NumberOfArrowsLabel);
            this.Controls.Add(this.NumberOfCoinsLabel);
            this.Controls.Add(this.southEastButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.northWestButton);
            this.Controls.Add(this.southWestButton);
            this.Controls.Add(this.northEastButton);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.spaceshipPicture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.laserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceshipPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NumberOfCoinsLabel;
        private System.Windows.Forms.Label NumberOfArrowsLabel;
        private System.Windows.Forms.Label NorthRoomsLabel;
        private System.Windows.Forms.Label NorthEastRoomsLabel;
        private System.Windows.Forms.Label NorthWestRoomsLabel;
        private System.Windows.Forms.Label SouthRoomsLabel;
        private System.Windows.Forms.Label SouthEastRoomsLabel;
        private System.Windows.Forms.Label SouthWestRoomsLabel;
        private System.Windows.Forms.Button PurchaseArrowsButton;
        private System.Windows.Forms.Button ShootArrowButton;
        private System.Windows.Forms.Button PurchaseSecretButton;
        private RoundButton northButton;
        private RoundButton northEastButton;
        private RoundButton northWestButton;
        private RoundButton southButton;
        private RoundButton southWestButton;
        private RoundButton southEastButton;
        private System.Windows.Forms.Button buySecretButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox laserPicture;
        private System.Windows.Forms.PictureBox spaceshipPicture;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button viewHighscores;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label planetLabel;
        private System.Windows.Forms.Button displayHelp;
    }
}