namespace veterinario_projeto.PagInicial
{
    partial class ListarDonos
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
            buttonApagar = new Button();
            buttonSalvar = new Button();
            buttonListar = new Button();
            textBoxNIF = new TextBox();
            textBoxContacto = new TextBox();
            textBoxNome = new TextBox();
            textBoxID = new TextBox();
            NIF = new Label();
            Contacto = new Label();
            Nome = new Label();
            IDRegisto = new Label();
            dataGridViewDonos = new DataGridView();
            dateTimePickerNascimento = new DateTimePicker();
            DataNascimento = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonos).BeginInit();
            SuspendLayout();
            // 
            // buttonApagar
            // 
            buttonApagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApagar.Location = new Point(758, 182);
            buttonApagar.Margin = new Padding(3, 2, 3, 2);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(200, 60);
            buttonApagar.TabIndex = 35;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(758, 100);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(200, 60);
            buttonSalvar.TabIndex = 34;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonListar
            // 
            buttonListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListar.Location = new Point(758, 19);
            buttonListar.Margin = new Padding(3, 2, 3, 2);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(200, 60);
            buttonListar.TabIndex = 33;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // textBoxNIF
            // 
            textBoxNIF.BorderStyle = BorderStyle.FixedSingle;
            textBoxNIF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNIF.Location = new Point(279, 85);
            textBoxNIF.Margin = new Padding(3, 2, 3, 2);
            textBoxNIF.Name = "textBoxNIF";
            textBoxNIF.Size = new Size(365, 29);
            textBoxNIF.TabIndex = 31;
            // 
            // textBoxContacto
            // 
            textBoxContacto.BorderStyle = BorderStyle.FixedSingle;
            textBoxContacto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContacto.Location = new Point(279, 185);
            textBoxContacto.Margin = new Padding(3, 2, 3, 2);
            textBoxContacto.Name = "textBoxContacto";
            textBoxContacto.Size = new Size(365, 29);
            textBoxContacto.TabIndex = 30;
            // 
            // textBoxNome
            // 
            textBoxNome.BorderStyle = BorderStyle.FixedSingle;
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNome.Location = new Point(279, 136);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(365, 29);
            textBoxNome.TabIndex = 27;
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxID.Location = new Point(279, 14);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(365, 29);
            textBoxID.TabIndex = 26;
            // 
            // NIF
            // 
            NIF.AutoSize = true;
            NIF.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NIF.Location = new Point(196, 89);
            NIF.Name = "NIF";
            NIF.Size = new Size(49, 23);
            NIF.TabIndex = 25;
            NIF.Text = "NIF";
            // 
            // Contacto
            // 
            Contacto.AutoSize = true;
            Contacto.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Contacto.Location = new Point(145, 190);
            Contacto.Name = "Contacto";
            Contacto.Size = new Size(97, 23);
            Contacto.TabIndex = 24;
            Contacto.Text = "Contacto";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Nome.Location = new Point(178, 141);
            Nome.Name = "Nome";
            Nome.Size = new Size(66, 23);
            Nome.TabIndex = 21;
            Nome.Text = "Nome";
            // 
            // IDRegisto
            // 
            IDRegisto.AutoSize = true;
            IDRegisto.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            IDRegisto.Location = new Point(99, 19);
            IDRegisto.Name = "IDRegisto";
            IDRegisto.Size = new Size(143, 23);
            IDRegisto.TabIndex = 19;
            IDRegisto.Text = "ID do Registo";
            // 
            // dataGridViewDonos
            // 
            dataGridViewDonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDonos.Location = new Point(17, 272);
            dataGridViewDonos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDonos.Name = "dataGridViewDonos";
            dataGridViewDonos.RowHeadersWidth = 51;
            dataGridViewDonos.RowTemplate.Height = 29;
            dataGridViewDonos.Size = new Size(1009, 205);
            dataGridViewDonos.TabIndex = 18;
            dataGridViewDonos.CellContentClick += dataGridViewDonos_CellContentClick;
            // 
            // dateTimePickerNascimento
            // 
            dateTimePickerNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerNascimento.Location = new Point(279, 47);
            dateTimePickerNascimento.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            dateTimePickerNascimento.Size = new Size(365, 29);
            dateTimePickerNascimento.TabIndex = 36;
            // 
            // DataNascimento
            // 
            DataNascimento.AutoSize = true;
            DataNascimento.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DataNascimento.Location = new Point(31, 53);
            DataNascimento.Name = "DataNascimento";
            DataNascimento.Size = new Size(208, 23);
            DataNascimento.TabIndex = 37;
            DataNascimento.Text = "Data de Nascimento";
            // 
            // ListarDonos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1042, 496);
            Controls.Add(DataNascimento);
            Controls.Add(dateTimePickerNascimento);
            Controls.Add(buttonApagar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonListar);
            Controls.Add(textBoxNIF);
            Controls.Add(textBoxContacto);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxID);
            Controls.Add(NIF);
            Controls.Add(Contacto);
            Controls.Add(Nome);
            Controls.Add(IDRegisto);
            Controls.Add(dataGridViewDonos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarDonos";
            Text = "ListarDonos";
            Load += ListarDonos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonApagar;
        private Button buttonSalvar;
        private Button buttonListar;
        private TextBox textBoxNIF;
        private TextBox textBoxContacto;
        private TextBox textBoxNome;
        private TextBox textBoxID;
        private Label NIF;
        private Label Contacto;
        private Label Nome;
        private Label IDRegisto;
        private DataGridView dataGridViewDonos;
        private DateTimePicker dateTimePickerNascimento;
        private Label DataNascimento;
    }
}