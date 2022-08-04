using PROVA_DE_SUFICIENCIA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVA_DE_SUFICIENCIA
{
    public partial class Grafico : Form
    {
        private List<Viagem> _listViagens;
        private  Viagem _viagem;
        public Grafico(Viagem viagem, List<Viagem> listViagens)
        {

            _listViagens = listViagens;
            _viagem = viagem;
            InitializeComponent();
        }

        private void ListViewCSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void AtualizarDados()
        {
            try
            {
                lblValorTotal.Text = _viagem.GetValorTotal().ToString();
                lblOciosas.Text = (_viagem.totalDePassageiros - _viagem.Passageiros.Count()).ToString();

                ListViewCSV.Items.Clear();
                cbxPlaca.SelectedItem = null;
                cbxData.SelectedItem = null;
                cbxHora.SelectedItem = null;

                foreach (var passageiro in _viagem.Passageiros)
                {
                    AtualizarCsv(passageiro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarCsv(Passageiro passageiro)
        {
                 var item = new ListViewItem(passageiro.Nome);
                item.SubItems.Add(passageiro.Idade.ToString());
                item.SubItems.Add(passageiro.Telefone.ToString());
                item.SubItems.Add($"R${passageiro.GetTarifa()}");
                ListViewCSV.Items.Add(item);
        }

        private async void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV| *.csv", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Nome;Idade;Telefone;Tarifa");
                            foreach (ListViewItem item in ListViewCSV.Items)
                            {
                                sb.AppendLine(string.Format($"{item.SubItems[0].Text};{item.SubItems[1].Text};{item.SubItems[2].Text};{item.SubItems[3].Text}"));
                            }
                            await sw.WriteLineAsync(sb.ToString());
                            MessageBox.Show("Arquivo salvo com sucesso", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbxPlaca.SelectedItem != null)
            _viagem = _listViagens.Where(x => x.PlacaOnibus == cbxPlaca.SelectedItem.ToString()).First();
            if(cbxData.SelectedItem != null)
            _viagem = _listViagens.Where(x => x.DataViagem.ToString() == cbxData.SelectedItem.ToString()).First();
            if (cbxHora.SelectedItem != null)
                _viagem = _listViagens.Where(x => x.HoraViagem.ToString() == cbxHora.SelectedItem.ToString()).First();


            AtualizarDados();
        }
        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            cbxPlaca.Items.Clear();
            object[] items = new object[_listViagens.Count()];
            var i = _listViagens.Count() - 1;
            foreach (Viagem item in _listViagens)
            {
                items[i] = new string(item.PlacaOnibus.ToString());
                i--;
            }
            cbxPlaca.Items.AddRange(items);
        }

        private void cbxData_MouseClick(object sender, MouseEventArgs e)
        {
            cbxData.Items.Clear();
            object[] items = new object[_listViagens.Count()];
            var i = _listViagens.Count() - 1;
            foreach (Viagem item in _listViagens)
            {
                items[i] = new string(item.DataViagem.ToString());
                i--;
            }
            cbxData.Items.AddRange(items);
        }

        private void cbxHora_MouseClick(object sender, MouseEventArgs e)
        {
            cbxHora.Items.Clear();
            object[] items = new object[_listViagens.Count()];
            var i = _listViagens.Count() - 1;
            foreach (Viagem item in _listViagens)
            {
                items[i] = new string(item.HoraViagem.ToString());
                i--;
            }
            cbxHora.Items.AddRange(items);
        }
        private void btnMaisVelhos_Click(object sender, EventArgs e)
        {
            ListViewCSV.Items.Clear();
               var velhosPassageiros = _listViagens.SelectMany( x=> x.Passageiros.Where(y=> y.Idade>60).OrderBy(y=>y.Nome)).ToList();
            foreach (var passageiro in velhosPassageiros)
            {
                AtualizarCsv(passageiro);
            }
        }
    }
}
