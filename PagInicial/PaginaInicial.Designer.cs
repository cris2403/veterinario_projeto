namespace veterinario_projeto
{
    partial class PaginaInicial
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
            btn_canimal = new Button();
            btn_fmedica = new Button();
            btn_donos = new Button();
            btn_produtos = new Button();
            btn_colaboradores = new Button();
            btn_consultas = new Button();
            btn_pagamentos = new Button();
            SuspendLayout();
            // 
            // btn_canimal
            // 
            btn_canimal.Location = new Point(36, 28);
            btn_canimal.Name = "btn_canimal";
            btn_canimal.Size = new Size(126, 36);
            btn_canimal.TabIndex = 0;
            btn_canimal.Text = "Cadastro do Animal";
            btn_canimal.UseVisualStyleBackColor = true;
            // 
            // btn_fmedica
            // 
            btn_fmedica.Location = new Point(1069, 28);
            btn_fmedica.Name = "btn_fmedica";
            btn_fmedica.Size = new Size(118, 36);
            btn_fmedica.TabIndex = 1;
            btn_fmedica.Text = "Ficha Médica";
            btn_fmedica.UseVisualStyleBackColor = true;
            // 
            // btn_donos
            // 
            btn_donos.Location = new Point(178, 28);
            btn_donos.Name = "btn_donos";
            btn_donos.Size = new Size(126, 36);
            btn_donos.TabIndex = 2;
            btn_donos.Text = "Donos";
            btn_donos.UseVisualStyleBackColor = true;
            // 
            // btn_produtos
            // 
            btn_produtos.Location = new Point(464, 28);
            btn_produtos.Name = "btn_produtos";
            btn_produtos.Size = new Size(126, 36);
            btn_produtos.TabIndex = 3;
            btn_produtos.Text = "Produtos";
            btn_produtos.UseVisualStyleBackColor = true;
            // 
            // btn_colaboradores
            // 
            btn_colaboradores.Location = new Point(324, 28);
            btn_colaboradores.Name = "btn_colaboradores";
            btn_colaboradores.Size = new Size(120, 36);
            btn_colaboradores.TabIndex = 4;
            btn_colaboradores.Text = "Colaboradores";
            btn_colaboradores.UseVisualStyleBackColor = true;
            // 
            // btn_consultas
            // 
            btn_consultas.Location = new Point(607, 28);
            btn_consultas.Name = "btn_consultas";
            btn_consultas.Size = new Size(126, 36);
            btn_consultas.TabIndex = 5;
            btn_consultas.Text = "Consultas";
            btn_consultas.UseVisualStyleBackColor = true;
            // 
            // btn_pagamentos
            // 
            btn_pagamentos.Location = new Point(753, 28);
            btn_pagamentos.Name = "btn_pagamentos";
            btn_pagamentos.Size = new Size(126, 36);
            btn_pagamentos.TabIndex = 6;
            btn_pagamentos.Text = "Pagamentos";
            btn_pagamentos.UseVisualStyleBackColor = true;
            // 
            // PagInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 532);
            Controls.Add(btn_pagamentos);
            Controls.Add(btn_consultas);
            Controls.Add(btn_colaboradores);
            Controls.Add(btn_produtos);
            Controls.Add(btn_donos);
            Controls.Add(btn_fmedica);
            Controls.Add(btn_canimal);
            Name = "PagInicial";
            Text = "Página Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_canimal;
        private Button btn_fmedica;
        private Button btn_donos;
        private Button btn_produtos;
        private Button btn_colaboradores;
        private Button btn_consultas;
        private Button btn_pagamentos;
    }
}