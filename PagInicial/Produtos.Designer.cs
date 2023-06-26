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
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(561, 318);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(227, 69);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInserir.Location = new System.Drawing.Point(296, 318);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(227, 69);
            this.buttonInserir.TabIndex = 25;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(31, 318);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(227, 69);
            this.buttonListar.TabIndex = 24;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // textBoxCodProd
            // 
            this.textBoxCodProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCodProd.Location = new System.Drawing.Point(397, 60);
            this.textBoxCodProd.Name = "textBoxCodProd";
            this.textBoxCodProd.Size = new System.Drawing.Size(354, 34);
            this.textBoxCodProd.TabIndex = 23;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPreco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPreco.Location = new System.Drawing.Point(397, 239);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(356, 34);
            this.textBoxPreco.TabIndex = 22;
            // 
            // textBoxDescProd
            // 
            this.textBoxDescProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescProd.Location = new System.Drawing.Point(397, 147);
            this.textBoxDescProd.Name = "textBoxDescProd";
            this.textBoxDescProd.Size = new System.Drawing.Size(356, 34);
            this.textBoxDescProd.TabIndex = 21;
            // 
            // comboBoxTipoProd
            // 
            this.comboBoxTipoProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTipoProd.FormattingEnabled = true;
            this.comboBoxTipoProd.Items.AddRange(new object[] {
            "Fármacos\t",
            "Alimentares",
            "Suplementares"});
            this.comboBoxTipoProd.Location = new System.Drawing.Point(397, 100);
            this.comboBoxTipoProd.Name = "comboBoxTipoProd";
            this.comboBoxTipoProd.Size = new System.Drawing.Size(354, 36);
            this.comboBoxTipoProd.TabIndex = 19;
            // 
            // Preco
            // 
            this.Preco.AutoSize = true;
            this.Preco.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Preco.Location = new System.Drawing.Point(159, 241);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(200, 28);
            this.Preco.TabIndex = 18;
            this.Preco.Text = "Preço (Unitário)";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Quantidade.Location = new System.Drawing.Point(53, 201);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(306, 28);
            this.Quantidade.TabIndex = 17;
            this.Quantidade.Text = "Quantidade em Armazém";
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Descrição.Location = new System.Drawing.Point(102, 153);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(257, 28);
            this.Descrição.TabIndex = 16;
            this.Descrição.Text = "Descrição do Produto";
            // 
            // TipoProduto
            // 
            this.TipoProduto.AutoSize = true;
            this.TipoProduto.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TipoProduto.Location = new System.Drawing.Point(163, 108);
            this.TipoProduto.Name = "TipoProduto";
            this.TipoProduto.Size = new System.Drawing.Size(196, 28);
            this.TipoProduto.TabIndex = 15;
            this.TipoProduto.Text = "Tipo do Produto";
            // 
            // CodProduto
            // 
            this.CodProduto.AutoSize = true;
            this.CodProduto.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CodProduto.Location = new System.Drawing.Point(135, 66);
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.Size = new System.Drawing.Size(224, 28);
            this.CodProduto.TabIndex = 14;
            this.CodProduto.Text = "Código do Produto";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuant.Location = new System.Drawing.Point(397, 195);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(356, 34);
            this.textBoxQuant.TabIndex = 27;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
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