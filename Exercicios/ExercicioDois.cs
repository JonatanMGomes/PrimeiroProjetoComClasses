namespace PrimeiroProjetoComClasses.Exercicios{
    public class ExercicioDois{
        public void RealizarExercicio(){
            string nome, corrigirDados;
            int idade, AnoAtual, contador;
            float SalarioAtual, porcentagem;
            bool repetir;
            repetir = true;

            Console.WriteLine("Bem vindo a Calculadora de Aumento Salarial ExercicioDois!");
            Console.WriteLine("");
            do{
                Console.WriteLine("Qual o seu nome?");
                nome = Console.ReadLine();

                Console.WriteLine("Qual idade vc completa esse ano?");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Em qual ano nós estamos?");
                AnoAtual = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o seu salário atualmente?");
                SalarioAtual = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine("Deseja corrigir alguma das informações?");
                Console.WriteLine("    ( s )....SIM    ( n )....NÃO");
                corrigirDados = (Console.ReadLine());
                if (corrigirDados == "n"){
                    repetir = false;
                }
                Console.WriteLine("");

            } while (repetir == true);

            porcentagem = 1.5f;
            for (contador = 0; contador <= 10; contador++){
                SalarioAtual = RetornarNovoSalario(SalarioAtual, porcentagem);
                Console.WriteLine((AnoAtual + contador) + " - " + (SalarioAtual));
                porcentagem = porcentagem * 2;
            }
            for (contador = 0; contador < 5; contador++){
                SalarioAtual = RetornarNovoSalario(SalarioAtual, 5);
                Console.WriteLine(SalarioAtual);
            }
        }
        float RetornarNovoSalario(float salario, float porcentagemAjuste){
            float reajuste = (salario * (porcentagemAjuste / 100));
            return salario + reajuste;
        }
    }
}