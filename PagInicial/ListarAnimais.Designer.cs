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
            dataGridViewAnimais = new DataGridView();
            ID = new Label();
            Dono = new Label();
            Nome = new Label();
            Tipo = new Label();
            Raça = new Label();
            Peso = new Label();
            Idade = new Label();
            textBoxID = new TextBox();
            textBoxNome = new TextBox();
            textBoxDono = new TextBox();
            textBoxPeso = new TextBox();
            textBoxIdade = new TextBox();
            textBoxRaca = new TextBox();
            buttonListar = new Button();
            buttonSalvar = new Button();
            buttonApagar = new Button();
            comboBoxTipo = new ComboBox();
            NovosDados = new Label();
            Pesquisa = new Label();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimais).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAnimais
            // 
            dataGridViewAnimais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimais.Location = new Point(19, 272);
            dataGridViewAnimais.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAnimais.Name = "dataGridViewAnimais";
            dataGridViewAnimais.RowHeadersWidth = 51;
            dataGridViewAnimais.RowTemplate.Height = 29;
            dataGridViewAnimais.Size = new Size(1009, 205);
            dataGridViewAnimais.TabIndex = 0;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ID.Location = new Point(26, 54);
            ID.Name = "ID";
            ID.Size = new Size(35, 23);
            ID.TabIndex = 1;
            ID.Text = "ID";
            // 
            // Dono
            // 
            Dono.AutoSize = true;
            Dono.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Dono.Location = new Point(26, 144);
            Dono.Name = "Dono";
            Dono.Size = new Size(61, 23);
            Dono.TabIndex = 2;
            Dono.Text = "Dono";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Nome.Location = new Point(19, 197);
            Nome.Name = "Nome";
            Nome.Size = new Size(66, 23);
            Nome.TabIndex = 3;
            Nome.Text = "Nome";
            // 
            // Tipo
            // 
            Tipo.AutoSize = true;
            Tipo.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Tipo.Location = new Point(395, 37);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(54, 23);
            Tipo.TabIndex = 4;
            Tipo.Text = "Tipo";
            // 
            // Raça
            // 
            Raça.AutoSize = true;
            Raça.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Raça.Location = new Point(381, 87);
            Raça.Name = "Raça";
            Raça.Size = new Size(58, 23);
            Raça.TabIndex = 5;
            Raça.Text = "Raça";
            // 
            // Peso
            // 
            Peso.AutoSize = true;
            Peso.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Peso.Location = new Point(381, 202);
            Peso.Name = "Peso";
            Peso.Size = new Size(56, 23);
            Peso.TabIndex = 6;
            Peso.Text = "Peso";
            // 
            // Idade
            // 
            Idade.AutoSize = true;
            Idade.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Idade.Location = new Point(381, 132);
            Idade.Name = "Idade";
            Idade.Size = new Size(66, 23);
            Idade.TabIndex = 7;
            Idade.Text = "Idade";
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxID.Location = new Point(120, 45);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(204, 29);
            textBoxID.TabIndex = 8;
            // 
            // textBoxNome
            // 
            textBoxNome.BorderStyle = BorderStyle.FixedSingle;
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNome.Location = new Point(108, 196);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(204, 29);
            textBoxNome.TabIndex = 9;
            // 
            // textBoxDono
            // 
            textBoxDono.BorderStyle = BorderStyle.FixedSingle;
            textBoxDono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDono.Location = new Point(108, 135);
            textBoxDono.Margin = new Padding(3, 2, 3, 2);
            textBoxDono.Name = "textBoxDono";
            textBoxDono.Size = new Size(204, 29);
            textBoxDono.TabIndex = 10;
            // 
            // textBoxPeso
            // 
            textBoxPeso.BorderStyle = BorderStyle.FixedSingle;
            textBoxPeso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPeso.Location = new Point(470, 205);
            textBoxPeso.Margin = new Padding(3, 2, 3, 2);
            textBoxPeso.Name = "textBoxPeso";
            textBoxPeso.Size = new Size(204, 29);
            textBoxPeso.TabIndex = 12;
            // 
            // textBoxIdade
            // 
            textBoxIdade.BorderStyle = BorderStyle.FixedSingle;
            textBoxIdade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIdade.Location = new Point(470, 135);
            textBoxIdade.Margin = new Padding(3, 2, 3, 2);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(204, 29);
            textBoxIdade.TabIndex = 13;
            // 
            // textBoxRaca
            // 
            textBoxRaca.BorderStyle = BorderStyle.FixedSingle;
            textBoxRaca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRaca.Location = new Point(470, 87);
            textBoxRaca.Margin = new Padding(3, 2, 3, 2);
            textBoxRaca.Name = "textBoxRaca";
            textBoxRaca.Size = new Size(204, 29);
            textBoxRaca.TabIndex = 14;
            // 
            // buttonListar
            // 
            buttonListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListar.Location = new Point(790, 26);
            buttonListar.Margin = new Padding(3, 2, 3, 2);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(200, 40);
            buttonListar.TabIndex = 15;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(790, 91);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(200, 40);
            buttonSalvar.TabIndex = 16;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApagar.Location = new Point(790, 156);
            buttonApagar.Margin = new Padding(3, 2, 3, 2);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(200, 40);
            buttonApagar.TabIndex = 17;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Cão", "Gato", "Pássaro", "Hamster" });
            comboBoxTipo.Location = new Point(470, 37);
            comboBoxTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(204, 29);
            comboBoxTipo.TabIndex = 21;
            // 
            // NovosDados
            // 
            NovosDados.AutoSize = true;
            NovosDados.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NovosDados.Location = new Point(89, 91);
            NovosDados.Name = "NovosDados";
            NovosDados.Size = new Size(133, 25);
            NovosDados.TabIndex = 59;
            NovosDados.Text = "Novos Dados";
            // 
            // Pesquisa
            // 
            Pesquisa.AutoSize = true;
            Pesquisa.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Pesquisa.Location = new Point(54, 9);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Size = new Size(234, 25);
            Pesquisa.TabIndex = 58;
            Pesquisa.Text = "Id para Pesquisa/Seleção";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(790, 215);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(200, 40);
            buttonCancelar.TabIndex = 60;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // ListarAnimais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1059, 485);
            Controls.Add(buttonCancelar);
            Controls.Add(NovosDados);
            Controls.Add(Pesquisa);
            Controls.Add(comboBoxTipo);
            Controls.Add(buttonApagar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonListar);
            Controls.Add(textBoxRaca);
            Controls.Add(textBoxIdade);
            Controls.Add(textBoxPeso);
            Controls.Add(textBoxDono);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxID);
            Controls.Add(Idade);
            Controls.Add(Peso);
            Controls.Add(Raça);
            Controls.Add(Tipo);
            Controls.Add(Nome);
            Controls.Add(Dono);
            Controls.Add(ID);
            Controls.Add(dataGridViewAnimais);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarAnimais";
            Text = "ListarAnimais";
            Load += ListarAnimais_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimais).EndInit();
            ResumeLayout(false);
            PerformLayout();
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