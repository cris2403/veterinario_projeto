namespace veterinario_projeto
{
    partial class produtos
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
            txt_preçoProdutos = new TextBox();
            txt_qntdProdutos = new TextBox();
            txt_tipoProdutos = new TextBox();
            txt_idProdutos = new TextBox();
            lbl_preçoProdutos = new Label();
            lbl_qntsProdutos = new Label();
            lbl_familiaProdutos = new Label();
            lbl_idprodutos = new Label();
            txt_descricaoProdutos = new TextBox();
            lbl_descricaoProdutos = new Label();
            dataGridView1 = new DataGridView();
            btn_editarProdutos = new Button();
            btn_apagarProdutos = new Button();
            btn_listarProdutos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_preçoProdutos
            // 
            txt_preçoProdutos.Location = new Point(155, 333);
            txt_preçoProdutos.Margin = new Padding(3, 4, 3, 4);
            txt_preçoProdutos.Name = "txt_preçoProdutos";
            txt_preçoProdutos.Size = new Size(114, 27);
            txt_preçoProdutos.TabIndex = 19;
            // 
            // txt_qntdProdutos
            // 
            txt_qntdProdutos.Location = new Point(155, 287);
            txt_qntdProdutos.Margin = new Padding(3, 4, 3, 4);
            txt_qntdProdutos.Name = "txt_qntdProdutos";
            txt_qntdProdutos.Size = new Size(114, 27);
            txt_qntdProdutos.TabIndex = 18;
            // 
            // txt_tipoProdutos
            // 
            txt_tipoProdutos.Location = new Point(155, 218);
            txt_tipoProdutos.Margin = new Padding(3, 4, 3, 4);
            txt_tipoProdutos.Name = "txt_tipoProdutos";
            txt_tipoProdutos.Size = new Size(114, 27);
            txt_tipoProdutos.TabIndex = 17;
            // 
            // txt_idProdutos
            // 
            txt_idProdutos.Location = new Point(154, 182);
            txt_idProdutos.Margin = new Padding(3, 4, 3, 4);
            txt_idProdutos.Name = "txt_idProdutos";
            txt_idProdutos.Size = new Size(114, 27);
            txt_idProdutos.TabIndex = 16;
            // 
            // lbl_preçoProdutos
            // 
            lbl_preçoProdutos.AutoSize = true;
            lbl_preçoProdutos.Location = new Point(92, 338);
            lbl_preçoProdutos.Name = "lbl_preçoProdutos";
            lbl_preçoProdutos.Size = new Size(103, 20);
            lbl_preçoProdutos.TabIndex = 15;
            lbl_preçoProdutos.Text = "Preço Unitario";
            // 
            // lbl_qntsProdutos
            // 
            lbl_qntsProdutos.AutoSize = true;
            lbl_qntsProdutos.Location = new Point(94, 293);
            lbl_qntsProdutos.Name = "lbl_qntsProdutos";
            lbl_qntsProdutos.Size = new Size(87, 20);
            lbl_qntsProdutos.TabIndex = 14;
            lbl_qntsProdutos.Text = "Quantidade";
            // 
            // lbl_familiaProdutos
            // 
            lbl_familiaProdutos.AutoSize = true;
            lbl_familiaProdutos.Location = new Point(96, 224);
            lbl_familiaProdutos.Name = "lbl_familiaProdutos";
            lbl_familiaProdutos.Size = new Size(122, 20);
            lbl_familiaProdutos.TabIndex = 13;
            lbl_familiaProdutos.Text = "Tipo de Pordutos";
            // 
            // lbl_idprodutos
            // 
            lbl_idprodutos.AutoSize = true;
            lbl_idprodutos.Location = new Point(97, 184);
            lbl_idprodutos.Name = "lbl_idprodutos";
            lbl_idprodutos.Size = new Size(22, 20);
            lbl_idprodutos.TabIndex = 12;
            lbl_idprodutos.Text = "id";
            // 
            // txt_descricaoProdutos
            // 
            txt_descricaoProdutos.Location = new Point(156, 252);
            txt_descricaoProdutos.Margin = new Padding(3, 4, 3, 4);
            txt_descricaoProdutos.Name = "txt_descricaoProdutos";
            txt_descricaoProdutos.Size = new Size(114, 27);
            txt_descricaoProdutos.TabIndex = 21;
            // 
            // lbl_descricaoProdutos
            // 
            lbl_descricaoProdutos.AutoSize = true;
            lbl_descricaoProdutos.Location = new Point(95, 258);
            lbl_descricaoProdutos.Name = "lbl_descricaoProdutos";
            lbl_descricaoProdutos.Size = new Size(137, 20);
            lbl_descricaoProdutos.TabIndex = 20;
            lbl_descricaoProdutos.Text = "Descrição Produtos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(427, 160);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(274, 200);
            dataGridView1.TabIndex = 22;
            // 
            // btn_editarProdutos
            // 
            btn_editarProdutos.Location = new Point(492, 41);
            btn_editarProdutos.Margin = new Padding(3, 4, 3, 4);
            btn_editarProdutos.Name = "btn_editarProdutos";
            btn_editarProdutos.Size = new Size(86, 31);
            btn_editarProdutos.TabIndex = 25;
            btn_editarProdutos.Text = "Editar";
            btn_editarProdutos.UseVisualStyleBackColor = true;
            // 
            // btn_apagarProdutos
            // 
            btn_apagarProdutos.Location = new Point(342, 41);
            btn_apagarProdutos.Margin = new Padding(3, 4, 3, 4);
            btn_apagarProdutos.Name = "btn_apagarProdutos";
            btn_apagarProdutos.Size = new Size(86, 31);
            btn_apagarProdutos.TabIndex = 24;
            btn_apagarProdutos.Text = "Apagar";
            btn_apagarProdutos.UseVisualStyleBackColor = true;
            // 
            // btn_listarProdutos
            // 
            btn_listarProdutos.Location = new Point(181, 41);
            btn_listarProdutos.Margin = new Padding(3, 4, 3, 4);
            btn_listarProdutos.Name = "btn_listarProdutos";
            btn_listarProdutos.Size = new Size(86, 31);
            btn_listarProdutos.TabIndex = 23;
            btn_listarProdutos.Text = "Listar";
            btn_listarProdutos.UseVisualStyleBackColor = true;
            // 
            // produtos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_editarProdutos);
            Controls.Add(btn_apagarProdutos);
            Controls.Add(btn_listarProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(txt_descricaoProdutos);
            Controls.Add(lbl_descricaoProdutos);
            Controls.Add(txt_preçoProdutos);
            Controls.Add(txt_qntdProdutos);
            Controls.Add(txt_tipoProdutos);
            Controls.Add(txt_idProdutos);
            Controls.Add(lbl_preçoProdutos);
            Controls.Add(lbl_qntsProdutos);
            Controls.Add(lbl_familiaProdutos);
            Controls.Add(lbl_idprodutos);
            Name = "produtos";
            Text = "produtos";
            Load += produtos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_preçoProdutos;
        private TextBox txt_qntdProdutos;
        private TextBox txt_tipoProdutos;
        private TextBox txt_idProdutos;
        private Label lbl_preçoProdutos;
        private Label lbl_qntsProdutos;
        private Label lbl_familiaProdutos;
        private Label lbl_idprodutos;
        private TextBox txt_descricaoProdutos;
        private Label lbl_descricaoProdutos;
        private DataGridView dataGridView1;
        private Button btn_editarProdutos;
        private Button btn_apagarProdutos;
        private Button btn_listarProdutos;
    }
}