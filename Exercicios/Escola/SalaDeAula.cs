namespace PrimeiroProjetoComClasses.Exercicios.Escola{
    public class SalaDeAula{
        public string NomeDoProfessor { get; private set; }
        public string Serie { get; }
        public List<Aluno> Alunos { get; private set; }

        public SalaDeAula(string serie, List<Aluno> listaDeAlunosInicial, string professor){
            NomeDoProfessor = professor;
            Serie = serie;
            Alunos = listaDeAlunosInicial;
        }
        public void AdicionarAluno(string nome, DateTime dataDeNascimento, string cpf){
            Alunos.Add(new Aluno(nome, dataDeNascimento, cpf));
        }
        public void AdicionarAluno(Aluno aluno){
            Alunos.Add(aluno);
        }
        public void RemoverAluno(string cpf){
            Alunos.RemoveAll(aluno => aluno.CPF == cpf);
        }
        public void MudarProfessor(string nomeDoProfessor){
            NomeDoProfessor = nomeDoProfessor;
        }
    }
}