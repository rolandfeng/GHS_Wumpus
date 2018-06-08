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
            ((System.ComponentModel.ISupportInitialize)(this.astronaut)).BeginInit();
            this.SuspendLayout();
            // 
            // closeMap
            // 
            this.closeMap.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMap.Location = new System.Drawing.Point(23, 555);
            this.closeMap.Name = "closeMap";
            this.closeMap.Size = new System.Drawing.Size(100, 37);
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
            this.astronaut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.astronaut.Location = new System.Drawing.Point(550, 481);
            this.astronaut.Name = "astronaut";
            this.astronaut.Size = new System.Drawing.Size(112, 112);
            this.astronaut.TabIndex = 31;
            this.astronaut.TabStop = false;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 601);
            this.Controls.Add(this.astronaut);
            this.Controls.Add(this.closeMap);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(697, 643);
            this.MinimumSize = new System.Drawing.Size(697, 640);
            this.Name = "MapForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.astronaut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeMap;
        private System.Windows.Forms.PictureBox astronaut;
    }
}