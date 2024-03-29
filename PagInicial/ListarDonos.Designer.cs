﻿namespace veterinario_projeto.PagInicial
{
    partial class ListarDonos
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
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.NIF = new System.Windows.Forms.Label();
            this.Contacto = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.IDRegisto = new System.Windows.Forms.Label();
            this.dataGridViewDonos = new System.Windows.Forms.DataGridView();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.DataNascimento = new System.Windows.Forms.Label();
            this.NovosDados = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(865, 232);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(229, 80);
            this.buttonApagar.TabIndex = 35;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(865, 123);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(229, 80);
            this.buttonSalvar.TabIndex = 34;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListar.Location = new System.Drawing.Point(865, 15);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(229, 80);
            this.buttonListar.TabIndex = 33;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNIF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNIF.Location = new System.Drawing.Point(319, 225);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(417, 34);
            this.textBoxNIF.TabIndex = 31;
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContacto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContacto.Location = new System.Drawing.Point(319, 359);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(417, 34);
            this.textBoxContacto.TabIndex = 30;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(319, 293);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(417, 34);
            this.textBoxNome.TabIndex = 27;
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(319, 67);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(417, 34);
            this.textBoxID.TabIndex = 26;
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NIF.Location = new System.Drawing.Point(224, 231);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(58, 28);
            this.NIF.TabIndex = 25;
            this.NIF.Text = "NIF";
            // 
            // Contacto
            // 
            this.Contacto.AutoSize = true;
            this.Contacto.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Contacto.Location = new System.Drawing.Point(166, 365);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(116, 28);
            this.Contacto.TabIndex = 24;
            this.Contacto.Text = "Contacto";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(203, 300);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(79, 28);
            this.Nome.TabIndex = 21;
            this.Nome.Text = "Nome";
            // 
            // IDRegisto
            // 
            this.IDRegisto.AutoSize = true;
            this.IDRegisto.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.IDRegisto.Location = new System.Drawing.Point(110, 71);
            this.IDRegisto.Name = "IDRegisto";
            this.IDRegisto.Size = new System.Drawing.Size(169, 28);
            this.IDRegisto.TabIndex = 19;
            this.IDRegisto.Text = "ID do Registo";
            // 
            // dataGridViewDonos
            // 
            this.dataGridViewDonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonos.Location = new System.Drawing.Point(19, 412);
            this.dataGridViewDonos.Name = "dataGridViewDonos";
            this.dataGridViewDonos.RowHeadersWidth = 51;
            this.dataGridViewDonos.RowTemplate.Height = 29;
            this.dataGridViewDonos.Size = new System.Drawing.Size(1153, 224);
            this.dataGridViewDonos.TabIndex = 18;
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(319, 175);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(417, 34);
            this.dateTimePickerNascimento.TabIndex = 36;
            // 
            // DataNascimento
            // 
            this.DataNascimento.AutoSize = true;
            this.DataNascimento.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DataNascimento.Location = new System.Drawing.Point(35, 183);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(247, 28);
            this.DataNascimento.TabIndex = 37;
            this.DataNascimento.Text = "Data de Nascimento";
            // 
            // NovosDados
            // 
            this.NovosDados.AutoSize = true;
            this.NovosDados.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NovosDados.Location = new System.Drawing.Point(245, 117);
            this.NovosDados.Name = "NovosDados";
            this.NovosDados.Size = new System.Drawing.Size(166, 32);
            this.NovosDados.TabIndex = 59;
            this.NovosDados.Text = "Novos Dados";
            // 
            // Pesquisa
            // 
            this.Pesquisa.AutoSize = true;
            this.Pesquisa.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pesquisa.Location = new System.Drawing.Point(221, 21);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(295, 32);
            this.Pesquisa.TabIndex = 58;
            this.Pesquisa.Text = "Id para Pesquisa/Seleção";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(865, 327);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(229, 80);
            this.buttonCancelar.TabIndex = 60;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // ListarDonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1191, 661);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.NovosDados);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.NIF);
            this.Controls.Add(this.Contacto);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.IDRegisto);
            this.Controls.Add(this.dataGridViewDonos);
            this.Name = "ListarDonos";
            this.Text = "ListarDonos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonApagar;
        private Button buttonSalvar;
        private Button buttonListar;
        private TextBox textBoxNIF;
        private TextBox textBoxContacto;
        private TextBox textBoxNome;
        private TextBox textBoxID;
        private Label NIF;
        private Label Contacto;
        private Label Nome;
        private Label IDRegisto;
        private DataGridView dataGridViewDonos;
        private DateTimePicker dateTimePickerNascimento;
        private Label DataNascimento;
        private Label NovosDados;
        private Label Pesquisa;
        private Button buttonCancelar;
    }
}