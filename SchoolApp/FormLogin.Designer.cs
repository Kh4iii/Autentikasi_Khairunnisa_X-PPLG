namespace SchoolApp
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
            txtUsername = new TextBox();
            txtRegister = new TextBox();
            btnSubmitLogin = new Button();
            btnNavToRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 15F);
            txtUsername.Location = new Point(402, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username...";
            txtUsername.Size = new Size(293, 47);
            txtUsername.TabIndex = 0;
            // 
            // txtRegister
            // 
            txtRegister.Font = new Font("Segoe UI", 15F);
            txtRegister.Location = new Point(402, 179);
            txtRegister.Name = "txtRegister";
            txtRegister.PlaceholderText = "Passowrd...";
            txtRegister.Size = new Size(293, 47);
            txtRegister.TabIndex = 1;
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.Font = new Font("Impact", 15F);
            btnSubmitLogin.Location = new Point(402, 324);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(293, 42);
            btnSubmitLogin.TabIndex = 2;
            btnSubmitLogin.Text = "Login";
            btnSubmitLogin.UseVisualStyleBackColor = true;
            btnSubmitLogin.Click += btnSubmitLogin_Click;
            // 
            // btnNavToRegister
            // 
            btnNavToRegister.Font = new Font("Impact", 15F);
            btnNavToRegister.Location = new Point(402, 256);
            btnNavToRegister.Name = "btnNavToRegister";
            btnNavToRegister.Size = new Size(293, 41);
            btnNavToRegister.TabIndex = 3;
            btnNavToRegister.Text = "To Register";
            btnNavToRegister.UseVisualStyleBackColor = true;
            btnNavToRegister.Click += btnNavToRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(467, 53);
            label1.Name = "label1";
            label1.Size = new Size(178, 33);
            label1.TabIndex = 4;
            label1.Text = "Form Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 637);
            Controls.Add(label1);
            Controls.Add(btnNavToRegister);
            Controls.Add(btnSubmitLogin);
            Controls.Add(txtRegister);
            Controls.Add(txtUsername);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtRegister;
        private Button btnSubmitLogin;
        private Button btnNavToRegister;
        private Label label1;
    }
}