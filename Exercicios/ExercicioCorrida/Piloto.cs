namespace PrimeiroProjetoComClasses.Exercicios.ExercicioCorrida
{
    public class Piloto : Pessoa{
        public double PesoHabilidade {get; private set;}
        public Piloto(string nome, int idade, double peso): base(nome, idade, peso){
            PesoHabilidade = 1;
        }

        //Encapsulamento
        public void DefinirPesoHabilidade(){
            if(Nome == "Leandrão"){
                PesoHabilidade = 1.2;
            } else if(Nome == "Darlan"){
                PesoHabilidade = 0.5;
            } else if(Nome == "Rubinho"){
                PesoHabilidade = 0.8;
            }
        }
    }
}