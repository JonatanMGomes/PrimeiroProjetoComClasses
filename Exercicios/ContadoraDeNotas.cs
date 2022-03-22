namespace PrimeiroProjetoComClasses.Exercicios{
    public class ContadoraDeNotas{
        float notas100, notas50, notas20, notas10, notas5, notas2, notas1;
        int valorInformado, valorAtualizado, restoDiv;

        public void valorDesejado(){
            Console.WriteLine("Informe o valor desejado, mas sem centavos.");
            valorInformado = int.Parse(Console.ReadLine());
            valorAtualizado = valorInformado;
            Console.WriteLine("");
        }
        public int contarNota(int valor, int nota){
            int qtdNotas = valor/nota;
            return qtdNotas;
        }

        public void atualizaValor(int nota){
            valorAtualizado = valorAtualizado%nota;
        }

        public void informaResultado(){
            Console.WriteLine("Para o valor informado de: " + valorInformado + ". São necessarias as seguintes notas:");
            Console.WriteLine("Notas de 100 - " + notas100);
            Console.WriteLine("Notas de  50 - " + notas50);
            Console.WriteLine("Notas de  20 - " + notas20);
            Console.WriteLine("Notas de  10 - " + notas10);
            Console.WriteLine("Notas de   5 - " + notas5);
            Console.WriteLine("Notas de   2 - " + notas2);
            Console.WriteLine("Nota de    1 - " + notas1);
        }

        public void realizarExercicio(){
            Console.WriteLine("Bem vindo ao Mestre das Notas, seu contador de notas. ;)");
            Console.WriteLine("");
            valorDesejado();
            for(int contador = 0; contador < 7; contador++){
                if(valorAtualizado >= 100){
                    notas100 = contarNota(valorAtualizado, 100);
                    atualizaValor(100);
                }else if(valorAtualizado >= 50){
                    notas50 = contarNota(valorAtualizado, 50);
                    atualizaValor(50);
                }else if(valorAtualizado >= 20){
                    notas20 = contarNota(valorAtualizado, 20);
                    atualizaValor(20);
                }else if (valorAtualizado >= 10){
                    notas10 = contarNota(valorAtualizado, 10);
                    atualizaValor(10);
                }else if(valorAtualizado >= 5){
                    notas5 = contarNota(valorAtualizado, 5);
                    atualizaValor(5);
                }else if(valorAtualizado >= 2){
                    notas2 = contarNota(valorAtualizado, 2);
                    atualizaValor(2);
                }else if(valorAtualizado >= 1){
                    notas1 = contarNota(valorAtualizado, 1);
                }
            }
            informaResultado();
            Console.WriteLine("");
        }

    }
}