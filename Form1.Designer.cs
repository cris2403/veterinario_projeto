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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegisto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(92, 31);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(110, 23);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(92, 93);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(104, 23);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(234, 30);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(372, 29);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPasword.Location = new System.Drawing.Point(234, 90);
            this.textBoxPasword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.Size = new System.Drawing.Size(372, 29);
            this.textBoxPasword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightGray;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(133, 187);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(173, 62);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegisto
            // 
            this.buttonRegisto.BackColor = System.Drawing.Color.LightGray;
            this.buttonRegisto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegisto.Location = new System.Drawing.Point(346, 187);
            this.buttonRegisto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegisto.Name = "buttonRegisto";
            this.buttonRegisto.Size = new System.Drawing.Size(192, 62);
            this.buttonRegisto.TabIndex = 6;
            this.buttonRegisto.Text = "Registo";
            this.buttonRegisto.UseVisualStyleBackColor = false;
            this.buttonRegisto.Click += new System.EventHandler(this.buttonRegisto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonRegisto);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox textBoxUsername;
        private TextBox textBoxPasword;
        private Button buttonLogin;
        private Button buttonRegisto;
    }
}