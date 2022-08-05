using PROVA_DE_SUFICIENCIA.Entities;

namespace PROVA_DE_SUFICIENCIA
{
    /// <summary>
    /// Kauê Felipe Salvio
    /// </summary>
    public partial class Cadastro : Form
    {

        private readonly Viagem viagem;
        public Cadastro(Viagem _empresa)
        {
            this.viagem = _empresa;
            InitializeComponent();
        }

        private void ChangeFieldDown()
        {
            var pointCheckBoxEstudante = new Point(277, 602);
            var pointCheckBoxIdoso = new Point(277, 682);
            var pointRegisterButton = new Point(12, 650);
            checkEstudante.Location = pointCheckBoxEstudante;
            checkIdoso.Location = pointCheckBoxIdoso;
            registrar_pessoa.Location = pointRegisterButton;
        }
        private void ChangeFieldUp()
        {
            var pointCheckBoxEstudante = new Point(278, 381);
            var pointCheckBoxIdoso = new Point(278, 461);
            var pointRegisterButton = new Point(12, 461);
            checkEstudante.Location = pointCheckBoxEstudante;
            checkIdoso.Location = pointCheckBoxIdoso;
            registrar_pessoa.Location = pointRegisterButton;
        }


        private void Cadastro_Load(object sender, EventArgs e)
        {
            lblRG.Hide();
            lblEscola.Hide();
            mskTxtRg.Hide();
            txtEscola.Hide();
            checkEstudante.Checked = false;
            checkIdoso.Checked = false;
            ChangeFieldUp();
        }

        private void checkEstudante_CheckedChanged(object sender, EventArgs e)
        {

            if (checkIdoso.Checked == false & checkEstudante.Checked == false)
                ChangeFieldUp();

            if (checkEstudante.Checked)
            {
                lblEscola.Show();
                txtEscola.Show();
                lblRG.Hide();
                mskTxtRg.Hide();
                checkIdoso.Checked = false;

                ChangeFieldDown();
            }
            else
            {
                lblEscola.Hide();
                txtEscola.Hide();
            }

        }

        private void checkIdoso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIdoso.Checked == false & checkEstudante.Checked == false)
                ChangeFieldUp();

            if (checkIdoso.Checked)
            {
                lblRG.Show();
                mskTxtRg.Show();
                lblEscola.Hide();
                txtEscola.Hide();
                checkEstudante.Checked = false;

                ChangeFieldDown();
            }
            else
            {
                lblRG.Hide();
                mskTxtRg.Hide();
            }
        }

        public bool ValidarCampos()
        {
            var valido = true;
            if (txtNome.Text.Length < 1 || txtNome.Text.Length > 100)
            {
                txtNome.Focus();
                valido = false;
            }
            if (mskTxtTelefone.Text.Length > 15)
            {
                mskTxtTelefone.Focus();
                valido = false;
            }
            if (comboBox1.SelectedIndex < 0 || comboBox1.SelectedIndex > 100)
            {
                comboBox1.Focus();
                valido = false;
            }
            if (checkIdoso.Checked & mskTxtRg.Text.Length < 9)
            {
                mskTxtRg.Focus();
                valido = false;
            }
            if (checkEstudante.Checked & txtEscola.Text.Length < 1)
            {
                txtEscola.Focus();
                valido = false;
            }
            if (checkIdoso.Checked & int.Parse(comboBox1.SelectedItem.ToString()) < 60)
            {
                throw new ArgumentException("Usuário inválido!");
            }

            return valido;
        }

        private void registrar_pessoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    Passageiro passageiro;
                    if (checkIdoso.Checked)
                        passageiro = new Idoso(txtNome.Text, mskTxtTelefone.Text, int.Parse(comboBox1.SelectedItem.ToString()), mskTxtRg.Text);
                    else if (checkEstudante.Checked)
                        passageiro = new Estudante(txtNome.Text, mskTxtTelefone.Text, int.Parse(comboBox1.SelectedItem.ToString()), txtEscola.Text);
                    else
                        passageiro = new Passageiro(txtNome.Text, mskTxtTelefone.Text, int.Parse(comboBox1.SelectedItem.ToString()));

                    viagem.AddPassageiro(passageiro);
                    MessageBox.Show("Passageiro registrado com sucesso! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Campos inválidos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

