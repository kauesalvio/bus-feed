namespace PROVA_DE_SUFICIENCIA
{
    partial class ViagemCadastro
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
            this.mskTxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraViagem = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblDataViagem = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.RegistrarViagem = new System.Windows.Forms.Button();
            this.txtNomeMotorista = new System.Windows.Forms.TextBox();
            this.mskDataViagem = new System.Windows.Forms.MaskedTextBox();
            this.mskHoraViagem = new System.Windows.Forms.MaskedTextBox();
            this.CheckMunicipal = new System.Windows.Forms.CheckBox();
            this.CheckInterMunicipal = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskTxtPlaca
            // 
            this.mskTxtPlaca.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTxtPlaca.Location = new System.Drawing.Point(318, 64);
            this.mskTxtPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.mskTxtPlaca.Mask = "AAA-0000";
            this.mskTxtPlaca.Name = "mskTxtPlaca";
            this.mskTxtPlaca.Size = new System.Drawing.Size(97, 39);
            this.mskTxtPlaca.TabIndex = 2;
            // 
            // lblHoraViagem
            // 
            this.lblHoraViagem.AutoSize = true;
            this.lblHoraViagem.Location = new System.Drawing.Point(106, 148);
            this.lblHoraViagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraViagem.Name = "lblHoraViagem";
            this.lblHoraViagem.Size = new System.Drawing.Size(36, 15);
            this.lblHoraViagem.TabIndex = 34;
            this.lblHoraViagem.Text = "Hora ";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(318, 47);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(91, 15);
            this.lblPlaca.TabIndex = 36;
            this.lblPlaca.Text = "Placa do ônibus";
            // 
            // lblDataViagem
            // 
            this.lblDataViagem.AutoSize = true;
            this.lblDataViagem.Location = new System.Drawing.Point(5, 148);
            this.lblDataViagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataViagem.Name = "lblDataViagem";
            this.lblDataViagem.Size = new System.Drawing.Size(31, 15);
            this.lblDataViagem.TabIndex = 35;
            this.lblDataViagem.Text = "Data";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 47);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(111, 15);
            this.lblNome.TabIndex = 34;
            this.lblNome.Text = "Nome do motorista";
            // 
            // RegistrarViagem
            // 
            this.RegistrarViagem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RegistrarViagem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrarViagem.Location = new System.Drawing.Point(299, 314);
            this.RegistrarViagem.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrarViagem.Name = "RegistrarViagem";
            this.RegistrarViagem.Size = new System.Drawing.Size(135, 41);
            this.RegistrarViagem.TabIndex = 7;
            this.RegistrarViagem.Text = "Adicionar";
            this.RegistrarViagem.UseVisualStyleBackColor = false;
            this.RegistrarViagem.Click += new System.EventHandler(this.RegistrarViagem_Click);
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeMotorista.Location = new System.Drawing.Point(5, 64);
            this.txtNomeMotorista.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.Size = new System.Drawing.Size(309, 39);
            this.txtNomeMotorista.TabIndex = 1;
            // 
            // mskDataViagem
            // 
            this.mskDataViagem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskDataViagem.Location = new System.Drawing.Point(5, 165);
            this.mskDataViagem.Margin = new System.Windows.Forms.Padding(2);
            this.mskDataViagem.Mask = "00/00/0000";
            this.mskDataViagem.Name = "mskDataViagem";
            this.mskDataViagem.Size = new System.Drawing.Size(97, 39);
            this.mskDataViagem.TabIndex = 3;
            this.mskDataViagem.ValidatingType = typeof(System.DateTime);
            // 
            // mskHoraViagem
            // 
            this.mskHoraViagem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskHoraViagem.Location = new System.Drawing.Point(106, 165);
            this.mskHoraViagem.Margin = new System.Windows.Forms.Padding(2);
            this.mskHoraViagem.Mask = "00:00";
            this.mskHoraViagem.Name = "mskHoraViagem";
            this.mskHoraViagem.Size = new System.Drawing.Size(53, 39);
            this.mskHoraViagem.TabIndex = 4;
            this.mskHoraViagem.ValidatingType = typeof(System.DateTime);
            // 
            // CheckMunicipal
            // 
            this.CheckMunicipal.AutoSize = true;
            this.CheckMunicipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckMunicipal.Location = new System.Drawing.Point(508, 81);
            this.CheckMunicipal.Margin = new System.Windows.Forms.Padding(2);
            this.CheckMunicipal.Name = "CheckMunicipal";
            this.CheckMunicipal.Size = new System.Drawing.Size(138, 36);
            this.CheckMunicipal.TabIndex = 5;
            this.CheckMunicipal.Text = "Municipal";
            this.CheckMunicipal.UseVisualStyleBackColor = true;
            this.CheckMunicipal.CheckedChanged += new System.EventHandler(this.CheckMunicipal_CheckedChanged);
            // 
            // CheckInterMunicipal
            // 
            this.CheckInterMunicipal.AutoSize = true;
            this.CheckInterMunicipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckInterMunicipal.Location = new System.Drawing.Point(508, 121);
            this.CheckInterMunicipal.Margin = new System.Windows.Forms.Padding(2);
            this.CheckInterMunicipal.Name = "CheckInterMunicipal";
            this.CheckInterMunicipal.Size = new System.Drawing.Size(186, 36);
            this.CheckInterMunicipal.TabIndex = 6;
            this.CheckInterMunicipal.Text = "Intermunicipal";
            this.CheckInterMunicipal.UseVisualStyleBackColor = true;
            this.CheckInterMunicipal.CheckedChanged += new System.EventHandler(this.CheckInterMunicipal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tipo da viagem";
            // 
            // ViagemCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(787, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskHoraViagem);
            this.Controls.Add(this.mskDataViagem);
            this.Controls.Add(this.mskTxtPlaca);
            this.Controls.Add(this.lblHoraViagem);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblDataViagem);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.CheckInterMunicipal);
            this.Controls.Add(this.CheckMunicipal);
            this.Controls.Add(this.RegistrarViagem);
            this.Controls.Add(this.txtNomeMotorista);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViagemCadastro";
            this.Text = "ViagemCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox mskTxtPlaca;
        private Label lblHoraViagem;
        private Label lblPlaca;
        private Label lblDataViagem;
        private Label lblNome;
        private Button RegistrarViagem;
        private TextBox txtNomeMotorista;
        private MaskedTextBox mskDataViagem;
        private MaskedTextBox mskHoraViagem;
        private CheckBox CheckMunicipal;
        private CheckBox CheckInterMunicipal;
        private Label label1;
    }
}