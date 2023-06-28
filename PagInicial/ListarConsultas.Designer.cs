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
            buttonSalvar = new Button();
            buttonListar = new Button();
            buttonApagar = new Button();
            dateTimePickerConsulta = new DateTimePicker();
            textBoxHoraConsulta = new TextBox();
            textBoxId = new TextBox();
            comboBoxTipo = new ComboBox();
            HoraConsulta = new Label();
            DataConsulta = new Label();
            TipoConsulta = new Label();
            Id = new Label();
            dataGridViewConsultas = new DataGridView();
            label5 = new Label();
            comboBoxColab = new ComboBox();
            buttonCancelar = new Button();
            NovosDados = new Label();
            Pesquisa = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultas).BeginInit();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(802, 79);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(185, 56);
            buttonSalvar.TabIndex = 37;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonListar
            // 
            buttonListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListar.Location = new Point(802, 6);
            buttonListar.Margin = new Padding(3, 2, 3, 2);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(185, 56);
            buttonListar.TabIndex = 36;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApagar.Location = new Point(802, 155);
            buttonApagar.Margin = new Padding(3, 2, 3, 2);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(185, 56);
            buttonApagar.TabIndex = 35;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // dateTimePickerConsulta
            // 
            dateTimePickerConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerConsulta.Location = new Point(348, 206);
            dateTimePickerConsulta.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerConsulta.Name = "dateTimePickerConsulta";
            dateTimePickerConsulta.Size = new Size(364, 29);
            dateTimePickerConsulta.TabIndex = 34;
            // 
            // textBoxHoraConsulta
            // 
            textBoxHoraConsulta.BorderStyle = BorderStyle.FixedSingle;
            textBoxHoraConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHoraConsulta.Location = new Point(348, 238);
            textBoxHoraConsulta.Margin = new Padding(3, 2, 3, 2);
            textBoxHoraConsulta.Name = "textBoxHoraConsulta";
            textBoxHoraConsulta.Size = new Size(363, 29);
            textBoxHoraConsulta.TabIndex = 30;
            // 
            // textBoxId
            // 
            textBoxId.BorderStyle = BorderStyle.FixedSingle;
            textBoxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.Location = new Point(348, 53);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(363, 29);
            textBoxId.TabIndex = 29;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Consulta", "Pequena Cirurgia", "Vacinação", "Mudança de Penso" });
            comboBoxTipo.Location = new Point(348, 131);
            comboBoxTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(364, 29);
            comboBoxTipo.TabIndex = 27;
            // 
            // HoraConsulta
            // 
            HoraConsulta.AutoSize = true;
            HoraConsulta.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HoraConsulta.Location = new Point(153, 243);
            HoraConsulta.Name = "HoraConsulta";
            HoraConsulta.Size = new Size(184, 23);
            HoraConsulta.TabIndex = 26;
            HoraConsulta.Text = "Hora da Consulta";
            // 
            // DataConsulta
            // 
            DataConsulta.AutoSize = true;
            DataConsulta.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DataConsulta.Location = new Point(154, 210);
            DataConsulta.Name = "DataConsulta";
            DataConsulta.Size = new Size(183, 23);
            DataConsulta.TabIndex = 25;
            DataConsulta.Text = "Data da Consulta";
            // 
            // TipoConsulta
            // 
            TipoConsulta.AutoSize = true;
            TipoConsulta.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TipoConsulta.Location = new Point(160, 137);
            TipoConsulta.Name = "TipoConsulta";
            TipoConsulta.Size = new Size(178, 23);
            TipoConsulta.TabIndex = 22;
            TipoConsulta.Text = "Tipo de Consulta";
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Id.Location = new Point(198, 53);
            Id.Name = "Id";
            Id.Size = new Size(37, 23);
            Id.TabIndex = 19;
            Id.Text = "Id ";
            // 
            // dataGridViewConsultas
            // 
            dataGridViewConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsultas.Location = new Point(25, 292);
            dataGridViewConsultas.Margin = new Padding(3, 2, 3, 2);
            dataGridViewConsultas.Name = "dataGridViewConsultas";
            dataGridViewConsultas.RowHeadersWidth = 51;
            dataGridViewConsultas.RowTemplate.Height = 29;
            dataGridViewConsultas.Size = new Size(986, 166);
            dataGridViewConsultas.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(0, 172);
            label5.Name = "label5";
            label5.Size = new Size(332, 23);
            label5.TabIndex = 23;
            label5.Text = "Colaborador para o Atendimento";
            // 
            // comboBoxColab
            // 
            comboBoxColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxColab.FormattingEnabled = true;
            comboBoxColab.Items.AddRange(new object[] { "Médico Veterinário", "Assistente" });
            comboBoxColab.Location = new Point(348, 166);
            comboBoxColab.Margin = new Padding(3, 2, 3, 2);
            comboBoxColab.Name = "comboBoxColab";
            comboBoxColab.Size = new Size(364, 29);
            comboBoxColab.TabIndex = 28;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(802, 222);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(185, 56);
            buttonCancelar.TabIndex = 39;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // NovosDados
            // 
            NovosDados.AutoSize = true;
            NovosDados.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NovosDados.Location = new Point(279, 95);
            NovosDados.Name = "NovosDados";
            NovosDados.Size = new Size(133, 25);
            NovosDados.TabIndex = 59;
            NovosDados.Text = "Novos Dados";
            // 
            // Pesquisa
            // 
            Pesquisa.AutoSize = true;
            Pesquisa.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Pesquisa.Location = new Point(253, 12);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Size = new Size(234, 25);
            Pesquisa.TabIndex = 58;
            Pesquisa.Text = "Id para Pesquisa/Seleção";
            // 
            // ListarConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1038, 462);
            Controls.Add(NovosDados);
            Controls.Add(Pesquisa);
            Controls.Add(buttonCancelar);
            Controls.Add(dataGridViewConsultas);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonListar);
            Controls.Add(buttonApagar);
            Controls.Add(dateTimePickerConsulta);
            Controls.Add(textBoxHoraConsulta);
            Controls.Add(textBoxId);
            Controls.Add(comboBoxColab);
            Controls.Add(comboBoxTipo);
            Controls.Add(HoraConsulta);
            Controls.Add(DataConsulta);
            Controls.Add(label5);
            Controls.Add(TipoConsulta);
            Controls.Add(Id);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarConsultas";
            Text = "ListarConsultas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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