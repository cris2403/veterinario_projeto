namespace veterinario_projeto.PagInicial
{
    partial class Pagamentos
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
            this.btn_inserirPagamentos = new System.Windows.Forms.Button();
            this.btn_ListarPagamentos = new System.Windows.Forms.Button();
            this.btn_cancelarPagamentos = new System.Windows.Forms.Button();
            this.data_ProdPreco = new System.Windows.Forms.DataGridView();
            this.txt_AtoMedicoCusto = new System.Windows.Forms.TextBox();
            this.lbl_AtoMedicoCusto = new System.Windows.Forms.Label();
            this.txt_QuantProduto = new System.Windows.Forms.Label();
            this.data_AtoMedicoCusto = new System.Windows.Forms.DataGridView();
            this.lbl_descricaoAtoMedico = new System.Windows.Forms.Label();
            this.txt_descricaoAtoMedico = new System.Windows.Forms.TextBox();
            this.lbl_AtoMedico = new System.Windows.Forms.Label();
            this.lbl_tipoProduto = new System.Windows.Forms.Label();
            this.lbl_DescricaoProduto = new System.Windows.Forms.Label();
            this.txt_descricaoProduto = new System.Windows.Forms.TextBox();
            this.txt_PrecoProduto = new System.Windows.Forms.TextBox();
            this.lbl_PrecoProduto = new System.Windows.Forms.Label();
            this.txt_QtdProduto = new System.Windows.Forms.TextBox();
            this.txt_atomedico = new System.Windows.Forms.ComboBox();
            this.txt_tipoProduto = new System.Windows.Forms.ComboBox();
            this.btn_pendentes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_ProdPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_AtoMedicoCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inserirPagamentos
            // 
            this.btn_inserirPagamentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_inserirPagamentos.Location = new System.Drawing.Point(14, 628);
            this.btn_inserirPagamentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_inserirPagamentos.Name = "btn_inserirPagamentos";
            this.btn_inserirPagamentos.Size = new System.Drawing.Size(323, 59);
            this.btn_inserirPagamentos.TabIndex = 1;
            this.btn_inserirPagamentos.Text = "Adicionar";
            this.btn_inserirPagamentos.UseVisualStyleBackColor = true;
            this.btn_inserirPagamentos.Click += new System.EventHandler(this.btn_inserirPagamentos_Click);
            // 
            // btn_ListarPagamentos
            // 
            this.btn_ListarPagamentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ListarPagamentos.Location = new System.Drawing.Point(344, 628);
            this.btn_ListarPagamentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ListarPagamentos.Name = "btn_ListarPagamentos";
            this.btn_ListarPagamentos.Size = new System.Drawing.Size(323, 59);
            this.btn_ListarPagamentos.TabIndex = 25;
            this.btn_ListarPagamentos.Text = "Listar";
            this.btn_ListarPagamentos.UseVisualStyleBackColor = true;
            this.btn_ListarPagamentos.Click += new System.EventHandler(this.btn_ListarPagamentos_Click);
            // 
            // btn_cancelarPagamentos
            // 
            this.btn_cancelarPagamentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelarPagamentos.Location = new System.Drawing.Point(1089, 628);
            this.btn_cancelarPagamentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancelarPagamentos.Name = "btn_cancelarPagamentos";
            this.btn_cancelarPagamentos.Size = new System.Drawing.Size(323, 59);
            this.btn_cancelarPagamentos.TabIndex = 26;
            this.btn_cancelarPagamentos.Text = "Cancelar";
            this.btn_cancelarPagamentos.UseVisualStyleBackColor = true;
            this.btn_cancelarPagamentos.Click += new System.EventHandler(this.btn_cancelarPagamentos_Click);
            // 
            // data_ProdPreco
            // 
            this.data_ProdPreco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ProdPreco.Location = new System.Drawing.Point(825, 411);
            this.data_ProdPreco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_ProdPreco.Name = "data_ProdPreco";
            this.data_ProdPreco.RowHeadersWidth = 51;
            this.data_ProdPreco.Size = new System.Drawing.Size(587, 185);
            this.data_ProdPreco.TabIndex = 28;
            // 
            // txt_AtoMedicoCusto
            // 
            this.txt_AtoMedicoCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AtoMedicoCusto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_AtoMedicoCusto.Location = new System.Drawing.Point(14, 259);
            this.txt_AtoMedicoCusto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AtoMedicoCusto.Name = "txt_AtoMedicoCusto";
            this.txt_AtoMedicoCusto.Size = new System.Drawing.Size(607, 34);
            this.txt_AtoMedicoCusto.TabIndex = 29;
            // 
            // lbl_AtoMedicoCusto
            // 
            this.lbl_AtoMedicoCusto.AutoSize = true;
            this.lbl_AtoMedicoCusto.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_AtoMedicoCusto.Location = new System.Drawing.Point(14, 223);
            this.lbl_AtoMedicoCusto.Name = "lbl_AtoMedicoCusto";
            this.lbl_AtoMedicoCusto.Size = new System.Drawing.Size(260, 28);
            this.lbl_AtoMedicoCusto.TabIndex = 31;
            this.lbl_AtoMedicoCusto.Text = "Custo do Ato Médico";
            // 
            // txt_QuantProduto
            // 
            this.txt_QuantProduto.AutoSize = true;
            this.txt_QuantProduto.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_QuantProduto.Location = new System.Drawing.Point(825, 223);
            this.txt_QuantProduto.Name = "txt_QuantProduto";
            this.txt_QuantProduto.Size = new System.Drawing.Size(294, 28);
            this.txt_QuantProduto.TabIndex = 32;
            this.txt_QuantProduto.Text = "Quantidade do Produto";
            // 
            // data_AtoMedicoCusto
            // 
            this.data_AtoMedicoCusto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_AtoMedicoCusto.Location = new System.Drawing.Point(14, 411);
            this.data_AtoMedicoCusto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_AtoMedicoCusto.Name = "data_AtoMedicoCusto";
            this.data_AtoMedicoCusto.RowHeadersWidth = 51;
            this.data_AtoMedicoCusto.RowTemplate.Height = 25;
            this.data_AtoMedicoCusto.Size = new System.Drawing.Size(607, 185);
            this.data_AtoMedicoCusto.TabIndex = 27;
            // 
            // lbl_descricaoAtoMedico
            // 
            this.lbl_descricaoAtoMedico.AutoSize = true;
            this.lbl_descricaoAtoMedico.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_descricaoAtoMedico.Location = new System.Drawing.Point(14, 127);
            this.lbl_descricaoAtoMedico.Name = "lbl_descricaoAtoMedico";
            this.lbl_descricaoAtoMedico.Size = new System.Drawing.Size(308, 28);
            this.lbl_descricaoAtoMedico.TabIndex = 33;
            this.lbl_descricaoAtoMedico.Text = "Descrição do Ato Médico";
            // 
            // txt_descricaoAtoMedico
            // 
            this.txt_descricaoAtoMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descricaoAtoMedico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_descricaoAtoMedico.Location = new System.Drawing.Point(14, 163);
            this.txt_descricaoAtoMedico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_descricaoAtoMedico.Name = "txt_descricaoAtoMedico";
            this.txt_descricaoAtoMedico.Size = new System.Drawing.Size(607, 34);
            this.txt_descricaoAtoMedico.TabIndex = 34;
            // 
            // lbl_AtoMedico
            // 
            this.lbl_AtoMedico.AutoSize = true;
            this.lbl_AtoMedico.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_AtoMedico.Location = new System.Drawing.Point(14, 27);
            this.lbl_AtoMedico.Name = "lbl_AtoMedico";
            this.lbl_AtoMedico.Size = new System.Drawing.Size(147, 28);
            this.lbl_AtoMedico.TabIndex = 35;
            this.lbl_AtoMedico.Text = "Ato Médico";
            // 
            // lbl_tipoProduto
            // 
            this.lbl_tipoProduto.AutoSize = true;
            this.lbl_tipoProduto.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_tipoProduto.Location = new System.Drawing.Point(825, 27);
            this.lbl_tipoProduto.Name = "lbl_tipoProduto";
            this.lbl_tipoProduto.Size = new System.Drawing.Size(206, 28);
            this.lbl_tipoProduto.TabIndex = 37;
            this.lbl_tipoProduto.Text = "Tipo de Produto";
            // 
            // lbl_DescricaoProduto
            // 
            this.lbl_DescricaoProduto.AutoSize = true;
            this.lbl_DescricaoProduto.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_DescricaoProduto.Location = new System.Drawing.Point(825, 127);
            this.lbl_DescricaoProduto.Name = "lbl_DescricaoProduto";
            this.lbl_DescricaoProduto.Size = new System.Drawing.Size(269, 28);
            this.lbl_DescricaoProduto.TabIndex = 38;
            this.lbl_DescricaoProduto.Text = "Descrição do Produto";
            // 
            // txt_descricaoProduto
            // 
            this.txt_descricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descricaoProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_descricaoProduto.Location = new System.Drawing.Point(825, 163);
            this.txt_descricaoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_descricaoProduto.Name = "txt_descricaoProduto";
            this.txt_descricaoProduto.Size = new System.Drawing.Size(587, 34);
            this.txt_descricaoProduto.TabIndex = 39;
            // 
            // txt_PrecoProduto
            // 
            this.txt_PrecoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PrecoProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_PrecoProduto.Location = new System.Drawing.Point(825, 356);
            this.txt_PrecoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PrecoProduto.Name = "txt_PrecoProduto";
            this.txt_PrecoProduto.Size = new System.Drawing.Size(587, 34);
            this.txt_PrecoProduto.TabIndex = 41;
            // 
            // lbl_PrecoProduto
            // 
            this.lbl_PrecoProduto.AutoSize = true;
            this.lbl_PrecoProduto.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_PrecoProduto.Location = new System.Drawing.Point(825, 313);
            this.lbl_PrecoProduto.Name = "lbl_PrecoProduto";
            this.lbl_PrecoProduto.Size = new System.Drawing.Size(219, 28);
            this.lbl_PrecoProduto.TabIndex = 42;
            this.lbl_PrecoProduto.Text = "Preço do Produto";
            // 
            // txt_QtdProduto
            // 
            this.txt_QtdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_QtdProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_QtdProduto.Location = new System.Drawing.Point(825, 259);
            this.txt_QtdProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_QtdProduto.Name = "txt_QtdProduto";
            this.txt_QtdProduto.Size = new System.Drawing.Size(587, 34);
            this.txt_QtdProduto.TabIndex = 43;
            // 
            // txt_atomedico
            // 
            this.txt_atomedico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_atomedico.FormattingEnabled = true;
            this.txt_atomedico.Items.AddRange(new object[] {
            "Consulta",
            "Pequena cirurgia",
            "Vacinação",
            "Mudança de penso"});
            this.txt_atomedico.Location = new System.Drawing.Point(14, 69);
            this.txt_atomedico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_atomedico.Name = "txt_atomedico";
            this.txt_atomedico.Size = new System.Drawing.Size(606, 36);
            this.txt_atomedico.TabIndex = 44;
            // 
            // txt_tipoProduto
            // 
            this.txt_tipoProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tipoProduto.FormattingEnabled = true;
            this.txt_tipoProduto.Items.AddRange(new object[] {
            "Fármacos",
            "Alimentares",
            "Suplementares"});
            this.txt_tipoProduto.Location = new System.Drawing.Point(825, 69);
            this.txt_tipoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tipoProduto.Name = "txt_tipoProduto";
            this.txt_tipoProduto.Size = new System.Drawing.Size(587, 36);
            this.txt_tipoProduto.TabIndex = 45;
            // 
            // btn_pendentes
            // 
            this.btn_pendentes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pendentes.Location = new System.Drawing.Point(674, 628);
            this.btn_pendentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_pendentes.Name = "btn_pendentes";
            this.btn_pendentes.Size = new System.Drawing.Size(399, 59);
            this.btn_pendentes.TabIndex = 46;
            this.btn_pendentes.Text = "Pagamentos Pendentes";
            this.btn_pendentes.UseVisualStyleBackColor = true;
            this.btn_pendentes.Click += new System.EventHandler(this.btn_pendentes_Click);
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1426, 703);
            this.Controls.Add(this.btn_pendentes);
            this.Controls.Add(this.txt_tipoProduto);
            this.Controls.Add(this.txt_atomedico);
            this.Controls.Add(this.txt_QtdProduto);
            this.Controls.Add(this.lbl_PrecoProduto);
            this.Controls.Add(this.txt_PrecoProduto);
            this.Controls.Add(this.txt_descricaoProduto);
            this.Controls.Add(this.lbl_DescricaoProduto);
            this.Controls.Add(this.lbl_tipoProduto);
            this.Controls.Add(this.lbl_AtoMedico);
            this.Controls.Add(this.txt_descricaoAtoMedico);
            this.Controls.Add(this.lbl_descricaoAtoMedico);
            this.Controls.Add(this.txt_QuantProduto);
            this.Controls.Add(this.lbl_AtoMedicoCusto);
            this.Controls.Add(this.txt_AtoMedicoCusto);
            this.Controls.Add(this.data_ProdPreco);
            this.Controls.Add(this.data_AtoMedicoCusto);
            this.Controls.Add(this.btn_cancelarPagamentos);
            this.Controls.Add(this.btn_ListarPagamentos);
            this.Controls.Add(this.btn_inserirPagamentos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pagamentos";
            this.Text = "Pagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.data_ProdPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_AtoMedicoCusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_inserirPagamentos;
        private Button btn_ListarPagamentos;
        private Button btn_cancelarPagamentos;
        private DataGridView data_ProdPreco;
        private TextBox txt_AtoMedicoCusto;
        private TextBox txt_Preco;
        private Label lbl_AtoMedicoCusto;
        private Label txt_QuantProduto;
        private DataGridView data_AtoMedicoCusto;
        private Label lbl_descricaoAtoMedico;
        private TextBox txt_descricaoAtoMedico;
        private Label lbl_AtoMedico;
        private Label lbl_tipoProduto;
        private Label lbl_DescricaoProduto;
        private TextBox txt_descricaoProduto;
        private TextBox txt_PrecoProduto;
        private Label lbl_PrecoProduto;
        private TextBox txt_QtdProduto;
        private ComboBox txt_atomedico;
        private ComboBox txt_tipoProduto;
        private Button btn_pendentes;
    }
}