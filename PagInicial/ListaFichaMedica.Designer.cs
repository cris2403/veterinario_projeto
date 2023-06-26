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
            this.dateTimePickerRegisto = new System.Windows.Forms.DateTimePicker();
            this.DataRegisto = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxDescMed = new System.Windows.Forms.TextBox();
            this.Custo = new System.Windows.Forms.Label();
            this.Descrição = new System.Windows.Forms.Label();
            this.AtoMedico = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.dataGridViewFichaMedica = new System.Windows.Forms.DataGridView();
            this.comboBoxAto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFichaMedica)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerRegisto
            // 
            this.dateTimePickerRegisto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerRegisto.Location = new System.Drawing.Point(290, 175);
            this.dateTimePickerRegisto.Name = "dateTimePickerRegisto";
            this.dateTimePickerRegisto.Size = new System.Drawing.Size(316, 34);
            this.dateTimePickerRegisto.TabIndex = 26;
            this.dateTimePickerRegisto.Value = new System.DateTime(2023, 6, 25, 0, 10, 15, 0);
            // 
            // DataRegisto
            // 
            this.DataRegisto.AutoSize = true;
            this.DataRegisto.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DataRegisto.Location = new System.Drawing.Point(16, 187);
            this.DataRegisto.Name = "DataRegisto";
            this.DataRegisto.Size = new System.Drawing.Size(268, 22);
            this.DataRegisto.TabIndex = 25;
            this.DataRegisto.Text = "Data de Inserção do Registo";
            // 
            // textBoxId
            // 
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxId.Location = new System.Drawing.Point(290, 16);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(316, 34);
            this.textBoxId.TabIndex = 23;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPreco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPreco.Location = new System.Drawing.Point(290, 137);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(316, 34);
            this.textBoxPreco.TabIndex = 22;
            // 
            // textBoxDescMed
            // 
            this.textBoxDescMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescMed.Location = new System.Drawing.Point(290, 98);
            this.textBoxDescMed.Name = "textBoxDescMed";
            this.textBoxDescMed.Size = new System.Drawing.Size(316, 34);
            this.textBoxDescMed.TabIndex = 21;
            // 
            // Custo
            // 
            this.Custo.AutoSize = true;
            this.Custo.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Custo.Location = new System.Drawing.Point(76, 149);
            this.Custo.Name = "Custo";
            this.Custo.Size = new System.Drawing.Size(208, 22);
            this.Custo.TabIndex = 20;
            this.Custo.Text = "Custo por Ato Médico";
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Descrição.Location = new System.Drawing.Point(49, 110);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(235, 22);
            this.Descrição.TabIndex = 19;
            this.Descrição.Text = "Descrição do Ato Médico";
            // 
            // AtoMedico
            // 
            this.AtoMedico.AutoSize = true;
            this.AtoMedico.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AtoMedico.Location = new System.Drawing.Point(171, 70);
            this.AtoMedico.Name = "AtoMedico";
            this.AtoMedico.Size = new System.Drawing.Size(113, 22);
            this.AtoMedico.TabIndex = 18;
            this.AtoMedico.Text = "Ato Médico";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Id.Location = new System.Drawing.Point(153, 28);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(131, 22);
            this.Id.TabIndex = 17;
            this.Id.Text = "Id do Registo";
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(612, 43);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(152, 44);
            this.buttonListar.TabIndex = 27;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(612, 104);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(152, 44);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(612, 169);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(152, 44);
            this.buttonApagar.TabIndex = 29;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // dataGridViewFichaMedica
            // 
            this.dataGridViewFichaMedica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFichaMedica.Location = new System.Drawing.Point(31, 238);
            this.dataGridViewFichaMedica.Name = "dataGridViewFichaMedica";
            this.dataGridViewFichaMedica.RowHeadersWidth = 51;
            this.dataGridViewFichaMedica.RowTemplate.Height = 29;
            this.dataGridViewFichaMedica.Size = new System.Drawing.Size(739, 188);
            this.dataGridViewFichaMedica.TabIndex = 30;
            // 
            // comboBoxAto
            // 
            this.comboBoxAto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAto.FormattingEnabled = true;
            this.comboBoxAto.Items.AddRange(new object[] {
            "Consulta",
            "Pequena Cirurgia",
            "Vacinação",
            "Mudança de Penso"});
            this.comboBoxAto.Location = new System.Drawing.Point(290, 56);
            this.comboBoxAto.Name = "comboBoxAto";
            this.comboBoxAto.Size = new System.Drawing.Size(316, 36);
            this.comboBoxAto.TabIndex = 31;
            // 
            // ListaFichaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAto);
            this.Controls.Add(this.dataGridViewFichaMedica);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.dateTimePickerRegisto);
            this.Controls.Add(this.DataRegisto);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxDescMed);
            this.Controls.Add(this.Custo);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.AtoMedico);
            this.Controls.Add(this.Id);
            this.Name = "ListaFichaMedica";
            this.Text = "ListaFichaMedica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFichaMedica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePickerRegisto;
        private Label DataRegisto;
        private TextBox textBoxId;
        private TextBox textBoxPreco;
        private TextBox textBoxDescMed;
        private Label Custo;
        private Label Descrição;
        private Label AtoMedico;
        private Label Id;
        private Button buttonListar;
        private Button buttonSalvar;
        private Button buttonApagar;
        private DataGridView dataGridViewFichaMedica;
        private ComboBox comboBoxAto;
    }
}