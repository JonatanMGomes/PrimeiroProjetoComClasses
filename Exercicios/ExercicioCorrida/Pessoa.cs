namespace PrimeiroProjetoComClasses.Exercicios.ExercicioCorrida{
    public class Pessoa{
        public string Nome { get; set; }
        public int Idade { get; set; }
        internal double Peso { get; set; }
        public string CorDosOlhos { get; set; }
        internal string Nacionalidade { get; set; }
        public Pessoa(string nome, int idade, double peso){
            Nome = nome;
            Idade = idade;
            Peso = peso;
        }

        //Metodos
       public void Falar(string texto){
            Console.WriteLine(Peso);
        }
    }
}