using PrimeiroProjetoComClasses.Exercicios.ProjetoLojaVirtualEletronicos;

namespace PrimeiroProjetoComClasses{
    public class Program{
          static void Main(string[] args){
            /*Usuario Usuario = new Usuario();
            Usuario.Nome = Usuario.PedeNome();
            Usuario.Email = Usuario.PedeEmail();
            CarrinhoCompras Carrinho = new CarrinhoCompras(Usuario);
            Carrinho.IniciarCompras();*/
            var numeros = new List<int>();
            var numerosMaisDez = new List<int>();
            var strings = new List<string>();
            for(var contador = 0; contador < 10; contador++){
              numeros.Add(contador);
              numerosMaisDez.Add(contador+10);
              strings.Add(contador.ToString());
            }
            Console.WriteLine("Finalizou");
            numeros.AddRange(numerosMaisDez);

            numeros.Remove(5);
            numeros.RemoveAt(3);
            numeros.RemoveAll(numeroARemover => numeroARemover < 10 || numeroARemover > 14);
            numeros.RemoveRange(0, 5);
         }
     }
}