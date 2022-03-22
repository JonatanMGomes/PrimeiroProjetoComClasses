namespace PrimeiroProjetoComClasses.Exercicios.ExercicioCorrida
{
    public class Carro
    {
        public string Modelo { get; set; }
        //Colocar piloto
        //Composição
        public Piloto Piloto { get; set; }
        public double PotenciaDoMotor { get; set; }
        public string TipoPneu { get; set; }
        public double Aceleracao {get;}
        public double TempoRealizadoNaCorrida {get; set;}
        public Carro(string modelo, double potenciaDoMotor, string tipoPneu, Piloto piloto){
            Modelo = modelo;
            PotenciaDoMotor = potenciaDoMotor;
            TipoPneu = tipoPneu; 
            Aceleracao = potenciaDoMotor * 3;
            Piloto = piloto;
        }

        public double CalcularTempoEmSegundos(double distanciaPercorridaEmMetro, string clima){
            double tempoEmSegundos = distanciaPercorridaEmMetro / Aceleracao;
            Piloto.DefinirPesoHabilidade();
            if(clima != TipoPneu)
            {
                tempoEmSegundos = tempoEmSegundos * 1.15;
            }
            
            tempoEmSegundos = tempoEmSegundos/Piloto.PesoHabilidade;
            return tempoEmSegundos;
        }
    }
}