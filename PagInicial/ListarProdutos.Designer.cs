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
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cod
            // 
            this.Cod.AutoSize = true;
            this.Cod.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Cod.Location = new System.Drawing.Point(11, 43);
            this.Cod.Name = "Cod";
            this.Cod.Size = new System.Drawing.Size(195, 23);
            this.Cod.TabIndex = 0;
            this.Cod.Text = "Código de Produto";
            // 
            // TipoProd
            // 
            this.TipoProd.AutoSize = true;
            this.TipoProd.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TipoProd.Location = new System.Drawing.Point(9, 112);
            this.TipoProd.Name = "TipoProd";
            this.TipoProd.Size = new System.Drawing.Size(176, 23);
            this.TipoProd.TabIndex = 1;
            this.TipoProd.Text = "Tipo De Produto";
            // 
            // DescProd
            // 
            this.DescProd.AutoSize = true;
            this.DescProd.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DescProd.Location = new System.Drawing.Point(312, 112);
            this.DescProd.Name = "DescProd";
            this.DescProd.Size = new System.Drawing.Size(225, 23);
            this.DescProd.TabIndex = 2;
            this.DescProd.Text = "Descrição do Produto";
            // 
            // Quant
            // 
            this.Quant.AutoSize = true;
            this.Quant.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Quant.Location = new System.Drawing.Point(9, 193);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(269, 23);
            this.Quant.TabIndex = 3;
            this.Quant.Text = "Quantidade em Armazém";
            // 
            // Preco
            // 
            this.Preco.AutoSize = true;
            this.Preco.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Preco.Location = new System.Drawing.Point(312, 192);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(175, 23);
            this.Preco.TabIndex = 4;
            this.Preco.Text = "Preço (Unitário)";
            // 
            // textBoxCod
            // 
            this.textBoxCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCod.Location = new System.Drawing.Point(213, 39);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(231, 34);
            this.textBoxCod.TabIndex = 5;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPreco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPreco.Location = new System.Drawing.Point(312, 219);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(212, 34);
            this.textBoxPreco.TabIndex = 6;
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuant.Location = new System.Drawing.Point(9, 219);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(212, 34);
            this.textBoxQuant.TabIndex = 7;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDesc.Location = new System.Drawing.Point(312, 147);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(212, 34);
            this.textBoxDesc.TabIndex = 8;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Fármacos\t",
            "Alimentares",
            "Suplementares"});
            this.comboBoxTipo.Location = new System.Drawing.Point(9, 147);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(212, 36);
            this.comboBoxTipo.TabIndex = 9;
            // 
            // CodPesquisa
            // 
            this.CodPesquisa.AutoSize = true;
            this.CodPesquisa.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CodPesquisa.Location = new System.Drawing.Point(101, 5);
            this.CodPesquisa.Name = "CodPesquisa";
            this.CodPesquisa.Size = new System.Drawing.Size(312, 23);
            this.CodPesquisa.TabIndex = 10;
            this.CodPesquisa.Text = "Código Para Pesquisa/Seleção";
            // 
            // NovoDados
            // 
            this.NovoDados.AutoSize = true;
            this.NovoDados.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NovoDados.Location = new System.Drawing.Point(185, 80);
            this.NovoDados.Name = "NovoDados";
            this.NovoDados.Size = new System.Drawing.Size(140, 23);
            this.NovoDados.TabIndex = 11;
            this.NovoDados.Text = "Novos Dados";
            // 
            // buttonLista
            // 
            this.buttonLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLista.Location = new System.Drawing.Point(559, 4);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(183, 52);
            this.buttonLista.TabIndex = 12;
            this.buttonLista.Text = "Listar";
            this.buttonLista.UseVisualStyleBackColor = true;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(559, 71);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(183, 52);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(559, 144);
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
            this.dataGridViewProdutos.Location = new System.Drawing.Point(9, 276);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.RowTemplate.Height = 29;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(770, 165);
            this.dataGridViewProdutos.TabIndex = 15;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(559, 215);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(183, 52);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // ListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.buttonCancelar);
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
        private Button buttonCancelar;
    }
}