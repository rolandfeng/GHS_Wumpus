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
            this.laserNorthPicture = new System.Windows.Forms.PictureBox();
            this.spaceshipPicture = new System.Windows.Forms.PictureBox();
            this.southEastButton = new RoundButton();
            this.southButton = new RoundButton();
            this.northWestButton = new RoundButton();
            this.southWestButton = new RoundButton();
            this.northEastButton = new RoundButton();
            this.northButton = new RoundButton();
            this.playAgain = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.viewHighscores = new System.Windows.Forms.Button();
            this.laserSouthPicture = new System.Windows.Forms.PictureBox();
            this.laserNorthWestPicture = new System.Windows.Forms.PictureBox();
            this.laserSouthEastPicture = new System.Windows.Forms.PictureBox();
            this.laserSouthWestPicture = new System.Windows.Forms.PictureBox();
            this.laserNorthEastPicture = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.laserNorthPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceshipPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserSouthPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserNorthWestPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserSouthEastPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserSouthWestPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserNorthEastPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfCoinsLabel
            // 
            this.NumberOfCoinsLabel.AutoSize = true;
            this.NumberOfCoinsLabel.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfCoinsLabel.Location = new System.Drawing.Point(1670, 15);
            this.NumberOfCoinsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfCoinsLabel.Name = "NumberOfCoinsLabel";
            this.NumberOfCoinsLabel.Size = new System.Drawing.Size(167, 20);
            this.NumberOfCoinsLabel.TabIndex = 6;
            this.NumberOfCoinsLabel.Text = "Number of Coins";
            // 
            // NumberOfArrowsLabel
            // 
            this.NumberOfArrowsLabel.AutoSize = true;
            this.NumberOfArrowsLabel.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfArrowsLabel.Location = new System.Drawing.Point(1660, 52);
            this.NumberOfArrowsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfArrowsLabel.Name = "NumberOfArrowsLabel";
            this.NumberOfArrowsLabel.Size = new System.Drawing.Size(176, 20);
            this.NumberOfArrowsLabel.TabIndex = 7;
            this.NumberOfArrowsLabel.Text = "Number of Lasers\r\n";
            // 
            // NorthRoomsLabel
            // 
            this.NorthRoomsLabel.AutoSize = true;
            this.NorthRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NorthRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.NorthRoomsLabel.Location = new System.Drawing.Point(862, 52);
            this.NorthRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NorthRoomsLabel.Name = "NorthRoomsLabel";
            this.NorthRoomsLabel.Size = new System.Drawing.Size(61, 40);
            this.NorthRoomsLabel.TabIndex = 8;
            this.NorthRoomsLabel.Text = "NN";
            // 
            // NorthEastRoomsLabel
            // 
            this.NorthEastRoomsLabel.AutoSize = true;
            this.NorthEastRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NorthEastRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthEastRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.NorthEastRoomsLabel.Location = new System.Drawing.Point(1666, 282);
            this.NorthEastRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NorthEastRoomsLabel.Name = "NorthEastRoomsLabel";
            this.NorthEastRoomsLabel.Size = new System.Drawing.Size(58, 40);
            this.NorthEastRoomsLabel.TabIndex = 9;
            this.NorthEastRoomsLabel.Text = "NE";
            // 
            // NorthWestRoomsLabel
            // 
            this.NorthWestRoomsLabel.AutoSize = true;
            this.NorthWestRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NorthWestRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthWestRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.NorthWestRoomsLabel.Location = new System.Drawing.Point(140, 310);
            this.NorthWestRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NorthWestRoomsLabel.Name = "NorthWestRoomsLabel";
            this.NorthWestRoomsLabel.Size = new System.Drawing.Size(73, 40);
            this.NorthWestRoomsLabel.TabIndex = 10;
            this.NorthWestRoomsLabel.Text = "NW";
            // 
            // SouthRoomsLabel
            // 
            this.SouthRoomsLabel.AutoSize = true;
            this.SouthRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SouthRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.SouthRoomsLabel.Location = new System.Drawing.Point(862, 898);
            this.SouthRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SouthRoomsLabel.Name = "SouthRoomsLabel";
            this.SouthRoomsLabel.Size = new System.Drawing.Size(51, 40);
            this.SouthRoomsLabel.TabIndex = 11;
            this.SouthRoomsLabel.Text = "SS";
            // 
            // SouthEastRoomsLabel
            // 
            this.SouthEastRoomsLabel.AutoSize = true;
            this.SouthEastRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SouthEastRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthEastRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.SouthEastRoomsLabel.Location = new System.Drawing.Point(1666, 570);
            this.SouthEastRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SouthEastRoomsLabel.Name = "SouthEastRoomsLabel";
            this.SouthEastRoomsLabel.Size = new System.Drawing.Size(54, 40);
            this.SouthEastRoomsLabel.TabIndex = 12;
            this.SouthEastRoomsLabel.Text = "SE";
            // 
            // SouthWestRoomsLabel
            // 
            this.SouthWestRoomsLabel.AutoSize = true;
            this.SouthWestRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SouthWestRoomsLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthWestRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.SouthWestRoomsLabel.Location = new System.Drawing.Point(159, 592);
            this.SouthWestRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SouthWestRoomsLabel.Name = "SouthWestRoomsLabel";
            this.SouthWestRoomsLabel.Size = new System.Drawing.Size(69, 40);
            this.SouthWestRoomsLabel.TabIndex = 13;
            this.SouthWestRoomsLabel.Text = "SW";
            // 
            // PurchaseArrowsButton
            // 
            this.PurchaseArrowsButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseArrowsButton.Location = new System.Drawing.Point(1641, 92);
            this.PurchaseArrowsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PurchaseArrowsButton.Name = "PurchaseArrowsButton";
            this.PurchaseArrowsButton.Size = new System.Drawing.Size(243, 35);
            this.PurchaseArrowsButton.TabIndex = 15;
            this.PurchaseArrowsButton.Text = "Purchase Lasers";
            this.PurchaseArrowsButton.UseVisualStyleBackColor = true;
            this.PurchaseArrowsButton.Click += new System.EventHandler(this.PurchaseArrowsButton_Click);
            // 
            // ShootArrowButton
            // 
            this.ShootArrowButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootArrowButton.Location = new System.Drawing.Point(1641, 138);
            this.ShootArrowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShootArrowButton.Name = "ShootArrowButton";
            this.ShootArrowButton.Size = new System.Drawing.Size(243, 35);
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
            this.buySecretButton.Location = new System.Drawing.Point(1641, 183);
            this.buySecretButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buySecretButton.Name = "buySecretButton";
            this.buySecretButton.Size = new System.Drawing.Size(243, 35);
            this.buySecretButton.TabIndex = 17;
            this.buySecretButton.Text = "Purchase Secret";
            this.buySecretButton.UseVisualStyleBackColor = true;
            this.buySecretButton.Click += new System.EventHandler(this.buySecretButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // laserNorthPicture
            // 
            this.laserNorthPicture.BackColor = System.Drawing.Color.Transparent;
            this.laserNorthPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("laserNorthPicture.ErrorImage")));
            this.laserNorthPicture.Image = ((System.Drawing.Image)(resources.GetObject("laserNorthPicture.Image")));
            this.laserNorthPicture.Location = new System.Drawing.Point(824, 310);
            this.laserNorthPicture.Name = "laserNorthPicture";
            this.laserNorthPicture.Size = new System.Drawing.Size(77, 54);
            this.laserNorthPicture.TabIndex = 20;
            this.laserNorthPicture.TabStop = false;
            // 
            // spaceshipPicture
            // 
            this.spaceshipPicture.BackColor = System.Drawing.Color.Transparent;
            this.spaceshipPicture.Image = ((System.Drawing.Image)(resources.GetObject("spaceshipPicture.Image")));
            this.spaceshipPicture.Location = new System.Drawing.Point(800, 400);
            this.spaceshipPicture.Name = "spaceshipPicture";
            this.spaceshipPicture.Size = new System.Drawing.Size(183, 155);
            this.spaceshipPicture.TabIndex = 21;
            this.spaceshipPicture.TabStop = false;
            // 
            // southEastButton
            // 
            this.southEastButton.BackColor = System.Drawing.Color.Red;
            this.southEastButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.southEastButton.ForeColor = System.Drawing.Color.Transparent;
            this.southEastButton.Location = new System.Drawing.Point(1212, 203);
            this.southEastButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.southEastButton.Name = "southEastButton";
            this.southEastButton.Size = new System.Drawing.Size(460, 515);
            this.southEastButton.TabIndex = 19;
            this.southEastButton.UseVisualStyleBackColor = true;
            this.southEastButton.Click += new System.EventHandler(this.southEastButton_Click);
            // 
            // southButton
            // 
            this.southButton.BackColor = System.Drawing.Color.Red;
            this.southButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.southButton.ForeColor = System.Drawing.Color.Transparent;
            this.southButton.Location = new System.Drawing.Point(510, 470);
            this.southButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(552, 738);
            this.southButton.TabIndex = 19;
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // northWestButton
            // 
            this.northWestButton.BackColor = System.Drawing.Color.Red;
            this.northWestButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.northWestButton.ForeColor = System.Drawing.Color.Transparent;
            this.northWestButton.Location = new System.Drawing.Point(26, -48);
            this.northWestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.northWestButton.Name = "northWestButton";
            this.northWestButton.Size = new System.Drawing.Size(476, 552);
            this.northWestButton.TabIndex = 19;
            this.northWestButton.UseVisualStyleBackColor = true;
            this.northWestButton.Click += new System.EventHandler(this.northWestButton_Click);
            // 
            // southWestButton
            // 
            this.southWestButton.BackColor = System.Drawing.Color.Red;
            this.southWestButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.southWestButton.ForeColor = System.Drawing.Color.Transparent;
            this.southWestButton.Location = new System.Drawing.Point(-28, 212);
            this.southWestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.southWestButton.Name = "southWestButton";
            this.southWestButton.Size = new System.Drawing.Size(530, 495);
            this.southWestButton.TabIndex = 19;
            this.southWestButton.UseVisualStyleBackColor = true;
            this.southWestButton.Click += new System.EventHandler(this.southWestButton_Click);
            // 
            // northEastButton
            // 
            this.northEastButton.BackColor = System.Drawing.Color.Red;
            this.northEastButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.northEastButton.ForeColor = System.Drawing.Color.Transparent;
            this.northEastButton.Location = new System.Drawing.Point(1212, -65);
            this.northEastButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.northEastButton.Name = "northEastButton";
            this.northEastButton.Size = new System.Drawing.Size(531, 590);
            this.northEastButton.TabIndex = 19;
            this.northEastButton.UseVisualStyleBackColor = true;
            this.northEastButton.Click += new System.EventHandler(this.northEastButton_Click);
            // 
            // northButton
            // 
            this.northButton.BackColor = System.Drawing.Color.Red;
            this.northButton.BackgroundImage = global::wumpus.Properties.Resources.planet1;
            this.northButton.ForeColor = System.Drawing.Color.Transparent;
            this.northButton.Location = new System.Drawing.Point(510, -168);
            this.northButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(494, 575);
            this.northButton.TabIndex = 19;
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // playAgain
            // 
            this.playAgain.AutoSize = true;
            this.playAgain.BackColor = System.Drawing.Color.Transparent;
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgain.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.ForeColor = System.Drawing.Color.White;
            this.playAgain.Location = new System.Drawing.Point(510, 399);
            this.playAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(188, 80);
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
            this.quitButton.Location = new System.Drawing.Point(1160, 400);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(188, 80);
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
            this.viewHighscores.Location = new System.Drawing.Point(833, 399);
            this.viewHighscores.Margin = new System.Windows.Forms.Padding(2);
            this.viewHighscores.Name = "viewHighscores";
            this.viewHighscores.Size = new System.Drawing.Size(238, 80);
            this.viewHighscores.TabIndex = 24;
            this.viewHighscores.Text = "View Highscores";
            this.viewHighscores.UseVisualStyleBackColor = false;
            this.viewHighscores.Click += new System.EventHandler(this.viewHighscores_Click);
            // 
            // laserSouthPicture
            // 
            this.laserSouthPicture.BackColor = System.Drawing.Color.Transparent;
            this.laserSouthPicture.Image = ((System.Drawing.Image)(resources.GetObject("laserSouthPicture.Image")));
            this.laserSouthPicture.Location = new System.Drawing.Point(824, 515);
            this.laserSouthPicture.Name = "laserSouthPicture";
            this.laserSouthPicture.Size = new System.Drawing.Size(87, 56);
            this.laserSouthPicture.TabIndex = 25;
            this.laserSouthPicture.TabStop = false;
            // 
            // laserNorthWestPicture
            // 
            this.laserNorthWestPicture.BackColor = System.Drawing.Color.Transparent;
            this.laserNorthWestPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("laserNorthWestPicture.BackgroundImage")));
            this.laserNorthWestPicture.Location = new System.Drawing.Point(718, 379);
            this.laserNorthWestPicture.Name = "laserNorthWestPicture";
            this.laserNorthWestPicture.Size = new System.Drawing.Size(76, 46);
            this.laserNorthWestPicture.TabIndex = 26;
            this.laserNorthWestPicture.TabStop = false;
            // 
            // laserSouthEastPicture
            // 
            this.laserSouthEastPicture.BackColor = System.Drawing.Color.Transparent;
            this.laserSouthEastPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("laserSouthEastPicture.BackgroundImage")));
            this.laserSouthEastPicture.Location = new System.Drawing.Point(939, 464);
            this.laserSouthEastPicture.Name = "laserSouthEastPicture";
            this.laserSouthEastPicture.Size = new System.Drawing.Size(81, 46);
            this.laserSouthEastPicture.TabIndex = 27;
            this.laserSouthEastPicture.TabStop = false;
            // 
            // laserSouthWestPicture
            // 
            this.laserSouthWestPicture.BackColor = System.Drawing.Color.Transparent;
            this.laserSouthWestPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("laserSouthWestPicture.BackgroundImage")));
            this.laserSouthWestPicture.Location = new System.Drawing.Point(718, 464);
            this.laserSouthWestPicture.Name = "laserSouthWestPicture";
            this.laserSouthWestPicture.Size = new System.Drawing.Size(76, 46);
            this.laserSouthWestPicture.TabIndex = 28;
            this.laserSouthWestPicture.TabStop = false;
            // 
            // laserNorthEastPicture
            // 
            this.laserNorthEastPicture.BackColor = System.Drawing.Color.Transparent;
            this.laserNorthEastPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("laserNorthEastPicture.BackgroundImage")));
            this.laserNorthEastPicture.Location = new System.Drawing.Point(939, 379);
            this.laserNorthEastPicture.Name = "laserNorthEastPicture";
            this.laserNorthEastPicture.Size = new System.Drawing.Size(72, 46);
            this.laserNorthEastPicture.TabIndex = 29;
            this.laserNorthEastPicture.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wumpus.Properties.Resources.startBackgroundCrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 840);
            this.Controls.Add(this.laserNorthEastPicture);
            this.Controls.Add(this.laserSouthWestPicture);
            this.Controls.Add(this.laserSouthEastPicture);
            this.Controls.Add(this.laserNorthWestPicture);
            this.Controls.Add(this.laserSouthPicture);
            this.Controls.Add(this.viewHighscores);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.spaceshipPicture);
            this.Controls.Add(this.laserNorthPicture);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainGame";
            this.Text = "MainGame";
            ((System.ComponentModel.ISupportInitialize)(this.laserNorthPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceshipPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserSouthPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserNorthWestPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserSouthEastPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserSouthWestPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserNorthEastPicture)).EndInit();
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
        private System.Windows.Forms.PictureBox laserNorthPicture;
        private System.Windows.Forms.PictureBox spaceshipPicture;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button viewHighscores;
        private System.Windows.Forms.PictureBox laserSouthPicture;
        private System.Windows.Forms.PictureBox laserNorthWestPicture;
        private System.Windows.Forms.PictureBox laserSouthEastPicture;
        private System.Windows.Forms.PictureBox laserSouthWestPicture;
        private System.Windows.Forms.PictureBox laserNorthEastPicture;
        private System.Windows.Forms.Timer timer2;
    }
}