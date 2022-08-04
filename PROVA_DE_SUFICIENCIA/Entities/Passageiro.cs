using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_DE_SUFICIENCIA.Entities
{
    public class Passageiro
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public float TarifaInteira { get; set; } = 6.0f;

        public Passageiro(string nome, string telefone, int idade)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
        }

        public virtual float GetTarifa()
        {
            return TarifaInteira;
        }
    }
}
