using PROVA_DE_SUFICIENCIA.Entities;

namespace PROVA_DE_SUFICIENCIA
{
    /// <summary>
    /// Kauê Felipe Salvio
    /// </summary>
    public partial class ViagemCadastro : Form
    {
        private readonly List<Viagem> _viagemList;
        public ViagemCadastro(List<Viagem> viagemList)
        {
            _viagemList = viagemList;
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            var isValid = true;
            if (txtNomeMotorista.Text.Length < 1 || txtNomeMotorista.Text.Length > 100)
            {
                txtNomeMotorista.Focus();
                isValid = false;
            }
            if (mskTxtPlaca.Text.Length > 8)
            {
                mskTxtPlaca.Focus();
                isValid = false;
            }
            if (mskDataViagem.Text.Length > 10)
            {
                mskTxtPlaca.Focus();
                isValid = false;
            }
            if (mskHoraViagem.Text.Length > 5)
            {
                mskTxtPlaca.Focus();
                isValid = false;
            }     

            return isValid;
        }
        private void RegistrarViagem_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            if(CheckInterMunicipal.Checked)
            {
                var viagem = new Intermunicipal(mskTxtPlaca.Text, txtNomeMotorista.Text, FormatarData(mskDataViagem.Text), FormatarHoras(mskHoraViagem.Text));
                _viagemList.Add(viagem);
                MessageBox.Show("Viagem intermunicipal cadastrada com sucesso!");
            }
            else if(CheckMunicipal.Checked)
            {
                var viagem = new Municipal(mskTxtPlaca.Text, txtNomeMotorista.Text, FormatarData(mskDataViagem.Text), FormatarHoras(mskHoraViagem.Text));
                _viagemList.Add(viagem);
                MessageBox.Show("Viagem municipal cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Viagem não selecionada!");
            }
        }

        private void CheckMunicipal_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckMunicipal.Checked)
            {
                CheckInterMunicipal.Checked = false;
            }
        }

        private void CheckInterMunicipal_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckInterMunicipal.Checked)
            {
                CheckMunicipal.Checked = false;
            }
        }
        private DateTime FormatarData(string date)
        {

            var dia = int.Parse(date.Substring(0, 2));
            var mes = int.Parse(date.Substring(3, 2));
            var ano = int.Parse(date.Substring(6, 4));
            return new DateTime(ano, mes, dia);
        }
        private TimeOnly FormatarHoras(string time)
        {
            var horas = int.Parse(time.Substring(0, 2));
            var minutos = int.Parse(time.Substring(3, 2));
            return new TimeOnly(horas, minutos);
        }
       
    }
}
