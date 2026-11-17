namespace SchoolApp
{
    partial class FormRegister
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
            label1 = new Label();
            txtFullName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnSubmitRegister = new Button();
            btnNavToLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(443, 70);
            label1.Name = "label1";
            label1.Size = new Size(165, 33);
            label1.TabIndex = 0;
            label1.Text = "Form Register";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 15F);
            txtFullName.Location = new Point(398, 129);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name...";
            txtFullName.Size = new Size(246, 47);
            txtFullName.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 15F);
            txtUserName.Location = new Point(398, 199);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username...";
            txtUserName.Size = new Size(246, 47);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(398, 272);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password...";
            txtPassword.Size = new Size(246, 47);
            txtPassword.TabIndex = 3;
            // 
            // btnSubmitRegister
            // 
            btnSubmitRegister.Font = new Font("Impact", 15F);
            btnSubmitRegister.Location = new Point(398, 347);
            btnSubmitRegister.Name = "btnSubmitRegister";
            btnSubmitRegister.Size = new Size(246, 43);
            btnSubmitRegister.TabIndex = 4;
            btnSubmitRegister.Text = "Register";
            btnSubmitRegister.UseVisualStyleBackColor = true;
            btnSubmitRegister.Click += btnSubmitRegister_Click;
            // 
            // btnNavToLogin
            // 
            btnNavToLogin.Font = new Font("Impact", 15F);
            btnNavToLogin.Location = new Point(398, 412);
            btnNavToLogin.Name = "btnNavToLogin";
            btnNavToLogin.Size = new Size(246, 45);
            btnNavToLogin.TabIndex = 5;
            btnNavToLogin.Text = "To Login";
            btnNavToLogin.UseVisualStyleBackColor = true;
            btnNavToLogin.Click += btnNavToLogin_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 646);
            Controls.Add(btnNavToLogin);
            Controls.Add(btnSubmitRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnSubmitRegister;
        private Button btnNavToLogin;
    }
}