using PrimeiroProjetoComClasses.Exercicios.Escola;
namespace PrimeiroProjetoComClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
         var secretaria = new Secretaria();
         secretaria.CadastrarNovasTurmas();
        }
        public static void ExerciciosDateTimeTimeSpan(){
          //DateTime
            var dataEHoraAtual = DateTime.Now;
            var dataEHoraMaisUmDia = DateTime.Now.AddDays(1);
            var dataEHoraMenosUmMes = DateTime.Now.AddMonths(-1);
            Console.WriteLine("Insura sua data em mes/dia/ano");
            var dataDeNascimento = DateTime.Parse(Console.ReadLine());
            var dateTimeEmString = dataDeNascimento.ToString("dd/MM/yyyy hh:mm:ss");
            //TimeSpan
            var diferenca = dataEHoraAtual.Subtract(dataEHoraMenosUmMes);
            Console.WriteLine(diferenca.Days);
            Console.WriteLine($"Você nasceu no dia: {dataDeNascimento.Day} do mês: {dataDeNascimento.Month} e era {dataDeNascimento.DayOfWeek}");
            Console.WriteLine("Finalizou");
        }
        public static void ExerciciosLista()
            {
                var numeros = new List<int>();
                var numerosMaisDez = new List<int>();
                var strings = new List<string>();
                for (var contador = 0; contador < 10; contador++)
                {
                    numeros.Add(contador);
                    numerosMaisDez.Add(contador + 10);
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