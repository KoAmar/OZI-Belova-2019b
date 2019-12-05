namespace Lab7
{
    partial class Main
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
            this.labelCryptedText = new System.Windows.Forms.Label();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.labelOpenText = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelKeySize = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelNameOfContainer = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.storageNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createAndSaveButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCryptedText
            // 
            this.labelCryptedText.AutoSize = true;
            this.labelCryptedText.Location = new System.Drawing.Point(644, 9);
            this.labelCryptedText.Name = "labelCryptedText";
            this.labelCryptedText.Size = new System.Drawing.Size(123, 13);
            this.labelCryptedText.TabIndex = 3;
            this.labelCryptedText.Text = "Зашифрованный текст";
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(466, 28);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.encryptedTextBox.Size = new System.Drawing.Size(301, 265);
            this.encryptedTextBox.TabIndex = 2;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 25);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageTextBox.Size = new System.Drawing.Size(301, 265);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Text = "Hello world";
            // 
            // labelOpenText
            // 
            this.labelOpenText.AutoSize = true;
            this.labelOpenText.Location = new System.Drawing.Point(9, 9);
            this.labelOpenText.Name = "labelOpenText";
            this.labelOpenText.Size = new System.Drawing.Size(139, 13);
            this.labelOpenText.TabIndex = 0;
            this.labelOpenText.Text = "Не зашифрованный текст";
            // 
            // decryptButton
            // 
            this.decryptButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.decryptButton.Image = global::Lab7.Properties.Resources._1486348529_back_backwards_repeat_arrows_arrow_80455;
            this.decryptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decryptButton.Location = new System.Drawing.Point(319, 195);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(141, 61);
            this.decryptButton.TabIndex = 13;
            this.decryptButton.Text = "Расшифровать";
            this.decryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelKeySize);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 49);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размер ключа";
            // 
            // labelKeySize
            // 
            this.labelKeySize.AutoSize = true;
            this.labelKeySize.Location = new System.Drawing.Point(8, 23);
            this.labelKeySize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKeySize.Name = "labelKeySize";
            this.labelKeySize.Size = new System.Drawing.Size(31, 13);
            this.labelKeySize.TabIndex = 3;
            this.labelKeySize.Text = "2048";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelNameOfContainer);
            this.groupBox3.Location = new System.Drawing.Point(637, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 49);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Место хранения";
            // 
            // labelNameOfContainer
            // 
            this.labelNameOfContainer.AutoSize = true;
            this.labelNameOfContainer.Location = new System.Drawing.Point(5, 23);
            this.labelNameOfContainer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameOfContainer.Name = "labelNameOfContainer";
            this.labelNameOfContainer.Size = new System.Drawing.Size(91, 13);
            this.labelNameOfContainer.TabIndex = 2;
            this.labelNameOfContainer.Text = "MachineKeyStore";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 354);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoTextBox.Size = new System.Drawing.Size(755, 244);
            this.infoTextBox.TabIndex = 17;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(319, 312);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(141, 36);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Отчистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // storageNameTextBox
            // 
            this.storageNameTextBox.Location = new System.Drawing.Point(319, 52);
            this.storageNameTextBox.Name = "storageNameTextBox";
            this.storageNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.storageNameTextBox.TabIndex = 22;
            this.storageNameTextBox.Text = "Default";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Название контейнера";
            // 
            // createAndSaveButton
            // 
            this.createAndSaveButton.Location = new System.Drawing.Point(319, 78);
            this.createAndSaveButton.Name = "createAndSaveButton";
            this.createAndSaveButton.Size = new System.Drawing.Size(141, 23);
            this.createAndSaveButton.TabIndex = 23;
            this.createAndSaveButton.Text = "Сохранить";
            this.createAndSaveButton.UseVisualStyleBackColor = true;
            this.createAndSaveButton.Click += new System.EventHandler(this.createAndSaveButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Image = global::Lab7.Properties.Resources._1486348528_forward_arrows_arrow_front_go_80452;
            this.encryptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptButton.Location = new System.Drawing.Point(319, 128);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(141, 61);
            this.encryptButton.TabIndex = 12;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 607);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.labelOpenText);
            this.Controls.Add(this.storageNameTextBox);
            this.Controls.Add(this.labelCryptedText);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.createAndSaveButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Lab7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label labelCryptedText;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label labelOpenText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button createAndSaveButton;
        private System.Windows.Forms.TextBox storageNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKeySize;
        private System.Windows.Forms.Label labelNameOfContainer;
    }
}

