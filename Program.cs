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
            //adicionar outra lista
            numeros.AddRange(numerosMaisDez);
            //remover item
            numeros.Remove(5);
            numeros.RemoveAt(3);
            numeros.RemoveAll(numeroARemover => numeroARemover < 10 || numeroARemover > 14);
            numeros.RemoveRange(0, 5);
            //buscar index
            var indexString = strings.IndexOf("a");
            var indexCinco = numeros.IndexOf(5);
            //buscar na lista
            var valorNaPosicaoTres = numeros.ElementAt(3);
            var valorPar = numeros.Find(numero => numero % 2 == 0);
            var valoresParesDois = numeros.FindAll(numero => numero % 2 == 0);
            //verificação
            var temQuinze = numeros.Any(numero => numero == 15);
            var temQuatorze = numeros.Exists(numero => numero == 14);
            var todosSaoPares = numeros.All(numero => numero % 2 == 0);
            var textoComMaisDeCincoLetras = strings.All(numero => strings.Count > 5);
            //ordenação
            var ordenacaoDescrescente = numeros.OrderByDescending(x => x);
            var ordenacaoCrescente = numeros.OrderBy(x => x);
         }
     }
}