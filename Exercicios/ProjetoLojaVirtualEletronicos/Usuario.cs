namespace PrimeiroProjetoComClasses.Exercicios.ProjetoLojaVirtualEletronicos{
    public class Usuario{
        public string Nome {get; set;}
        public string Email {get; set;}
        public Usuario(){

        }
        public Usuario(string nome, string email){
            Nome = nome;
            Email = email;
        }
        public int EscolherProduto(){
            int produtoEscolhido;
            Console.WriteLine("Qual produto deseja? 1-Celular(R$ 500) 2-Computador(R$ 2000) 3-Video Game(R$ 1500)");
            produtoEscolhido = int.Parse(Console.ReadLine());
            return produtoEscolhido;
        }
        public string PedeNome(){
            Console.WriteLine("Qual seu nome?");
            string nomeInformado = Console.ReadLine();
            return nomeInformado;
        }
        public string PedeEmail(){
            Console.WriteLine("Qual seu email?");
            string emailInformado = Console.ReadLine();
            return emailInformado;
        }
    }
}