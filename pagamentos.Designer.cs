namespace veterinario_projeto
{
    partial class pagamentos
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
            btn_Pagamentos = new Button();
            lbl_metodoPagamento = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // btn_Pagamentos
            // 
            btn_Pagamentos.Location = new Point(573, 118);
            btn_Pagamentos.Margin = new Padding(3, 4, 3, 4);
            btn_Pagamentos.Name = "btn_Pagamentos";
            btn_Pagamentos.Size = new Size(86, 31);
            btn_Pagamentos.TabIndex = 37;
            btn_Pagamentos.Text = "Pagar";
            btn_Pagamentos.UseVisualStyleBackColor = true;
            // 
            // lbl_metodoPagamento
            // 
            lbl_metodoPagamento.AutoSize = true;
            lbl_metodoPagamento.Location = new Point(74, 118);
            lbl_metodoPagamento.Name = "lbl_metodoPagamento";
            lbl_metodoPagamento.Size = new Size(162, 20);
            lbl_metodoPagamento.TabIndex = 38;
            lbl_metodoPagamento.Text = "Metodo de Pagamento";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(94, 169);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 39;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(94, 196);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 40;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(94, 226);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 41;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // pagamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lbl_metodoPagamento);
            Controls.Add(btn_Pagamentos);
            Name = "pagamentos";
            Text = "pagamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_editarProdutos;
        private Button btn_apagarProdutos;
        private Button btn_Pagamentos;
        private Label lbl_metodoPagamento;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}