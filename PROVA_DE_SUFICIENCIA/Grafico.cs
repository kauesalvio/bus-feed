using PROVA_DE_SUFICIENCIA.Entities;
using System.Data;
using System.Text;

namespace PROVA_DE_SUFICIENCIA
{
    /// <summary>
    /// Kauê Felipe Salvio
    /// </summary>
    public partial class Grafico : Form
    {
        private List<Viagem> _viagens;
        private Viagem _viagem;
        private List<Passageiro> _listCsv;

        public Grafico(Viagem viagem, List<Viagem> listViagens)
        {
            _viagens = listViagens;
            _viagem = viagem;
            _listCsv = new List<Passageiro>();
            InitializeComponent();
        }

        private void ListViewCSV_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Grafico_Load(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void AtualizarDados()
        {
            try
            {
                lblValorTotal.Text = _viagem.GetValorTotal().ToString();
                lblOciosas.Text = (_viagem.numeroDePassageiros - _viagem.Passageiros.Count()).ToString();

                ListViewCSV.Items.Clear();
                cbxPlaca.SelectedItem = null;
                cbxData.SelectedItem = null;
                cbxHora.SelectedItem = null;

                foreach (var passageiro in _viagem.Passageiros)
                {
                    var item = new ListViewItem(passageiro.Nome);
                    item.SubItems.Add(passageiro.Idade.ToString());
                    item.SubItems.Add(passageiro.Telefone.ToString());
                    item.SubItems.Add($"R${passageiro.GetTarifa()}");
                    ListViewCSV.Items.Add(item);
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
            _listCsv.Add(passageiro);
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
                            sb.AppendLine($"{_viagem.DataDaViagem.ToString() ?? string.Empty};{_viagem.HoraDaViagem.ToString() ?? string.Empty};{_viagem.PlacaOnibus};{_viagem.NomeMotorista};");
                            foreach (var item in _listCsv)
                            {
                                sb.AppendLine(string.Format($"{item.GetType().Name.Substring(0, 1)};{item.Nome};{item.Telefone};{item.Idade};"));
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
            _viagem = _viagens.Where(x => x.PlacaOnibus == cbxPlaca.SelectedItem.ToString()).First();
            if(cbxData.SelectedItem != null)
            _viagem = _viagens.Where(x => x.DataDaViagem.ToString() == cbxData.SelectedItem.ToString()).First();
            if (cbxHora.SelectedItem != null)
                _viagem = _viagens.Where(x => x.HoraDaViagem.ToString() == cbxHora.SelectedItem.ToString()).First();


            AtualizarDados();
        }
        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            cbxPlaca.Items.Clear();
            object[] items = new object[_viagens.Count()];
            var i = _viagens.Count() - 1;
            foreach (Viagem item in _viagens)
            {
                items[i] = new string(item.PlacaOnibus.ToString());
                i--;
            }
            cbxPlaca.Items.AddRange(items);
        }

        private void cbxData_MouseClick(object sender, MouseEventArgs e)
        {
            cbxData.Items.Clear();
            object[] items = new object[_viagens.Count()];
            var i = _viagens.Count() - 1;
            foreach (Viagem item in _viagens)
            {
                items[i] = new string(item.DataDaViagem.ToString());
                i--;
            }
            cbxData.Items.AddRange(items);
        }

        private void cbxHora_MouseClick(object sender, MouseEventArgs e)
        {
            cbxHora.Items.Clear();
            object[] items = new object[_viagens.Count()];
            var i = _viagens.Count() - 1;
            foreach (Viagem item in _viagens)
            {
                items[i] = new string(item.HoraDaViagem.ToString());
                i--;
            }
            cbxHora.Items.AddRange(items);
        }

        private void btnMaisVelhos_Click(object sender, EventArgs e)
        {
            ListViewCSV.Items.Clear();
            var velhosPassageiros = _viagens.SelectMany( x=> x.Passageiros.Where(y => y.Idade >= 60).OrderBy(y => y.Nome)).ToList();
            foreach (var passageiro in velhosPassageiros)
            {
                var item = new ListViewItem(passageiro.Nome);
                item.SubItems.Add(passageiro.Idade.ToString());
                item.SubItems.Add(passageiro.Telefone.ToString());
                item.SubItems.Add($"R${passageiro.GetTarifa()}");
                ListViewCSV.Items.Add(item);
                AtualizarCsv(passageiro);
            }
        }
    }
}
