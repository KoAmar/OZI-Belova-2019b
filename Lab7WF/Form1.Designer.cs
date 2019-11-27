namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxForEncryptedTextBox2 = new System.Windows.Forms.CheckBox();
            this.labelCryptedText = new System.Windows.Forms.Label();
            this.encryptedTextBox2 = new System.Windows.Forms.TextBox();
            this.openTextBox = new System.Windows.Forms.TextBox();
            this.labelOpenText = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxForEncryptedTextBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decryptedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.encryptedTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.storageNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createAndSaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxForEncryptedTextBox2);
            this.groupBox1.Controls.Add(this.labelCryptedText);
            this.groupBox1.Controls.Add(this.encryptedTextBox2);
            this.groupBox1.Controls.Add(this.openTextBox);
            this.groupBox1.Controls.Add(this.labelOpenText);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(628, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxForEncryptedTextBox2
            // 
            this.checkBoxForEncryptedTextBox2.AutoSize = true;
            this.checkBoxForEncryptedTextBox2.Location = new System.Drawing.Point(421, 23);
            this.checkBoxForEncryptedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxForEncryptedTextBox2.Name = "checkBoxForEncryptedTextBox2";
            this.checkBoxForEncryptedTextBox2.Size = new System.Drawing.Size(65, 21);
            this.checkBoxForEncryptedTextBox2.TabIndex = 18;
            this.checkBoxForEncryptedTextBox2.Text = "Bytes";
            this.checkBoxForEncryptedTextBox2.UseVisualStyleBackColor = true;
            this.checkBoxForEncryptedTextBox2.CheckedChanged += new System.EventHandler(this.checkBoxForEncryptedTextBox2_CheckedChanged);
            // 
            // labelCryptedText
            // 
            this.labelCryptedText.AutoSize = true;
            this.labelCryptedText.Location = new System.Drawing.Point(313, 25);
            this.labelCryptedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCryptedText.Name = "labelCryptedText";
            this.labelCryptedText.Size = new System.Drawing.Size(98, 17);
            this.labelCryptedText.TabIndex = 3;
            this.labelCryptedText.Text = "Encrypted text";
            // 
            // encryptedTextBox2
            // 
            this.encryptedTextBox2.Location = new System.Drawing.Point(317, 46);
            this.encryptedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.encryptedTextBox2.Multiline = true;
            this.encryptedTextBox2.Name = "encryptedTextBox2";
            this.encryptedTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.encryptedTextBox2.Size = new System.Drawing.Size(295, 122);
            this.encryptedTextBox2.TabIndex = 2;
            // 
            // openTextBox
            // 
            this.openTextBox.Location = new System.Drawing.Point(13, 46);
            this.openTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.openTextBox.Multiline = true;
            this.openTextBox.Name = "openTextBox";
            this.openTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.openTextBox.Size = new System.Drawing.Size(295, 122);
            this.openTextBox.TabIndex = 1;
            this.openTextBox.Text = "hello";
            // 
            // labelOpenText
            // 
            this.labelOpenText.AutoSize = true;
            this.labelOpenText.Location = new System.Drawing.Point(9, 25);
            this.labelOpenText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpenText.Name = "labelOpenText";
            this.labelOpenText.Size = new System.Drawing.Size(69, 17);
            this.labelOpenText.TabIndex = 0;
            this.labelOpenText.Text = "Open text";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(166, 278);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(100, 28);
            this.decryptButton.TabIndex = 13;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(28, 278);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(4);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(100, 28);
            this.encryptButton.TabIndex = 12;
            this.encryptButton.Text = "Enrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxForEncryptedTextBox1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.decryptedTextBox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.encryptedTextBox1);
            this.groupBox5.Location = new System.Drawing.Point(16, 366);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(628, 171);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // checkBoxForEncryptedTextBox1
            // 
            this.checkBoxForEncryptedTextBox1.AutoSize = true;
            this.checkBoxForEncryptedTextBox1.Location = new System.Drawing.Point(101, 17);
            this.checkBoxForEncryptedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxForEncryptedTextBox1.Name = "checkBoxForEncryptedTextBox1";
            this.checkBoxForEncryptedTextBox1.Size = new System.Drawing.Size(65, 21);
            this.checkBoxForEncryptedTextBox1.TabIndex = 9;
            this.checkBoxForEncryptedTextBox1.Text = "Bytes";
            this.checkBoxForEncryptedTextBox1.UseVisualStyleBackColor = true;
            this.checkBoxForEncryptedTextBox1.CheckedChanged += new System.EventHandler(this.checkBoxForEncryptedTextBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Decrypted text";
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(312, 38);
            this.decryptedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.decryptedTextBox.Multiline = true;
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.decryptedTextBox.Size = new System.Drawing.Size(295, 122);
            this.decryptedTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Encrypted text";
            // 
            // encryptedTextBox1
            // 
            this.encryptedTextBox1.Location = new System.Drawing.Point(8, 38);
            this.encryptedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.encryptedTextBox1.Multiline = true;
            this.encryptedTextBox1.Name = "encryptedTextBox1";
            this.encryptedTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.encryptedTextBox1.Size = new System.Drawing.Size(295, 122);
            this.encryptedTextBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(128, 60);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KeySize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "4096";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(166, 211);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(173, 60);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saving Place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User container";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(669, 165);
            this.infoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoTextBox.Size = new System.Drawing.Size(400, 306);
            this.infoTextBox.TabIndex = 17;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(828, 488);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // storageNameTextBox
            // 
            this.storageNameTextBox.Location = new System.Drawing.Point(762, 72);
            this.storageNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.storageNameTextBox.Name = "storageNameTextBox";
            this.storageNameTextBox.Size = new System.Drawing.Size(187, 22);
            this.storageNameTextBox.TabIndex = 22;
            this.storageNameTextBox.Text = "MyContainer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Container name";
            // 
            // createAndSaveButton
            // 
            this.createAndSaveButton.Location = new System.Drawing.Point(762, 117);
            this.createAndSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.createAndSaveButton.Name = "createAndSaveButton";
            this.createAndSaveButton.Size = new System.Drawing.Size(188, 28);
            this.createAndSaveButton.TabIndex = 23;
            this.createAndSaveButton.Text = "Save";
            this.createAndSaveButton.UseVisualStyleBackColor = true;
            this.createAndSaveButton.Click += new System.EventHandler(this.createAndSaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 548);
            this.Controls.Add(this.storageNameTextBox);
            this.Controls.Add(this.createAndSaveButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LR #7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label labelCryptedText;
        private System.Windows.Forms.TextBox encryptedTextBox2;
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.Label labelOpenText;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox decryptedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox encryptedTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.CheckBox checkBoxForEncryptedTextBox1;
        private System.Windows.Forms.CheckBox checkBoxForEncryptedTextBox2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button createAndSaveButton;
        private System.Windows.Forms.TextBox storageNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

