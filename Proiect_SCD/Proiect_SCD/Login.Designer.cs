
namespace Proiect_SCD
{
    partial class Login
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
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charPass = new System.Windows.Forms.Button();
            this.createAcc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Peru;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginButton.Font = new System.Drawing.Font("SuperFrench", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.DarkRed;
            this.loginButton.Location = new System.Drawing.Point(100, 306);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(107, 37);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Sign in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_ClickAsync);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Tan;
            this.usernameTextBox.Font = new System.Drawing.Font("SuperFrench", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.Location = new System.Drawing.Point(33, 102);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(252, 26);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passswordTextBox
            // 
            this.passswordTextBox.BackColor = System.Drawing.Color.Tan;
            this.passswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passswordTextBox.Location = new System.Drawing.Point(33, 217);
            this.passswordTextBox.Name = "passswordTextBox";
            this.passswordTextBox.PasswordChar = '*';
            this.passswordTextBox.Size = new System.Drawing.Size(252, 31);
            this.passswordTextBox.TabIndex = 2;
            this.passswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SuperFrench", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SuperFrench", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(33, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // charPass
            // 
            this.charPass.BackColor = System.Drawing.Color.DarkOrange;
            this.charPass.Location = new System.Drawing.Point(260, 217);
            this.charPass.Name = "charPass";
            this.charPass.Size = new System.Drawing.Size(25, 26);
            this.charPass.TabIndex = 5;
            this.charPass.UseVisualStyleBackColor = false;
            this.charPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charPass_MouseDown);
            this.charPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charPass_MouseUp);
            // 
            // createAcc
            // 
            this.createAcc.AutoSize = true;
            this.createAcc.Font = new System.Drawing.Font("SuperFrench", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createAcc.Location = new System.Drawing.Point(61, 418);
            this.createAcc.Name = "createAcc";
            this.createAcc.Size = new System.Drawing.Size(185, 18);
            this.createAcc.TabIndex = 6;
            this.createAcc.Text = "Don\'t have an account?";
            this.createAcc.Click += new System.EventHandler(this.createAcc_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(317, 474);
            this.Controls.Add(this.createAcc);
            this.Controls.Add(this.charPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passswordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.loginButton);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button charPass;
        private System.Windows.Forms.Label createAcc;
    }
}