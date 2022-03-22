using PrimeiroProjetoComClasses.Exercicios.ProjetoLojaVirtualEletronicos;

namespace PrimeiroProjetoComClasses{
    public class Program{
          static void Main(string[] args){
            Usuario Usuario = new Usuario();
            Usuario.Nome = Usuario.PedeNome();
            Usuario.Email = Usuario.PedeEmail();
            CarrinhoCompras Carrinho = new CarrinhoCompras(Usuario);
            Carrinho.IniciarCompras();
         }
     }
}