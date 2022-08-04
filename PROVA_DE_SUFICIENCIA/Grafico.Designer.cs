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
            this.BtnExport.Location = new System.Drawing.Point(146, 507);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(112, 34);
            this.BtnExport.TabIndex = 1;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
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
            this.ListViewCSV.Location = new System.Drawing.Point(23, 12);
            this.ListViewCSV.MultiSelect = false;
            this.ListViewCSV.Name = "ListViewCSV";
            this.ListViewCSV.Size = new System.Drawing.Size(359, 441);
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
            this.lblValorTotal.Location = new System.Drawing.Point(690, 184);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 24);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "label1";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDados.Location = new System.Drawing.Point(419, 73);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(242, 96);
            this.lblDados.TabIndex = 4;
            this.lblDados.Text = "Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(456, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor total viagem:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxPlaca
            // 
            this.cbxPlaca.FormattingEnabled = true;
            this.cbxPlaca.Location = new System.Drawing.Point(748, 357);
            this.cbxPlaca.Name = "cbxPlaca";
            this.cbxPlaca.Size = new System.Drawing.Size(182, 33);
            this.cbxPlaca.TabIndex = 7;
            this.cbxPlaca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // cbxData
            // 
            this.cbxData.FormattingEnabled = true;
            this.cbxData.Location = new System.Drawing.Point(748, 422);
            this.cbxData.Name = "cbxData";
            this.cbxData.Size = new System.Drawing.Size(182, 33);
            this.cbxData.TabIndex = 8;
            this.cbxData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxData_MouseClick);
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(748, 495);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(182, 33);
            this.cbxHora.TabIndex = 9;
            this.cbxHora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxHora_MouseClick);
            // 
            // btnMaisVelhos
            // 
            this.btnMaisVelhos.Location = new System.Drawing.Point(12, 507);
            this.btnMaisVelhos.Name = "btnMaisVelhos";
            this.btnMaisVelhos.Size = new System.Drawing.Size(112, 34);
            this.btnMaisVelhos.TabIndex = 10;
            this.btnMaisVelhos.Text = "MaisVelhos";
            this.btnMaisVelhos.UseVisualStyleBackColor = true;
            this.btnMaisVelhos.Click += new System.EventHandler(this.btnMaisVelhos_Click);
            // 
            // lblTotalDeVagasNaViagem
            // 
            this.lblTotalDeVagasNaViagem.AutoSize = true;
            this.lblTotalDeVagasNaViagem.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeVagasNaViagem.Location = new System.Drawing.Point(388, 247);
            this.lblTotalDeVagasNaViagem.Name = "lblTotalDeVagasNaViagem";
            this.lblTotalDeVagasNaViagem.Size = new System.Drawing.Size(293, 30);
            this.lblTotalDeVagasNaViagem.TabIndex = 12;
            this.lblTotalDeVagasNaViagem.Text = "Numero de pessoas ociosas";
            // 
            // lblOciosas
            // 
            this.lblOciosas.AutoSize = true;
            this.lblOciosas.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOciosas.Location = new System.Drawing.Point(690, 247);
            this.lblOciosas.Name = "lblOciosas";
            this.lblOciosas.Size = new System.Drawing.Size(0, 24);
            this.lblOciosas.TabIndex = 11;
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 640);
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