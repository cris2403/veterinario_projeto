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
            this.DataPVISITA = new System.Windows.Forms.Label();
            this.dateTimePickerPVisita = new System.Windows.Forms.DateTimePicker();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.textBoxColab = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxDiagnostico = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.NomeColaborador = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.Diagnostico = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.dataGridViewFichaMedica = new System.Windows.Forms.DataGridView();
            this.Observações = new System.Windows.Forms.Label();
            this.Prescricao = new System.Windows.Forms.Label();
            this.textBoxObservacoes = new System.Windows.Forms.TextBox();
            this.textBoxPrescricao = new System.Windows.Forms.TextBox();
            this.Pesquisa = new System.Windows.Forms.Label();
            this.NovosDados = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFichaMedica)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPVISITA
            // 
            this.DataPVISITA.AutoSize = true;
            this.DataPVISITA.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DataPVISITA.Location = new System.Drawing.Point(43, 153);
            this.DataPVISITA.Name = "DataPVISITA";
            this.DataPVISITA.Size = new System.Drawing.Size(220, 28);
            this.DataPVISITA.TabIndex = 51;
            this.DataPVISITA.Text = "Próxima Consulta";
            // 
            // dateTimePickerPVisita
            // 
            this.dateTimePickerPVisita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerPVisita.Location = new System.Drawing.Point(328, 147);
            this.dateTimePickerPVisita.Name = "dateTimePickerPVisita";
            this.dateTimePickerPVisita.Size = new System.Drawing.Size(417, 34);
            this.dateTimePickerPVisita.TabIndex = 50;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(875, 231);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(229, 80);
            this.buttonApagar.TabIndex = 49;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(875, 125);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(229, 80);
            this.buttonSalvar.TabIndex = 48;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(875, 19);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(229, 80);
            this.buttonListar.TabIndex = 47;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // textBoxColab
            // 
            this.textBoxColab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxColab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxColab.Location = new System.Drawing.Point(328, 191);
            this.textBoxColab.Name = "textBoxColab";
            this.textBoxColab.Size = new System.Drawing.Size(417, 34);
            this.textBoxColab.TabIndex = 46;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPeso.Location = new System.Drawing.Point(328, 276);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(417, 34);
            this.textBoxPeso.TabIndex = 45;
            // 
            // textBoxDiagnostico
            // 
            this.textBoxDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiagnostico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDiagnostico.Location = new System.Drawing.Point(328, 231);
            this.textBoxDiagnostico.Name = "textBoxDiagnostico";
            this.textBoxDiagnostico.Size = new System.Drawing.Size(417, 34);
            this.textBoxDiagnostico.TabIndex = 44;
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(328, 45);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(417, 34);
            this.textBoxID.TabIndex = 43;
            // 
            // NomeColaborador
            // 
            this.NomeColaborador.AutoSize = true;
            this.NomeColaborador.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NomeColaborador.Location = new System.Drawing.Point(43, 193);
            this.NomeColaborador.Name = "NomeColaborador";
            this.NomeColaborador.Size = new System.Drawing.Size(263, 28);
            this.NomeColaborador.TabIndex = 42;
            this.NomeColaborador.Text = "Nome do Colaborador";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Peso.Location = new System.Drawing.Point(69, 287);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(66, 28);
            this.Peso.TabIndex = 41;
            this.Peso.Text = "Peso";
            // 
            // Diagnostico
            // 
            this.Diagnostico.AutoSize = true;
            this.Diagnostico.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Diagnostico.Location = new System.Drawing.Point(57, 237);
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.Size = new System.Drawing.Size(148, 28);
            this.Diagnostico.TabIndex = 40;
            this.Diagnostico.Text = "Diagnostico";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(119, 45);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(41, 28);
            this.ID.TabIndex = 39;
            this.ID.Text = "ID";
            // 
            // dataGridViewFichaMedica
            // 
            this.dataGridViewFichaMedica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFichaMedica.Location = new System.Drawing.Point(43, 419);
            this.dataGridViewFichaMedica.Name = "dataGridViewFichaMedica";
            this.dataGridViewFichaMedica.RowHeadersWidth = 51;
            this.dataGridViewFichaMedica.RowTemplate.Height = 29;
            this.dataGridViewFichaMedica.Size = new System.Drawing.Size(1141, 211);
            this.dataGridViewFichaMedica.TabIndex = 38;
            // 
            // Observações
            // 
            this.Observações.AutoSize = true;
            this.Observações.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Observações.Location = new System.Drawing.Point(69, 324);
            this.Observações.Name = "Observações";
            this.Observações.Size = new System.Drawing.Size(157, 28);
            this.Observações.TabIndex = 52;
            this.Observações.Text = "Observações";
            // 
            // Prescricao
            // 
            this.Prescricao.AutoSize = true;
            this.Prescricao.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Prescricao.Location = new System.Drawing.Point(57, 371);
            this.Prescricao.Name = "Prescricao";
            this.Prescricao.Size = new System.Drawing.Size(222, 28);
            this.Prescricao.TabIndex = 53;
            this.Prescricao.Text = "Prescrição Médica";
            // 
            // textBoxObservacoes
            // 
            this.textBoxObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxObservacoes.Location = new System.Drawing.Point(328, 320);
            this.textBoxObservacoes.Name = "textBoxObservacoes";
            this.textBoxObservacoes.Size = new System.Drawing.Size(417, 34);
            this.textBoxObservacoes.TabIndex = 54;
            // 
            // textBoxPrescricao
            // 
            this.textBoxPrescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrescricao.Location = new System.Drawing.Point(328, 367);
            this.textBoxPrescricao.Name = "textBoxPrescricao";
            this.textBoxPrescricao.Size = new System.Drawing.Size(417, 34);
            this.textBoxPrescricao.TabIndex = 55;
            // 
            // Pesquisa
            // 
            this.Pesquisa.AutoSize = true;
            this.Pesquisa.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pesquisa.Location = new System.Drawing.Point(161, 9);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(295, 32);
            this.Pesquisa.TabIndex = 56;
            this.Pesquisa.Text = "Id para Pesquisa/Seleção";
            // 
            // NovosDados
            // 
            this.NovosDados.AutoSize = true;
            this.NovosDados.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NovosDados.Location = new System.Drawing.Point(202, 97);
            this.NovosDados.Name = "NovosDados";
            this.NovosDados.Size = new System.Drawing.Size(166, 32);
            this.NovosDados.TabIndex = 57;
            this.NovosDados.Text = "Novos Dados";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(875, 333);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(229, 80);
            this.buttonCancelar.TabIndex = 58;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // ListaFichaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1209, 641);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.NovosDados);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.textBoxPrescricao);
            this.Controls.Add(this.textBoxObservacoes);
            this.Controls.Add(this.Prescricao);
            this.Controls.Add(this.Observações);
            this.Controls.Add(this.DataPVISITA);
            this.Controls.Add(this.dateTimePickerPVisita);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.textBoxColab);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxDiagnostico);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.NomeColaborador);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Diagnostico);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridViewFichaMedica);
            this.Name = "ListaFichaMedica";
            this.Text = "ListaFichaMedica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFichaMedica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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