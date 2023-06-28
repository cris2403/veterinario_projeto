namespace veterinario_projeto.PagInicial
{
    partial class Colaboradores
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
            lbl_idColab = new Label();
            lbl_nomeColab = new Label();
            lbl_NascColab = new Label();
            lbl_nifColab = new Label();
            lbl_tipoColab = new Label();
            lbl_funcaoColab = new Label();
            lbl_datainicioColab = new Label();
            lbl_datafimColab = new Label();
            lbl_contactoColab = new Label();
            lbl_disponibilidadeColab = new Label();
            date_nascimentoColab = new DateTimePicker();
            date_inicioColab = new DateTimePicker();
            date_fimColab = new DateTimePicker();
            txt_idColab = new TextBox();
            txt_contactoColab = new TextBox();
            txt_nifColab = new TextBox();
            txt_nomeColab = new TextBox();
            btn_salvarColab = new Button();
            btn_cancelarColab = new Button();
            btn_limparColab = new Button();
            comboBox_tipoColab = new ComboBox();
            comboBox_funcaoColab = new ComboBox();
            txt_disponibilidadeColab = new TextBox();
            buttonListar = new Button();
            SuspendLayout();
            // 
            // lbl_idColab
            // 
            lbl_idColab.AutoSize = true;
            lbl_idColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_idColab.Location = new Point(133, 28);
            lbl_idColab.Name = "lbl_idColab";
            lbl_idColab.Size = new Size(187, 23);
            lbl_idColab.TabIndex = 0;
            lbl_idColab.Text = "Id de Colaborador";
            // 
            // lbl_nomeColab
            // 
            lbl_nomeColab.AutoSize = true;
            lbl_nomeColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_nomeColab.Location = new Point(274, 58);
            lbl_nomeColab.Name = "lbl_nomeColab";
            lbl_nomeColab.Size = new Size(66, 23);
            lbl_nomeColab.TabIndex = 1;
            lbl_nomeColab.Text = "Nome";
            // 
            // lbl_NascColab
            // 
            lbl_NascColab.AutoSize = true;
            lbl_NascColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_NascColab.Location = new Point(109, 86);
            lbl_NascColab.Name = "lbl_NascColab";
            lbl_NascColab.Size = new Size(208, 23);
            lbl_NascColab.TabIndex = 2;
            lbl_NascColab.Text = "Data de Nascimento";
            // 
            // lbl_nifColab
            // 
            lbl_nifColab.AutoSize = true;
            lbl_nifColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_nifColab.Location = new Point(292, 116);
            lbl_nifColab.Name = "lbl_nifColab";
            lbl_nifColab.Size = new Size(49, 23);
            lbl_nifColab.TabIndex = 3;
            lbl_nifColab.Text = "NIF";
            // 
            // lbl_tipoColab
            // 
            lbl_tipoColab.AutoSize = true;
            lbl_tipoColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_tipoColab.Location = new Point(109, 144);
            lbl_tipoColab.Name = "lbl_tipoColab";
            lbl_tipoColab.Size = new Size(210, 23);
            lbl_tipoColab.TabIndex = 4;
            lbl_tipoColab.Text = "Tipo de Colaborador";
            // 
            // lbl_funcaoColab
            // 
            lbl_funcaoColab.AutoSize = true;
            lbl_funcaoColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_funcaoColab.Location = new Point(259, 174);
            lbl_funcaoColab.Name = "lbl_funcaoColab";
            lbl_funcaoColab.Size = new Size(82, 23);
            lbl_funcaoColab.TabIndex = 5;
            lbl_funcaoColab.Text = "Função";
            // 
            // lbl_datainicioColab
            // 
            lbl_datainicioColab.AutoSize = true;
            lbl_datainicioColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_datainicioColab.Location = new Point(10, 231);
            lbl_datainicioColab.Name = "lbl_datainicioColab";
            lbl_datainicioColab.Size = new Size(306, 23);
            lbl_datainicioColab.TabIndex = 6;
            lbl_datainicioColab.Text = "Data de Inicio da Colaboração";
            // 
            // lbl_datafimColab
            // 
            lbl_datafimColab.AutoSize = true;
            lbl_datafimColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_datafimColab.Location = new Point(28, 259);
            lbl_datafimColab.Name = "lbl_datafimColab";
            lbl_datafimColab.Size = new Size(289, 23);
            lbl_datafimColab.TabIndex = 7;
            lbl_datafimColab.Text = "Data do Fim da Colaboração";
            // 
            // lbl_contactoColab
            // 
            lbl_contactoColab.AutoSize = true;
            lbl_contactoColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_contactoColab.Location = new Point(242, 202);
            lbl_contactoColab.Name = "lbl_contactoColab";
            lbl_contactoColab.Size = new Size(97, 23);
            lbl_contactoColab.TabIndex = 8;
            lbl_contactoColab.Text = "Contacto";
            // 
            // lbl_disponibilidadeColab
            // 
            lbl_disponibilidadeColab.AutoSize = true;
            lbl_disponibilidadeColab.Font = new Font("Century", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_disponibilidadeColab.Location = new Point(70, 335);
            lbl_disponibilidadeColab.Name = "lbl_disponibilidadeColab";
            lbl_disponibilidadeColab.Size = new Size(249, 23);
            lbl_disponibilidadeColab.TabIndex = 9;
            lbl_disponibilidadeColab.Text = "Disponibilidade Horária";
            // 
            // date_nascimentoColab
            // 
            date_nascimentoColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_nascimentoColab.Location = new Point(363, 82);
            date_nascimentoColab.Name = "date_nascimentoColab";
            date_nascimentoColab.Size = new Size(236, 29);
            date_nascimentoColab.TabIndex = 10;
            // 
            // date_inicioColab
            // 
            date_inicioColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_inicioColab.Location = new Point(363, 226);
            date_inicioColab.Name = "date_inicioColab";
            date_inicioColab.Size = new Size(236, 29);
            date_inicioColab.TabIndex = 11;
            // 
            // date_fimColab
            // 
            date_fimColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_fimColab.Location = new Point(363, 255);
            date_fimColab.Name = "date_fimColab";
            date_fimColab.Size = new Size(236, 29);
            date_fimColab.TabIndex = 12;
            // 
            // txt_idColab
            // 
            txt_idColab.BorderStyle = BorderStyle.FixedSingle;
            txt_idColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idColab.Location = new Point(363, 23);
            txt_idColab.Name = "txt_idColab";
            txt_idColab.Size = new Size(236, 29);
            txt_idColab.TabIndex = 14;
            // 
            // txt_contactoColab
            // 
            txt_contactoColab.BorderStyle = BorderStyle.FixedSingle;
            txt_contactoColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_contactoColab.Location = new Point(363, 198);
            txt_contactoColab.Name = "txt_contactoColab";
            txt_contactoColab.Size = new Size(236, 29);
            txt_contactoColab.TabIndex = 16;
            // 
            // txt_nifColab
            // 
            txt_nifColab.BorderStyle = BorderStyle.FixedSingle;
            txt_nifColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nifColab.Location = new Point(363, 111);
            txt_nifColab.Name = "txt_nifColab";
            txt_nifColab.Size = new Size(236, 29);
            txt_nifColab.TabIndex = 19;
            // 
            // txt_nomeColab
            // 
            txt_nomeColab.BorderStyle = BorderStyle.FixedSingle;
            txt_nomeColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeColab.Location = new Point(363, 53);
            txt_nomeColab.Name = "txt_nomeColab";
            txt_nomeColab.Size = new Size(236, 29);
            txt_nomeColab.TabIndex = 20;
            // 
            // btn_salvarColab
            // 
            btn_salvarColab.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvarColab.Location = new Point(46, 475);
            btn_salvarColab.Name = "btn_salvarColab";
            btn_salvarColab.Size = new Size(128, 40);
            btn_salvarColab.TabIndex = 21;
            btn_salvarColab.Text = "Salvar";
            btn_salvarColab.UseVisualStyleBackColor = true;
            btn_salvarColab.Click += btn_salvarColab_Click;
            // 
            // btn_cancelarColab
            // 
            btn_cancelarColab.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelarColab.Location = new Point(448, 477);
            btn_cancelarColab.Name = "btn_cancelarColab";
            btn_cancelarColab.Size = new Size(130, 40);
            btn_cancelarColab.TabIndex = 22;
            btn_cancelarColab.Text = "Cancelar";
            btn_cancelarColab.UseVisualStyleBackColor = true;
            btn_cancelarColab.Click += btn_cancelarColab_Click;
            // 
            // btn_limparColab
            // 
            btn_limparColab.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limparColab.Location = new Point(242, 475);
            btn_limparColab.Name = "btn_limparColab";
            btn_limparColab.Size = new Size(130, 40);
            btn_limparColab.TabIndex = 23;
            btn_limparColab.Text = "Limpar";
            btn_limparColab.UseVisualStyleBackColor = true;
            btn_limparColab.Click += btn_limparColab_Click;
            // 
            // comboBox_tipoColab
            // 
            comboBox_tipoColab.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tipoColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_tipoColab.FormattingEnabled = true;
            comboBox_tipoColab.Items.AddRange(new object[] { "Interno", "Externo" });
            comboBox_tipoColab.Location = new Point(363, 138);
            comboBox_tipoColab.Name = "comboBox_tipoColab";
            comboBox_tipoColab.Size = new Size(236, 29);
            comboBox_tipoColab.TabIndex = 24;
            // 
            // comboBox_funcaoColab
            // 
            comboBox_funcaoColab.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_funcaoColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_funcaoColab.FormattingEnabled = true;
            comboBox_funcaoColab.Items.AddRange(new object[] { "Médico Veterinário", "Assistente" });
            comboBox_funcaoColab.Location = new Point(363, 168);
            comboBox_funcaoColab.Name = "comboBox_funcaoColab";
            comboBox_funcaoColab.Size = new Size(236, 29);
            comboBox_funcaoColab.TabIndex = 25;
            // 
            // txt_disponibilidadeColab
            // 
            txt_disponibilidadeColab.BorderStyle = BorderStyle.FixedSingle;
            txt_disponibilidadeColab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_disponibilidadeColab.Location = new Point(363, 331);
            txt_disponibilidadeColab.Name = "txt_disponibilidadeColab";
            txt_disponibilidadeColab.Size = new Size(236, 29);
            txt_disponibilidadeColab.TabIndex = 26;
            // 
            // buttonListar
            // 
            buttonListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListar.Location = new Point(242, 403);
            buttonListar.Margin = new Padding(3, 2, 3, 2);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(130, 40);
            buttonListar.TabIndex = 27;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // Colaboradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(609, 536);
            Controls.Add(buttonListar);
            Controls.Add(txt_disponibilidadeColab);
            Controls.Add(comboBox_funcaoColab);
            Controls.Add(comboBox_tipoColab);
            Controls.Add(btn_limparColab);
            Controls.Add(btn_cancelarColab);
            Controls.Add(btn_salvarColab);
            Controls.Add(txt_nomeColab);
            Controls.Add(txt_nifColab);
            Controls.Add(txt_contactoColab);
            Controls.Add(txt_idColab);
            Controls.Add(date_fimColab);
            Controls.Add(date_inicioColab);
            Controls.Add(date_nascimentoColab);
            Controls.Add(lbl_disponibilidadeColab);
            Controls.Add(lbl_contactoColab);
            Controls.Add(lbl_datafimColab);
            Controls.Add(lbl_datainicioColab);
            Controls.Add(lbl_funcaoColab);
            Controls.Add(lbl_tipoColab);
            Controls.Add(lbl_nifColab);
            Controls.Add(lbl_NascColab);
            Controls.Add(lbl_nomeColab);
            Controls.Add(lbl_idColab);
            Name = "Colaboradores";
            Text = "Colaboradores";
            Load += Colaboradores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_idColab;
        private Label lbl_nomeColab;
        private Label lbl_NascColab;
        private Label lbl_nifColab;
        private Label lbl_tipoColab;
        private Label lbl_funcaoColab;
        private Label lbl_datainicioColab;
        private Label lbl_datafimColab;
        private Label lbl_contactoColab;
        private Label lbl_disponibilidadeColab;
        private DateTimePicker date_nascimentoColab;
        private DateTimePicker date_inicioColab;
        private DateTimePicker date_fimColab;
        private TextBox txt_idColab;
        private TextBox txt_contactoColab;
        private TextBox txt_nifColab;
        private TextBox txt_nomeColab;
        private Button btn_salvarColab;
        private Button btn_cancelarColab;
        private Button btn_limparColab;
        private ComboBox comboBox_tipoColab;
        private ComboBox comboBox_funcaoColab;
        private TextBox txt_disponibilidadeColab;
        private Button buttonListar;
    }
}