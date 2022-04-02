namespace PrimeiroProjetoComClasses.Exercicios.Escola
{
    public class Pessoa
    {
        public string CPF { get; }
        public string Nome { get; }
        public DateTime DataDeNascimento { get; }

        public Pessoa(string nome, DateTime dataDeNascimento, string cpf)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            CPF = cpf;
        }
    }
}