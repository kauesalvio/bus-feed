namespace PROVA_DE_SUFICIENCIA.Entities
{
    /// <summary>
    /// Kauê Felipe Salvio
    /// </summary>
    public class Idoso : Passageiro
    {

        public string RegistroGeral { get; set; }
        public Idoso(string nome, string telefone, int idade, string rg) : base(nome, telefone, idade)
        {
            RegistroGeral = rg;
        }

        public override float GetTarifa()
        {
            return 0.0f;
        }

    }
}
