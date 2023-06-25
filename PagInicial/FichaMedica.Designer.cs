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
            this.AtoMedico = new System.Windows.Forms.Label();
            this.Descrição = new System.Windows.Forms.Label();
            this.Custo = new System.Windows.Forms.Label();
            this.textBoxDescMed = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.DataRegisto = new System.Windows.Forms.Label();
            this.dateTimePickerRegisto = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(179, 147);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(98, 20);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id do Registo";
            // 
            // AtoMedico
            // 
            this.AtoMedico.AutoSize = true;
            this.AtoMedico.Location = new System.Drawing.Point(179, 187);
            this.AtoMedico.Name = "AtoMedico";
            this.AtoMedico.Size = new System.Drawing.Size(87, 20);
            this.AtoMedico.TabIndex = 1;
            this.AtoMedico.Text = "Ato Médico";
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Location = new System.Drawing.Point(179, 235);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(178, 20);
            this.Descrição.TabIndex = 2;
            this.Descrição.Text = "Descrição do Ato Médico";
            // 
            // Custo
            // 
            this.Custo.AutoSize = true;
            this.Custo.Location = new System.Drawing.Point(177, 268);
            this.Custo.Name = "Custo";
            this.Custo.Size = new System.Drawing.Size(155, 20);
            this.Custo.TabIndex = 4;
            this.Custo.Text = "Custo por Ato Médico";
            // 
            // textBoxDescMed
            // 
            this.textBoxDescMed.Location = new System.Drawing.Point(363, 228);
            this.textBoxDescMed.Name = "textBoxDescMed";
            this.textBoxDescMed.Size = new System.Drawing.Size(207, 27);
            this.textBoxDescMed.TabIndex = 7;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(338, 261);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(244, 27);
            this.textBoxPreco.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(325, 144);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(215, 27);
            this.textBoxId.TabIndex = 9;
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(12, 377);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(209, 48);
            this.buttonListar.TabIndex = 11;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(269, 377);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(209, 48);
            this.buttonInserir.TabIndex = 12;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(542, 377);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(209, 48);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // DataRegisto
            // 
            this.DataRegisto.AutoSize = true;
            this.DataRegisto.Location = new System.Drawing.Point(93, 308);
            this.DataRegisto.Name = "DataRegisto";
            this.DataRegisto.Size = new System.Drawing.Size(197, 20);
            this.DataRegisto.TabIndex = 15;
            this.DataRegisto.Text = "Data de Inserção do Registo";
            // 
            // dateTimePickerRegisto
            // 
            this.dateTimePickerRegisto.Location = new System.Drawing.Point(296, 303);
            this.dateTimePickerRegisto.Name = "dateTimePickerRegisto";
            this.dateTimePickerRegisto.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerRegisto.TabIndex = 16;
            this.dateTimePickerRegisto.Value = new System.DateTime(2023, 6, 25, 0, 10, 15, 0);
            // 
            // comboBoxAto
            // 
            this.comboBoxAto.FormattingEnabled = true;
            this.comboBoxAto.Items.AddRange(new object[] {
            "Consulta",
            "Pequena Cirurgia",
            "Vacinação",
            "Mudança de Penso"});
            this.comboBoxAto.Location = new System.Drawing.Point(325, 184);
            this.comboBoxAto.Name = "comboBoxAto";
            this.comboBoxAto.Size = new System.Drawing.Size(215, 28);
            this.comboBoxAto.TabIndex = 32;
            // 
            // FichaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAto);
            this.Controls.Add(this.dateTimePickerRegisto);
            this.Controls.Add(this.DataRegisto);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxDescMed);
            this.Controls.Add(this.Custo);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.AtoMedico);
            this.Controls.Add(this.Id);
            this.Name = "FichaMedica";
            this.Text = "FichaMedica";
            this.Load += new System.EventHandler(this.FichaMedica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Id;
        private Label AtoMedico;
        private Label Descrição;
        private Label Custo;
        private TextBox textBoxDescMed;
        private TextBox textBoxPreco;
        private TextBox textBoxId;
        private Button buttonListar;
        private Button buttonInserir;
        private Button buttonCancelar;
        private Label DataRegisto;
        private DateTimePicker dateTimePickerRegisto;
        private ComboBox comboBoxAto;
    }
}