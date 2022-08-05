namespace PROVA_DE_SUFICIENCIA.Entities
{
    /// <summary>
    /// Kauê Felipe Salvio
    /// </summary>
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

        public Passageiro() { }

        public virtual float GetTarifa()
        {
            return TarifaInteira;
        }
    }
}
