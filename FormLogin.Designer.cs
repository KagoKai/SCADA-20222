﻿
namespace test
{
    partial class FormLogin
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
            this.account = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(96, 90);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(140, 28);
            this.account.TabIndex = 0;
            this.account.Text = "Tên đăng nhập:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(141, 132);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(95, 28);
            this.password.TabIndex = 1;
            this.password.Text = "Mật khẩu:";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(120, 196);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(135, 50);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(341, 196);
            this.quitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(133, 50);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Thoát";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(265, 89);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(220, 30);
            this.txtAccount.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(265, 130);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 30);
            this.txtPassword.TabIndex = 5;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(93, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(384, 41);
            this.title.TabIndex = 6;
            this.title.Text = "Hệ thống CIP nhà máy bia";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 293);
            this.Controls.Add(this.title);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Drawing.SizeF AutoScaleDimensions { get; set; }
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label title;
    }
}