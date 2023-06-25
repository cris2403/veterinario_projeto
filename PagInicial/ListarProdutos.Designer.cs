namespace veterinario_projeto.PagInicial
{
    partial class ListarProdutos
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
            this.Cod = new System.Windows.Forms.Label();
            this.TipoProd = new System.Windows.Forms.Label();
            this.DescProd = new System.Windows.Forms.Label();
            this.Quant = new System.Windows.Forms.Label();
            this.Preco = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.CodPesquisa = new System.Windows.Forms.Label();
            this.NovoDados = new System.Windows.Forms.Label();
            this.buttonLista = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cod
            // 
            this.Cod.AutoSize = true;
            this.Cod.Location = new System.Drawing.Point(12, 43);
            this.Cod.Name = "Cod";
            this.Cod.Size = new System.Drawing.Size(136, 20);
            this.Cod.TabIndex = 0;
            this.Cod.Text = "Código de Produto";
            // 
            // TipoProd
            // 
            this.TipoProd.AutoSize = true;
            this.TipoProd.Location = new System.Drawing.Point(29, 112);
            this.TipoProd.Name = "TipoProd";
            this.TipoProd.Size = new System.Drawing.Size(119, 20);
            this.TipoProd.TabIndex = 1;
            this.TipoProd.Text = "Tipo De Produto";
            // 
            // DescProd
            // 
            this.DescProd.AutoSize = true;
            this.DescProd.Location = new System.Drawing.Point(299, 112);
            this.DescProd.Name = "DescProd";
            this.DescProd.Size = new System.Drawing.Size(153, 20);
            this.DescProd.TabIndex = 2;
            this.DescProd.Text = "Descrição do Produto";
            // 
            // Quant
            // 
            this.Quant.AutoSize = true;
            this.Quant.Location = new System.Drawing.Point(12, 193);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(180, 20);
            this.Quant.TabIndex = 3;
            this.Quant.Text = "Quantidade em Armazém";
            // 
            // Preco
            // 
            this.Preco.AutoSize = true;
            this.Preco.Location = new System.Drawing.Point(315, 193);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(113, 20);
            this.Preco.TabIndex = 4;
            this.Preco.Text = "Preço (Unitário)";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(198, 43);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(125, 27);
            this.textBoxCod.TabIndex = 5;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(315, 226);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(125, 27);
            this.textBoxPreco.TabIndex = 6;
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Location = new System.Drawing.Point(23, 226);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(125, 27);
            this.textBoxQuant.TabIndex = 7;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(315, 146);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(125, 27);
            this.textBoxDesc.TabIndex = 8;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Fármacos\t",
            "Alimentares",
            "Suplementares"});
            this.comboBoxTipo.Location = new System.Drawing.Point(12, 146);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTipo.TabIndex = 9;
            // 
            // CodPesquisa
            // 
            this.CodPesquisa.AutoSize = true;
            this.CodPesquisa.Location = new System.Drawing.Point(100, 5);
            this.CodPesquisa.Name = "CodPesquisa";
            this.CodPesquisa.Size = new System.Drawing.Size(208, 20);
            this.CodPesquisa.TabIndex = 10;
            this.CodPesquisa.Text = "Código Para Pesquisa/Seleção";
            // 
            // NovoDados
            // 
            this.NovoDados.AutoSize = true;
            this.NovoDados.Location = new System.Drawing.Point(142, 86);
            this.NovoDados.Name = "NovoDados";
            this.NovoDados.Size = new System.Drawing.Size(98, 20);
            this.NovoDados.TabIndex = 11;
            this.NovoDados.Text = "Novos Dados";
            // 
            // buttonLista
            // 
            this.buttonLista.Location = new System.Drawing.Point(559, 27);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(183, 52);
            this.buttonLista.TabIndex = 12;
            this.buttonLista.Text = "Listar";
            this.buttonLista.UseVisualStyleBackColor = true;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(559, 112);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(183, 52);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(559, 193);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(183, 52);
            this.buttonApagar.TabIndex = 14;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(9, 268);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.RowTemplate.Height = 29;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(770, 166);
            this.dataGridViewProdutos.TabIndex = 15;
            // 
            // ListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonLista);
            this.Controls.Add(this.NovoDados);
            this.Controls.Add(this.CodPesquisa);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxQuant);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.DescProd);
            this.Controls.Add(this.TipoProd);
            this.Controls.Add(this.Cod);
            this.Name = "ListarProdutos";
            this.Text = "ListarProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Cod;
        private Label TipoProd;
        private Label DescProd;
        private Label Quant;
        private Label Preco;
        private TextBox textBoxCod;
        private TextBox textBoxPreco;
        private TextBox textBoxQuant;
        private TextBox textBoxDesc;
        private ComboBox comboBoxTipo;
        private Label CodPesquisa;
        private Label NovoDados;
        private Button buttonLista;
        private Button buttonSalvar;
        private Button buttonApagar;
        private DataGridView dataGridViewProdutos;
    }
}