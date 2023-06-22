namespace veterinario_projeto
{
    partial class Listar
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
            dataGridView1 = new DataGridView();
            btn_listarListar = new Button();
            btn_apagarListar = new Button();
            btn_editarListar = new Button();
            lbl_idListar = new Label();
            lbl_usernameListar = new Label();
            lbl_emailListar = new Label();
            lbl_passwordListar = new Label();
            txt_idListar = new TextBox();
            txt_usernameListar = new TextBox();
            txt_emailListar = new TextBox();
            txt_passwordListar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(239, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_listarListar
            // 
            btn_listarListar.Location = new Point(189, 12);
            btn_listarListar.Name = "btn_listarListar";
            btn_listarListar.Size = new Size(75, 23);
            btn_listarListar.TabIndex = 1;
            btn_listarListar.Text = "Listar";
            btn_listarListar.UseVisualStyleBackColor = true;
            btn_listarListar.Click += btn_listarListar_Click;
            // 
            // btn_apagarListar
            // 
            btn_apagarListar.Location = new Point(330, 12);
            btn_apagarListar.Name = "btn_apagarListar";
            btn_apagarListar.Size = new Size(75, 23);
            btn_apagarListar.TabIndex = 2;
            btn_apagarListar.Text = "Apagar";
            btn_apagarListar.UseVisualStyleBackColor = true;
            btn_apagarListar.Click += btn_apagarListar_Click;
            // 
            // btn_editarListar
            // 
            btn_editarListar.Location = new Point(461, 12);
            btn_editarListar.Name = "btn_editarListar";
            btn_editarListar.Size = new Size(75, 23);
            btn_editarListar.TabIndex = 3;
            btn_editarListar.Text = "Editar";
            btn_editarListar.UseVisualStyleBackColor = true;
            btn_editarListar.Click += btn_editarListar_Click;
            // 
            // lbl_idListar
            // 
            lbl_idListar.AutoSize = true;
            lbl_idListar.Location = new Point(28, 88);
            lbl_idListar.Name = "lbl_idListar";
            lbl_idListar.Size = new Size(17, 15);
            lbl_idListar.TabIndex = 4;
            lbl_idListar.Text = "id";
            // 
            // lbl_usernameListar
            // 
            lbl_usernameListar.AutoSize = true;
            lbl_usernameListar.Location = new Point(27, 118);
            lbl_usernameListar.Name = "lbl_usernameListar";
            lbl_usernameListar.Size = new Size(59, 15);
            lbl_usernameListar.TabIndex = 5;
            lbl_usernameListar.Text = "username";
            // 
            // lbl_emailListar
            // 
            lbl_emailListar.AutoSize = true;
            lbl_emailListar.Location = new Point(25, 146);
            lbl_emailListar.Name = "lbl_emailListar";
            lbl_emailListar.Size = new Size(36, 15);
            lbl_emailListar.TabIndex = 6;
            lbl_emailListar.Text = "email";
            // 
            // lbl_passwordListar
            // 
            lbl_passwordListar.AutoSize = true;
            lbl_passwordListar.Location = new Point(24, 180);
            lbl_passwordListar.Name = "lbl_passwordListar";
            lbl_passwordListar.Size = new Size(57, 15);
            lbl_passwordListar.TabIndex = 7;
            lbl_passwordListar.Text = "password";
            // 
            // txt_idListar
            // 
            txt_idListar.Location = new Point(78, 86);
            txt_idListar.Name = "txt_idListar";
            txt_idListar.Size = new Size(100, 23);
            txt_idListar.TabIndex = 8;
            // 
            // txt_usernameListar
            // 
            txt_usernameListar.Location = new Point(79, 113);
            txt_usernameListar.Name = "txt_usernameListar";
            txt_usernameListar.Size = new Size(100, 23);
            txt_usernameListar.TabIndex = 9;
            // 
            // txt_emailListar
            // 
            txt_emailListar.Location = new Point(79, 142);
            txt_emailListar.Name = "txt_emailListar";
            txt_emailListar.Size = new Size(100, 23);
            txt_emailListar.TabIndex = 10;
            // 
            // txt_passwordListar
            // 
            txt_passwordListar.Location = new Point(79, 176);
            txt_passwordListar.Name = "txt_passwordListar";
            txt_passwordListar.Size = new Size(100, 23);
            txt_passwordListar.TabIndex = 11;
            // 
            // Listar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_passwordListar);
            Controls.Add(txt_emailListar);
            Controls.Add(txt_usernameListar);
            Controls.Add(txt_idListar);
            Controls.Add(lbl_passwordListar);
            Controls.Add(lbl_emailListar);
            Controls.Add(lbl_usernameListar);
            Controls.Add(lbl_idListar);
            Controls.Add(btn_editarListar);
            Controls.Add(btn_apagarListar);
            Controls.Add(btn_listarListar);
            Controls.Add(dataGridView1);
            Name = "Listar";
            Text = "Listar";
            Load += Listar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_listarListar;
        private Button btn_apagarListar;
        private Button btn_editarListar;
        private Label lbl_idListar;
        private Label lbl_usernameListar;
        private Label lbl_emailListar;
        private Label lbl_passwordListar;
        private TextBox txt_idListar;
        private TextBox txt_usernameListar;
        private TextBox txt_emailListar;
        private TextBox txt_passwordListar;
    }
}