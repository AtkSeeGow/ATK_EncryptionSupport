namespace EncryptionSupport.Form
{
    partial class Form
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
            this.encryptionLabel = new System.Windows.Forms.Label();
            this.decryptionLabel = new System.Windows.Forms.Label();
            this.decryptionTextBox = new System.Windows.Forms.TextBox();
            this.encryptionTextBox = new System.Windows.Forms.TextBox();
            this.executebutton = new System.Windows.Forms.Button();
            this.encryptionResultLabel = new System.Windows.Forms.Label();
            this.encryptionResultTextBox = new System.Windows.Forms.TextBox();
            this.decryptionResultLabel = new System.Windows.Forms.Label();
            this.decryptionResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encryptionLabel
            // 
            this.encryptionLabel.AutoSize = true;
            this.encryptionLabel.Location = new System.Drawing.Point(12, 6);
            this.encryptionLabel.Name = "encryptionLabel";
            this.encryptionLabel.Size = new System.Drawing.Size(63, 12);
            this.encryptionLabel.TabIndex = 0;
            this.encryptionLabel.Text = "Encryption :";
            // 
            // decryptionLabel
            // 
            this.decryptionLabel.AutoSize = true;
            this.decryptionLabel.Location = new System.Drawing.Point(12, 56);
            this.decryptionLabel.Name = "decryptionLabel";
            this.decryptionLabel.Size = new System.Drawing.Size(63, 12);
            this.decryptionLabel.TabIndex = 1;
            this.decryptionLabel.Text = "Decryption :";
            // 
            // decryptionTextBox
            // 
            this.decryptionTextBox.Location = new System.Drawing.Point(81, 56);
            this.decryptionTextBox.Name = "decryptionTextBox";
            this.decryptionTextBox.Size = new System.Drawing.Size(452, 22);
            this.decryptionTextBox.TabIndex = 2;
            // 
            // encryptionTextBox
            // 
            this.encryptionTextBox.Location = new System.Drawing.Point(81, 6);
            this.encryptionTextBox.Name = "encryptionTextBox";
            this.encryptionTextBox.Size = new System.Drawing.Size(452, 22);
            this.encryptionTextBox.TabIndex = 3;
            // 
            // executebutton
            // 
            this.executebutton.Location = new System.Drawing.Point(12, 109);
            this.executebutton.Name = "executebutton";
            this.executebutton.Size = new System.Drawing.Size(519, 23);
            this.executebutton.TabIndex = 4;
            this.executebutton.Text = "Execute";
            this.executebutton.UseVisualStyleBackColor = true;
            this.executebutton.Click += new System.EventHandler(this.executeEvent);
            // 
            // encryptionResultLabel
            // 
            this.encryptionResultLabel.AutoSize = true;
            this.encryptionResultLabel.Location = new System.Drawing.Point(12, 31);
            this.encryptionResultLabel.Name = "encryptionResultLabel";
            this.encryptionResultLabel.Size = new System.Drawing.Size(40, 12);
            this.encryptionResultLabel.TabIndex = 5;
            this.encryptionResultLabel.Text = "Result :";
            // 
            // encryptionResultTextBox
            // 
            this.encryptionResultTextBox.Location = new System.Drawing.Point(81, 31);
            this.encryptionResultTextBox.Name = "encryptionResultTextBox";
            this.encryptionResultTextBox.Size = new System.Drawing.Size(452, 22);
            this.encryptionResultTextBox.TabIndex = 6;
            // 
            // decryptionResultLabel
            // 
            this.decryptionResultLabel.AutoSize = true;
            this.decryptionResultLabel.Location = new System.Drawing.Point(12, 81);
            this.decryptionResultLabel.Name = "decryptionResultLabel";
            this.decryptionResultLabel.Size = new System.Drawing.Size(40, 12);
            this.decryptionResultLabel.TabIndex = 7;
            this.decryptionResultLabel.Text = "Result :";
            // 
            // decryptionResultTextBox
            // 
            this.decryptionResultTextBox.Location = new System.Drawing.Point(81, 81);
            this.decryptionResultTextBox.Name = "decryptionResultTextBox";
            this.decryptionResultTextBox.Size = new System.Drawing.Size(452, 22);
            this.decryptionResultTextBox.TabIndex = 8;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 139);
            this.Controls.Add(this.decryptionResultTextBox);
            this.Controls.Add(this.decryptionResultLabel);
            this.Controls.Add(this.encryptionResultTextBox);
            this.Controls.Add(this.encryptionResultLabel);
            this.Controls.Add(this.executebutton);
            this.Controls.Add(this.encryptionTextBox);
            this.Controls.Add(this.decryptionTextBox);
            this.Controls.Add(this.decryptionLabel);
            this.Controls.Add(this.encryptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.Text = "ATK_EncryptionSupport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encryptionLabel;
        private System.Windows.Forms.Label decryptionLabel;
        private System.Windows.Forms.TextBox decryptionTextBox;
        private System.Windows.Forms.TextBox encryptionTextBox;
        private System.Windows.Forms.Button executebutton;
        private System.Windows.Forms.Label encryptionResultLabel;
        private System.Windows.Forms.TextBox encryptionResultTextBox;
        private System.Windows.Forms.Label decryptionResultLabel;
        private System.Windows.Forms.TextBox decryptionResultTextBox;
    }
}

