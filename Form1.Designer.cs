namespace veterinario_projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            Password = new Label();
            textBoxUsername = new TextBox();
            textBoxPasword = new TextBox();
            buttonLogin = new Button();
            buttonRegisto = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Username.Location = new Point(92, 31);
            Username.Name = "Username";
            Username.Size = new Size(110, 23);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Password.Location = new Point(92, 93);
            Password.Name = "Password";
            Password.Size = new Size(104, 23);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(234, 30);
            textBoxUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(372, 29);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPasword
            // 
            textBoxPasword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasword.Location = new Point(234, 90);
            textBoxPasword.Margin = new Padding(3, 2, 3, 2);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(372, 29);
            textBoxPasword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.LightGray;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(133, 164);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(173, 62);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegisto
            // 
            buttonRegisto.BackColor = Color.LightGray;
            buttonRegisto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegisto.Location = new Point(345, 164);
            buttonRegisto.Margin = new Padding(3, 2, 3, 2);
            buttonRegisto.Name = "buttonRegisto";
            buttonRegisto.Size = new Size(192, 62);
            buttonRegisto.TabIndex = 6;
            buttonRegisto.Text = "Registo";
            buttonRegisto.UseVisualStyleBackColor = false;
            buttonRegisto.Click += buttonRegisto_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(234, 243);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(192, 62);
            button1.TabIndex = 7;
            button1.Text = "Listar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(buttonRegisto);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPasword);
            Controls.Add(textBoxUsername);
            Controls.Add(Password);
            Controls.Add(Username);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox textBoxUsername;
        private TextBox textBoxPasword;
        private Button buttonLogin;
        private Button buttonRegisto;
        private Button button1;
    }
}