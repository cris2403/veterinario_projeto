namespace veterinario_projeto.PagInicial
{
    partial class ListarDonos
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
            buttonApagar = new Button();
            buttonSalvar = new Button();
            buttonListar = new Button();
            textBoxNIF = new TextBox();
            textBoxContacto = new TextBox();
            textBoxNome = new TextBox();
            textBoxID = new TextBox();
            NIF = new Label();
            Contacto = new Label();
            Nome = new Label();
            IDRegisto = new Label();
            dataGridViewDonos = new DataGridView();
            dateTimePickerNascimento = new DateTimePicker();
            DataNascimento = new Label();
            NovosDados = new Label();
            Pesquisa = new Label();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonos).BeginInit();
            SuspendLayout();
            // 
            // buttonApagar
            // 
            buttonApagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApagar.Location = new Point(757, 174);
            buttonApagar.Margin = new Padding(3, 2, 3, 2);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(200, 60);
            buttonApagar.TabIndex = 35;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(757, 92);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(200, 60);
            buttonSalvar.TabIndex = 34;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonListar
            // 
            buttonListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListar.Location = new Point(757, 11);
            buttonListar.Margin = new Padding(3, 2, 3, 2);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(200, 60);
            buttonListar.TabIndex = 33;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // textBoxNIF
            // 
            textBoxNIF.BorderStyle = BorderStyle.FixedSingle;
            textBoxNIF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNIF.Location = new Point(279, 169);
            textBoxNIF.Margin = new Padding(3, 2, 3, 2);
            textBoxNIF.Name = "textBoxNIF";
            textBoxNIF.Size = new Size(365, 29);
            textBoxNIF.TabIndex = 31;
            // 
            // textBoxContacto
            // 
            textBoxContacto.BorderStyle = BorderStyle.FixedSingle;
            textBoxContacto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContacto.Location = new Point(279, 269);
            textBoxContacto.Margin = new Padding(3, 2, 3, 2);
            textBoxContacto.Name = "textBoxContacto";
            textBoxContacto.Size = new Size(365, 29);
            textBoxContacto.TabIndex = 30;
            // 
            // textBoxNome
            // 
            textBoxNome.BorderStyle = BorderStyle.FixedSingle;
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNome.Location = new Point(279, 220);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(365, 29);
            textBoxNome.TabIndex = 27;
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxID.Location = new Point(279, 50);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(365, 29);
            textBoxID.TabIndex = 26;
            // 
            // NIF
            // 
            NIF.AutoSize = true;
            NIF.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NIF.Location = new Point(196, 173);
            NIF.Name = "NIF";
            NIF.Size = new Size(49, 23);
            NIF.TabIndex = 25;
            NIF.Text = "NIF";
            // 
            // Contacto
            // 
            Contacto.AutoSize = true;
            Contacto.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Contacto.Location = new Point(145, 274);
            Contacto.Name = "Contacto";
            Contacto.Size = new Size(97, 23);
            Contacto.TabIndex = 24;
            Contacto.Text = "Contacto";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Nome.Location = new Point(178, 225);
            Nome.Name = "Nome";
            Nome.Size = new Size(66, 23);
            Nome.TabIndex = 21;
            Nome.Text = "Nome";
            // 
            // IDRegisto
            // 
            IDRegisto.AutoSize = true;
            IDRegisto.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            IDRegisto.Location = new Point(96, 53);
            IDRegisto.Name = "IDRegisto";
            IDRegisto.Size = new Size(143, 23);
            IDRegisto.TabIndex = 19;
            IDRegisto.Text = "ID do Registo";
            // 
            // dataGridViewDonos
            // 
            dataGridViewDonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDonos.Location = new Point(17, 309);
            dataGridViewDonos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDonos.Name = "dataGridViewDonos";
            dataGridViewDonos.RowHeadersWidth = 51;
            dataGridViewDonos.RowTemplate.Height = 29;
            dataGridViewDonos.Size = new Size(1009, 168);
            dataGridViewDonos.TabIndex = 18;
            dataGridViewDonos.CellContentClick += dataGridViewDonos_CellContentClick;
            // 
            // dateTimePickerNascimento
            // 
            dateTimePickerNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerNascimento.Location = new Point(279, 131);
            dateTimePickerNascimento.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            dateTimePickerNascimento.Size = new Size(365, 29);
            dateTimePickerNascimento.TabIndex = 36;
            // 
            // DataNascimento
            // 
            DataNascimento.AutoSize = true;
            DataNascimento.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DataNascimento.Location = new Point(31, 137);
            DataNascimento.Name = "DataNascimento";
            DataNascimento.Size = new Size(208, 23);
            DataNascimento.TabIndex = 37;
            DataNascimento.Text = "Data de Nascimento";
            // 
            // NovosDados
            // 
            NovosDados.AutoSize = true;
            NovosDados.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NovosDados.Location = new Point(214, 88);
            NovosDados.Name = "NovosDados";
            NovosDados.Size = new Size(133, 25);
            NovosDados.TabIndex = 59;
            NovosDados.Text = "Novos Dados";
            // 
            // Pesquisa
            // 
            Pesquisa.AutoSize = true;
            Pesquisa.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Pesquisa.Location = new Point(193, 16);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Size = new Size(234, 25);
            Pesquisa.TabIndex = 58;
            Pesquisa.Text = "Id para Pesquisa/Seleção";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(757, 245);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(200, 60);
            buttonCancelar.TabIndex = 60;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // ListarDonos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1042, 496);
            Controls.Add(buttonCancelar);
            Controls.Add(NovosDados);
            Controls.Add(Pesquisa);
            Controls.Add(DataNascimento);
            Controls.Add(dateTimePickerNascimento);
            Controls.Add(buttonApagar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonListar);
            Controls.Add(textBoxNIF);
            Controls.Add(textBoxContacto);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxID);
            Controls.Add(NIF);
            Controls.Add(Contacto);
            Controls.Add(Nome);
            Controls.Add(IDRegisto);
            Controls.Add(dataGridViewDonos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarDonos";
            Text = "ListarDonos";
            Load += ListarDonos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonApagar;
        private Button buttonSalvar;
        private Button buttonListar;
        private TextBox textBoxNIF;
        private TextBox textBoxContacto;
        private TextBox textBoxNome;
        private TextBox textBoxID;
        private Label NIF;
        private Label Contacto;
        private Label Nome;
        private Label IDRegisto;
        private DataGridView dataGridViewDonos;
        private DateTimePicker dateTimePickerNascimento;
        private Label DataNascimento;
        private Label NovosDados;
        private Label Pesquisa;
        private Button buttonCancelar;
    }
}