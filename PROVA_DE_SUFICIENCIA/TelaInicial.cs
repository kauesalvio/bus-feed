using PROVA_DE_SUFICIENCIA.Entities;
using System.Data;

namespace PROVA_DE_SUFICIENCIA
{
    /// <summary>
    /// Kauê Felipe Salvio
    /// </summary>
    public partial class TelaInicial : Form
    {
        private readonly List<Viagem> viagens;
        private Viagem viagem;
        public TelaInicial()
        {
            viagens = new List<Viagem>();
            InitializeComponent();
        }

        private void RegistrarPassageiro_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Ônibus não selecionado! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            viagem = viagens.Where(x => x.PlacaOnibus == comboBox1.SelectedItem.ToString()).Single();
            var registar = new Cadastro(viagem);
            registar.Show();
        }

        private void GraficoCSV_Click(object sender, EventArgs e)
        {
            var grafico = new Grafico(viagem, viagens);
            grafico.Show();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            RegistrarPassageiro.Visible = true;
            GraficoCSV.Visible = true;
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            var viagemCadastro = new ViagemCadastro(viagens);
            viagemCadastro.Show();
        }

        private object[] Plates(List<Viagem> listaViagens)
        {
            object[] items = new object[listaViagens.Count()];
            var i = listaViagens.Count() - 1;
            foreach (Viagem item in listaViagens)
            {
                items[i] = new string(item.PlacaOnibus.ToString());
                i--;
            }
            return items;
        }

        private void comboBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(Plates(viagens));      
        }
    }
}

