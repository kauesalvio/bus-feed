namespace PROVA_DE_SUFICIENCIA
{
    partial class TelaInicial
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
            this.RegistrarPassageiro = new System.Windows.Forms.Button();
            this.GraficoCSV = new System.Windows.Forms.Button();
            this.btnViagem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistrarPassageiro
            // 
            this.RegistrarPassageiro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegistrarPassageiro.Location = new System.Drawing.Point(172, 208);
            this.RegistrarPassageiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegistrarPassageiro.Name = "RegistrarPassageiro";
            this.RegistrarPassageiro.Size = new System.Drawing.Size(136, 38);
            this.RegistrarPassageiro.TabIndex = 0;
            this.RegistrarPassageiro.Text = "Registrar Passageiro";
            this.RegistrarPassageiro.UseVisualStyleBackColor = false;
            this.RegistrarPassageiro.Click += new System.EventHandler(this.RegistrarPassageiro_Click);
            // 
            // GraficoCSV
            // 
            this.GraficoCSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GraficoCSV.Location = new System.Drawing.Point(172, 268);
            this.GraficoCSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GraficoCSV.Name = "GraficoCSV";
            this.GraficoCSV.Size = new System.Drawing.Size(136, 35);
            this.GraficoCSV.TabIndex = 1;
            this.GraficoCSV.Text = "Grafico";
            this.GraficoCSV.UseVisualStyleBackColor = false;
            this.GraficoCSV.Click += new System.EventHandler(this.GraficoCSV_Click);
            // 
            // btnViagem
            // 
            this.btnViagem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViagem.Location = new System.Drawing.Point(172, 149);
            this.btnViagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViagem.Name = "btnViagem";
            this.btnViagem.Size = new System.Drawing.Size(136, 37);
            this.btnViagem.TabIndex = 2;
            this.btnViagem.Text = "Viagem Cadastro";
            this.btnViagem.UseVisualStyleBackColor = false;
            this.btnViagem.Click += new System.EventHandler(this.btnViagem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 112);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUS FEED";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(490, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnViagem);
            this.Controls.Add(this.GraficoCSV);
            this.Controls.Add(this.RegistrarPassageiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RegistrarPassageiro;
        private Button GraficoCSV;
        private Button btnViagem;
        private ComboBox comboBox1;
        private Label label1;
    }
}