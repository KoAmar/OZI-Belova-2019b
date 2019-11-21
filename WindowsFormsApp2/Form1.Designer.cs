namespace WindowsFormsApp2
{
    partial class Form1
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
            this.plainText = new System.Windows.Forms.TextBox();
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.keyText = new System.Windows.Forms.TextBox();
            this.plainTextClearButton = new System.Windows.Forms.Button();
            this.encryptedTextClearButton = new System.Windows.Forms.Button();
            this.keySizeLabel = new System.Windows.Forms.Label();
            this.blockSizeLabel = new System.Windows.Forms.Label();
            this.cipherModeLabel = new System.Windows.Forms.Label();
            this.paddingModeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(48, 32);
            this.plainText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plainText.Multiline = true;
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(166, 82);
            this.plainText.TabIndex = 0;
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(48, 172);
            this.encryptedText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encryptedText.Multiline = true;
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(166, 82);
            this.encryptedText.TabIndex = 1;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(48, 118);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(68, 24);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(48, 258);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(68, 24);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(292, 200);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(31, 13);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Key: ";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(381, 268);
            this.generateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(68, 24);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // keyText
            // 
            this.keyText.Enabled = false;
            this.keyText.Location = new System.Drawing.Point(337, 197);
            this.keyText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyText.Multiline = true;
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(166, 57);
            this.keyText.TabIndex = 6;
            // 
            // plainTextClearButton
            // 
            this.plainTextClearButton.Location = new System.Drawing.Point(146, 118);
            this.plainTextClearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plainTextClearButton.Name = "plainTextClearButton";
            this.plainTextClearButton.Size = new System.Drawing.Size(68, 24);
            this.plainTextClearButton.TabIndex = 7;
            this.plainTextClearButton.Text = "Clear";
            this.plainTextClearButton.UseVisualStyleBackColor = true;
            this.plainTextClearButton.Click += new System.EventHandler(this.plainTextClearButton_Click);
            // 
            // encryptedTextClearButton
            // 
            this.encryptedTextClearButton.Location = new System.Drawing.Point(146, 258);
            this.encryptedTextClearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encryptedTextClearButton.Name = "encryptedTextClearButton";
            this.encryptedTextClearButton.Size = new System.Drawing.Size(68, 24);
            this.encryptedTextClearButton.TabIndex = 8;
            this.encryptedTextClearButton.Text = "Clear";
            this.encryptedTextClearButton.UseVisualStyleBackColor = true;
            this.encryptedTextClearButton.Click += new System.EventHandler(this.encryptedTextClearButton_Click);
            // 
            // keySizeLabel
            // 
            this.keySizeLabel.AutoSize = true;
            this.keySizeLabel.Location = new System.Drawing.Point(294, 32);
            this.keySizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keySizeLabel.Name = "keySizeLabel";
            this.keySizeLabel.Size = new System.Drawing.Size(58, 13);
            this.keySizeLabel.TabIndex = 9;
            this.keySizeLabel.Text = "Key size = ";
            // 
            // blockSizeLabel
            // 
            this.blockSizeLabel.AutoSize = true;
            this.blockSizeLabel.Location = new System.Drawing.Point(294, 54);
            this.blockSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blockSizeLabel.Name = "blockSizeLabel";
            this.blockSizeLabel.Size = new System.Drawing.Size(67, 13);
            this.blockSizeLabel.TabIndex = 10;
            this.blockSizeLabel.Text = "Block size = ";
            // 
            // cipherModeLabel
            // 
            this.cipherModeLabel.AutoSize = true;
            this.cipherModeLabel.Location = new System.Drawing.Point(294, 77);
            this.cipherModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cipherModeLabel.Name = "cipherModeLabel";
            this.cipherModeLabel.Size = new System.Drawing.Size(79, 13);
            this.cipherModeLabel.TabIndex = 11;
            this.cipherModeLabel.Text = "Cipher Mode = ";
            // 
            // paddingModeLabel
            // 
            this.paddingModeLabel.AutoSize = true;
            this.paddingModeLabel.Location = new System.Drawing.Point(294, 100);
            this.paddingModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paddingModeLabel.Name = "paddingModeLabel";
            this.paddingModeLabel.Size = new System.Drawing.Size(88, 13);
            this.paddingModeLabel.TabIndex = 12;
            this.paddingModeLabel.Text = "Padding Mode = ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 164);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 16);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Password:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Plain text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Encrypted text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valid keySize: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Valid keySize: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(600, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.paddingModeLabel);
            this.Controls.Add(this.cipherModeLabel);
            this.Controls.Add(this.blockSizeLabel);
            this.Controls.Add(this.keySizeLabel);
            this.Controls.Add(this.encryptedTextClearButton);
            this.Controls.Add(this.plainTextClearButton);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.plainText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "POKONECHNY LAB 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.TextBox encryptedText;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Button plainTextClearButton;
        private System.Windows.Forms.Button encryptedTextClearButton;
        private System.Windows.Forms.Label keySizeLabel;
        private System.Windows.Forms.Label blockSizeLabel;
        private System.Windows.Forms.Label cipherModeLabel;
        private System.Windows.Forms.Label paddingModeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

