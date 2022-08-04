namespace PROVA_DE_SUFICIENCIA.Entities
{
    public class Estudante : Passageiro
    {
        public Estudante(string nome, string telefone, int idade, string escola) : base(nome, telefone, idade)
        {
            Escola = escola;
        }

        public string Escola { get; set; }

        public override float GetTarifa()
        {
            return (base.GetTarifa()/2);
        }
    }
}
