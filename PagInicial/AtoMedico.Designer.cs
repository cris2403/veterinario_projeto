namespace veterinario_projeto.PagInicial
{
    partial class AtoMedico
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
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_custo = new System.Windows.Forms.Label();
            this.lbl_DataRegisto = new System.Windows.Forms.Label();
            this.lbl_AtoMedico = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxCusto = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataRegisto = new System.Windows.Forms.DateTimePicker();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxAtoMedico = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_desc.Location = new System.Drawing.Point(24, 147);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(124, 28);
            this.lbl_desc.TabIndex = 13;
            this.lbl_desc.Text = "Descrição";
            // 
            // lbl_custo
            // 
            this.lbl_custo.AutoSize = true;
            this.lbl_custo.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_custo.Location = new System.Drawing.Point(24, 101);
            this.lbl_custo.Name = "lbl_custo";
            this.lbl_custo.Size = new System.Drawing.Size(80, 28);
            this.lbl_custo.TabIndex = 12;
            this.lbl_custo.Text = "Custo";
            // 
            // lbl_DataRegisto
            // 
            this.lbl_DataRegisto.AutoSize = true;
            this.lbl_DataRegisto.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_DataRegisto.Location = new System.Drawing.Point(7, 216);
            this.lbl_DataRegisto.Name = "lbl_DataRegisto";
            this.lbl_DataRegisto.Size = new System.Drawing.Size(197, 28);
            this.lbl_DataRegisto.TabIndex = 11;
            this.lbl_DataRegisto.Text = "Data do Registo";
            // 
            // lbl_AtoMedico
            // 
            this.lbl_AtoMedico.AutoSize = true;
            this.lbl_AtoMedico.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_AtoMedico.Location = new System.Drawing.Point(24, 59);
            this.lbl_AtoMedico.Name = "lbl_AtoMedico";
            this.lbl_AtoMedico.Size = new System.Drawing.Size(142, 28);
            this.lbl_AtoMedico.TabIndex = 10;
            this.lbl_AtoMedico.Text = "Ato Médico";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_id.Location = new System.Drawing.Point(77, 19);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(36, 28);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(197, 19);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(263, 27);
            this.textBoxId.TabIndex = 14;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(197, 147);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(263, 27);
            this.textBoxDesc.TabIndex = 15;
            // 
            // textBoxCusto
            // 
            this.textBoxCusto.Location = new System.Drawing.Point(197, 105);
            this.textBoxCusto.Name = "textBoxCusto";
            this.textBoxCusto.Size = new System.Drawing.Size(263, 27);
            this.textBoxCusto.TabIndex = 16;
            // 
            // dateTimePickerDataRegisto
            // 
            this.dateTimePickerDataRegisto.Location = new System.Drawing.Point(210, 218);
            this.dateTimePickerDataRegisto.Name = "dateTimePickerDataRegisto";
            this.dateTimePickerDataRegisto.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerDataRegisto.TabIndex = 18;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInserir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInserir.Location = new System.Drawing.Point(24, 358);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(150, 66);
            this.buttonInserir.TabIndex = 19;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(299, 358);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(150, 66);
            this.buttonListar.TabIndex = 20;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(558, 358);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 66);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxAtoMedico
            // 
            this.comboBoxAtoMedico.FormattingEnabled = true;
            this.comboBoxAtoMedico.Items.AddRange(new object[] {
            "Consulta",
            "Pequena Cirurgia",
            "Vacinação",
            "Mudança de penso"});
            this.comboBoxAtoMedico.Location = new System.Drawing.Point(197, 60);
            this.comboBoxAtoMedico.Name = "comboBoxAtoMedico";
            this.comboBoxAtoMedico.Size = new System.Drawing.Size(264, 28);
            this.comboBoxAtoMedico.TabIndex = 22;
            // 
            // AtoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAtoMedico);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.dateTimePickerDataRegisto);
            this.Controls.Add(this.textBoxCusto);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_custo);
            this.Controls.Add(this.lbl_DataRegisto);
            this.Controls.Add(this.lbl_AtoMedico);
            this.Controls.Add(this.lbl_id);
            this.Name = "AtoMedico";
            this.Text = "AtoMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_desc;
        private Label lbl_custo;
        private Label lbl_DataRegisto;
        private Label lbl_AtoMedico;
        private Label lbl_id;
        private TextBox textBoxId;
        private TextBox textBoxDesc;
        private TextBox textBoxCusto;
        private DateTimePicker dateTimePickerDataRegisto;
        private Button buttonInserir;
        private Button buttonListar;
        private Button buttonCancelar;
        private ComboBox comboBoxAtoMedico;
    }
}