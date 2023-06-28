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
            Cod = new Label();
            TipoProd = new Label();
            DescProd = new Label();
            Quant = new Label();
            Preco = new Label();
            textBoxCod = new TextBox();
            textBoxPreco = new TextBox();
            textBoxQuant = new TextBox();
            textBoxDesc = new TextBox();
            comboBoxTipo = new ComboBox();
            CodPesquisa = new Label();
            NovoDados = new Label();
            buttonLista = new Button();
            buttonSalvar = new Button();
            buttonApagar = new Button();
            dataGridViewProdutos = new DataGridView();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // Cod
            // 
            Cod.AutoSize = true;
            Cod.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Cod.Location = new Point(10, 32);
            Cod.Name = "Cod";
            Cod.Size = new Size(161, 20);
            Cod.TabIndex = 0;
            Cod.Text = "Código de Produto";
            // 
            // TipoProd
            // 
            TipoProd.AutoSize = true;
            TipoProd.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TipoProd.Location = new Point(8, 84);
            TipoProd.Name = "TipoProd";
            TipoProd.Size = new Size(144, 20);
            TipoProd.TabIndex = 1;
            TipoProd.Text = "Tipo De Produto";
            // 
            // DescProd
            // 
            DescProd.AutoSize = true;
            DescProd.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DescProd.Location = new Point(273, 84);
            DescProd.Name = "DescProd";
            DescProd.Size = new Size(183, 20);
            DescProd.TabIndex = 2;
            DescProd.Text = "Descrição do Produto";
            // 
            // Quant
            // 
            Quant.AutoSize = true;
            Quant.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Quant.Location = new Point(8, 145);
            Quant.Name = "Quant";
            Quant.Size = new Size(219, 20);
            Quant.TabIndex = 3;
            Quant.Text = "Quantidade em Armazém";
            // 
            // Preco
            // 
            Preco.AutoSize = true;
            Preco.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Preco.Location = new Point(273, 144);
            Preco.Name = "Preco";
            Preco.Size = new Size(143, 20);
            Preco.TabIndex = 4;
            Preco.Text = "Preço (Unitário)";
            // 
            // textBoxCod
            // 
            textBoxCod.BorderStyle = BorderStyle.FixedSingle;
            textBoxCod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCod.Location = new Point(186, 29);
            textBoxCod.Margin = new Padding(3, 2, 3, 2);
            textBoxCod.Name = "textBoxCod";
            textBoxCod.Size = new Size(202, 29);
            textBoxCod.TabIndex = 5;
            // 
            // textBoxPreco
            // 
            textBoxPreco.BorderStyle = BorderStyle.FixedSingle;
            textBoxPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPreco.Location = new Point(273, 164);
            textBoxPreco.Margin = new Padding(3, 2, 3, 2);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(186, 29);
            textBoxPreco.TabIndex = 6;
            // 
            // textBoxQuant
            // 
            textBoxQuant.BorderStyle = BorderStyle.FixedSingle;
            textBoxQuant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuant.Location = new Point(8, 164);
            textBoxQuant.Margin = new Padding(3, 2, 3, 2);
            textBoxQuant.Name = "textBoxQuant";
            textBoxQuant.Size = new Size(186, 29);
            textBoxQuant.TabIndex = 7;
            // 
            // textBoxDesc
            // 
            textBoxDesc.BorderStyle = BorderStyle.FixedSingle;
            textBoxDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDesc.Location = new Point(273, 110);
            textBoxDesc.Margin = new Padding(3, 2, 3, 2);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(186, 29);
            textBoxDesc.TabIndex = 8;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Fármacos\t", "Alimentares", "Suplementares" });
            comboBoxTipo.Location = new Point(8, 110);
            comboBoxTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(186, 29);
            comboBoxTipo.TabIndex = 9;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // CodPesquisa
            // 
            CodPesquisa.AutoSize = true;
            CodPesquisa.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CodPesquisa.Location = new Point(88, 4);
            CodPesquisa.Name = "CodPesquisa";
            CodPesquisa.Size = new Size(257, 20);
            CodPesquisa.TabIndex = 10;
            CodPesquisa.Text = "Código Para Pesquisa/Seleção";
            // 
            // NovoDados
            // 
            NovoDados.AutoSize = true;
            NovoDados.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NovoDados.Location = new Point(162, 60);
            NovoDados.Name = "NovoDados";
            NovoDados.Size = new Size(114, 20);
            NovoDados.TabIndex = 11;
            NovoDados.Text = "Novos Dados";
            // 
            // buttonLista
            // 
            buttonLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLista.Location = new Point(489, 3);
            buttonLista.Margin = new Padding(3, 2, 3, 2);
            buttonLista.Name = "buttonLista";
            buttonLista.Size = new Size(160, 39);
            buttonLista.TabIndex = 12;
            buttonLista.Text = "Listar";
            buttonLista.UseVisualStyleBackColor = true;
            buttonLista.Click += buttonLista_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(489, 53);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(160, 39);
            buttonSalvar.TabIndex = 13;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApagar.Location = new Point(489, 108);
            buttonApagar.Margin = new Padding(3, 2, 3, 2);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(160, 39);
            buttonApagar.TabIndex = 14;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(8, 207);
            dataGridViewProdutos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowHeadersWidth = 51;
            dataGridViewProdutos.RowTemplate.Height = 29;
            dataGridViewProdutos.Size = new Size(674, 124);
            dataGridViewProdutos.TabIndex = 15;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(489, 161);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(160, 39);
            buttonCancelar.TabIndex = 16;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // ListarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonCancelar);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(buttonApagar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonLista);
            Controls.Add(NovoDados);
            Controls.Add(CodPesquisa);
            Controls.Add(comboBoxTipo);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxQuant);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxCod);
            Controls.Add(Preco);
            Controls.Add(Quant);
            Controls.Add(DescProd);
            Controls.Add(TipoProd);
            Controls.Add(Cod);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarProdutos";
            Text = "ListarProdutos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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