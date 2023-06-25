namespace veterinario_projeto.PagInicial
{
    partial class Consultas
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
            this.Id = new System.Windows.Forms.Label();
            this.NomeDono = new System.Windows.Forms.Label();
            this.NomeAnimal = new System.Windows.Forms.Label();
            this.TipoConsulta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ContactoTelefonico = new System.Windows.Forms.Label();
            this.DataConsulta = new System.Windows.Forms.Label();
            this.HoraConsulta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(23, 23);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(98, 20);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id do Registo";
            // 
            // NomeDono
            // 
            this.NomeDono.AutoSize = true;
            this.NomeDono.Location = new System.Drawing.Point(23, 67);
            this.NomeDono.Name = "NomeDono";
            this.NomeDono.Size = new System.Drawing.Size(113, 20);
            this.NomeDono.TabIndex = 1;
            this.NomeDono.Text = "Nome do Dono";
            // 
            // NomeAnimal
            // 
            this.NomeAnimal.AutoSize = true;
            this.NomeAnimal.Location = new System.Drawing.Point(23, 110);
            this.NomeAnimal.Name = "NomeAnimal";
            this.NomeAnimal.Size = new System.Drawing.Size(123, 20);
            this.NomeAnimal.TabIndex = 2;
            this.NomeAnimal.Text = "Nome do Animal";
            // 
            // TipoConsulta
            // 
            this.TipoConsulta.AutoSize = true;
            this.TipoConsulta.Location = new System.Drawing.Point(23, 153);
            this.TipoConsulta.Name = "TipoConsulta";
            this.TipoConsulta.Size = new System.Drawing.Size(121, 20);
            this.TipoConsulta.TabIndex = 3;
            this.TipoConsulta.Text = "Tipo de Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Colaborador para o Atendimento";
            // 
            // ContactoTelefonico
            // 
            this.ContactoTelefonico.AutoSize = true;
            this.ContactoTelefonico.Location = new System.Drawing.Point(23, 246);
            this.ContactoTelefonico.Name = "ContactoTelefonico";
            this.ContactoTelefonico.Size = new System.Drawing.Size(142, 20);
            this.ContactoTelefonico.TabIndex = 5;
            this.ContactoTelefonico.Text = "Contacto Telefônico";
            // 
            // DataConsulta
            // 
            this.DataConsulta.AutoSize = true;
            this.DataConsulta.Location = new System.Drawing.Point(23, 288);
            this.DataConsulta.Name = "DataConsulta";
            this.DataConsulta.Size = new System.Drawing.Size(123, 20);
            this.DataConsulta.TabIndex = 6;
            this.DataConsulta.Text = "Data da Consulta";
            // 
            // HoraConsulta
            // 
            this.HoraConsulta.AutoSize = true;
            this.HoraConsulta.Location = new System.Drawing.Point(23, 334);
            this.HoraConsulta.Name = "HoraConsulta";
            this.HoraConsulta.Size = new System.Drawing.Size(124, 20);
            this.HoraConsulta.TabIndex = 7;
            this.HoraConsulta.Text = "Hora da Consulta";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 595);
            this.Controls.Add(this.HoraConsulta);
            this.Controls.Add(this.DataConsulta);
            this.Controls.Add(this.ContactoTelefonico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TipoConsulta);
            this.Controls.Add(this.NomeAnimal);
            this.Controls.Add(this.NomeDono);
            this.Controls.Add(this.Id);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Id;
        private Label NomeDono;
        private Label NomeAnimal;
        private Label TipoConsulta;
        private Label label5;
        private Label ContactoTelefonico;
        private Label DataConsulta;
        private Label HoraConsulta;
    }
}