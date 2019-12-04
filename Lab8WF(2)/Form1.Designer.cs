namespace ClientApp
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
            this.components = new System.ComponentModel.Container();
            this.message = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.Hashlable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signatureValue = new System.Windows.Forms.TextBox();
            this.verifySignature = new System.Windows.Forms.Button();
            this.logsAfter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HashSizelable = new System.Windows.Forms.Label();
            this.PrivateKeylabel = new System.Windows.Forms.Label();
            this.KeySizelabel = new System.Windows.Forms.Label();
            this.PublicKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(75, 22);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(100, 20);
            this.message.TabIndex = 3;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(205, 22);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(117, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Create signature";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Hashlable
            // 
            this.Hashlable.AutoSize = true;
            this.Hashlable.Location = new System.Drawing.Point(72, 57);
            this.Hashlable.Name = "Hashlable";
            this.Hashlable.Size = new System.Drawing.Size(41, 13);
            this.Hashlable.TabIndex = 5;
            this.Hashlable.Text = "Hash:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Signature: ";
            // 
            // signatureValue
            // 
            this.signatureValue.Location = new System.Drawing.Point(75, 175);
            this.signatureValue.Name = "signatureValue";
            this.signatureValue.Size = new System.Drawing.Size(413, 20);
            this.signatureValue.TabIndex = 8;
            // 
            // verifySignature
            // 
            this.verifySignature.Location = new System.Drawing.Point(75, 214);
            this.verifySignature.Name = "verifySignature";
            this.verifySignature.Size = new System.Drawing.Size(117, 23);
            this.verifySignature.TabIndex = 9;
            this.verifySignature.Text = "Verify signature";
            this.verifySignature.UseVisualStyleBackColor = true;
            this.verifySignature.Click += new System.EventHandler(this.verifySignature_Click);
            // 
            // logsAfter
            // 
            this.logsAfter.Location = new System.Drawing.Point(75, 252);
            this.logsAfter.Multiline = true;
            this.logsAfter.Name = "logsAfter";
            this.logsAfter.Size = new System.Drawing.Size(413, 30);
            this.logsAfter.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Logs:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HashSizelable
            // 
            this.HashSizelable.AutoSize = true;
            this.HashSizelable.Location = new System.Drawing.Point(72, 79);
            this.HashSizelable.Name = "HashSizelable";
            this.HashSizelable.Size = new System.Drawing.Size(59, 13);
            this.HashSizelable.TabIndex = 13;
            this.HashSizelable.Text = "Hash size: ";
            // 
            // PrivateKeylabel
            // 
            this.PrivateKeylabel.AutoSize = true;
            this.PrivateKeylabel.Location = new System.Drawing.Point(72, 101);
            this.PrivateKeylabel.Name = "PrivateKeylabel";
            this.PrivateKeylabel.Size = new System.Drawing.Size(66, 13);
            this.PrivateKeylabel.TabIndex = 14;
            this.PrivateKeylabel.Text = "Private key: ";
            // 
            // KeySizelabel
            // 
            this.KeySizelabel.AutoSize = true;
            this.KeySizelabel.Location = new System.Drawing.Point(72, 145);
            this.KeySizelabel.Name = "KeySizelabel";
            this.KeySizelabel.Size = new System.Drawing.Size(52, 13);
            this.KeySizelabel.TabIndex = 15;
            this.KeySizelabel.Text = "Key size: ";
            // 
            // PublicKeyLabel
            // 
            this.PublicKeyLabel.AutoSize = true;
            this.PublicKeyLabel.Location = new System.Drawing.Point(72, 123);
            this.PublicKeyLabel.Name = "PublicKeyLabel";
            this.PublicKeyLabel.Size = new System.Drawing.Size(62, 13);
            this.PublicKeyLabel.TabIndex = 16;
            this.PublicKeyLabel.Text = "Public key: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 307);
            this.Controls.Add(this.PublicKeyLabel);
            this.Controls.Add(this.KeySizelabel);
            this.Controls.Add(this.PrivateKeylabel);
            this.Controls.Add(this.HashSizelable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logsAfter);
            this.Controls.Add(this.verifySignature);
            this.Controls.Add(this.signatureValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hashlable);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label Hashlable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signatureValue;
        private System.Windows.Forms.Button verifySignature;
        private System.Windows.Forms.TextBox logsAfter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label HashSizelable;
        private System.Windows.Forms.Label PrivateKeylabel;
        private System.Windows.Forms.Label KeySizelabel;
        private System.Windows.Forms.Label PublicKeyLabel;
    }
}

