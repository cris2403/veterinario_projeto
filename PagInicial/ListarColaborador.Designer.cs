namespace veterinario_projeto.PagInicial
{
    partial class ListarColaborador
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
            textBoxContacto = new TextBox();
            textBoxNIF = new TextBox();
            textBoxNome = new TextBox();
            textBoxID = new TextBox();
            Função = new Label();
            Contacto = new Label();
            Tipo = new Label();
            NIF = new Label();
            Nome = new Label();
            ID = new Label();
            dataGridViewColaborador = new DataGridView();
            dateTimePickerNascimento = new DateTimePicker();
            label1 = new Label();
            textBoxDisp = new TextBox();
            date_fimColab = new DateTimePicker();
            date_inicioColab = new DateTimePicker();
            lbl_disponibilidadeColab = new Label();
            lbl_datafimColab = new Label();
            lbl_datainicioColab = new Label();
            comboBox_funcaoColab = new ComboBox();
            comboBox_tipoColab = new ComboBox();
            NovosDados = new Label();
            Pesquisa = new Label();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewColaborador).BeginInit();
            SuspendLayout();
            // 
            // buttonApagar
            // 
            buttonApagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApagar.Location = new Point(725, 166);
            buttonApagar.Margin = new Padding(3, 2, 3, 2);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(200, 54);
            buttonApagar.TabIndex = 35;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(725, 92);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(200, 54);
            buttonSalvar.TabIndex = 34;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonListar
            // 
            buttonListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListar.Location = new Point(725, 22);
            buttonListar.Margin = new Padding(3, 2, 3, 2);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(200, 54);
            buttonListar.TabIndex = 33;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // textBoxContacto
            // 
            textBoxContacto.BorderStyle = BorderStyle.FixedSingle;
            textBoxContacto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContacto.Location = new Point(116, 266);
            textBoxContacto.Margin = new Padding(3, 2, 3, 2);
            textBoxContacto.Name = "textBoxContacto";
            textBoxContacto.Size = new Size(227, 29);
            textBoxContacto.TabIndex = 30;
            // 
            // textBoxNIF
            // 
            textBoxNIF.BorderStyle = BorderStyle.FixedSingle;
            textBoxNIF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNIF.Location = new Point(116, 227);
            textBoxNIF.Margin = new Padding(3, 2, 3, 2);
            textBoxNIF.Name = "textBoxNIF";
            textBoxNIF.Size = new Size(227, 29);
            textBoxNIF.TabIndex = 29;
            // 
            // textBoxNome
            // 
            textBoxNome.BorderStyle = BorderStyle.FixedSingle;
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNome.Location = new Point(116, 191);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(227, 29);
            textBoxNome.TabIndex = 27;
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxID.Location = new Point(118, 39);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(227, 29);
            textBoxID.TabIndex = 26;
            // 
            // Função
            // 
            Função.AutoSize = true;
            Função.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Função.Location = new Point(26, 164);
            Função.Name = "Função";
            Função.Size = new Size(70, 20);
            Função.TabIndex = 25;
            Função.Text = "Função";
            // 
            // Contacto
            // 
            Contacto.AutoSize = true;
            Contacto.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Contacto.Location = new Point(11, 267);
            Contacto.Name = "Contacto";
            Contacto.Size = new Size(83, 20);
            Contacto.TabIndex = 24;
            Contacto.Text = "Contacto";
            // 
            // Tipo
            // 
            Tipo.AutoSize = true;
            Tipo.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Tipo.Location = new Point(51, 126);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(46, 20);
            Tipo.TabIndex = 23;
            Tipo.Text = "Tipo";
            // 
            // NIF
            // 
            NIF.AutoSize = true;
            NIF.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NIF.Location = new Point(55, 237);
            NIF.Name = "NIF";
            NIF.Size = new Size(43, 20);
            NIF.TabIndex = 22;
            NIF.Text = "NIF";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Nome.Location = new Point(39, 202);
            Nome.Name = "Nome";
            Nome.Size = new Size(56, 20);
            Nome.TabIndex = 21;
            Nome.Text = "Nome";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ID.Location = new Point(68, 48);
            ID.Name = "ID";
            ID.Size = new Size(30, 20);
            ID.TabIndex = 19;
            ID.Text = "ID";
            // 
            // dataGridViewColaborador
            // 
            dataGridViewColaborador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColaborador.Location = new Point(5, 309);
            dataGridViewColaborador.Margin = new Padding(3, 2, 3, 2);
            dataGridViewColaborador.Name = "dataGridViewColaborador";
            dataGridViewColaborador.RowHeadersWidth = 51;
            dataGridViewColaborador.RowTemplate.Height = 29;
            dataGridViewColaborador.Size = new Size(1009, 156);
            dataGridViewColaborador.TabIndex = 18;
            // 
            // dateTimePickerNascimento
            // 
            dateTimePickerNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerNascimento.Location = new Point(390, 92);
            dateTimePickerNascimento.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            dateTimePickerNascimento.Size = new Size(227, 29);
            dateTimePickerNascimento.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(408, 70);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 37;
            label1.Text = "Data de Nascimento";
            // 
            // textBoxDisp
            // 
            textBoxDisp.BorderStyle = BorderStyle.FixedSingle;
            textBoxDisp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDisp.Location = new Point(390, 266);
            textBoxDisp.Name = "textBoxDisp";
            textBoxDisp.Size = new Size(227, 29);
            textBoxDisp.TabIndex = 43;
            // 
            // date_fimColab
            // 
            date_fimColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_fimColab.Location = new Point(390, 204);
            date_fimColab.Name = "date_fimColab";
            date_fimColab.Size = new Size(227, 29);
            date_fimColab.TabIndex = 42;
            // 
            // date_inicioColab
            // 
            date_inicioColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_inicioColab.Location = new Point(390, 146);
            date_inicioColab.Name = "date_inicioColab";
            date_inicioColab.Size = new Size(227, 29);
            date_inicioColab.TabIndex = 41;
            date_inicioColab.ValueChanged += date_inicioColab_ValueChanged;
            // 
            // lbl_disponibilidadeColab
            // 
            lbl_disponibilidadeColab.AutoSize = true;
            lbl_disponibilidadeColab.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_disponibilidadeColab.Location = new Point(408, 236);
            lbl_disponibilidadeColab.Name = "lbl_disponibilidadeColab";
            lbl_disponibilidadeColab.Size = new Size(209, 20);
            lbl_disponibilidadeColab.TabIndex = 40;
            lbl_disponibilidadeColab.Text = "Disponibilidade Horária";
            // 
            // lbl_datafimColab
            // 
            lbl_datafimColab.AutoSize = true;
            lbl_datafimColab.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_datafimColab.Location = new Point(390, 181);
            lbl_datafimColab.Name = "lbl_datafimColab";
            lbl_datafimColab.Size = new Size(243, 20);
            lbl_datafimColab.TabIndex = 39;
            lbl_datafimColab.Text = "Data do Fim da Colaboração";
            // 
            // lbl_datainicioColab
            // 
            lbl_datainicioColab.AutoSize = true;
            lbl_datainicioColab.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_datainicioColab.Location = new Point(390, 123);
            lbl_datainicioColab.Name = "lbl_datainicioColab";
            lbl_datainicioColab.Size = new Size(258, 20);
            lbl_datainicioColab.TabIndex = 38;
            lbl_datainicioColab.Text = "Data de Inicio da Colaboração";
            // 
            // comboBox_funcaoColab
            // 
            comboBox_funcaoColab.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_funcaoColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_funcaoColab.FormattingEnabled = true;
            comboBox_funcaoColab.Items.AddRange(new object[] { "Médico Veterinário", "Assistente" });
            comboBox_funcaoColab.Location = new Point(116, 153);
            comboBox_funcaoColab.Name = "comboBox_funcaoColab";
            comboBox_funcaoColab.Size = new Size(227, 29);
            comboBox_funcaoColab.TabIndex = 45;
            // 
            // comboBox_tipoColab
            // 
            comboBox_tipoColab.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tipoColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_tipoColab.FormattingEnabled = true;
            comboBox_tipoColab.Items.AddRange(new object[] { "Interno", "Externo" });
            comboBox_tipoColab.Location = new Point(116, 117);
            comboBox_tipoColab.Name = "comboBox_tipoColab";
            comboBox_tipoColab.Size = new Size(227, 29);
            comboBox_tipoColab.TabIndex = 44;
            // 
            // NovosDados
            // 
            NovosDados.AutoSize = true;
            NovosDados.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NovosDados.Location = new Point(159, 89);
            NovosDados.Name = "NovosDados";
            NovosDados.Size = new Size(133, 25);
            NovosDados.TabIndex = 59;
            NovosDados.Text = "Novos Dados";
            // 
            // Pesquisa
            // 
            Pesquisa.AutoSize = true;
            Pesquisa.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Pesquisa.Location = new Point(118, 4);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Size = new Size(234, 25);
            Pesquisa.TabIndex = 58;
            Pesquisa.Text = "Id para Pesquisa/Seleção";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(725, 233);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(200, 54);
            buttonCancelar.TabIndex = 60;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // ListarColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1018, 470);
            Controls.Add(buttonCancelar);
            Controls.Add(NovosDados);
            Controls.Add(Pesquisa);
            Controls.Add(comboBox_funcaoColab);
            Controls.Add(comboBox_tipoColab);
            Controls.Add(textBoxDisp);
            Controls.Add(date_fimColab);
            Controls.Add(date_inicioColab);
            Controls.Add(lbl_disponibilidadeColab);
            Controls.Add(lbl_datafimColab);
            Controls.Add(lbl_datainicioColab);
            Controls.Add(label1);
            Controls.Add(dateTimePickerNascimento);
            Controls.Add(buttonApagar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonListar);
            Controls.Add(textBoxContacto);
            Controls.Add(textBoxNIF);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxID);
            Controls.Add(Função);
            Controls.Add(Contacto);
            Controls.Add(Tipo);
            Controls.Add(NIF);
            Controls.Add(Nome);
            Controls.Add(ID);
            Controls.Add(dataGridViewColaborador);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarColaborador";
            Text = "ListarColaborador";
            Load += ListarColaborador_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewColaborador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonApagar;
        private Button buttonSalvar;
        private Button buttonListar;
        private TextBox textBoxContacto;
        private TextBox textBoxNIF;
        private TextBox textBoxNome;
        private TextBox textBoxID;
        private Label Função;
        private Label Contacto;
        private Label Tipo;
        private Label NIF;
        private Label Nome;
        private Label ID;
        private DataGridView dataGridViewColaborador;
        private DateTimePicker dateTimePickerNascimento;
        private Label label1;
        private TextBox textBoxDisp;
        private DateTimePicker date_fimColab;
        private DateTimePicker date_inicioColab;
        private Label lbl_disponibilidadeColab;
        private Label lbl_datafimColab;
        private Label lbl_datainicioColab;
        private ComboBox comboBox_funcaoColab;
        private ComboBox comboBox_tipoColab;
        private Label NovosDados;
        private Label Pesquisa;
        private Button buttonCancelar;
    }
}