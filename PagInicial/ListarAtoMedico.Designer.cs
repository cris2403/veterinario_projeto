namespace veterinario_projeto.PagInicial
{
    partial class ListarAtoMedico
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
            this.NovosDados = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Label();
            this.dataGridViewAtoMedico = new System.Windows.Forms.DataGridView();
            this.dateTimePickerRegisto = new System.Windows.Forms.DateTimePicker();
            this.textBoxCusto = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.comboBoxAto = new System.Windows.Forms.ComboBox();
            this.Custo = new System.Windows.Forms.Label();
            this.DataRegisto = new System.Windows.Forms.Label();
            this.AtoMedico = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtoMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // NovosDados
            // 
            this.NovosDados.AutoSize = true;
            this.NovosDados.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NovosDados.Location = new System.Drawing.Point(164, 131);
            this.NovosDados.Name = "NovosDados";
            this.NovosDados.Size = new System.Drawing.Size(166, 32);
            this.NovosDados.TabIndex = 72;
            this.NovosDados.Text = "Novos Dados";
            // 
            // Pesquisa
            // 
            this.Pesquisa.AutoSize = true;
            this.Pesquisa.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pesquisa.Location = new System.Drawing.Point(134, 20);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(295, 32);
            this.Pesquisa.TabIndex = 71;
            this.Pesquisa.Text = "Id para Pesquisa/Seleção";
            // 
            // dataGridViewAtoMedico
            // 
            this.dataGridViewAtoMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtoMedico.Location = new System.Drawing.Point(11, 379);
            this.dataGridViewAtoMedico.Name = "dataGridViewAtoMedico";
            this.dataGridViewAtoMedico.RowHeadersWidth = 51;
            this.dataGridViewAtoMedico.RowTemplate.Height = 29;
            this.dataGridViewAtoMedico.Size = new System.Drawing.Size(1127, 221);
            this.dataGridViewAtoMedico.TabIndex = 70;
            // 
            // dateTimePickerRegisto
            // 
            this.dateTimePickerRegisto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerRegisto.Location = new System.Drawing.Point(243, 279);
            this.dateTimePickerRegisto.Name = "dateTimePickerRegisto";
            this.dateTimePickerRegisto.Size = new System.Drawing.Size(415, 34);
            this.dateTimePickerRegisto.TabIndex = 69;
            // 
            // textBoxCusto
            // 
            this.textBoxCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCusto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCusto.Location = new System.Drawing.Point(243, 328);
            this.textBoxCusto.Name = "textBoxCusto";
            this.textBoxCusto.Size = new System.Drawing.Size(415, 34);
            this.textBoxCusto.TabIndex = 68;
            // 
            // textBoxId
            // 
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxId.Location = new System.Drawing.Point(243, 75);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(415, 34);
            this.textBoxId.TabIndex = 67;
            // 
            // comboBoxAto
            // 
            this.comboBoxAto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAto.FormattingEnabled = true;
            this.comboBoxAto.Items.AddRange(new object[] {
            "Médico Veterinário",
            "Assistente"});
            this.comboBoxAto.Location = new System.Drawing.Point(243, 233);
            this.comboBoxAto.Name = "comboBoxAto";
            this.comboBoxAto.Size = new System.Drawing.Size(415, 36);
            this.comboBoxAto.TabIndex = 66;
            // 
            // Custo
            // 
            this.Custo.AutoSize = true;
            this.Custo.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Custo.Location = new System.Drawing.Point(20, 328);
            this.Custo.Name = "Custo";
            this.Custo.Size = new System.Drawing.Size(80, 28);
            this.Custo.TabIndex = 64;
            this.Custo.Text = "Custo";
            // 
            // DataRegisto
            // 
            this.DataRegisto.AutoSize = true;
            this.DataRegisto.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DataRegisto.Location = new System.Drawing.Point(21, 284);
            this.DataRegisto.Name = "DataRegisto";
            this.DataRegisto.Size = new System.Drawing.Size(197, 28);
            this.DataRegisto.TabIndex = 63;
            this.DataRegisto.Text = "Data do Registo";
            // 
            // AtoMedico
            // 
            this.AtoMedico.AutoSize = true;
            this.AtoMedico.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AtoMedico.Location = new System.Drawing.Point(28, 241);
            this.AtoMedico.Name = "AtoMedico";
            this.AtoMedico.Size = new System.Drawing.Size(142, 28);
            this.AtoMedico.TabIndex = 62;
            this.AtoMedico.Text = "Ato Médico";
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Descricao.Location = new System.Drawing.Point(28, 187);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(124, 28);
            this.Descricao.TabIndex = 61;
            this.Descricao.Text = "Descrição";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Id.Location = new System.Drawing.Point(71, 75);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(43, 28);
            this.Id.TabIndex = 60;
            this.Id.Text = "Id ";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDesc.Location = new System.Drawing.Point(243, 185);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(415, 34);
            this.textBoxDesc.TabIndex = 73;
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Apagar.Location = new System.Drawing.Point(890, 203);
            this.btn_Apagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(206, 66);
            this.btn_Apagar.TabIndex = 74;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(890, 112);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(206, 66);
            this.buttonSalvar.TabIndex = 75;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(890, 20);
            this.buttonListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(206, 66);
            this.buttonListar.TabIndex = 76;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(890, 296);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(206, 66);
            this.buttonCancelar.TabIndex = 77;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // ListarAtoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1150, 612);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.NovosDados);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.dataGridViewAtoMedico);
            this.Controls.Add(this.dateTimePickerRegisto);
            this.Controls.Add(this.textBoxCusto);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.comboBoxAto);
            this.Controls.Add(this.Custo);
            this.Controls.Add(this.DataRegisto);
            this.Controls.Add(this.AtoMedico);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.Id);
            this.Name = "ListarAtoMedico";
            this.Text = "ListarAtoMedico";
            this.Load += new System.EventHandler(this.ListarAtoMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtoMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NovosDados;
        private Label Pesquisa;
        private DataGridView dataGridViewAtoMedico;
        private DateTimePicker dateTimePickerRegisto;
        private TextBox textBoxCusto;
        private TextBox textBoxId;
        private ComboBox comboBoxAto;
        private Label Custo;
        private Label DataRegisto;
        private Label AtoMedico;
        private Label Descricao;
        private Label Id;
        private TextBox textBoxDesc;
        private Button btn_Apagar;
        private Button buttonSalvar;
        private Button buttonListar;
        private Button buttonCancelar;
    }
}