namespace PrimeiroProjetoComClasses.Exercicios.ProjetoQuaseTrêsLanches{
    public class Pizza : Prato{
        public bool BordaRecheada {get; set;}

        public Pizza(string recheio, bool bordaRecheada) : base(recheio){
            BordaRecheada = bordaRecheada;
        }
        public override void CalcularPreco(){
            Preco = 30;
            if(BordaRecheada == true){
                Preco = Preco+10;
            }
        }
    }
}