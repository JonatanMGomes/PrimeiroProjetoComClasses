namespace PrimeiroProjetoComClasses.Exercicios.ProjetoQuaseTrêsLanches
{
    public class Lanche : Prato{
        public bool Duplo {get; set;}

        public Lanche(string recheio, bool duplo) : base(recheio){
            Duplo = duplo;
        }
        public override void CalcularPreco(){
            Preco = 30;
            if(Duplo == true){
                Preco = Preco+(Preco/2);
            }
        }
    }
}