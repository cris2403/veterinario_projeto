namespace veterinario_projeto
{
    partial class ListarLogin
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
            this.ID = new System.Windows.Forms.Label();
            this.NovoUser = new System.Windows.Forms.Label();
            this.NovoEmail = new System.Windows.Forms.Label();
            this.NovaPass = new System.Windows.Forms.Label();
            this.dataGridViewLogin = new System.Windows.Forms.DataGridView();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(40, 35);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // NovoUser
            // 
            this.NovoUser.AutoSize = true;
            this.NovoUser.Location = new System.Drawing.Point(40, 114);
            this.NovoUser.Name = "NovoUser";
            this.NovoUser.Size = new System.Drawing.Size(115, 20);
            this.NovoUser.TabIndex = 1;
            this.NovoUser.Text = "Novo Username";
            // 
            // NovoEmail
            // 
            this.NovoEmail.AutoSize = true;
            this.NovoEmail.Location = new System.Drawing.Point(321, 35);
            this.NovoEmail.Name = "NovoEmail";
            this.NovoEmail.Size = new System.Drawing.Size(86, 20);
            this.NovoEmail.TabIndex = 2;
            this.NovoEmail.Text = "Novo Email";
            // 
            // NovaPass
            // 
            this.NovaPass.AutoSize = true;
            this.NovaPass.Location = new System.Drawing.Point(396, 114);
            this.NovaPass.Name = "NovaPass";
            this.NovaPass.Size = new System.Drawing.Size(109, 20);
            this.NovaPass.TabIndex = 3;
            this.NovaPass.Text = "Nova Password";
            // 
            // dataGridViewLogin
            // 
            this.dataGridViewLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogin.Location = new System.Drawing.Point(26, 235);
            this.dataGridViewLogin.Name = "dataGridViewLogin";
            this.dataGridViewLogin.RowHeadersWidth = 51;
            this.dataGridViewLogin.RowTemplate.Height = 29;
            this.dataGridViewLogin.Size = new System.Drawing.Size(744, 180);
            this.dataGridViewLogin.TabIndex = 4;
            this.dataGridViewLogin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLogin_CellClick);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(26, 165);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(171, 51);
            this.buttonListar.TabIndex = 5;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(321, 165);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(171, 51);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(599, 165);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(171, 51);
            this.buttonApagar.TabIndex = 7;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(428, 35);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(323, 27);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(519, 108);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(239, 27);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(174, 114);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(180, 27);
            this.textBoxUsername.TabIndex = 10;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(76, 35);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(239, 27);
            this.textBoxID.TabIndex = 11;
            // 
            // ListarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.dataGridViewLogin);
            this.Controls.Add(this.NovaPass);
            this.Controls.Add(this.NovoEmail);
            this.Controls.Add(this.NovoUser);
            this.Controls.Add(this.ID);
            this.Name = "ListarLogin";
            this.Text = "ListarLogin";
            this.Load += new System.EventHandler(this.ListarLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ID;
        private Label NovoUser;
        private Label NovoEmail;
        private Label NovaPass;
        private DataGridView dataGridViewLogin;
        private Button buttonListar;
        private Button buttonSalvar;
        private Button buttonApagar;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxID;
    }
}