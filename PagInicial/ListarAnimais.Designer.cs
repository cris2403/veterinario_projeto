namespace veterinario_projeto.PagInicial
{
    partial class ListarAnimais
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
            this.dataGridViewAnimais = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.Label();
            this.Dono = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.Raça = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.Idade = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxDono = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.textBoxRaca = new System.Windows.Forms.TextBox();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.NovosDados = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnimais
            // 
            this.dataGridViewAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimais.Location = new System.Drawing.Point(22, 363);
            this.dataGridViewAnimais.Name = "dataGridViewAnimais";
            this.dataGridViewAnimais.RowHeadersWidth = 51;
            this.dataGridViewAnimais.RowTemplate.Height = 29;
            this.dataGridViewAnimais.Size = new System.Drawing.Size(1153, 273);
            this.dataGridViewAnimais.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(30, 72);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(41, 28);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // Dono
            // 
            this.Dono.AutoSize = true;
            this.Dono.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Dono.Location = new System.Drawing.Point(30, 192);
            this.Dono.Name = "Dono";
            this.Dono.Size = new System.Drawing.Size(72, 28);
            this.Dono.TabIndex = 2;
            this.Dono.Text = "Dono";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(22, 263);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(79, 28);
            this.Nome.TabIndex = 3;
            this.Nome.Text = "Nome";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Tipo.Location = new System.Drawing.Point(451, 49);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(63, 28);
            this.Tipo.TabIndex = 4;
            this.Tipo.Text = "Tipo";
            // 
            // Raça
            // 
            this.Raça.AutoSize = true;
            this.Raça.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Raça.Location = new System.Drawing.Point(435, 116);
            this.Raça.Name = "Raça";
            this.Raça.Size = new System.Drawing.Size(69, 28);
            this.Raça.TabIndex = 5;
            this.Raça.Text = "Raça";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Peso.Location = new System.Drawing.Point(435, 269);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(66, 28);
            this.Peso.TabIndex = 6;
            this.Peso.Text = "Peso";
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Idade.Location = new System.Drawing.Point(435, 176);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(77, 28);
            this.Idade.TabIndex = 7;
            this.Idade.Text = "Idade";
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(137, 60);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(233, 34);
            this.textBoxID.TabIndex = 8;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(123, 261);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(233, 34);
            this.textBoxNome.TabIndex = 9;
            // 
            // textBoxDono
            // 
            this.textBoxDono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDono.Location = new System.Drawing.Point(123, 180);
            this.textBoxDono.Name = "textBoxDono";
            this.textBoxDono.Size = new System.Drawing.Size(233, 34);
            this.textBoxDono.TabIndex = 10;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPeso.Location = new System.Drawing.Point(537, 273);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(233, 34);
            this.textBoxPeso.TabIndex = 12;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIdade.Location = new System.Drawing.Point(537, 180);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(233, 34);
            this.textBoxIdade.TabIndex = 13;
            // 
            // textBoxRaca
            // 
            this.textBoxRaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRaca.Location = new System.Drawing.Point(537, 116);
            this.textBoxRaca.Name = "textBoxRaca";
            this.textBoxRaca.Size = new System.Drawing.Size(233, 34);
            this.textBoxRaca.TabIndex = 14;
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(903, 35);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(229, 53);
            this.buttonListar.TabIndex = 15;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(903, 121);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(229, 53);
            this.buttonSalvar.TabIndex = 16;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(903, 208);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(229, 53);
            this.buttonApagar.TabIndex = 17;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Cão",
            "Gato",
            "Pássaro",
            "Hamster"});
            this.comboBoxTipo.Location = new System.Drawing.Point(537, 49);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(233, 36);
            this.comboBoxTipo.TabIndex = 21;
            // 
            // NovosDados
            // 
            this.NovosDados.AutoSize = true;
            this.NovosDados.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NovosDados.Location = new System.Drawing.Point(102, 121);
            this.NovosDados.Name = "NovosDados";
            this.NovosDados.Size = new System.Drawing.Size(166, 32);
            this.NovosDados.TabIndex = 59;
            this.NovosDados.Text = "Novos Dados";
            // 
            // Pesquisa
            // 
            this.Pesquisa.AutoSize = true;
            this.Pesquisa.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pesquisa.Location = new System.Drawing.Point(62, 12);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(295, 32);
            this.Pesquisa.TabIndex = 58;
            this.Pesquisa.Text = "Id para Pesquisa/Seleção";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(903, 287);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(229, 53);
            this.buttonCancelar.TabIndex = 60;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // ListarAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1210, 647);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.NovosDados);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.textBoxRaca);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxDono);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Raça);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Dono);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridViewAnimais);
            this.Name = "ListarAnimais";
            this.Text = "ListarAnimais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAnimais;
        private Label ID;
        private Label Dono;
        private Label Nome;
        private Label Tipo;
        private Label Raça;
        private Label Peso;
        private Label Idade;
        private TextBox textBoxID;
        private TextBox textBoxNome;
        private TextBox textBoxDono;
        private TextBox textBoxPeso;
        private TextBox textBoxIdade;
        private TextBox textBoxRaca;
        private Button buttonListar;
        private Button buttonSalvar;
        private Button buttonApagar;
        private ComboBox comboBoxTipo;
        private Label NovosDados;
        private Label Pesquisa;
        private Button buttonCancelar;
    }
}