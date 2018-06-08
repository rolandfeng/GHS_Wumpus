namespace wumpus.forms
{
    partial class MapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.closeMap = new System.Windows.Forms.Button();
            this.astronaut = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.astronaut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeMap
            // 
            this.closeMap.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMap.Location = new System.Drawing.Point(33, 542);
            this.closeMap.Name = "closeMap";
            this.closeMap.Size = new System.Drawing.Size(103, 50);
            this.closeMap.TabIndex = 30;
            this.closeMap.Text = "Close";
            this.closeMap.UseVisualStyleBackColor = true;
            this.closeMap.Click += new System.EventHandler(this.closeMap_Click);
            // 
            // astronaut
            // 
            this.astronaut.BackColor = System.Drawing.Color.Transparent;
            this.astronaut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("astronaut.BackgroundImage")));
            this.astronaut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.astronaut.Location = new System.Drawing.Point(61, 61);
            this.astronaut.Name = "astronaut";
            this.astronaut.Size = new System.Drawing.Size(100, 100);
            this.astronaut.TabIndex = 31;
            this.astronaut.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 540);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 572);
            this.Controls.Add(this.astronaut);
            this.Controls.Add(this.closeMap);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(697, 643);
            this.MinimumSize = new System.Drawing.Size(697, 643);
            this.Name = "MapForm";
            this.Text = "Map";
            ((System.ComponentModel.ISupportInitialize)(this.astronaut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeMap;
        private System.Windows.Forms.PictureBox astronaut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}