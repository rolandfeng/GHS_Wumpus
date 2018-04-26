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
            this.northButton = new System.Windows.Forms.Button();
            this.northEastButton = new System.Windows.Forms.Button();
            this.southWestButton = new System.Windows.Forms.Button();
            this.northWestButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.southEastButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(269, 149);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(75, 23);
            this.northButton.TabIndex = 0;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // northEastButton
            // 
            this.northEastButton.Location = new System.Drawing.Point(269, 193);
            this.northEastButton.Name = "northEastButton";
            this.northEastButton.Size = new System.Drawing.Size(75, 23);
            this.northEastButton.TabIndex = 1;
            this.northEastButton.Text = "Northeast";
            this.northEastButton.UseVisualStyleBackColor = true;
            this.northEastButton.Click += new System.EventHandler(this.northEastButton_Click);
            // 
            // southWestButton
            // 
            this.southWestButton.Location = new System.Drawing.Point(269, 332);
            this.southWestButton.Name = "southWestButton";
            this.southWestButton.Size = new System.Drawing.Size(75, 23);
            this.southWestButton.TabIndex = 2;
            this.southWestButton.Text = "Southwest";
            this.southWestButton.UseVisualStyleBackColor = true;
            this.southWestButton.Click += new System.EventHandler(this.southWestButton_Click);
            // 
            // northWestButton
            // 
            this.northWestButton.Location = new System.Drawing.Point(269, 385);
            this.northWestButton.Name = "northWestButton";
            this.northWestButton.Size = new System.Drawing.Size(75, 23);
            this.northWestButton.TabIndex = 3;
            this.northWestButton.Text = "Northwest";
            this.northWestButton.UseVisualStyleBackColor = true;
            this.northWestButton.Click += new System.EventHandler(this.northWestButton_Click);
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(269, 283);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(75, 23);
            this.southButton.TabIndex = 4;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // southEastButton
            // 
            this.southEastButton.Location = new System.Drawing.Point(269, 237);
            this.southEastButton.Name = "southEastButton";
            this.southEastButton.Size = new System.Drawing.Size(75, 23);
            this.southEastButton.TabIndex = 5;
            this.southEastButton.Text = "Southeast";
            this.southEastButton.UseVisualStyleBackColor = true;
            this.southEastButton.Click += new System.EventHandler(this.southEastButton_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 586);
            this.Controls.Add(this.southEastButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.northWestButton);
            this.Controls.Add(this.southWestButton);
            this.Controls.Add(this.northEastButton);
            this.Controls.Add(this.northButton);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button northEastButton;
        private System.Windows.Forms.Button southWestButton;
        private System.Windows.Forms.Button northWestButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button southEastButton;
    }
}