namespace PrimeiroProjetoComClasses.Exercicios.Escola
{
    public class Professor : Pessoa
    {
        public List<string> DiscplinaQueLeciona { get; private set;}
        public Professor(string nome, DateTime dataDeNascimento, string cpf, string disciplina) : base(nome, dataDeNascimento, cpf)
        {
            DiscplinaQueLeciona = new List<string>();
            DiscplinaQueLeciona.Add(disciplina);
        }
        public void adicionarDisciplinaAoCurriculo(string disciplina)
        {
            DiscplinaQueLeciona.Add(disciplina);
        }
        public void RemoverDisciplinaAoCurriculo(string disciplina)
        {
            DiscplinaQueLeciona.Remove(disciplina);
        }
    }
}