namespace PrimeiroProjetoComClasses.Exercicios.Escola{
    public class SalaDeAula{
        public List<Professor> Professores { get; private set; }
        public string Serie { get; private set; }
        public List<Aluno> Alunos { get; private set; }

        public SalaDeAula(string serie, List<Aluno> listaDeAlunosInicial, List<Professor> professores){
            Professores = professores;
            Serie = serie;
            Alunos = listaDeAlunosInicial;
        }
        public void AdicionarAluno(Aluno aluno){
            Alunos.Add(aluno);
        }
        public void RemoverAluno(string cpf){
            Alunos.RemoveAll(aluno => aluno.CPF == cpf);
        }
        public void AdicionarProfessor(Professor professor){
            Professores.Add(professor);
        }
        public void RemoverProfessor(string cpf){
            Professores.RemoveAll(professor => professor.CPF == cpf);
        }
    }
}