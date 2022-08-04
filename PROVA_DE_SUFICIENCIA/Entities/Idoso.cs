namespace PROVA_DE_SUFICIENCIA.Entities
{
    public class Idoso : Passageiro
    {
        public Idoso(string nome, string telefone, int idade, string rg) : base(nome, telefone, idade)
        {
            Rg = rg;
        }

        public string Rg { get; set; }

        public override float GetTarifa()
        {
            return 0.0f;
        }

    }
}
