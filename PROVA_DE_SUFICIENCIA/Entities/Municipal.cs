namespace PROVA_DE_SUFICIENCIA.Entities
{
    public class Municipal : Viagem
    {
        public override int totalDePassageiros { get; set; } = 35;
        public Municipal(string placaOnibus, string nomeMotorista, DateTime dataViagem,TimeOnly horaViagem) : base(placaOnibus, nomeMotorista, dataViagem, horaViagem)
        {
        }
        public override void AddPassageiro(Passageiro passageiro)
        {
            var numeroDePassageiros = Passageiros.Count();
            if(numeroDePassageiros == 35)
            {
                throw new ArgumentException($"Limite de {totalDePassageiros} passageiros atingido"); 
            }
            base.AddPassageiro(passageiro);
        }

    }
}
