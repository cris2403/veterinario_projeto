namespace veterinario_projeto
{
    partial class Form2
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
            Username = new Label();
            Email = new Label();
            Password = new Label();
            textBoxUsername = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegisto = new Button();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Username.Location = new Point(86, 50);
            Username.Name = "Username";
            Username.Size = new Size(110, 23);
            Username.TabIndex = 0;
            Username.Text = "Username";
            Username.Click += label1_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Email.Location = new Point(130, 98);
            Email.Name = "Email";
            Email.Size = new Size(69, 23);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Password.Location = new Point(93, 139);
            Password.Name = "Password";
            Password.Size = new Size(104, 23);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(272, 46);
            textBoxUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(364, 29);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(272, 94);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(364, 29);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(272, 134);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(364, 29);
            textBoxPassword.TabIndex = 5;
            // 
            // buttonRegisto
            // 
            buttonRegisto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegisto.Location = new Point(38, 219);
            buttonRegisto.Margin = new Padding(3, 2, 3, 2);
            buttonRegisto.Name = "buttonRegisto";
            buttonRegisto.Size = new Size(191, 45);
            buttonRegisto.TabIndex = 6;
            buttonRegisto.Text = "Registo";
            buttonRegisto.UseVisualStyleBackColor = true;
            buttonRegisto.Click += buttonRegisto_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(403, 219);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(191, 45);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegisto);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxUsername);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Username);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Email;
        private Label Password;
        private TextBox textBoxUsername;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonRegisto;
        private Button buttonLogin;
    }
}