namespace PrimeiroProjetoComClasses.Exercicios.ProjetoPetShop{
    public class PedidoPetShop{
        public string NomeDoDono {get; set;}
        public int TelefoneDoDono {get; set;}
        public Animal[] Animais {get; set;}
        public double Preco {get; set;}

        public PedidoPetShop(string nomeDoDono, int telefoneDoDono, int qtdAnimais){
            NomeDoDono = nomeDoDono;
            TelefoneDoDono = telefoneDoDono;
            Animais = new Animal[qtdAnimais];
        }
        
        public void CalcularPreco(){
            Preco = 0;
            for(int contador = 0; contador < Animais.Length; contador++){
                Preco = Preco + ((Animais[contador].Comer()*2) + (Animais[contador].TomarBanho()*3));
            }
        }
    }
}