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
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.Função = new System.Windows.Forms.Label();
            this.Contacto = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.NIF = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.dataGridViewColaborador = new System.Windows.Forms.DataGridView();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDisp = new System.Windows.Forms.TextBox();
            this.date_fimColab = new System.Windows.Forms.DateTimePicker();
            this.date_inicioColab = new System.Windows.Forms.DateTimePicker();
            this.lbl_disponibilidadeColab = new System.Windows.Forms.Label();
            this.lbl_datafimColab = new System.Windows.Forms.Label();
            this.lbl_datainicioColab = new System.Windows.Forms.Label();
            this.comboBox_funcaoColab = new System.Windows.Forms.ComboBox();
            this.comboBox_tipoColab = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(831, 254);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(228, 54);
            this.buttonApagar.TabIndex = 35;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(831, 145);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(228, 54);
            this.buttonSalvar.TabIndex = 34;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(831, 37);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(228, 54);
            this.buttonListar.TabIndex = 33;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Location = new System.Drawing.Point(81, 241);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(233, 27);
            this.textBoxContacto.TabIndex = 30;
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(67, 197);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(233, 27);
            this.textBoxNIF.TabIndex = 29;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(67, 154);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(233, 27);
            this.textBoxNome.TabIndex = 27;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(52, 8);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(233, 27);
            this.textBoxID.TabIndex = 26;
            // 
            // Função
            // 
            this.Função.AutoSize = true;
            this.Função.Location = new System.Drawing.Point(6, 105);
            this.Função.Name = "Função";
            this.Função.Size = new System.Drawing.Size(56, 20);
            this.Função.TabIndex = 25;
            this.Função.Text = "Função";
            // 
            // Contacto
            // 
            this.Contacto.AutoSize = true;
            this.Contacto.Location = new System.Drawing.Point(6, 244);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(69, 20);
            this.Contacto.TabIndex = 24;
            this.Contacto.Text = "Contacto";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(22, 54);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(39, 20);
            this.Tipo.TabIndex = 23;
            this.Tipo.Text = "Tipo";
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Location = new System.Drawing.Point(22, 204);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(31, 20);
            this.NIF.TabIndex = 22;
            this.NIF.Text = "NIF";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 152);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(50, 20);
            this.Nome.TabIndex = 21;
            this.Nome.Text = "Nome";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(22, 8);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 20);
            this.ID.TabIndex = 19;
            this.ID.Text = "ID";
            // 
            // dataGridViewColaborador
            // 
            this.dataGridViewColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColaborador.Location = new System.Drawing.Point(6, 346);
            this.dataGridViewColaborador.Name = "dataGridViewColaborador";
            this.dataGridViewColaborador.RowHeadersWidth = 51;
            this.dataGridViewColaborador.RowTemplate.Height = 29;
            this.dataGridViewColaborador.Size = new System.Drawing.Size(1153, 273);
            this.dataGridViewColaborador.TabIndex = 18;
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(403, 37);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerNascimento.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Data de Nascimento";
            // 
            // textBoxDisp
            // 
            this.textBoxDisp.Location = new System.Drawing.Point(394, 237);
            this.textBoxDisp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDisp.Name = "textBoxDisp";
            this.textBoxDisp.Size = new System.Drawing.Size(259, 27);
            this.textBoxDisp.TabIndex = 43;
            // 
            // date_fimColab
            // 
            this.date_fimColab.Location = new System.Drawing.Point(394, 152);
            this.date_fimColab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_fimColab.Name = "date_fimColab";
            this.date_fimColab.Size = new System.Drawing.Size(259, 27);
            this.date_fimColab.TabIndex = 42;
            // 
            // date_inicioColab
            // 
            this.date_inicioColab.Location = new System.Drawing.Point(394, 97);
            this.date_inicioColab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_inicioColab.Name = "date_inicioColab";
            this.date_inicioColab.Size = new System.Drawing.Size(259, 27);
            this.date_inicioColab.TabIndex = 41;
            this.date_inicioColab.ValueChanged += new System.EventHandler(this.date_inicioColab_ValueChanged);
            // 
            // lbl_disponibilidadeColab
            // 
            this.lbl_disponibilidadeColab.AutoSize = true;
            this.lbl_disponibilidadeColab.Location = new System.Drawing.Point(422, 197);
            this.lbl_disponibilidadeColab.Name = "lbl_disponibilidadeColab";
            this.lbl_disponibilidadeColab.Size = new System.Drawing.Size(169, 20);
            this.lbl_disponibilidadeColab.TabIndex = 40;
            this.lbl_disponibilidadeColab.Text = "Disponibilidade Horária";
            // 
            // lbl_datafimColab
            // 
            this.lbl_datafimColab.AutoSize = true;
            this.lbl_datafimColab.Location = new System.Drawing.Point(417, 128);
            this.lbl_datafimColab.Name = "lbl_datafimColab";
            this.lbl_datafimColab.Size = new System.Drawing.Size(201, 20);
            this.lbl_datafimColab.TabIndex = 39;
            this.lbl_datafimColab.Text = "Data do Fim da Colaboração";
            // 
            // lbl_datainicioColab
            // 
            this.lbl_datainicioColab.AutoSize = true;
            this.lbl_datainicioColab.Location = new System.Drawing.Point(417, 73);
            this.lbl_datainicioColab.Name = "lbl_datainicioColab";
            this.lbl_datainicioColab.Size = new System.Drawing.Size(212, 20);
            this.lbl_datainicioColab.TabIndex = 38;
            this.lbl_datainicioColab.Text = "Data de Inicio da Colaboração";
            // 
            // comboBox_funcaoColab
            // 
            this.comboBox_funcaoColab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_funcaoColab.FormattingEnabled = true;
            this.comboBox_funcaoColab.Items.AddRange(new object[] {
            "Médico Veterinário",
            "Assistente"});
            this.comboBox_funcaoColab.Location = new System.Drawing.Point(81, 102);
            this.comboBox_funcaoColab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_funcaoColab.Name = "comboBox_funcaoColab";
            this.comboBox_funcaoColab.Size = new System.Drawing.Size(259, 28);
            this.comboBox_funcaoColab.TabIndex = 45;
            // 
            // comboBox_tipoColab
            // 
            this.comboBox_tipoColab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoColab.FormattingEnabled = true;
            this.comboBox_tipoColab.Items.AddRange(new object[] {
            "Interno",
            "Externo"});
            this.comboBox_tipoColab.Location = new System.Drawing.Point(81, 51);
            this.comboBox_tipoColab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_tipoColab.Name = "comboBox_tipoColab";
            this.comboBox_tipoColab.Size = new System.Drawing.Size(259, 28);
            this.comboBox_tipoColab.TabIndex = 44;
            // 
            // ListarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 626);
            this.Controls.Add(this.comboBox_funcaoColab);
            this.Controls.Add(this.comboBox_tipoColab);
            this.Controls.Add(this.textBoxDisp);
            this.Controls.Add(this.date_fimColab);
            this.Controls.Add(this.date_inicioColab);
            this.Controls.Add(this.lbl_disponibilidadeColab);
            this.Controls.Add(this.lbl_datafimColab);
            this.Controls.Add(this.lbl_datainicioColab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.Função);
            this.Controls.Add(this.Contacto);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.NIF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridViewColaborador);
            this.Name = "ListarColaborador";
            this.Text = "ListarColaborador";
            this.Load += new System.EventHandler(this.ListarColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColaborador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}