namespace veterinario_projeto.PagInicial
{
    partial class ListaFichaMedica
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
            DataPVISITA = new Label();
            dateTimePickerPVisita = new DateTimePicker();
            buttonApagar = new Button();
            buttonSalvar = new Button();
            buttonListar = new Button();
            textBoxColab = new TextBox();
            textBoxPeso = new TextBox();
            textBoxDiagnostico = new TextBox();
            textBoxID = new TextBox();
            NomeColaborador = new Label();
            Peso = new Label();
            Diagnostico = new Label();
            ID = new Label();
            dataGridViewFichaMedica = new DataGridView();
            Observações = new Label();
            Prescricao = new Label();
            textBoxObservacoes = new TextBox();
            textBoxPrescricao = new TextBox();
            Pesquisa = new Label();
            NovosDados = new Label();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFichaMedica).BeginInit();
            SuspendLayout();
            // 
            // DataPVISITA
            // 
            DataPVISITA.AutoSize = true;
            DataPVISITA.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DataPVISITA.Location = new Point(38, 115);
            DataPVISITA.Name = "DataPVISITA";
            DataPVISITA.Size = new Size(187, 23);
            DataPVISITA.TabIndex = 51;
            DataPVISITA.Text = "Próxima Consulta";
            DataPVISITA.Click += DataPVISITA_Click;
            // 
            // dateTimePickerPVisita
            // 
            dateTimePickerPVisita.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerPVisita.Location = new Point(287, 110);
            dateTimePickerPVisita.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerPVisita.Name = "dateTimePickerPVisita";
            dateTimePickerPVisita.Size = new Size(365, 29);
            dateTimePickerPVisita.TabIndex = 50;
            // 
            // buttonApagar
            // 
            buttonApagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApagar.Location = new Point(766, 173);
            buttonApagar.Margin = new Padding(3, 2, 3, 2);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(200, 60);
            buttonApagar.TabIndex = 49;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(766, 94);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(200, 60);
            buttonSalvar.TabIndex = 48;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonListar
            // 
            buttonListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListar.Location = new Point(766, 14);
            buttonListar.Margin = new Padding(3, 2, 3, 2);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(200, 60);
            buttonListar.TabIndex = 47;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // textBoxColab
            // 
            textBoxColab.BorderStyle = BorderStyle.FixedSingle;
            textBoxColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxColab.Location = new Point(287, 143);
            textBoxColab.Margin = new Padding(3, 2, 3, 2);
            textBoxColab.Name = "textBoxColab";
            textBoxColab.Size = new Size(365, 29);
            textBoxColab.TabIndex = 46;
            // 
            // textBoxPeso
            // 
            textBoxPeso.BorderStyle = BorderStyle.FixedSingle;
            textBoxPeso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPeso.Location = new Point(287, 207);
            textBoxPeso.Margin = new Padding(3, 2, 3, 2);
            textBoxPeso.Name = "textBoxPeso";
            textBoxPeso.Size = new Size(365, 29);
            textBoxPeso.TabIndex = 45;
            // 
            // textBoxDiagnostico
            // 
            textBoxDiagnostico.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiagnostico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDiagnostico.Location = new Point(287, 173);
            textBoxDiagnostico.Margin = new Padding(3, 2, 3, 2);
            textBoxDiagnostico.Name = "textBoxDiagnostico";
            textBoxDiagnostico.Size = new Size(365, 29);
            textBoxDiagnostico.TabIndex = 44;
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxID.Location = new Point(287, 34);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(365, 29);
            textBoxID.TabIndex = 43;
            // 
            // NomeColaborador
            // 
            NomeColaborador.AutoSize = true;
            NomeColaborador.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NomeColaborador.Location = new Point(38, 145);
            NomeColaborador.Name = "NomeColaborador";
            NomeColaborador.Size = new Size(222, 23);
            NomeColaborador.TabIndex = 42;
            NomeColaborador.Text = "Nome do Colaborador";
            // 
            // Peso
            // 
            Peso.AutoSize = true;
            Peso.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Peso.Location = new Point(60, 215);
            Peso.Name = "Peso";
            Peso.Size = new Size(56, 23);
            Peso.TabIndex = 41;
            Peso.Text = "Peso";
            // 
            // Diagnostico
            // 
            Diagnostico.AutoSize = true;
            Diagnostico.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Diagnostico.Location = new Point(50, 178);
            Diagnostico.Name = "Diagnostico";
            Diagnostico.Size = new Size(125, 23);
            Diagnostico.TabIndex = 40;
            Diagnostico.Text = "Diagnostico";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ID.Location = new Point(104, 34);
            ID.Name = "ID";
            ID.Size = new Size(35, 23);
            ID.TabIndex = 39;
            ID.Text = "ID";
            // 
            // dataGridViewFichaMedica
            // 
            dataGridViewFichaMedica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFichaMedica.Location = new Point(38, 314);
            dataGridViewFichaMedica.Margin = new Padding(3, 2, 3, 2);
            dataGridViewFichaMedica.Name = "dataGridViewFichaMedica";
            dataGridViewFichaMedica.RowHeadersWidth = 51;
            dataGridViewFichaMedica.RowTemplate.Height = 29;
            dataGridViewFichaMedica.Size = new Size(998, 158);
            dataGridViewFichaMedica.TabIndex = 38;
            dataGridViewFichaMedica.CellContentClick += dataGridViewFichaMedica_CellContentClick;
            // 
            // Observações
            // 
            Observações.AutoSize = true;
            Observações.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Observações.Location = new Point(60, 243);
            Observações.Name = "Observações";
            Observações.Size = new Size(132, 23);
            Observações.TabIndex = 52;
            Observações.Text = "Observações";
            // 
            // Prescricao
            // 
            Prescricao.AutoSize = true;
            Prescricao.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Prescricao.Location = new Point(50, 278);
            Prescricao.Name = "Prescricao";
            Prescricao.Size = new Size(187, 23);
            Prescricao.TabIndex = 53;
            Prescricao.Text = "Prescrição Médica";
            // 
            // textBoxObservacoes
            // 
            textBoxObservacoes.BorderStyle = BorderStyle.FixedSingle;
            textBoxObservacoes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxObservacoes.Location = new Point(287, 240);
            textBoxObservacoes.Margin = new Padding(3, 2, 3, 2);
            textBoxObservacoes.Name = "textBoxObservacoes";
            textBoxObservacoes.Size = new Size(365, 29);
            textBoxObservacoes.TabIndex = 54;
            // 
            // textBoxPrescricao
            // 
            textBoxPrescricao.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrescricao.Location = new Point(287, 275);
            textBoxPrescricao.Margin = new Padding(3, 2, 3, 2);
            textBoxPrescricao.Name = "textBoxPrescricao";
            textBoxPrescricao.Size = new Size(365, 29);
            textBoxPrescricao.TabIndex = 55;
            // 
            // Pesquisa
            // 
            Pesquisa.AutoSize = true;
            Pesquisa.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Pesquisa.Location = new Point(141, 7);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Size = new Size(234, 25);
            Pesquisa.TabIndex = 56;
            Pesquisa.Text = "Id para Pesquisa/Seleção";
            Pesquisa.Click += Pesquisa_Click;
            // 
            // NovosDados
            // 
            NovosDados.AutoSize = true;
            NovosDados.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NovosDados.Location = new Point(177, 73);
            NovosDados.Name = "NovosDados";
            NovosDados.Size = new Size(133, 25);
            NovosDados.TabIndex = 57;
            NovosDados.Text = "Novos Dados";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(766, 250);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(200, 60);
            buttonCancelar.TabIndex = 58;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // ListaFichaMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1058, 481);
            Controls.Add(buttonCancelar);
            Controls.Add(NovosDados);
            Controls.Add(Pesquisa);
            Controls.Add(textBoxPrescricao);
            Controls.Add(textBoxObservacoes);
            Controls.Add(Prescricao);
            Controls.Add(Observações);
            Controls.Add(DataPVISITA);
            Controls.Add(dateTimePickerPVisita);
            Controls.Add(buttonApagar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonListar);
            Controls.Add(textBoxColab);
            Controls.Add(textBoxPeso);
            Controls.Add(textBoxDiagnostico);
            Controls.Add(textBoxID);
            Controls.Add(NomeColaborador);
            Controls.Add(Peso);
            Controls.Add(Diagnostico);
            Controls.Add(ID);
            Controls.Add(dataGridViewFichaMedica);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListaFichaMedica";
            Text = "ListaFichaMedica";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFichaMedica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DataPVISITA;
        private DateTimePicker dateTimePickerPVisita;
        private Button buttonApagar;
        private Button buttonSalvar;
        private Button buttonListar;
        private TextBox textBoxColab;
        private TextBox textBoxPeso;
        private TextBox textBoxDiagnostico;
        private TextBox textBoxID;
        private Label NomeColaborador;
        private Label Peso;
        private Label Diagnostico;
        private Label ID;
        private DataGridView dataGridViewFichaMedica;
        private Label Observações;
        private Label Prescricao;
        private TextBox textBoxObservacoes;
        private TextBox textBoxPrescricao;
        private Label Pesquisa;
        private Label NovosDados;
        private Button buttonCancelar;
    }
}