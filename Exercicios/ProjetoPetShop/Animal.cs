namespace PrimeiroProjetoComClasses.Exercicios.ProjetoPetShop{
    public class Animal{
        public string Raca {get; set;}
        public int Idade {get; set;}
        public double Peso {get; set;}
        public Animal(string raca, int idade, double peso){
            Raca = raca;
            Idade = idade;
            Peso = peso;
        }

        public virtual int Comer(){
            int comeu = 100;
            Console.WriteLine("Animal alimentado!");
            return comeu;
        }

        public virtual int TomarBanho(){
            int banho = 10;
            Console.WriteLine("Animal tomou banho!");
            return banho;
        }
    }
}