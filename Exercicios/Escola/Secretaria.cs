namespace PrimeiroProjetoComClasses.Exercicios.Escola
{
    public class Secretaria
    {
        public List<SalaDeAula> CadastrarNovasTurmas()
        {
            var salasDeAula = new List<SalaDeAula>();
            string opcaoContinuar;
            do
            {
                Console.WriteLine("Deseja adicionar uma nova sala de aula? 1-Sim | 2-Não");
                opcaoContinuar = Console.ReadLine();
                if (opcaoContinuar == "1")
                {
                    Console.WriteLine("Qual a serie?");
                    var serie = Console.ReadLine();
                    var professores = CadastrarProfessoresDaTurma();
                    var alunos = CadastrarPrimeirosAlunosDaTurma();
                    salasDeAula.Add(new SalaDeAula(serie, alunos, professores));
                    Console.WriteLine("Sala de Aula adicionada com sucesso!");
                }
                else if (opcaoContinuar == "2")
                {
                    Console.WriteLine("Operação finalizada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            } while (opcaoContinuar != "2");
            return salasDeAula;
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
        private Professor CadastrarNovoProfessor()
        {
            Console.WriteLine("Qual nome do professor?");
            var nomeDoAluno = Console.ReadLine();
            Console.WriteLine("Qual CPF do professor?");
            var cpf = Console.ReadLine();
            Console.WriteLine("Qual data de nascimento do professor?");
            var dataDeNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Qual disciplina leciona?");
            var disciplina = Console.ReadLine();
            return new Professor(nomeDoAluno, dataDeNascimento, cpf, disciplina);
        }
        private List<Aluno> CadastrarPrimeirosAlunosDaTurma()
        {
            string continuarAdicionando;
            var primeirosAlunos = new List<Aluno>();
            do
            {
                Console.WriteLine("Deseja adicionar novo aluno? 1-Sim | 2-Não");
                continuarAdicionando = Console.ReadLine();
                switch (continuarAdicionando)
                {
                    case "1":
                        primeirosAlunos.Add(CadastrarNovoAluno());
                        break;
                    case "2":
                        Console.WriteLine("Cadastramento finalizado!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (continuarAdicionando != "2");
            return primeirosAlunos;
        }
        private List<Professor> CadastrarProfessoresDaTurma()
        {
            string continuarAdicionando;
            var professoresDaTurma = new List<Professor>();
            do
            {
                Console.WriteLine("Deseja adicionar novo professor? 1-Sim | 2-Não");
                continuarAdicionando = Console.ReadLine();
                switch (continuarAdicionando)
                {
                    case "1":
                        professoresDaTurma.Add(CadastrarNovoProfessor());
                        break;
                    case "2":
                        Console.WriteLine("Cadastramento finalizado!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (continuarAdicionando != "2");
            return professoresDaTurma;
        }
    }
}