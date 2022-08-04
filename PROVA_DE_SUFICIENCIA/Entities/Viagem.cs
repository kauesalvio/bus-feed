using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_DE_SUFICIENCIA.Entities
{
    public abstract class Viagem
    {
        public virtual int totalDePassageiros { get; set; }
        public string PlacaOnibus { get; set; }
        public string NomeMotorista { get; set; }
        public DateTime DataViagem { get; set; }
        public TimeOnly HoraViagem { get; set; }
        public List<Passageiro> Passageiros{ get; set; }

        public virtual void AddPassageiro(Passageiro passageiro)
        {
            Passageiros.Add(passageiro);
        }
        public virtual float GetValorTotal()
        {
            return Passageiros.Select(x => x.GetTarifa()).Sum();
        }

        public Viagem(string placaOnibus, string nomeMotorista, DateTime dataViagem, TimeOnly horaViagem)
        {
            PlacaOnibus = placaOnibus;
            NomeMotorista = nomeMotorista;
            DataViagem = dataViagem;
            HoraViagem = horaViagem;
            Passageiros = new List<Passageiro>();
        }
    }
}
