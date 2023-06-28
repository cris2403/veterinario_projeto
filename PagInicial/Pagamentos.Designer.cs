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
            btn_inserirPagamentos = new Button();
            btn_ListarPagamentos = new Button();
            btn_cancelarPagamentos = new Button();
            data_ProdPreco = new DataGridView();
            txt_AtoMedicoCusto = new TextBox();
            lbl_AtoMedicoCusto = new Label();
            txt_QuantProduto = new Label();
            data_AtoMedicoCusto = new DataGridView();
            lbl_descricaoAtoMedico = new Label();
            txt_descricaoAtoMedico = new TextBox();
            lbl_AtoMedico = new Label();
            lbl_tipoProduto = new Label();
            lbl_DescricaoProduto = new Label();
            txt_descricaoProduto = new TextBox();
            txt_PrecoProduto = new TextBox();
            lbl_PrecoProduto = new Label();
            txt_QtdProduto = new TextBox();
            txt_atomedico = new ComboBox();
            txt_tipoProduto = new ComboBox();
            btn_pendentes = new Button();
            ((System.ComponentModel.ISupportInitialize)data_ProdPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_AtoMedicoCusto).BeginInit();
            SuspendLayout();
            // 
            // btn_inserirPagamentos
            // 
            btn_inserirPagamentos.Location = new Point(412, 471);
            btn_inserirPagamentos.Name = "btn_inserirPagamentos";
            btn_inserirPagamentos.Size = new Size(75, 23);
            btn_inserirPagamentos.TabIndex = 1;
            btn_inserirPagamentos.Text = "Adicionar";
            btn_inserirPagamentos.UseVisualStyleBackColor = true;
            btn_inserirPagamentos.Click += btn_inserirPagamentos_Click;
            // 
            // btn_ListarPagamentos
            // 
            btn_ListarPagamentos.Location = new Point(510, 471);
            btn_ListarPagamentos.Name = "btn_ListarPagamentos";
            btn_ListarPagamentos.Size = new Size(75, 23);
            btn_ListarPagamentos.TabIndex = 25;
            btn_ListarPagamentos.Text = "Listar";
            btn_ListarPagamentos.UseVisualStyleBackColor = true;
            btn_ListarPagamentos.Click += btn_ListarPagamentos_Click;
            // 
            // btn_cancelarPagamentos
            // 
            btn_cancelarPagamentos.Location = new Point(791, 471);
            btn_cancelarPagamentos.Name = "btn_cancelarPagamentos";
            btn_cancelarPagamentos.Size = new Size(75, 23);
            btn_cancelarPagamentos.TabIndex = 26;
            btn_cancelarPagamentos.Text = "Cancelar";
            btn_cancelarPagamentos.UseVisualStyleBackColor = true;
            btn_cancelarPagamentos.Click += btn_cancelarPagamentos_Click;
            // 
            // data_ProdPreco
            // 
            data_ProdPreco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ProdPreco.Location = new Point(722, 308);
            data_ProdPreco.Name = "data_ProdPreco";
            data_ProdPreco.Size = new Size(514, 139);
            data_ProdPreco.TabIndex = 28;
            data_ProdPreco.CellClick += data_ProdPreco_CellClick;
            // 
            // txt_AtoMedicoCusto
            // 
            txt_AtoMedicoCusto.Location = new Point(50, 194);
            txt_AtoMedicoCusto.Name = "txt_AtoMedicoCusto";
            txt_AtoMedicoCusto.Size = new Size(230, 23);
            txt_AtoMedicoCusto.TabIndex = 29;
            // 
            // lbl_AtoMedicoCusto
            // 
            lbl_AtoMedicoCusto.AutoSize = true;
            lbl_AtoMedicoCusto.Location = new Point(50, 167);
            lbl_AtoMedicoCusto.Name = "lbl_AtoMedicoCusto";
            lbl_AtoMedicoCusto.Size = new Size(120, 15);
            lbl_AtoMedicoCusto.TabIndex = 31;
            lbl_AtoMedicoCusto.Text = "Custo do Ato Médico";
            // 
            // txt_QuantProduto
            // 
            txt_QuantProduto.AutoSize = true;
            txt_QuantProduto.Location = new Point(722, 167);
            txt_QuantProduto.Name = "txt_QuantProduto";
            txt_QuantProduto.Size = new Size(132, 15);
            txt_QuantProduto.TabIndex = 32;
            txt_QuantProduto.Text = "Quantidade do Produto";
            // 
            // data_AtoMedicoCusto
            // 
            data_AtoMedicoCusto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_AtoMedicoCusto.Location = new Point(12, 308);
            data_AtoMedicoCusto.Name = "data_AtoMedicoCusto";
            data_AtoMedicoCusto.RowTemplate.Height = 25;
            data_AtoMedicoCusto.Size = new Size(531, 139);
            data_AtoMedicoCusto.TabIndex = 27;
            data_AtoMedicoCusto.CellClick += data_AtoMedicoCusto_CellClick;
            // 
            // lbl_descricaoAtoMedico
            // 
            lbl_descricaoAtoMedico.AutoSize = true;
            lbl_descricaoAtoMedico.Location = new Point(50, 95);
            lbl_descricaoAtoMedico.Name = "lbl_descricaoAtoMedico";
            lbl_descricaoAtoMedico.Size = new Size(140, 15);
            lbl_descricaoAtoMedico.TabIndex = 33;
            lbl_descricaoAtoMedico.Text = "Descrição do Ato Médico";
            // 
            // txt_descricaoAtoMedico
            // 
            txt_descricaoAtoMedico.Location = new Point(50, 122);
            txt_descricaoAtoMedico.Name = "txt_descricaoAtoMedico";
            txt_descricaoAtoMedico.Size = new Size(230, 23);
            txt_descricaoAtoMedico.TabIndex = 34;
            // 
            // lbl_AtoMedico
            // 
            lbl_AtoMedico.AutoSize = true;
            lbl_AtoMedico.Location = new Point(50, 20);
            lbl_AtoMedico.Name = "lbl_AtoMedico";
            lbl_AtoMedico.Size = new Size(69, 15);
            lbl_AtoMedico.TabIndex = 35;
            lbl_AtoMedico.Text = "Ato Médico";
            // 
            // lbl_tipoProduto
            // 
            lbl_tipoProduto.AutoSize = true;
            lbl_tipoProduto.Location = new Point(722, 20);
            lbl_tipoProduto.Name = "lbl_tipoProduto";
            lbl_tipoProduto.Size = new Size(92, 15);
            lbl_tipoProduto.TabIndex = 37;
            lbl_tipoProduto.Text = "Tipo de Produto";
            // 
            // lbl_DescricaoProduto
            // 
            lbl_DescricaoProduto.AutoSize = true;
            lbl_DescricaoProduto.Location = new Point(722, 95);
            lbl_DescricaoProduto.Name = "lbl_DescricaoProduto";
            lbl_DescricaoProduto.Size = new Size(121, 15);
            lbl_DescricaoProduto.TabIndex = 38;
            lbl_DescricaoProduto.Text = "Descrição do Produto";
            // 
            // txt_descricaoProduto
            // 
            txt_descricaoProduto.Location = new Point(722, 122);
            txt_descricaoProduto.Name = "txt_descricaoProduto";
            txt_descricaoProduto.Size = new Size(302, 23);
            txt_descricaoProduto.TabIndex = 39;
            // 
            // txt_PrecoProduto
            // 
            txt_PrecoProduto.Location = new Point(722, 267);
            txt_PrecoProduto.Name = "txt_PrecoProduto";
            txt_PrecoProduto.Size = new Size(302, 23);
            txt_PrecoProduto.TabIndex = 41;
            // 
            // lbl_PrecoProduto
            // 
            lbl_PrecoProduto.AutoSize = true;
            lbl_PrecoProduto.Location = new Point(722, 235);
            lbl_PrecoProduto.Name = "lbl_PrecoProduto";
            lbl_PrecoProduto.Size = new Size(100, 15);
            lbl_PrecoProduto.TabIndex = 42;
            lbl_PrecoProduto.Text = "Preço do Produto";
            // 
            // txt_QtdProduto
            // 
            txt_QtdProduto.Location = new Point(722, 194);
            txt_QtdProduto.Name = "txt_QtdProduto";
            txt_QtdProduto.Size = new Size(302, 23);
            txt_QtdProduto.TabIndex = 43;
            // 
            // txt_atomedico
            // 
            txt_atomedico.FormattingEnabled = true;
            txt_atomedico.Items.AddRange(new object[] { "Consulta", "Pequena cirurgia", "Vacinação", "Mudança de penso" });
            txt_atomedico.Location = new Point(50, 52);
            txt_atomedico.Name = "txt_atomedico";
            txt_atomedico.Size = new Size(230, 23);
            txt_atomedico.TabIndex = 44;
            // 
            // txt_tipoProduto
            // 
            txt_tipoProduto.FormattingEnabled = true;
            txt_tipoProduto.Items.AddRange(new object[] { "Fármacos", "Alimentares", "Suplementares" });
            txt_tipoProduto.Location = new Point(722, 52);
            txt_tipoProduto.Name = "txt_tipoProduto";
            txt_tipoProduto.Size = new Size(302, 23);
            txt_tipoProduto.TabIndex = 45;
            // 
            // btn_pendentes
            // 
            btn_pendentes.Location = new Point(610, 471);
            btn_pendentes.Name = "btn_pendentes";
            btn_pendentes.Size = new Size(163, 23);
            btn_pendentes.TabIndex = 46;
            btn_pendentes.Text = "Pagamentos Pendentes";
            btn_pendentes.UseVisualStyleBackColor = true;
            btn_pendentes.Click += btn_pendentes_Click;
            // 
            // Pagamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 527);
            Controls.Add(btn_pendentes);
            Controls.Add(txt_tipoProduto);
            Controls.Add(txt_atomedico);
            Controls.Add(txt_QtdProduto);
            Controls.Add(lbl_PrecoProduto);
            Controls.Add(txt_PrecoProduto);
            Controls.Add(txt_descricaoProduto);
            Controls.Add(lbl_DescricaoProduto);
            Controls.Add(lbl_tipoProduto);
            Controls.Add(lbl_AtoMedico);
            Controls.Add(txt_descricaoAtoMedico);
            Controls.Add(lbl_descricaoAtoMedico);
            Controls.Add(txt_QuantProduto);
            Controls.Add(lbl_AtoMedicoCusto);
            Controls.Add(txt_AtoMedicoCusto);
            Controls.Add(data_ProdPreco);
            Controls.Add(data_AtoMedicoCusto);
            Controls.Add(btn_cancelarPagamentos);
            Controls.Add(btn_ListarPagamentos);
            Controls.Add(btn_inserirPagamentos);
            Name = "Pagamentos";
            Text = "Pagamentos";
            ((System.ComponentModel.ISupportInitialize)data_ProdPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_AtoMedicoCusto).EndInit();
            ResumeLayout(false);
            PerformLayout();
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