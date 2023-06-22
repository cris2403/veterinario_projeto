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
            button_cAnimal = new Button();
            btn_fmedica = new Button();
            btn_donos = new Button();
            btn_produtos = new Button();
            btn_colaboradores = new Button();
            btn_consultas = new Button();
            btn_pagamentos = new Button();
            SuspendLayout();
            // 
            // button_cAnimal
            // 
            button_cAnimal.Location = new Point(36, 28);
            button_cAnimal.Name = "button_cAnimal";
            button_cAnimal.Size = new Size(126, 36);
            button_cAnimal.TabIndex = 0;
            button_cAnimal.Text = "Cadastro do Animal";
            button_cAnimal.UseVisualStyleBackColor = true;
            button_cAnimal.Click += button_cAnimal_Click;
            // 
            // btn_fmedica
            // 
            btn_fmedica.Location = new Point(136, 249);
            btn_fmedica.Name = "btn_fmedica";
            btn_fmedica.Size = new Size(118, 36);
            btn_fmedica.TabIndex = 1;
            btn_fmedica.Text = "Ficha Médica";
            btn_fmedica.UseVisualStyleBackColor = true;
            // 
            // btn_donos
            // 
            btn_donos.Location = new Point(36, 102);
            btn_donos.Name = "btn_donos";
            btn_donos.Size = new Size(126, 36);
            btn_donos.TabIndex = 2;
            btn_donos.Text = "Donos";
            btn_donos.UseVisualStyleBackColor = true;
            btn_donos.Click += btn_donos_Click;
            // 
            // btn_produtos
            // 
            btn_produtos.Location = new Point(219, 28);
            btn_produtos.Name = "btn_produtos";
            btn_produtos.Size = new Size(126, 36);
            btn_produtos.TabIndex = 3;
            btn_produtos.Text = "Produtos";
            btn_produtos.UseVisualStyleBackColor = true;
            // 
            // btn_colaboradores
            // 
            btn_colaboradores.Location = new Point(36, 173);
            btn_colaboradores.Name = "btn_colaboradores";
            btn_colaboradores.Size = new Size(126, 36);
            btn_colaboradores.TabIndex = 4;
            btn_colaboradores.Text = "Colaboradores";
            btn_colaboradores.UseVisualStyleBackColor = true;
            btn_colaboradores.Click += btn_colaboradores_Click;
            // 
            // btn_consultas
            // 
            btn_consultas.Location = new Point(219, 102);
            btn_consultas.Name = "btn_consultas";
            btn_consultas.Size = new Size(126, 36);
            btn_consultas.TabIndex = 5;
            btn_consultas.Text = "Consultas";
            btn_consultas.UseVisualStyleBackColor = true;
            // 
            // btn_pagamentos
            // 
            btn_pagamentos.Location = new Point(219, 173);
            btn_pagamentos.Name = "btn_pagamentos";
            btn_pagamentos.Size = new Size(126, 36);
            btn_pagamentos.TabIndex = 6;
            btn_pagamentos.Text = "Pagamentos";
            btn_pagamentos.UseVisualStyleBackColor = true;
            // 
            // PaginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 366);
            Controls.Add(btn_pagamentos);
            Controls.Add(btn_consultas);
            Controls.Add(btn_colaboradores);
            Controls.Add(btn_produtos);
            Controls.Add(btn_donos);
            Controls.Add(btn_fmedica);
            Controls.Add(button_cAnimal);
            Name = "PaginaInicial";
            Text = "Página Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button button_cAnimal;
        private Button btn_fmedica;
        private Button btn_donos;
        private Button btn_produtos;
        private Button btn_colaboradores;
        private Button btn_consultas;
        private Button btn_pagamentos;
    }
}