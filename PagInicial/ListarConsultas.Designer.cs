namespace veterinario_projeto.PagInicial
{
    partial class ListarConsultas
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.dateTimePickerConsulta = new System.Windows.Forms.DateTimePicker();
            this.textBoxHoraConsulta = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.HoraConsulta = new System.Windows.Forms.Label();
            this.DataConsulta = new System.Windows.Forms.Label();
            this.TipoConsulta = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.dataGridViewConsultas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxColab = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.NovosDados = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(917, 105);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(211, 75);
            this.buttonSalvar.TabIndex = 37;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(917, 8);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(211, 75);
            this.buttonListar.TabIndex = 36;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(917, 207);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(211, 75);
            this.buttonApagar.TabIndex = 35;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // dateTimePickerConsulta
            // 
            this.dateTimePickerConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerConsulta.Location = new System.Drawing.Point(398, 275);
            this.dateTimePickerConsulta.Name = "dateTimePickerConsulta";
            this.dateTimePickerConsulta.Size = new System.Drawing.Size(415, 34);
            this.dateTimePickerConsulta.TabIndex = 34;
            // 
            // textBoxHoraConsulta
            // 
            this.textBoxHoraConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHoraConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHoraConsulta.Location = new System.Drawing.Point(398, 317);
            this.textBoxHoraConsulta.Name = "textBoxHoraConsulta";
            this.textBoxHoraConsulta.Size = new System.Drawing.Size(415, 34);
            this.textBoxHoraConsulta.TabIndex = 30;
            // 
            // textBoxId
            // 
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxId.Location = new System.Drawing.Point(398, 71);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(415, 34);
            this.textBoxId.TabIndex = 29;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Consulta",
            "Pequena Cirurgia",
            "Vacinação",
            "Mudança de Penso"});
            this.comboBoxTipo.Location = new System.Drawing.Point(398, 175);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(415, 36);
            this.comboBoxTipo.TabIndex = 27;
            // 
            // HoraConsulta
            // 
            this.HoraConsulta.AutoSize = true;
            this.HoraConsulta.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HoraConsulta.Location = new System.Drawing.Point(175, 324);
            this.HoraConsulta.Name = "HoraConsulta";
            this.HoraConsulta.Size = new System.Drawing.Size(217, 28);
            this.HoraConsulta.TabIndex = 26;
            this.HoraConsulta.Text = "Hora da Consulta";
            // 
            // DataConsulta
            // 
            this.DataConsulta.AutoSize = true;
            this.DataConsulta.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DataConsulta.Location = new System.Drawing.Point(176, 280);
            this.DataConsulta.Name = "DataConsulta";
            this.DataConsulta.Size = new System.Drawing.Size(216, 28);
            this.DataConsulta.TabIndex = 25;
            this.DataConsulta.Text = "Data da Consulta";
            // 
            // TipoConsulta
            // 
            this.TipoConsulta.AutoSize = true;
            this.TipoConsulta.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TipoConsulta.Location = new System.Drawing.Point(183, 183);
            this.TipoConsulta.Name = "TipoConsulta";
            this.TipoConsulta.Size = new System.Drawing.Size(209, 28);
            this.TipoConsulta.TabIndex = 22;
            this.TipoConsulta.Text = "Tipo de Consulta";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Id.Location = new System.Drawing.Point(226, 71);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(43, 28);
            this.Id.TabIndex = 19;
            this.Id.Text = "Id ";
            // 
            // dataGridViewConsultas
            // 
            this.dataGridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultas.Location = new System.Drawing.Point(29, 389);
            this.dataGridViewConsultas.Name = "dataGridViewConsultas";
            this.dataGridViewConsultas.RowHeadersWidth = 51;
            this.dataGridViewConsultas.RowTemplate.Height = 29;
            this.dataGridViewConsultas.Size = new System.Drawing.Size(1127, 221);
            this.dataGridViewConsultas.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Colaborador para o Atendimento";
            // 
            // comboBoxColab
            // 
            this.comboBoxColab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxColab.FormattingEnabled = true;
            this.comboBoxColab.Items.AddRange(new object[] {
            "Médico Veterinário",
            "Assistente"});
            this.comboBoxColab.Location = new System.Drawing.Point(398, 221);
            this.comboBoxColab.Name = "comboBoxColab";
            this.comboBoxColab.Size = new System.Drawing.Size(415, 36);
            this.comboBoxColab.TabIndex = 28;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(917, 296);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(211, 75);
            this.buttonCancelar.TabIndex = 39;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // NovosDados
            // 
            this.NovosDados.AutoSize = true;
            this.NovosDados.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NovosDados.Location = new System.Drawing.Point(319, 127);
            this.NovosDados.Name = "NovosDados";
            this.NovosDados.Size = new System.Drawing.Size(166, 32);
            this.NovosDados.TabIndex = 59;
            this.NovosDados.Text = "Novos Dados";
            // 
            // Pesquisa
            // 
            this.Pesquisa.AutoSize = true;
            this.Pesquisa.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pesquisa.Location = new System.Drawing.Point(289, 16);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(295, 32);
            this.Pesquisa.TabIndex = 58;
            this.Pesquisa.Text = "Id para Pesquisa/Seleção";
            // 
            // ListarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1186, 616);
            this.Controls.Add(this.NovosDados);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewConsultas);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dateTimePickerConsulta);
            this.Controls.Add(this.textBoxHoraConsulta);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.comboBoxColab);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.HoraConsulta);
            this.Controls.Add(this.DataConsulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TipoConsulta);
            this.Controls.Add(this.Id);
            this.Name = "ListarConsultas";
            this.Text = "ListarConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonListar;
        private Button buttonApagar;
        private DateTimePicker dateTimePickerConsulta;
        private TextBox textBoxHoraConsulta;
        private TextBox textBoxId;
        private ComboBox comboBoxTipo;
        private Label HoraConsulta;
        private Label DataConsulta;
        private Label TipoConsulta;
        private Label Id;
        private DataGridView dataGridViewConsultas;
        private Label label5;
        private ComboBox comboBoxColab;
        private Button buttonCancelar;
        private Label NovosDados;
        private Label Pesquisa;
    }
}