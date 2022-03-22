namespace PrimeiroProjetoComClasses.Exercicios.ProjetoPetShop{
    public class Gato : Animal{
        public Gato(string raca, int idade, double peso) : base(raca, idade, peso) {
        }
        public override int Comer(){
            int comeu = 50;
            Console.WriteLine("Gato alimentado!");
            return comeu;
        }

        public override int TomarBanho(){
            int banho = 15;
            Console.WriteLine("Gato tomou banho!");
            return banho;
        }
    }
}