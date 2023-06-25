namespace veterinario_projeto.PagInicial
{
    partial class Produtos
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.textBoxCodProd = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxDescProd = new System.Windows.Forms.TextBox();
            this.comboBoxTipoProd = new System.Windows.Forms.ComboBox();
            this.Preco = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.Descrição = new System.Windows.Forms.Label();
            this.TipoProduto = new System.Windows.Forms.Label();
            this.CodProduto = new System.Windows.Forms.Label();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(561, 318);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(209, 48);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(288, 318);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(209, 48);
            this.buttonInserir.TabIndex = 25;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(31, 318);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(209, 48);
            this.buttonListar.TabIndex = 24;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // textBoxCodProd
            // 
            this.textBoxCodProd.Location = new System.Drawing.Point(344, 85);
            this.textBoxCodProd.Name = "textBoxCodProd";
            this.textBoxCodProd.Size = new System.Drawing.Size(215, 27);
            this.textBoxCodProd.TabIndex = 23;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(317, 259);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(244, 27);
            this.textBoxPreco.TabIndex = 22;
            // 
            // textBoxDescProd
            // 
            this.textBoxDescProd.Location = new System.Drawing.Point(354, 167);
            this.textBoxDescProd.Name = "textBoxDescProd";
            this.textBoxDescProd.Size = new System.Drawing.Size(207, 27);
            this.textBoxDescProd.TabIndex = 21;
            // 
            // comboBoxTipoProd
            // 
            this.comboBoxTipoProd.FormattingEnabled = true;
            this.comboBoxTipoProd.Items.AddRange(new object[] {
            "Fármacos\t",
            "Alimentares",
            "Suplementares"});
            this.comboBoxTipoProd.Location = new System.Drawing.Point(344, 120);
            this.comboBoxTipoProd.Name = "comboBoxTipoProd";
            this.comboBoxTipoProd.Size = new System.Drawing.Size(215, 28);
            this.comboBoxTipoProd.TabIndex = 19;
            // 
            // Preco
            // 
            this.Preco.AutoSize = true;
            this.Preco.Location = new System.Drawing.Point(198, 266);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(113, 20);
            this.Preco.TabIndex = 18;
            this.Preco.Text = "Preço (Unitário)";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(198, 218);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(180, 20);
            this.Quantidade.TabIndex = 17;
            this.Quantidade.Text = "Quantidade em Armazém";
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Location = new System.Drawing.Point(198, 176);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(153, 20);
            this.Descrição.TabIndex = 16;
            this.Descrição.Text = "Descrição do Produto";
            // 
            // TipoProduto
            // 
            this.TipoProduto.AutoSize = true;
            this.TipoProduto.Location = new System.Drawing.Point(198, 128);
            this.TipoProduto.Name = "TipoProduto";
            this.TipoProduto.Size = new System.Drawing.Size(118, 20);
            this.TipoProduto.TabIndex = 15;
            this.TipoProduto.Text = "Tipo do Produto";
            // 
            // CodProduto
            // 
            this.CodProduto.AutoSize = true;
            this.CodProduto.Location = new System.Drawing.Point(198, 88);
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.Size = new System.Drawing.Size(137, 20);
            this.CodProduto.TabIndex = 14;
            this.CodProduto.Text = "Código do Produto";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Location = new System.Drawing.Point(384, 215);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(177, 27);
            this.textBoxQuant.TabIndex = 27;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxQuant);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.textBoxCodProd);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxDescProd);
            this.Controls.Add(this.comboBoxTipoProd);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.TipoProduto);
            this.Controls.Add(this.CodProduto);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancelar;
        private Button buttonInserir;
        private Button buttonListar;
        private TextBox textBoxCodProd;
        private TextBox textBoxPreco;
        private TextBox textBoxDescProd;
        private ComboBox comboBoxTipoProd;
        private Label Preco;
        private Label Quantidade;
        private Label Descrição;
        private Label TipoProduto;
        private Label CodProduto;
        private TextBox textBoxQuant;
    }
}