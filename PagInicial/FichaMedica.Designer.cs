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
            this.Id = new System.Windows.Forms.Label();
            this.TipoConsulta = new System.Windows.Forms.Label();
            this.NomeAnimal = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.textBoxAnimal = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.DataPVisita = new System.Windows.Forms.Label();
            this.dateTimePickerPVisita = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerConsulta = new System.Windows.Forms.DateTimePicker();
            this.DataAtoMédico = new System.Windows.Forms.Label();
            this.NomeColaborador = new System.Windows.Forms.Label();
            this.Diagnóstico = new System.Windows.Forms.Label();
            this.textBoxDiagnostico = new System.Windows.Forms.TextBox();
            this.textBoxExtra = new System.Windows.Forms.TextBox();
            this.Observações = new System.Windows.Forms.Label();
            this.textBoxPrescricaoMedica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxColaborador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Id.Location = new System.Drawing.Point(130, 9);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(164, 28);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id do Registo";
            // 
            // TipoConsulta
            // 
            this.TipoConsulta.AutoSize = true;
            this.TipoConsulta.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TipoConsulta.Location = new System.Drawing.Point(106, 152);
            this.TipoConsulta.Name = "TipoConsulta";
            this.TipoConsulta.Size = new System.Drawing.Size(209, 28);
            this.TipoConsulta.TabIndex = 1;
            this.TipoConsulta.Text = "Tipo de Consulta";
            // 
            // NomeAnimal
            // 
            this.NomeAnimal.AutoSize = true;
            this.NomeAnimal.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NomeAnimal.Location = new System.Drawing.Point(111, 62);
            this.NomeAnimal.Name = "NomeAnimal";
            this.NomeAnimal.Size = new System.Drawing.Size(204, 28);
            this.NomeAnimal.TabIndex = 2;
            this.NomeAnimal.Text = "Nome do Animal";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Peso.Location = new System.Drawing.Point(82, 293);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(66, 28);
            this.Peso.TabIndex = 4;
            this.Peso.Text = "Peso";
            // 
            // textBoxAnimal
            // 
            this.textBoxAnimal.Location = new System.Drawing.Point(360, 62);
            this.textBoxAnimal.Name = "textBoxAnimal";
            this.textBoxAnimal.Size = new System.Drawing.Size(391, 27);
            this.textBoxAnimal.TabIndex = 7;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(360, 297);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(391, 27);
            this.textBoxPeso.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(360, 13);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(391, 27);
            this.textBoxId.TabIndex = 9;
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(249, 515);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(219, 70);
            this.buttonListar.TabIndex = 11;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInserir.Location = new System.Drawing.Point(506, 515);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(219, 70);
            this.buttonInserir.TabIndex = 12;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(779, 515);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(219, 70);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // DataPVisita
            // 
            this.DataPVisita.AutoSize = true;
            this.DataPVisita.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DataPVisita.Location = new System.Drawing.Point(81, 433);
            this.DataPVisita.Name = "DataPVisita";
            this.DataPVisita.Size = new System.Drawing.Size(185, 28);
            this.DataPVisita.TabIndex = 15;
            this.DataPVisita.Text = "Próxima Visita";
            // 
            // dateTimePickerPVisita
            // 
            this.dateTimePickerPVisita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerPVisita.Location = new System.Drawing.Point(359, 427);
            this.dateTimePickerPVisita.Name = "dateTimePickerPVisita";
            this.dateTimePickerPVisita.Size = new System.Drawing.Size(391, 34);
            this.dateTimePickerPVisita.TabIndex = 16;
            this.dateTimePickerPVisita.Value = new System.DateTime(2023, 6, 25, 0, 10, 15, 0);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Consulta",
            "Pequena Cirurgia",
            "Vacinação",
            "Mudança de Penso"});
            this.comboBoxTipo.Location = new System.Drawing.Point(360, 156);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(391, 28);
            this.comboBoxTipo.TabIndex = 32;
            // 
            // dateTimePickerConsulta
            // 
            this.dateTimePickerConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerConsulta.Location = new System.Drawing.Point(360, 104);
            this.dateTimePickerConsulta.Name = "dateTimePickerConsulta";
            this.dateTimePickerConsulta.Size = new System.Drawing.Size(391, 34);
            this.dateTimePickerConsulta.TabIndex = 34;
            this.dateTimePickerConsulta.Value = new System.DateTime(2023, 6, 25, 0, 10, 15, 0);
            // 
            // DataAtoMédico
            // 
            this.DataAtoMédico.AutoSize = true;
            this.DataAtoMédico.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DataAtoMédico.Location = new System.Drawing.Point(82, 110);
            this.DataAtoMédico.Name = "DataAtoMédico";
            this.DataAtoMédico.Size = new System.Drawing.Size(245, 28);
            this.DataAtoMédico.TabIndex = 33;
            this.DataAtoMédico.Text = "Data Do Ato Médico";
            // 
            // NomeColaborador
            // 
            this.NomeColaborador.AutoSize = true;
            this.NomeColaborador.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NomeColaborador.Location = new System.Drawing.Point(81, 202);
            this.NomeColaborador.Name = "NomeColaborador";
            this.NomeColaborador.Size = new System.Drawing.Size(263, 28);
            this.NomeColaborador.TabIndex = 35;
            this.NomeColaborador.Text = "Nome do Colaborador";
            // 
            // Diagnóstico
            // 
            this.Diagnóstico.AutoSize = true;
            this.Diagnóstico.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Diagnóstico.Location = new System.Drawing.Point(82, 245);
            this.Diagnóstico.Name = "Diagnóstico";
            this.Diagnóstico.Size = new System.Drawing.Size(148, 28);
            this.Diagnóstico.TabIndex = 37;
            this.Diagnóstico.Text = "Diagnóstico";
            // 
            // textBoxDiagnostico
            // 
            this.textBoxDiagnostico.Location = new System.Drawing.Point(360, 249);
            this.textBoxDiagnostico.Name = "textBoxDiagnostico";
            this.textBoxDiagnostico.Size = new System.Drawing.Size(391, 27);
            this.textBoxDiagnostico.TabIndex = 38;
            // 
            // textBoxExtra
            // 
            this.textBoxExtra.Location = new System.Drawing.Point(360, 347);
            this.textBoxExtra.Name = "textBoxExtra";
            this.textBoxExtra.Size = new System.Drawing.Size(391, 27);
            this.textBoxExtra.TabIndex = 40;
            // 
            // Observações
            // 
            this.Observações.AutoSize = true;
            this.Observações.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Observações.Location = new System.Drawing.Point(72, 343);
            this.Observações.Name = "Observações";
            this.Observações.Size = new System.Drawing.Size(282, 28);
            this.Observações.TabIndex = 39;
            this.Observações.Text = "Informações Adicionais";
            // 
            // textBoxPrescricaoMedica
            // 
            this.textBoxPrescricaoMedica.Location = new System.Drawing.Point(359, 384);
            this.textBoxPrescricaoMedica.Name = "textBoxPrescricaoMedica";
            this.textBoxPrescricaoMedica.Size = new System.Drawing.Size(391, 27);
            this.textBoxPrescricaoMedica.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Prescrição Médica";
            // 
            // textBoxColaborador
            // 
            this.textBoxColaborador.Location = new System.Drawing.Point(360, 202);
            this.textBoxColaborador.Name = "textBoxColaborador";
            this.textBoxColaborador.Size = new System.Drawing.Size(391, 27);
            this.textBoxColaborador.TabIndex = 36;
            // 
            // FichaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1267, 606);
            this.Controls.Add(this.textBoxPrescricaoMedica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExtra);
            this.Controls.Add(this.Observações);
            this.Controls.Add(this.textBoxDiagnostico);
            this.Controls.Add(this.Diagnóstico);
            this.Controls.Add(this.textBoxColaborador);
            this.Controls.Add(this.NomeColaborador);
            this.Controls.Add(this.dateTimePickerConsulta);
            this.Controls.Add(this.DataAtoMédico);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.dateTimePickerPVisita);
            this.Controls.Add(this.DataPVisita);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxAnimal);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.NomeAnimal);
            this.Controls.Add(this.TipoConsulta);
            this.Controls.Add(this.Id);
            this.Name = "FichaMedica";
            this.Text = "FichaMedica";
            this.Load += new System.EventHandler(this.FichaMedica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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