namespace PROVA_DE_SUFICIENCIA.Entities
{
    /// <summary>
    /// Kauê Felipe Salvio
    /// </summary>
    public class Intermunicipal : Viagem
    {
        public override int numeroDePassageiros { get; set; } = 28;
        public Intermunicipal(string placaOnibus, string nomeMotorista, DateTime dataViagem, TimeOnly horaViagem) : base(placaOnibus, nomeMotorista, dataViagem, horaViagem)
        { }

        public override void AddPassageiro(Passageiro passageiro)
        {
            var numeroDePassageiros = Passageiros.Count();
            if (numeroDePassageiros == 28)
            {
                throw new ArgumentException($"Vagas totais de passageiros atingido! ");
            }
            base.AddPassageiro(passageiro);
        }
        public override float GetValorTotal()
        {
            return Passageiros.Select(x => x.GetTarifa() + 3.95f).Sum();
        }
    }
}
