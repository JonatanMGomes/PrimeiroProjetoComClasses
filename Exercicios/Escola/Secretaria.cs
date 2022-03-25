namespace PrimeiroProjetoComClasses.Exercicios.Escola
{
    public class Secretaria
    {
        public void CadastrarNovasTurmas()
        {
            var salasDeAula = new List<SalaDeAula>();
            var opcaoContinuar = 0;
            do
            {
                Console.WriteLine("Deseja adicionar uma nova sala de aula? 1-Sim | 2-Não");
                opcaoContinuar = int.Parse(Console.ReadLine());
                if (opcaoContinuar == 1)
                {
                    Console.WriteLine("Qual o nome do professor?");
                    var nomeDoProfessor = Console.ReadLine();
                    Console.WriteLine("Qual a serie?");
                    var serie = Console.ReadLine();
                    var alunos = CadastrarPrimeirosAlunosDaTurma();
                    salasDeAula.Add(new SalaDeAula(serie, alunos, nomeDoProfessor));
                }
            } while (opcaoContinuar != 2);
        }
        private Aluno CadastrarNovoAluno()
        {
            Console.WriteLine("Qual nome do aluno?");
            var nomeDoAluno = Console.ReadLine();
            Console.WriteLine("Qual CPF do aluno?");
            var cpf = Console.ReadLine();
            Console.WriteLine("Qual data de nascimento do aluno?");
            var dataDeNascimento = DateTime.Parse(Console.ReadLine());
            return new Aluno(nomeDoAluno, dataDeNascimento, cpf);
        }
        private List<Aluno> CadastrarPrimeirosAlunosDaTurma()
        {
            var continuarAdicionando = 0;
            Console.WriteLine("Deseja adicionar novos alunos? 1-Sim | 2-Não");
            continuarAdicionando = int.Parse(Console.ReadLine());
            var primeirosAlunos = new List<Aluno>();
            while (continuarAdicionando == 1)
            {
                primeirosAlunos.Add(CadastrarNovoAluno());
            }
            return primeirosAlunos;
        }
    }
}