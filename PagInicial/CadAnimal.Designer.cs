﻿namespace veterinario_projeto.PagInicial
{
    partial class CadAnimal
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
            this.btn_salvarAnimal = new System.Windows.Forms.Button();
            this.btn_limparAnimal = new System.Windows.Forms.Button();
            this.btn_cancelarAnimal = new System.Windows.Forms.Button();
            this.lbl_nomeAnimal = new System.Windows.Forms.Label();
            this.lbl_tipoAnimal = new System.Windows.Forms.Label();
            this.lbl_racaAnimal = new System.Windows.Forms.Label();
            this.lbl_idadeAnimal = new System.Windows.Forms.Label();
            this.lbl_pesoAnimal = new System.Windows.Forms.Label();
            this.lbl_donoAnimal = new System.Windows.Forms.Label();
            this.txt_dono = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_raca = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.btn_pagDonoAnimal = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_salvarAnimal
            // 
            this.btn_salvarAnimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvarAnimal.Location = new System.Drawing.Point(465, 505);
            this.btn_salvarAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_salvarAnimal.Name = "btn_salvarAnimal";
            this.btn_salvarAnimal.Size = new System.Drawing.Size(129, 66);
            this.btn_salvarAnimal.TabIndex = 0;
            this.btn_salvarAnimal.Text = "Salvar";
            this.btn_salvarAnimal.UseVisualStyleBackColor = true;
            this.btn_salvarAnimal.Click += new System.EventHandler(this.btn_salvarAnimal_Click);
            // 
            // btn_limparAnimal
            // 
            this.btn_limparAnimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_limparAnimal.Location = new System.Drawing.Point(600, 505);
            this.btn_limparAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_limparAnimal.Name = "btn_limparAnimal";
            this.btn_limparAnimal.Size = new System.Drawing.Size(129, 66);
            this.btn_limparAnimal.TabIndex = 1;
            this.btn_limparAnimal.Text = "Limpar";
            this.btn_limparAnimal.UseVisualStyleBackColor = true;
            this.btn_limparAnimal.Click += new System.EventHandler(this.btn_limparAnimal_Click);
            // 
            // btn_cancelarAnimal
            // 
            this.btn_cancelarAnimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelarAnimal.Location = new System.Drawing.Point(735, 505);
            this.btn_cancelarAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancelarAnimal.Name = "btn_cancelarAnimal";
            this.btn_cancelarAnimal.Size = new System.Drawing.Size(129, 66);
            this.btn_cancelarAnimal.TabIndex = 2;
            this.btn_cancelarAnimal.Text = "Cancelar";
            this.btn_cancelarAnimal.UseVisualStyleBackColor = true;
            this.btn_cancelarAnimal.Click += new System.EventHandler(this.btn_cancelarAnimal_Click);
            // 
            // lbl_nomeAnimal
            // 
            this.lbl_nomeAnimal.AutoSize = true;
            this.lbl_nomeAnimal.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeAnimal.Location = new System.Drawing.Point(29, 144);
            this.lbl_nomeAnimal.Name = "lbl_nomeAnimal";
            this.lbl_nomeAnimal.Size = new System.Drawing.Size(204, 28);
            this.lbl_nomeAnimal.TabIndex = 3;
            this.lbl_nomeAnimal.Text = "Nome do Animal";
            // 
            // lbl_tipoAnimal
            // 
            this.lbl_tipoAnimal.AutoSize = true;
            this.lbl_tipoAnimal.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_tipoAnimal.Location = new System.Drawing.Point(45, 197);
            this.lbl_tipoAnimal.Name = "lbl_tipoAnimal";
            this.lbl_tipoAnimal.Size = new System.Drawing.Size(188, 28);
            this.lbl_tipoAnimal.TabIndex = 4;
            this.lbl_tipoAnimal.Text = "Tipo de Animal";
            // 
            // lbl_racaAnimal
            // 
            this.lbl_racaAnimal.AutoSize = true;
            this.lbl_racaAnimal.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_racaAnimal.Location = new System.Drawing.Point(164, 264);
            this.lbl_racaAnimal.Name = "lbl_racaAnimal";
            this.lbl_racaAnimal.Size = new System.Drawing.Size(69, 28);
            this.lbl_racaAnimal.TabIndex = 5;
            this.lbl_racaAnimal.Text = "Raça";
            // 
            // lbl_idadeAnimal
            // 
            this.lbl_idadeAnimal.AutoSize = true;
            this.lbl_idadeAnimal.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_idadeAnimal.Location = new System.Drawing.Point(156, 324);
            this.lbl_idadeAnimal.Name = "lbl_idadeAnimal";
            this.lbl_idadeAnimal.Size = new System.Drawing.Size(77, 28);
            this.lbl_idadeAnimal.TabIndex = 6;
            this.lbl_idadeAnimal.Text = "Idade";
            // 
            // lbl_pesoAnimal
            // 
            this.lbl_pesoAnimal.AutoSize = true;
            this.lbl_pesoAnimal.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_pesoAnimal.Location = new System.Drawing.Point(167, 382);
            this.lbl_pesoAnimal.Name = "lbl_pesoAnimal";
            this.lbl_pesoAnimal.Size = new System.Drawing.Size(66, 28);
            this.lbl_pesoAnimal.TabIndex = 7;
            this.lbl_pesoAnimal.Text = "Peso";
            // 
            // lbl_donoAnimal
            // 
            this.lbl_donoAnimal.AutoSize = true;
            this.lbl_donoAnimal.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_donoAnimal.Location = new System.Drawing.Point(161, 87);
            this.lbl_donoAnimal.Name = "lbl_donoAnimal";
            this.lbl_donoAnimal.Size = new System.Drawing.Size(72, 28);
            this.lbl_donoAnimal.TabIndex = 8;
            this.lbl_donoAnimal.Text = "Dono";
            // 
            // txt_dono
            // 
            this.txt_dono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dono.Location = new System.Drawing.Point(318, 81);
            this.txt_dono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dono.Name = "txt_dono";
            this.txt_dono.Size = new System.Drawing.Size(508, 34);
            this.txt_dono.TabIndex = 12;
            // 
            // txt_nome
            // 
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(318, 138);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(508, 34);
            this.txt_nome.TabIndex = 13;
            // 
            // txt_raca
            // 
            this.txt_raca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_raca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_raca.Location = new System.Drawing.Point(318, 258);
            this.txt_raca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_raca.Name = "txt_raca";
            this.txt_raca.Size = new System.Drawing.Size(508, 34);
            this.txt_raca.TabIndex = 15;
            // 
            // txt_idade
            // 
            this.txt_idade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_idade.Location = new System.Drawing.Point(318, 318);
            this.txt_idade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(508, 34);
            this.txt_idade.TabIndex = 16;
            // 
            // txt_peso
            // 
            this.txt_peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_peso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_peso.Location = new System.Drawing.Point(318, 376);
            this.txt_peso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(508, 34);
            this.txt_peso.TabIndex = 17;
            // 
            // btn_pagDonoAnimal
            // 
            this.btn_pagDonoAnimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pagDonoAnimal.Location = new System.Drawing.Point(31, 505);
            this.btn_pagDonoAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_pagDonoAnimal.Name = "btn_pagDonoAnimal";
            this.btn_pagDonoAnimal.Size = new System.Drawing.Size(140, 66);
            this.btn_pagDonoAnimal.TabIndex = 18;
            this.btn_pagDonoAnimal.Text = "Página do Dono";
            this.btn_pagDonoAnimal.UseVisualStyleBackColor = true;
            this.btn_pagDonoAnimal.Click += new System.EventHandler(this.btn_pagDonoAnimal_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(330, 505);
            this.buttonListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(129, 66);
            this.buttonListar.TabIndex = 19;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Cão",
            "Gato",
            "Pássaro",
            "Hamster"});
            this.comboBoxTipo.Location = new System.Drawing.Point(318, 194);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(508, 36);
            this.comboBoxTipo.TabIndex = 20;
            // 
            // CadAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.btn_pagDonoAnimal);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_raca);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_dono);
            this.Controls.Add(this.lbl_donoAnimal);
            this.Controls.Add(this.lbl_pesoAnimal);
            this.Controls.Add(this.lbl_idadeAnimal);
            this.Controls.Add(this.lbl_racaAnimal);
            this.Controls.Add(this.lbl_tipoAnimal);
            this.Controls.Add(this.lbl_nomeAnimal);
            this.Controls.Add(this.btn_cancelarAnimal);
            this.Controls.Add(this.btn_limparAnimal);
            this.Controls.Add(this.btn_salvarAnimal);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CadAnimal";
            this.Text = "Cadastro Animal";
            this.Load += new System.EventHandler(this.CadAnimal_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_salvarAnimal;
        private Button btn_limparAnimal;
        private Button btn_cancelarAnimal;
        private Label lbl_nomeAnimal;
        private Label lbl_tipoAnimal;
        private Label lbl_racaAnimal;
        private Label lbl_idadeAnimal;
        private Label lbl_pesoAnimal;
        private Label lbl_donoAnimal;
        private TextBox txt_dono;
        private TextBox txt_nome;
        private TextBox txt_raca;
        private TextBox txt_idade;
        private TextBox txt_peso;
        private Button btn_pagDonoAnimal;
        private Button buttonListar;
        private ComboBox comboBoxTipo;
    }
}