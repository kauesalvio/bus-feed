namespace PROVA_DE_SUFICIENCIA.Entities
{
    /// <summary>
    /// Kauê Felipe Salvio
    /// </summary>
    public class Municipal : Viagem
    {
        public override int numeroDePassageiros { get; set; } = 35;
        public Municipal(string placaOnibus, string nomeMotorista, DateTime dataViagem,TimeOnly horaViagem) : base(placaOnibus, nomeMotorista, dataViagem, horaViagem)
        {
        }
        public override void AddPassageiro(Passageiro passageiro)
        {
            var numeroDePassageiros = Passageiros.Count();
            if(numeroDePassageiros == 35)
            {
                throw new ArgumentException($"Vagas totais de passageiros atingido! "); 
            }
            base.AddPassageiro(passageiro);
        }

    }
}
