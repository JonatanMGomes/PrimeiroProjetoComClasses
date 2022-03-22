namespace PrimeiroProjetoComClasses.Exercicios.ProjetoQuaseTrêsLanches{
    public class Salgadinho : Prato{
        public string Tipo {get; set;}

        public Salgadinho(string recheio, string tipo) : base(recheio){
            Tipo = tipo;
        }
        public override void CalcularPreco(){
            if(Tipo == "Assado"){
                Preco = 6;
            }else if(Tipo == "Frito"){
                Preco = 7;
            }
        }
    }
}