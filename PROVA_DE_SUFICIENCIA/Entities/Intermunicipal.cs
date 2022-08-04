namespace PROVA_DE_SUFICIENCIA.Entities
{
    public class Intermunicipal : Viagem
    {
        public override int totalDePassageiros { get; set; } = 28;
        public Intermunicipal(string placaOnibus, string nomeMotorista, DateTime dataViagem, TimeOnly horaViagem) : base(placaOnibus, nomeMotorista, dataViagem, horaViagem)
        { }

        public override void AddPassageiro(Passageiro passageiro)
        {
            var numeroDePassageiros = Passageiros.Count();
            if (numeroDePassageiros == 28)
            {
                throw new ArgumentException($"Limite de {totalDePassageiros} passageiros atingido");
            }
            base.AddPassageiro(passageiro);
        }
        public override float GetValorTotal()
        {
            return Passageiros.Select(x => x.GetTarifa() + 3.95f).Sum();
        }
    }
}
