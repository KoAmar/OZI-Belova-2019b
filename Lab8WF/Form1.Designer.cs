namespace lab8_bel
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
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hashBox = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signButton = new System.Windows.Forms.Button();
            this.unsignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(8, 23);
            this.messageBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(290, 110);
            this.messageBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hash:";
            // 
            // hashBox
            // 
            this.hashBox.Location = new System.Drawing.Point(8, 157);
            this.hashBox.Margin = new System.Windows.Forms.Padding(2);
            this.hashBox.Multiline = true;
            this.hashBox.Name = "hashBox";
            this.hashBox.ReadOnly = true;
            this.hashBox.Size = new System.Drawing.Size(290, 62);
            this.hashBox.TabIndex = 4;
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.Control;
            this.infoBox.Location = new System.Drawing.Point(324, 23);
            this.infoBox.Margin = new System.Windows.Forms.Padding(2);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoBox.Size = new System.Drawing.Size(774, 382);
            this.infoBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Info:";
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(8, 235);
            this.signButton.Margin = new System.Windows.Forms.Padding(2);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(290, 77);
            this.signButton.TabIndex = 8;
            this.signButton.Text = "Sign";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // unsignButton
            // 
            this.unsignButton.Location = new System.Drawing.Point(9, 328);
            this.unsignButton.Margin = new System.Windows.Forms.Padding(2);
            this.unsignButton.Name = "unsignButton";
            this.unsignButton.Size = new System.Drawing.Size(289, 77);
            this.unsignButton.TabIndex = 9;
            this.unsignButton.Text = "Verify";
            this.unsignButton.UseVisualStyleBackColor = true;
            this.unsignButton.Click += new System.EventHandler(this.VerifySignatureButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 415);
            this.Controls.Add(this.unsignButton);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hashBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hashBox;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button unsignButton;
    }
}

