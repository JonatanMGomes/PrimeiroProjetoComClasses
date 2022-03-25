namespace PrimeiroProjetoComClasses.Exercicios.Escola{
    public class Aluno{
        public string CPF { get; }
        public string Nome { get; }
        public DateTime DataDeNascimento { get; }

        public Aluno(string nome, DateTime dataDeNascimento, string cpf){
        nome = nome;
        DataDeNascimento = dataDeNascimento;
        CPF = cpf;
        }
    }
}