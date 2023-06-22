namespace veterinario_projeto.PagInicial
{
    partial class Donos
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
            lbl_idDono = new Label();
            lbl_nomeDono = new Label();
            lbl_nascimentoDono = new Label();
            lbl_nifDono = new Label();
            lbl_contactoDono = new Label();
            dateTimePicker1 = new DateTimePicker();
            txt_idDono = new TextBox();
            txt_nomeDono = new TextBox();
            txt_nifDono = new TextBox();
            txt_contactoDono = new TextBox();
            btn_salvarDono = new Button();
            btn_limparDono = new Button();
            btn_cancelarDono = new Button();
            SuspendLayout();
            // 
            // lbl_idDono
            // 
            lbl_idDono.AutoSize = true;
            lbl_idDono.Location = new Point(12, 40);
            lbl_idDono.Name = "lbl_idDono";
            lbl_idDono.Size = new Size(75, 15);
            lbl_idDono.TabIndex = 0;
            lbl_idDono.Text = "Id de Registo";
            // 
            // lbl_nomeDono
            // 
            lbl_nomeDono.AutoSize = true;
            lbl_nomeDono.Location = new Point(12, 78);
            lbl_nomeDono.Name = "lbl_nomeDono";
            lbl_nomeDono.Size = new Size(40, 15);
            lbl_nomeDono.TabIndex = 1;
            lbl_nomeDono.Text = "Nome";
            // 
            // lbl_nascimentoDono
            // 
            lbl_nascimentoDono.AutoSize = true;
            lbl_nascimentoDono.Location = new Point(12, 119);
            lbl_nascimentoDono.Name = "lbl_nascimentoDono";
            lbl_nascimentoDono.Size = new Size(114, 15);
            lbl_nascimentoDono.TabIndex = 2;
            lbl_nascimentoDono.Text = "Data de Nascimento";
            // 
            // lbl_nifDono
            // 
            lbl_nifDono.AutoSize = true;
            lbl_nifDono.Location = new Point(12, 160);
            lbl_nifDono.Name = "lbl_nifDono";
            lbl_nifDono.Size = new Size(25, 15);
            lbl_nifDono.TabIndex = 3;
            lbl_nifDono.Text = "NIF";
            // 
            // lbl_contactoDono
            // 
            lbl_contactoDono.AutoSize = true;
            lbl_contactoDono.Location = new Point(12, 206);
            lbl_contactoDono.Name = "lbl_contactoDono";
            lbl_contactoDono.Size = new Size(56, 15);
            lbl_contactoDono.TabIndex = 4;
            lbl_contactoDono.Text = "Contacto";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // txt_idDono
            // 
            txt_idDono.Location = new Point(132, 37);
            txt_idDono.Name = "txt_idDono";
            txt_idDono.Size = new Size(200, 23);
            txt_idDono.TabIndex = 6;
            // 
            // txt_nomeDono
            // 
            txt_nomeDono.Location = new Point(132, 75);
            txt_nomeDono.Name = "txt_nomeDono";
            txt_nomeDono.Size = new Size(200, 23);
            txt_nomeDono.TabIndex = 7;
            // 
            // txt_nifDono
            // 
            txt_nifDono.Location = new Point(132, 157);
            txt_nifDono.Name = "txt_nifDono";
            txt_nifDono.Size = new Size(200, 23);
            txt_nifDono.TabIndex = 8;
            // 
            // txt_contactoDono
            // 
            txt_contactoDono.Location = new Point(132, 203);
            txt_contactoDono.Name = "txt_contactoDono";
            txt_contactoDono.Size = new Size(200, 23);
            txt_contactoDono.TabIndex = 9;
            // 
            // btn_salvarDono
            // 
            btn_salvarDono.Location = new Point(25, 289);
            btn_salvarDono.Name = "btn_salvarDono";
            btn_salvarDono.Size = new Size(126, 36);
            btn_salvarDono.TabIndex = 10;
            btn_salvarDono.Text = "Salvar";
            btn_salvarDono.UseVisualStyleBackColor = true;
            btn_salvarDono.Click += btn_salvarDono_Click;
            // 
            // btn_limparDono
            // 
            btn_limparDono.Location = new Point(170, 289);
            btn_limparDono.Name = "btn_limparDono";
            btn_limparDono.Size = new Size(126, 36);
            btn_limparDono.TabIndex = 11;
            btn_limparDono.Text = "Limpar";
            btn_limparDono.UseVisualStyleBackColor = true;
            btn_limparDono.Click += btn_limparDono_Click;
            // 
            // btn_cancelarDono
            // 
            btn_cancelarDono.Location = new Point(316, 289);
            btn_cancelarDono.Name = "btn_cancelarDono";
            btn_cancelarDono.Size = new Size(126, 36);
            btn_cancelarDono.TabIndex = 12;
            btn_cancelarDono.Text = "Cancelar";
            btn_cancelarDono.UseVisualStyleBackColor = true;
            btn_cancelarDono.Click += btn_cancelarDono_Click;
            // 
            // Donos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 347);
            Controls.Add(btn_cancelarDono);
            Controls.Add(btn_limparDono);
            Controls.Add(btn_salvarDono);
            Controls.Add(txt_contactoDono);
            Controls.Add(txt_nifDono);
            Controls.Add(txt_nomeDono);
            Controls.Add(txt_idDono);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_contactoDono);
            Controls.Add(lbl_nifDono);
            Controls.Add(lbl_nascimentoDono);
            Controls.Add(lbl_nomeDono);
            Controls.Add(lbl_idDono);
            Name = "Donos";
            Text = "Donos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_idDono;
        private Label lbl_nomeDono;
        private Label lbl_nascimentoDono;
        private Label lbl_nifDono;
        private Label lbl_contactoDono;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_idDono;
        private TextBox txt_nomeDono;
        private TextBox txt_nifDono;
        private TextBox txt_contactoDono;
        private Button btn_salvarDono;
        private Button btn_limparDono;
        private Button btn_cancelarDono;
    }
}