namespace veterinario_projeto.PagInicial
{
    partial class FichaMedica
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
            Id = new Label();
            TipoConsulta = new Label();
            NomeAnimal = new Label();
            Peso = new Label();
            textBoxAnimal = new TextBox();
            textBoxPeso = new TextBox();
            textBoxId = new TextBox();
            buttonListar = new Button();
            buttonInserir = new Button();
            buttonCancelar = new Button();
            DataPVisita = new Label();
            dateTimePickerPVisita = new DateTimePicker();
            comboBoxTipo = new ComboBox();
            dateTimePickerConsulta = new DateTimePicker();
            DataAtoMédico = new Label();
            NomeColaborador = new Label();
            Diagnóstico = new Label();
            textBoxDiagnostico = new TextBox();
            textBoxExtra = new TextBox();
            Observações = new Label();
            textBoxPrescricaoMedica = new TextBox();
            label1 = new Label();
            textBoxColaborador = new TextBox();
            SuspendLayout();
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Id.Location = new Point(114, 7);
            Id.Name = "Id";
            Id.Size = new Size(139, 23);
            Id.TabIndex = 0;
            Id.Text = "Id do Registo";
            // 
            // TipoConsulta
            // 
            TipoConsulta.AutoSize = true;
            TipoConsulta.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TipoConsulta.Location = new Point(93, 114);
            TipoConsulta.Name = "TipoConsulta";
            TipoConsulta.Size = new Size(178, 23);
            TipoConsulta.TabIndex = 1;
            TipoConsulta.Text = "Tipo de Consulta";
            // 
            // NomeAnimal
            // 
            NomeAnimal.AutoSize = true;
            NomeAnimal.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NomeAnimal.Location = new Point(97, 46);
            NomeAnimal.Name = "NomeAnimal";
            NomeAnimal.Size = new Size(173, 23);
            NomeAnimal.TabIndex = 2;
            NomeAnimal.Text = "Nome do Animal";
            // 
            // Peso
            // 
            Peso.AutoSize = true;
            Peso.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Peso.Location = new Point(72, 220);
            Peso.Name = "Peso";
            Peso.Size = new Size(56, 23);
            Peso.TabIndex = 4;
            Peso.Text = "Peso";
            // 
            // textBoxAnimal
            // 
            textBoxAnimal.Location = new Point(315, 46);
            textBoxAnimal.Margin = new Padding(3, 2, 3, 2);
            textBoxAnimal.Name = "textBoxAnimal";
            textBoxAnimal.Size = new Size(343, 23);
            textBoxAnimal.TabIndex = 7;
            // 
            // textBoxPeso
            // 
            textBoxPeso.Location = new Point(315, 223);
            textBoxPeso.Margin = new Padding(3, 2, 3, 2);
            textBoxPeso.Name = "textBoxPeso";
            textBoxPeso.Size = new Size(343, 23);
            textBoxPeso.TabIndex = 8;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(315, 10);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(343, 23);
            textBoxId.TabIndex = 9;
            // 
            // buttonListar
            // 
            buttonListar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListar.Location = new Point(218, 386);
            buttonListar.Margin = new Padding(3, 2, 3, 2);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(192, 52);
            buttonListar.TabIndex = 11;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInserir.Location = new Point(443, 386);
            buttonInserir.Margin = new Padding(3, 2, 3, 2);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(192, 52);
            buttonInserir.TabIndex = 12;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(682, 386);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(192, 52);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // DataPVisita
            // 
            DataPVisita.AutoSize = true;
            DataPVisita.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DataPVisita.Location = new Point(71, 325);
            DataPVisita.Name = "DataPVisita";
            DataPVisita.Size = new Size(157, 23);
            DataPVisita.TabIndex = 15;
            DataPVisita.Text = "Próxima Visita";
            // 
            // dateTimePickerPVisita
            // 
            dateTimePickerPVisita.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerPVisita.Location = new Point(314, 320);
            dateTimePickerPVisita.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerPVisita.Name = "dateTimePickerPVisita";
            dateTimePickerPVisita.Size = new Size(343, 29);
            dateTimePickerPVisita.TabIndex = 16;
            dateTimePickerPVisita.Value = new DateTime(2023, 6, 25, 0, 10, 15, 0);
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Consulta", "Pequena Cirurgia", "Vacinação", "Mudança de Penso" });
            comboBoxTipo.Location = new Point(315, 117);
            comboBoxTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(343, 23);
            comboBoxTipo.TabIndex = 32;
            // 
            // dateTimePickerConsulta
            // 
            dateTimePickerConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerConsulta.Location = new Point(315, 78);
            dateTimePickerConsulta.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerConsulta.Name = "dateTimePickerConsulta";
            dateTimePickerConsulta.Size = new Size(343, 29);
            dateTimePickerConsulta.TabIndex = 34;
            dateTimePickerConsulta.Value = new DateTime(2023, 6, 25, 0, 10, 15, 0);
            // 
            // DataAtoMédico
            // 
            DataAtoMédico.AutoSize = true;
            DataAtoMédico.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DataAtoMédico.Location = new Point(72, 82);
            DataAtoMédico.Name = "DataAtoMédico";
            DataAtoMédico.Size = new Size(206, 23);
            DataAtoMédico.TabIndex = 33;
            DataAtoMédico.Text = "Data Do Ato Médico";
            // 
            // NomeColaborador
            // 
            NomeColaborador.AutoSize = true;
            NomeColaborador.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NomeColaborador.Location = new Point(71, 152);
            NomeColaborador.Name = "NomeColaborador";
            NomeColaborador.Size = new Size(222, 23);
            NomeColaborador.TabIndex = 35;
            NomeColaborador.Text = "Nome do Colaborador";
            // 
            // Diagnóstico
            // 
            Diagnóstico.AutoSize = true;
            Diagnóstico.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Diagnóstico.Location = new Point(72, 184);
            Diagnóstico.Name = "Diagnóstico";
            Diagnóstico.Size = new Size(125, 23);
            Diagnóstico.TabIndex = 37;
            Diagnóstico.Text = "Diagnóstico";
            // 
            // textBoxDiagnostico
            // 
            textBoxDiagnostico.Location = new Point(315, 187);
            textBoxDiagnostico.Margin = new Padding(3, 2, 3, 2);
            textBoxDiagnostico.Name = "textBoxDiagnostico";
            textBoxDiagnostico.Size = new Size(343, 23);
            textBoxDiagnostico.TabIndex = 38;
            // 
            // textBoxExtra
            // 
            textBoxExtra.Location = new Point(315, 260);
            textBoxExtra.Margin = new Padding(3, 2, 3, 2);
            textBoxExtra.Name = "textBoxExtra";
            textBoxExtra.Size = new Size(343, 23);
            textBoxExtra.TabIndex = 40;
            // 
            // Observações
            // 
            Observações.AutoSize = true;
            Observações.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Observações.Location = new Point(63, 257);
            Observações.Name = "Observações";
            Observações.Size = new Size(239, 23);
            Observações.TabIndex = 39;
            Observações.Text = "Informações Adicionais";
            // 
            // textBoxPrescricaoMedica
            // 
            textBoxPrescricaoMedica.Location = new Point(314, 288);
            textBoxPrescricaoMedica.Margin = new Padding(3, 2, 3, 2);
            textBoxPrescricaoMedica.Name = "textBoxPrescricaoMedica";
            textBoxPrescricaoMedica.Size = new Size(343, 23);
            textBoxPrescricaoMedica.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(71, 292);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 41;
            label1.Text = "Prescrição Médica";
            // 
            // textBoxColaborador
            // 
            textBoxColaborador.Location = new Point(315, 152);
            textBoxColaborador.Margin = new Padding(3, 2, 3, 2);
            textBoxColaborador.Name = "textBoxColaborador";
            textBoxColaborador.Size = new Size(343, 23);
            textBoxColaborador.TabIndex = 36;
            // 
            // FichaMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1109, 454);
            Controls.Add(textBoxPrescricaoMedica);
            Controls.Add(label1);
            Controls.Add(textBoxExtra);
            Controls.Add(Observações);
            Controls.Add(textBoxDiagnostico);
            Controls.Add(Diagnóstico);
            Controls.Add(textBoxColaborador);
            Controls.Add(NomeColaborador);
            Controls.Add(dateTimePickerConsulta);
            Controls.Add(DataAtoMédico);
            Controls.Add(comboBoxTipo);
            Controls.Add(dateTimePickerPVisita);
            Controls.Add(DataPVisita);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonInserir);
            Controls.Add(buttonListar);
            Controls.Add(textBoxId);
            Controls.Add(textBoxPeso);
            Controls.Add(textBoxAnimal);
            Controls.Add(Peso);
            Controls.Add(NomeAnimal);
            Controls.Add(TipoConsulta);
            Controls.Add(Id);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FichaMedica";
            Text = "FichaMedica";
            Load += FichaMedica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Id;
        private Label TipoConsulta;
        private Label NomeAnimal;
        private Label Peso;
        private TextBox textBoxAnimal;
        private TextBox textBoxPeso;
        private TextBox textBoxId;
        private Button buttonListar;
        private Button buttonInserir;
        private Button buttonCancelar;
        private Label DataPVisita;
        private DateTimePicker dateTimePickerPVisita;
        private ComboBox comboBoxTipo;
        private DateTimePicker dateTimePickerConsulta;
        private Label DataAtoMédico;
        private Label NomeColaborador;
        private Label Diagnóstico;
        private TextBox textBoxDiagnostico;
        private TextBox textBoxExtra;
        private Label Observações;
        private TextBox textBoxPrescricaoMedica;
        private Label label1;
        private TextBox textBoxColaborador;
    }
}