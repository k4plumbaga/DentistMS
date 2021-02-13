
namespace DentistMS
{
    partial class LoginForm
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
            this.kullanıcıAdıLabel = new System.Windows.Forms.Label();
            this.kullanıcıAdıTextBox = new System.Windows.Forms.TextBox();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.hosgelidnizLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullanıcıAdıLabel
            // 
            this.kullanıcıAdıLabel.AutoSize = true;
            this.kullanıcıAdıLabel.Location = new System.Drawing.Point(22, 87);
            this.kullanıcıAdıLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.kullanıcıAdıLabel.Name = "kullanıcıAdıLabel";
            this.kullanıcıAdıLabel.Size = new System.Drawing.Size(113, 24);
            this.kullanıcıAdıLabel.TabIndex = 0;
            this.kullanıcıAdıLabel.Text = "Kullanıcı Adı";
            // 
            // kullanıcıAdıTextBox
            // 
            this.kullanıcıAdıTextBox.Location = new System.Drawing.Point(28, 116);
            this.kullanıcıAdıTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kullanıcıAdıTextBox.Name = "kullanıcıAdıTextBox";
            this.kullanıcıAdıTextBox.Size = new System.Drawing.Size(435, 29);
            this.kullanıcıAdıTextBox.TabIndex = 1;
            // 
            // girisYapButton
            // 
            this.girisYapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girisYapButton.Location = new System.Drawing.Point(155, 332);
            this.girisYapButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(159, 47);
            this.girisYapButton.TabIndex = 2;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = true;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(28, 239);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(435, 29);
            this.sifreTextBox.TabIndex = 3;
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Location = new System.Drawing.Point(24, 209);
            this.sifreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(47, 24);
            this.sifreLabel.TabIndex = 4;
            this.sifreLabel.Text = "Şifre";
            // 
            // hosgelidnizLabel
            // 
            this.hosgelidnizLabel.AutoSize = true;
            this.hosgelidnizLabel.Location = new System.Drawing.Point(106, 31);
            this.hosgelidnizLabel.Name = "hosgelidnizLabel";
            this.hosgelidnizLabel.Size = new System.Drawing.Size(273, 24);
            this.hosgelidnizLabel.TabIndex = 5;
            this.hosgelidnizLabel.Text = "Hoş Geldiniz, Lütfen Giriş Yapın";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 410);
            this.Controls.Add(this.hosgelidnizLabel);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.kullanıcıAdıTextBox);
            this.Controls.Add(this.kullanıcıAdıLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LoginForm";
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullanıcıAdıLabel;
        private System.Windows.Forms.TextBox kullanıcıAdıTextBox;
        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label hosgelidnizLabel;
    }
}