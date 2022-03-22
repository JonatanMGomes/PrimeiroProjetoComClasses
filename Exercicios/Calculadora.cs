namespace PrimeiroProjetoComClasses.Exercicios{
    public class Calculadora{
        //Comportamentos e propriedades/dados
        public void RealizarExercicio(){
            int valorInserido, segundoValor, opcao;
            do{
                ExibeOpcoesDeConta();
                opcao = SolicitaOperador();
                valorInserido = SolicitarValorInteiro();
                segundoValor = SolicitarValorInteiro();
                RealizarOperacao(opcao, valorInserido, segundoValor);
            } while (QuerFazerNovoCalculo());
        }
        int SolicitarValorInteiro(){
            Console.WriteLine("Insira um valor inteiro");
            return int.Parse(Console.ReadLine());
        }
        public void ExibeOpcoesDeConta(){
            Console.WriteLine("Bem vindo a calculadora do C#");
            Console.WriteLine("");
            Console.WriteLine("Insira uma opção de calculo");
            Console.WriteLine("1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão e 5 - Modulo");
        }
        public int SolicitaOperador(){
            Console.WriteLine("");
            Console.WriteLine("Insira a operação desejada");
            return int.Parse(Console.ReadLine());
        }

        public void RealizarOperacao(int opcao,int valorInserido, int segundoValor){
            Console.WriteLine("");
            switch (opcao){
                case 1:
                    Console.WriteLine("O resultado da soma é: " + Somar(valorInserido, segundoValor));
                    break;
                case 2:
                    Console.WriteLine("O resultado da subtração é: " + Subtrair(valorInserido, segundoValor));
                    break;
                case 3:
                    Console.WriteLine("O resultado da multiplicação é: " + Multiplicar(valorInserido, segundoValor));
                    break;
                case 4:
                    Console.WriteLine("O resultado da divisão é: " + Dividir(valorInserido, segundoValor));
                    break;
                case 5:
                    Console.WriteLine("O resultado do modulo é: " + Modulo(valorInserido, segundoValor));
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
        int Somar(int parametroUm, int parametroDois){
            return parametroUm + parametroDois;
        }
        int Subtrair(int parametroUm, int parametroDois){
            return parametroUm - parametroDois;
        }
        int Multiplicar(int parametroUm, int parametroDois){
            return parametroUm * parametroDois;
        }
        int Dividir(int parametroUm, int parametroDois){
            return parametroUm / parametroDois;
        }
        int Modulo(int parametroUm, int parametroDois){
            return parametroUm % parametroDois;
        }

        public bool QuerFazerNovoCalculo(){
            int opcao;
            Console.WriteLine("");
            Console.WriteLine("Deseja realizar mais alguma operação? 1 - Sim 2 - Não");
            opcao = int.Parse(Console.ReadLine());
            if(opcao == 1){
                return true;
            } else if(opcao == 2){
                return false;
                Console.WriteLine("Obrigado por atilizar nossa calculadora!");

            } else{
                Console.WriteLine("Opção invalida!");
                Console.WriteLine("Obrigado por atilizar nossa calculadora!");
                return false;
            }  
        }
    }
}