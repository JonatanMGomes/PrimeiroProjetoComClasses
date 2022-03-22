namespace PrimeiroProjetoComClasses.Exercicios.ProjetoPetShop{
    public class Cachorro : Animal{
        public Cachorro(string raca, int idade, double peso) : base(raca, idade, peso) {
        }
        public override int Comer(){
            int comeu = 100;
            Console.WriteLine("Cachorro alimentado!");
            return comeu;
        }

        public override int TomarBanho(){
            int banho = 10;
            Console.WriteLine("Cachorro tomou banho!");
            return banho;
        }
        
    }
}