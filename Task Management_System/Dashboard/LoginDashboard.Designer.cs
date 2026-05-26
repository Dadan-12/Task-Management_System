namespace Task_Management_System.Dashboards
{
    partial class LoginDashboard
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
            txtBoxUsername = new System.Windows.Forms.TextBox();
            txtBoxPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            clickRegister = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new System.Drawing.Point(158, 128);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new System.Drawing.Size(154, 21);
            txtBoxUsername.TabIndex = 0;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new System.Drawing.Point(158, 199);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new System.Drawing.Size(154, 21);
            txtBoxPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(158, 103);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 13);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(158, 173);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 13);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(137, 343);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 13);
            label3.TabIndex = 4;
            label3.Text = "Don't have an account yet?";
            // 
            // clickRegister
            // 
            clickRegister.AutoSize = true;
            clickRegister.Location = new System.Drawing.Point(282, 343);
            clickRegister.Name = "clickRegister";
            clickRegister.Size = new System.Drawing.Size(72, 13);
            clickRegister.TabIndex = 5;
            clickRegister.Text = "Register here";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(201, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 461);
            Controls.Add(btnLogin);
            Controls.Add(clickRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUsername);
            Name = "LoginDashboard";
            Text = "LoginDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label clickRegister;
        private System.Windows.Forms.Button btnLogin;
    }
}