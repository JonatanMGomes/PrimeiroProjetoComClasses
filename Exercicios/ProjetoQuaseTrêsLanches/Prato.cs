namespace PrimeiroProjetoComClasses.Exercicios.ProjetoQuaseTrêsLanches{
    public class Prato{
        public string Recheio {get; set;}
        public double Preco {get; set;}
        
        public Prato(string recheio){
            Recheio = recheio;
        }

        public virtual void CalcularPreco(){
            Preco = 10;
        }
    }
}