namespace PrimeiroProjetoComClasses.Exercicios.ProjetoPetShop{
    public class Hamster : Animal{
        public Hamster(string raca, int idade, double peso) : base(raca, idade, peso) {
        }
        
        public override int Comer(){
            int comeu = 25;
            Console.WriteLine("Hamster alimentado!");
            return comeu;
        }

        public override int TomarBanho(){
            int banho = 5;
            Console.WriteLine("Hamster tomou banho!");
            return banho;
        }
    }
}