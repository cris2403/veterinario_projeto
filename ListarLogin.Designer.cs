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
            ID = new Label();
            NovoUser = new Label();
            NovoEmail = new Label();
            NovaPass = new Label();
            dataGridViewLogin = new DataGridView();
            buttonListar = new Button();
            buttonSalvar = new Button();
            buttonApagar = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            textBoxID = new TextBox();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogin).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ID.Location = new Point(18, 79);
            ID.Name = "ID";
            ID.Size = new Size(30, 20);
            ID.TabIndex = 0;
            ID.Text = "ID";
            // 
            // NovoUser
            // 
            NovoUser.AutoSize = true;
            NovoUser.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NovoUser.Location = new Point(331, 73);
            NovoUser.Name = "NovoUser";
            NovoUser.Size = new Size(140, 20);
            NovoUser.TabIndex = 1;
            NovoUser.Text = "Novo Username";
            // 
            // NovoEmail
            // 
            NovoEmail.AutoSize = true;
            NovoEmail.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NovoEmail.Location = new Point(337, 124);
            NovoEmail.Name = "NovoEmail";
            NovoEmail.Size = new Size(106, 20);
            NovoEmail.TabIndex = 2;
            NovoEmail.Text = "Novo Email";
            // 
            // NovaPass
            // 
            NovaPass.AutoSize = true;
            NovaPass.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NovaPass.Location = new Point(337, 163);
            NovaPass.Name = "NovaPass";
            NovaPass.Size = new Size(134, 20);
            NovaPass.TabIndex = 3;
            NovaPass.Text = "Nova Password";
            // 
            // dataGridViewLogin
            // 
            dataGridViewLogin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogin.Location = new Point(13, 269);
            dataGridViewLogin.Margin = new Padding(3, 2, 3, 2);
            dataGridViewLogin.Name = "dataGridViewLogin";
            dataGridViewLogin.RowHeadersWidth = 51;
            dataGridViewLogin.RowTemplate.Height = 29;
            dataGridViewLogin.Size = new Size(731, 135);
            dataGridViewLogin.TabIndex = 4;
            dataGridViewLogin.CellClick += dataGridViewLogin_CellClick;
            // 
            // buttonListar
            // 
            buttonListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListar.Location = new Point(21, 214);
            buttonListar.Margin = new Padding(3, 2, 3, 2);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(150, 38);
            buttonListar.TabIndex = 5;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(209, 214);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(150, 38);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApagar.Location = new Point(410, 214);
            buttonApagar.Margin = new Padding(3, 2, 3, 2);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(150, 38);
            buttonApagar.TabIndex = 7;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(487, 115);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(199, 29);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(487, 158);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(199, 29);
            textBoxPassword.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(487, 70);
            textBoxUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(199, 29);
            textBoxUsername.TabIndex = 10;
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxID.Location = new Point(54, 75);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(158, 29);
            textBoxID.TabIndex = 11;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(594, 214);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(150, 38);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // ListarLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(756, 415);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxID);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonApagar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonListar);
            Controls.Add(dataGridViewLogin);
            Controls.Add(NovaPass);
            Controls.Add(NovoEmail);
            Controls.Add(NovoUser);
            Controls.Add(ID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarLogin";
            Text = "ListarLogin";
            Load += ListarLogin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button buttonCancelar;
    }
}