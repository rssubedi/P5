namespace P5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonForgotPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(227, 74);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(402, 20);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(227, 116);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(402, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(519, 151);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(110, 38);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(387, 151);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 38);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonForgotPassword
            // 
            this.buttonForgotPassword.Location = new System.Drawing.Point(227, 151);
            this.buttonForgotPassword.Margin = new System.Windows.Forms.Padding(2);
            this.buttonForgotPassword.Name = "buttonForgotPassword";
            this.buttonForgotPassword.Size = new System.Drawing.Size(131, 38);
            this.buttonForgotPassword.TabIndex = 6;
            this.buttonForgotPassword.Text = "Forgot Password";
            this.buttonForgotPassword.UseVisualStyleBackColor = true;
            this.buttonForgotPassword.Click += new System.EventHandler(this.buttonForgotPassword_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(864, 389);
            this.Controls.Add(this.buttonForgotPassword);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonForgotPassword;
    }
}