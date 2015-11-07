namespace SortingStrings
{
    partial class stringsForm
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
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.stringLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.stringListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(34, 49);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(221, 20);
            this.stringTextBox.TabIndex = 0;
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.Location = new System.Drawing.Point(34, 30);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(195, 13);
            this.stringLabel.TabIndex = 1;
            this.stringLabel.Text = "Type in a string & then click Enter buttton";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(261, 46);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // stringListBox
            // 
            this.stringListBox.FormattingEnabled = true;
            this.stringListBox.Location = new System.Drawing.Point(37, 111);
            this.stringListBox.Name = "stringListBox";
            this.stringListBox.Size = new System.Drawing.Size(299, 199);
            this.stringListBox.TabIndex = 3;
            // 
            // stringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 349);
            this.Controls.Add(this.stringListBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.stringLabel);
            this.Controls.Add(this.stringTextBox);
            this.Name = "stringsForm";
            this.Text = "Sorting Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.ListBox stringListBox;
    }
}

