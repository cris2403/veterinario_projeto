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
            this.button_cAnimal = new System.Windows.Forms.Button();
            this.btn_fmedica = new System.Windows.Forms.Button();
            this.btn_donos = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_colaboradores = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.btn_pagamentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cAnimal
            // 
            this.button_cAnimal.BackColor = System.Drawing.Color.LightGray;
            this.button_cAnimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cAnimal.Location = new System.Drawing.Point(12, 26);
            this.button_cAnimal.Name = "button_cAnimal";
            this.button_cAnimal.Size = new System.Drawing.Size(163, 70);
            this.button_cAnimal.TabIndex = 0;
            this.button_cAnimal.Text = "Cadastro do Animal";
            this.button_cAnimal.UseVisualStyleBackColor = false;
            // 
            // btn_fmedica
            // 
            this.btn_fmedica.BackColor = System.Drawing.Color.LightGray;
            this.btn_fmedica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fmedica.Location = new System.Drawing.Point(122, 269);
            this.btn_fmedica.Name = "btn_fmedica";
            this.btn_fmedica.Size = new System.Drawing.Size(155, 70);
            this.btn_fmedica.TabIndex = 1;
            this.btn_fmedica.Text = "Ficha Médica";
            this.btn_fmedica.UseVisualStyleBackColor = false;
            // 
            // btn_donos
            // 
            this.btn_donos.BackColor = System.Drawing.Color.LightGray;
            this.btn_donos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_donos.Location = new System.Drawing.Point(12, 102);
            this.btn_donos.Name = "btn_donos";
            this.btn_donos.Size = new System.Drawing.Size(163, 70);
            this.btn_donos.TabIndex = 2;
            this.btn_donos.Text = "Donos";
            this.btn_donos.UseVisualStyleBackColor = false;
            // 
            // btn_produtos
            // 
            this.btn_produtos.BackColor = System.Drawing.Color.LightGray;
            this.btn_produtos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_produtos.Location = new System.Drawing.Point(233, 26);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(163, 70);
            this.btn_produtos.TabIndex = 3;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.UseVisualStyleBackColor = false;
            // 
            // btn_colaboradores
            // 
            this.btn_colaboradores.BackColor = System.Drawing.Color.LightGray;
            this.btn_colaboradores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_colaboradores.Location = new System.Drawing.Point(12, 178);
            this.btn_colaboradores.Name = "btn_colaboradores";
            this.btn_colaboradores.Size = new System.Drawing.Size(163, 70);
            this.btn_colaboradores.TabIndex = 4;
            this.btn_colaboradores.Text = "Colaboradores";
            this.btn_colaboradores.UseVisualStyleBackColor = false;
            // 
            // btn_consultas
            // 
            this.btn_consultas.BackColor = System.Drawing.Color.LightGray;
            this.btn_consultas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_consultas.Location = new System.Drawing.Point(233, 102);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(163, 70);
            this.btn_consultas.TabIndex = 5;
            this.btn_consultas.Text = "Consultas";
            this.btn_consultas.UseVisualStyleBackColor = false;
            // 
            // btn_pagamentos
            // 
            this.btn_pagamentos.BackColor = System.Drawing.Color.LightGray;
            this.btn_pagamentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pagamentos.Location = new System.Drawing.Point(233, 178);
            this.btn_pagamentos.Name = "btn_pagamentos";
            this.btn_pagamentos.Size = new System.Drawing.Size(163, 70);
            this.btn_pagamentos.TabIndex = 6;
            this.btn_pagamentos.Text = "Pagamentos";
            this.btn_pagamentos.UseVisualStyleBackColor = false;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(408, 366);
            this.Controls.Add(this.btn_pagamentos);
            this.Controls.Add(this.btn_consultas);
            this.Controls.Add(this.btn_colaboradores);
            this.Controls.Add(this.btn_produtos);
            this.Controls.Add(this.btn_donos);
            this.Controls.Add(this.btn_fmedica);
            this.Controls.Add(this.button_cAnimal);
            this.Name = "PaginaInicial";
            this.Text = "Página Inicial";
            this.ResumeLayout(false);

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