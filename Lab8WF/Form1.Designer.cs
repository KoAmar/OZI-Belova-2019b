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
            this.plainBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signatureBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hashBox = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signButton = new System.Windows.Forms.Button();
            this.unsignButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plainBox
            // 
            this.plainBox.Location = new System.Drawing.Point(11, 28);
            this.plainBox.Multiline = true;
            this.plainBox.Name = "plainBox";
            this.plainBox.Size = new System.Drawing.Size(386, 135);
            this.plainBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plain text:";
            // 
            // signatureBox
            // 
            this.signatureBox.Location = new System.Drawing.Point(12, 362);
            this.signatureBox.Multiline = true;
            this.signatureBox.Name = "signatureBox";
            this.signatureBox.Size = new System.Drawing.Size(386, 135);
            this.signatureBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Signature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hash:";
            // 
            // hashBox
            // 
            this.hashBox.Location = new System.Drawing.Point(11, 193);
            this.hashBox.Multiline = true;
            this.hashBox.Name = "hashBox";
            this.hashBox.Size = new System.Drawing.Size(386, 135);
            this.hashBox.TabIndex = 4;
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(432, 28);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoBox.Size = new System.Drawing.Size(356, 469);
            this.infoBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Info:";
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(16, 517);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(75, 23);
            this.signButton.TabIndex = 8;
            this.signButton.Text = "Sign";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // unsignButton
            // 
            this.unsignButton.Location = new System.Drawing.Point(112, 517);
            this.unsignButton.Name = "unsignButton";
            this.unsignButton.Size = new System.Drawing.Size(75, 23);
            this.unsignButton.TabIndex = 9;
            this.unsignButton.Text = "Verify";
            this.unsignButton.UseVisualStyleBackColor = true;
            this.unsignButton.Click += new System.EventHandler(this.unsignButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(210, 517);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.unsignButton);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hashBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signatureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainBox);
            this.Name = "Form1";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plainBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signatureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hashBox;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button unsignButton;
        private System.Windows.Forms.Button changeButton;
    }
}

