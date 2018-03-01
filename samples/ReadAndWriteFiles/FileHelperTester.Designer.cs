namespace ReadAndWriteFiles
{
    partial class FileHelperTester
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
            this.AddItemButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textInput = new System.Windows.Forms.TextBox();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LoadFromFileButton = new System.Windows.Forms.Button();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(425, 40);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(126, 23);
            this.AddItemButton.TabIndex = 0;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(219, 42);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(12, 42);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(110, 20);
            this.textInput.TabIndex = 2;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(139, 42);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(63, 20);
            this.numberInput.TabIndex = 3;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(11, 26);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(28, 13);
            this.TextLabel.TabIndex = 4;
            this.TextLabel.Text = "Text";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(136, 26);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(44, 13);
            this.NumberLabel.TabIndex = 5;
            this.NumberLabel.Text = "Number";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(216, 26);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Date";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 94);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(543, 199);
            this.listBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Items";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 299);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearItemsButton_Click);
            // 
            // LoadFromFileButton
            // 
            this.LoadFromFileButton.Location = new System.Drawing.Point(232, 299);
            this.LoadFromFileButton.Name = "LoadFromFileButton";
            this.LoadFromFileButton.Size = new System.Drawing.Size(110, 23);
            this.LoadFromFileButton.TabIndex = 10;
            this.LoadFromFileButton.Text = "Load From File";
            this.LoadFromFileButton.UseVisualStyleBackColor = true;
            this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Location = new System.Drawing.Point(104, 299);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(110, 23);
            this.SaveToFileButton.TabIndex = 11;
            this.SaveToFileButton.Text = "Save To File";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // FileHelperTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 339);
            this.Controls.Add(this.SaveToFileButton);
            this.Controls.Add(this.LoadFromFileButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.AddItemButton);
            this.Name = "FileHelperTester";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button LoadFromFileButton;
        private System.Windows.Forms.Button SaveToFileButton;
    }
}

