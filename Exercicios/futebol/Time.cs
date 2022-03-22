using PrimeiroProjetoComClasses.Exercicios.ExercicioCorrida;
namespace PrimeiroProjetoComClasses.Exercicios.futebol{
    public class Time{
        public string Tecnico {get; set;}
        public Pessoa[] Jogadores {get; set;}
        public string Hino {get; set;}
        public int Pontos {get; set;}

        public virtual void JogarClassico(){
            Pontos = Pontos = 3;
        }
    }
}