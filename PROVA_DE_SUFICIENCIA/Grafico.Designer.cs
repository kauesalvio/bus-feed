namespace PROVA_DE_SUFICIENCIA
{
    partial class Grafico
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
            this.BtnExport = new System.Windows.Forms.Button();
            this.ListViewCSV = new System.Windows.Forms.ListView();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Idade = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.Tarifa = new System.Windows.Forms.ColumnHeader();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxPlaca = new System.Windows.Forms.ComboBox();
            this.cbxData = new System.Windows.Forms.ComboBox();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.btnMaisVelhos = new System.Windows.Forms.Button();
            this.lblTotalDeVagasNaViagem = new System.Windows.Forms.Label();
            this.lblOciosas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExport.Location = new System.Drawing.Point(256, 411);
            this.BtnExport.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(103, 37);
            this.BtnExport.TabIndex = 1;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // ListViewCSV
            // 
            this.ListViewCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewCSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Idade,
            this.Telefone,
            this.Tarifa});
            this.ListViewCSV.Location = new System.Drawing.Point(16, 7);
            this.ListViewCSV.Margin = new System.Windows.Forms.Padding(2);
            this.ListViewCSV.MultiSelect = false;
            this.ListViewCSV.Name = "ListViewCSV";
            this.ListViewCSV.Size = new System.Drawing.Size(343, 367);
            this.ListViewCSV.TabIndex = 2;
            this.ListViewCSV.UseCompatibleStateImageBehavior = false;
            this.ListViewCSV.View = System.Windows.Forms.View.Details;
            this.ListViewCSV.SelectedIndexChanged += new System.EventHandler(this.ListViewCSV_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            // 
            // Idade
            // 
            this.Idade.Text = "Idade";
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            // 
            // Tarifa
            // 
            this.Tarifa.Text = "Tarifa";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(638, 92);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(15, 17);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "0";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDados.Location = new System.Drawing.Point(509, 28);
            this.lblDados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(106, 28);
            this.lblDados.TabIndex = 4;
            this.lblDados.Text = "Resultados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(483, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(524, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxPlaca
            // 
            this.cbxPlaca.FormattingEnabled = true;
            this.cbxPlaca.Location = new System.Drawing.Point(524, 214);
            this.cbxPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPlaca.Name = "cbxPlaca";
            this.cbxPlaca.Size = new System.Drawing.Size(129, 23);
            this.cbxPlaca.TabIndex = 7;
            this.cbxPlaca.Text = "Placa ";
            this.cbxPlaca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // cbxData
            // 
            this.cbxData.FormattingEnabled = true;
            this.cbxData.Location = new System.Drawing.Point(524, 253);
            this.cbxData.Margin = new System.Windows.Forms.Padding(2);
            this.cbxData.Name = "cbxData";
            this.cbxData.Size = new System.Drawing.Size(129, 23);
            this.cbxData.TabIndex = 8;
            this.cbxData.Text = "Data";
            this.cbxData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxData_MouseClick);
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(524, 297);
            this.cbxHora.Margin = new System.Windows.Forms.Padding(2);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(129, 23);
            this.cbxHora.TabIndex = 9;
            this.cbxHora.Text = "Hora";
            this.cbxHora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxHora_MouseClick);
            // 
            // btnMaisVelhos
            // 
            this.btnMaisVelhos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaisVelhos.Location = new System.Drawing.Point(16, 411);
            this.btnMaisVelhos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaisVelhos.Name = "btnMaisVelhos";
            this.btnMaisVelhos.Size = new System.Drawing.Size(104, 37);
            this.btnMaisVelhos.TabIndex = 10;
            this.btnMaisVelhos.Text = "Mais Velhos";
            this.btnMaisVelhos.UseVisualStyleBackColor = false;
            this.btnMaisVelhos.Click += new System.EventHandler(this.btnMaisVelhos_Click);
            // 
            // lblTotalDeVagasNaViagem
            // 
            this.lblTotalDeVagasNaViagem.AutoSize = true;
            this.lblTotalDeVagasNaViagem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeVagasNaViagem.Location = new System.Drawing.Point(483, 130);
            this.lblTotalDeVagasNaViagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDeVagasNaViagem.Name = "lblTotalDeVagasNaViagem";
            this.lblTotalDeVagasNaViagem.Size = new System.Drawing.Size(82, 17);
            this.lblTotalDeVagasNaViagem.TabIndex = 12;
            this.lblTotalDeVagasNaViagem.Text = "Ociosidade";
            // 
            // lblOciosas
            // 
            this.lblOciosas.AutoSize = true;
            this.lblOciosas.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOciosas.Location = new System.Drawing.Point(653, 130);
            this.lblOciosas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOciosas.Name = "lblOciosas";
            this.lblOciosas.Size = new System.Drawing.Size(0, 17);
            this.lblOciosas.TabIndex = 11;
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(785, 475);
            this.Controls.Add(this.lblTotalDeVagasNaViagem);
            this.Controls.Add(this.lblOciosas);
            this.Controls.Add(this.btnMaisVelhos);
            this.Controls.Add(this.cbxHora);
            this.Controls.Add(this.cbxData);
            this.Controls.Add(this.cbxPlaca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.ListViewCSV);
            this.Controls.Add(this.BtnExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Grafico";
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.Grafico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnExport;
        private ListView ListViewCSV;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Telefone;
        private ColumnHeader Tarifa;
        private Label lblValorTotal;
        private Label lblDados;
        private Label label1;
        private Button button1;
        private ComboBox cbxPlaca;
        private ComboBox cbxData;
        private ComboBox cbxHora;
        private Button btnMaisVelhos;
        private Label lblTotalDeVagasNaViagem;
        private Label label3;
        private Label lblOciosas;
    }
}