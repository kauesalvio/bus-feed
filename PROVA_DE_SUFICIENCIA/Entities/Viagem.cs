namespace PROVA_DE_SUFICIENCIA.Entities
{
    /// <summary>
    /// Kauê Felipe Salvio
    /// </summary>
    public abstract class Viagem
    {
        public virtual int numeroDePassageiros { get; set; }
        public string PlacaOnibus { get; set; }
        public string NomeMotorista { get; set; }
        public DateTime DataDaViagem { get; set; }
        public TimeOnly HoraDaViagem { get; set; }
        public List<Passageiro> Passageiros{ get; set; }

        public virtual void AddPassageiro(Passageiro passageiro)
        {
            Passageiros.Add(passageiro);
        }
        public virtual float GetValorTotal()
        {
            return Passageiros.Select(x => x.GetTarifa()).Sum();
        }

        public Viagem(string placaOnibus, string nomeMotorista, DateTime dataDaViagem, TimeOnly horaDaViagem)
        {
            PlacaOnibus = placaOnibus;
            NomeMotorista = nomeMotorista;
            DataDaViagem = dataDaViagem;
            HoraDaViagem = horaDaViagem;
            Passageiros = new List<Passageiro>();
        }
    }
}
