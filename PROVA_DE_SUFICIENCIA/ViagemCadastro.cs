using PROVA_DE_SUFICIENCIA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVA_DE_SUFICIENCIA
{
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
            var valido = true;
            if (txtNomeMotorista.Text.Length < 1 || txtNomeMotorista.Text.Length > 100)
            {
                txtNomeMotorista.Focus();
                valido = false;
            }
            if (mskTxtPlaca.Text.Length > 8)
            {
                mskTxtPlaca.Focus();
                valido = false;
            }
            if (mskDataViagem.Text.Length > 10)
            {
                mskTxtPlaca.Focus();
                valido = false;
            }
            if (mskHoraViagem.Text.Length > 5)
            {
                mskTxtPlaca.Focus();
                valido = false;
            }     

            return valido;
        }
        private void RegistrarViagem_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            if(CheckInterMunicipal.Checked)
            {
                var viagem = new Intermunicipal(mskTxtPlaca.Text, txtNomeMotorista.Text, FormatarData(mskDataViagem.Text), FormatarHoras(mskHoraViagem.Text));
                _viagemList.Add(viagem);
            }
            else if(CheckMunicipal.Checked)
            {
                var viagem = new Municipal(mskTxtPlaca.Text, txtNomeMotorista.Text, FormatarData(mskDataViagem.Text), FormatarHoras(mskHoraViagem.Text));
                _viagemList.Add(viagem);
            }
            else
            {
                MessageBox.Show("Eh necessario selecionar um tipo de Viagem");
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
            var hours = int.Parse(time.Substring(0, 2));
            var minutes = int.Parse(time.Substring(3, 2));
            return new TimeOnly(hours, minutes);
        }
    }
}
