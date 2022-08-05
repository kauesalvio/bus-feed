namespace PROVA_DE_SUFICIENCIA
{
    partial class Cadastro
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
            this.lblEscola = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkIdoso = new System.Windows.Forms.CheckBox();
            this.checkEstudante = new System.Windows.Forms.CheckBox();
            this.registrar_pessoa = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mskTxtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.mskTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(152, 233);
            this.lblEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(40, 15);
            this.lblEscola.TabIndex = 25;
            this.lblEscola.Text = "Escola";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(152, 233);
            this.lblRG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(22, 15);
            this.lblRG.TabIndex = 24;
            this.lblRG.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // checkIdoso
            // 
            this.checkIdoso.AutoSize = true;
            this.checkIdoso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkIdoso.Location = new System.Drawing.Point(462, 111);
            this.checkIdoso.Margin = new System.Windows.Forms.Padding(2);
            this.checkIdoso.Name = "checkIdoso";
            this.checkIdoso.Size = new System.Drawing.Size(91, 36);
            this.checkIdoso.TabIndex = 20;
            this.checkIdoso.Text = "Idoso";
            this.checkIdoso.UseVisualStyleBackColor = true;
            this.checkIdoso.CheckedChanged += new System.EventHandler(this.checkIdoso_CheckedChanged);
            // 
            // checkEstudante
            // 
            this.checkEstudante.AutoSize = true;
            this.checkEstudante.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEstudante.Location = new System.Drawing.Point(462, 70);
            this.checkEstudante.Margin = new System.Windows.Forms.Padding(2);
            this.checkEstudante.Name = "checkEstudante";
            this.checkEstudante.Size = new System.Drawing.Size(138, 36);
            this.checkEstudante.TabIndex = 19;
            this.checkEstudante.Text = "Estudante";
            this.checkEstudante.UseVisualStyleBackColor = true;
            this.checkEstudante.CheckedChanged += new System.EventHandler(this.checkEstudante_CheckedChanged);
            // 
            // registrar_pessoa
            // 
            this.registrar_pessoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registrar_pessoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrar_pessoa.Location = new System.Drawing.Point(186, 317);
            this.registrar_pessoa.Margin = new System.Windows.Forms.Padding(2);
            this.registrar_pessoa.Name = "registrar_pessoa";
            this.registrar_pessoa.Size = new System.Drawing.Size(171, 52);
            this.registrar_pessoa.TabIndex = 18;
            this.registrar_pessoa.Text = "Registrar";
            this.registrar_pessoa.UseVisualStyleBackColor = false;
            this.registrar_pessoa.Click += new System.EventHandler(this.registrar_pessoa_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(152, 38);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 39);
            this.txtNome.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.comboBox1.Location = new System.Drawing.Point(152, 180);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 40);
            this.comboBox1.TabIndex = 0;
            // 
            // mskTxtRg
            // 
            this.mskTxtRg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTxtRg.Location = new System.Drawing.Point(152, 250);
            this.mskTxtRg.Margin = new System.Windows.Forms.Padding(2);
            this.mskTxtRg.Mask = "00 000 000-0";
            this.mskTxtRg.Name = "mskTxtRg";
            this.mskTxtRg.Size = new System.Drawing.Size(251, 39);
            this.mskTxtRg.TabIndex = 26;
            // 
            // txtEscola
            // 
            this.txtEscola.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEscola.Location = new System.Drawing.Point(152, 250);
            this.txtEscola.Margin = new System.Windows.Forms.Padding(2);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(251, 39);
            this.txtEscola.TabIndex = 17;
            // 
            // mskTxtTelefone
            // 
            this.mskTxtTelefone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTxtTelefone.Location = new System.Drawing.Point(152, 108);
            this.mskTxtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mskTxtTelefone.Mask = "(00) 00000-0000";
            this.mskTxtTelefone.Name = "mskTxtTelefone";
            this.mskTxtTelefone.Size = new System.Drawing.Size(251, 39);
            this.mskTxtTelefone.TabIndex = 27;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(647, 505);
            this.Controls.Add(this.mskTxtTelefone);
            this.Controls.Add(this.mskTxtRg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEscola);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkIdoso);
            this.Controls.Add(this.checkEstudante);
            this.Controls.Add(this.registrar_pessoa);
            this.Controls.Add(this.txtEscola);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label lblEscola;
        public Label lblRG;
        public Label label3;
        public Label label2;
        public Label label1;
        public CheckBox checkIdoso;
        public CheckBox checkEstudante;
        public Button registrar_pessoa;
        public TextBox txtNome;
        public ComboBox comboBox1;
        public MaskedTextBox mskTxtRg;
        public TextBox txtEscola;
        public MaskedTextBox mskTxtTelefone;
    }
}