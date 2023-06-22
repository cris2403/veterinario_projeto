namespace veterinario_projeto
{
    partial class ListarCao
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
            txt_peso = new TextBox();
            txt_idade = new TextBox();
            txt_raca = new TextBox();
            txt_tipo = new TextBox();
            txt_nome = new TextBox();
            txt_dono = new TextBox();
            lbl_donoAnimal = new Label();
            lbl_pesoAnimal = new Label();
            lbl_idadeAnimal = new Label();
            lbl_racaAnimal = new Label();
            lbl_tipoAnimal = new Label();
            lbl_nomeAnimal = new Label();
            btn_editarListar = new Button();
            btn_apagarListar = new Button();
            btn_listarListar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_peso
            // 
            txt_peso.BorderStyle = BorderStyle.FixedSingle;
            txt_peso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_peso.Location = new Point(222, 274);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(501, 29);
            txt_peso.TabIndex = 29;
            // 
            // txt_idade
            // 
            txt_idade.BorderStyle = BorderStyle.FixedSingle;
            txt_idade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idade.Location = new Point(222, 231);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(501, 29);
            txt_idade.TabIndex = 28;
            // 
            // txt_raca
            // 
            txt_raca.BorderStyle = BorderStyle.FixedSingle;
            txt_raca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_raca.Location = new Point(222, 186);
            txt_raca.Name = "txt_raca";
            txt_raca.Size = new Size(501, 29);
            txt_raca.TabIndex = 27;
            // 
            // txt_tipo
            // 
            txt_tipo.BorderStyle = BorderStyle.FixedSingle;
            txt_tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tipo.Location = new Point(222, 140);
            txt_tipo.Name = "txt_tipo";
            txt_tipo.Size = new Size(501, 29);
            txt_tipo.TabIndex = 26;
            // 
            // txt_nome
            // 
            txt_nome.BorderStyle = BorderStyle.FixedSingle;
            txt_nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(222, 96);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(501, 29);
            txt_nome.TabIndex = 25;
            // 
            // txt_dono
            // 
            txt_dono.BorderStyle = BorderStyle.FixedSingle;
            txt_dono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dono.Location = new Point(222, 53);
            txt_dono.Name = "txt_dono";
            txt_dono.Size = new Size(501, 29);
            txt_dono.TabIndex = 24;
            // 
            // lbl_donoAnimal
            // 
            lbl_donoAnimal.AutoSize = true;
            lbl_donoAnimal.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_donoAnimal.Location = new Point(127, 53);
            lbl_donoAnimal.Name = "lbl_donoAnimal";
            lbl_donoAnimal.Size = new Size(61, 23);
            lbl_donoAnimal.TabIndex = 23;
            lbl_donoAnimal.Text = "Dono";
            // 
            // lbl_pesoAnimal
            // 
            lbl_pesoAnimal.AutoSize = true;
            lbl_pesoAnimal.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_pesoAnimal.Location = new Point(132, 274);
            lbl_pesoAnimal.Name = "lbl_pesoAnimal";
            lbl_pesoAnimal.Size = new Size(56, 23);
            lbl_pesoAnimal.TabIndex = 22;
            lbl_pesoAnimal.Text = "Peso";
            // 
            // lbl_idadeAnimal
            // 
            lbl_idadeAnimal.AutoSize = true;
            lbl_idadeAnimal.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_idadeAnimal.Location = new Point(122, 231);
            lbl_idadeAnimal.Name = "lbl_idadeAnimal";
            lbl_idadeAnimal.Size = new Size(66, 23);
            lbl_idadeAnimal.TabIndex = 21;
            lbl_idadeAnimal.Text = "Idade";
            // 
            // lbl_racaAnimal
            // 
            lbl_racaAnimal.AutoSize = true;
            lbl_racaAnimal.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_racaAnimal.Location = new Point(130, 186);
            lbl_racaAnimal.Name = "lbl_racaAnimal";
            lbl_racaAnimal.Size = new Size(58, 23);
            lbl_racaAnimal.TabIndex = 20;
            lbl_racaAnimal.Text = "Raça";
            // 
            // lbl_tipoAnimal
            // 
            lbl_tipoAnimal.AutoSize = true;
            lbl_tipoAnimal.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_tipoAnimal.Location = new Point(27, 140);
            lbl_tipoAnimal.Name = "lbl_tipoAnimal";
            lbl_tipoAnimal.Size = new Size(161, 23);
            lbl_tipoAnimal.TabIndex = 19;
            lbl_tipoAnimal.Text = "Tipo de Animal";
            // 
            // lbl_nomeAnimal
            // 
            lbl_nomeAnimal.AutoSize = true;
            lbl_nomeAnimal.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_nomeAnimal.Location = new Point(15, 96);
            lbl_nomeAnimal.Name = "lbl_nomeAnimal";
            lbl_nomeAnimal.Size = new Size(173, 23);
            lbl_nomeAnimal.TabIndex = 18;
            lbl_nomeAnimal.Text = "Nome do Animal";
            // 
            // btn_editarListar
            // 
            btn_editarListar.Location = new Point(429, 3);
            btn_editarListar.Name = "btn_editarListar";
            btn_editarListar.Size = new Size(75, 23);
            btn_editarListar.TabIndex = 33;
            btn_editarListar.Text = "Editar";
            btn_editarListar.UseVisualStyleBackColor = true;
            // 
            // btn_apagarListar
            // 
            btn_apagarListar.Location = new Point(303, 3);
            btn_apagarListar.Name = "btn_apagarListar";
            btn_apagarListar.Size = new Size(75, 23);
            btn_apagarListar.TabIndex = 32;
            btn_apagarListar.Text = "Apagar";
            btn_apagarListar.UseVisualStyleBackColor = true;
            btn_apagarListar.Click += btn_apagarListar_Click;
            // 
            // btn_listarListar
            // 
            btn_listarListar.Location = new Point(165, 3);
            btn_listarListar.Name = "btn_listarListar";
            btn_listarListar.Size = new Size(75, 23);
            btn_listarListar.TabIndex = 31;
            btn_listarListar.Text = "Listar";
            btn_listarListar.UseVisualStyleBackColor = true;
            btn_listarListar.Click += btn_listarListar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(559, 129);
            dataGridView1.TabIndex = 30;
            // 
            // ListarCao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_editarListar);
            Controls.Add(btn_apagarListar);
            Controls.Add(btn_listarListar);
            Controls.Add(dataGridView1);
            Controls.Add(txt_peso);
            Controls.Add(txt_idade);
            Controls.Add(txt_raca);
            Controls.Add(txt_tipo);
            Controls.Add(txt_nome);
            Controls.Add(txt_dono);
            Controls.Add(lbl_donoAnimal);
            Controls.Add(lbl_pesoAnimal);
            Controls.Add(lbl_idadeAnimal);
            Controls.Add(lbl_racaAnimal);
            Controls.Add(lbl_tipoAnimal);
            Controls.Add(lbl_nomeAnimal);
            Name = "ListarCao";
            Text = "ListarCao";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_peso;
        private TextBox txt_idade;
        private TextBox txt_raca;
        private TextBox txt_tipo;
        private TextBox txt_nome;
        private TextBox txt_dono;
        private Label lbl_donoAnimal;
        private Label lbl_pesoAnimal;
        private Label lbl_idadeAnimal;
        private Label lbl_racaAnimal;
        private Label lbl_tipoAnimal;
        private Label lbl_nomeAnimal;
        private Button btn_editarListar;
        private Button btn_apagarListar;
        private Button btn_listarListar;
        private DataGridView dataGridView1;
    }
}