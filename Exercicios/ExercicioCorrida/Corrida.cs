namespace PrimeiroProjetoComClasses.Exercicios.ExercicioCorrida{
    public class Corrida{
        //Criar classe corrida para representar nossa corrida
        //Distancia, Clima, Carros, Paradas, NomePista, CarroGanhador
        //CadastrarParticipantes, IniciarACorrida, VerificarGanhador
        //Iniciar a corrida deve calcular o vencedor e gravar na propriedade CarroGanhador
        //Só devemos poder gravar o valor de CarroGanhador dentro da nossa classe corrida
        //VerificarGanhador deve retornar esse ganhador
        public string NomePista {get; set;}
        public string Clima {get; set;}
        public int Paradas {get; set;}
        public double Distancia {get; set;}
        public Carro CarroGanhador {get; private set;}
        public Carro[] Carros {get; set;}

        public Corrida(string nomePista, string clima, double distancia, int qtdCarros){
            NomePista = nomePista;
            Clima = clima;
            Distancia = distancia;
            Carros = new Carro[qtdCarros];
        }
        public void CadastrarParticipantes(){
            for (int contador = 0; contador < Carros.Length; contador++) {
                Console.WriteLine("Qual modelo do carro?");
                string modelo = Console.ReadLine();
                Console.WriteLine("Qual a potência do motor?");
                double potenciaDoMotor = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual tipo de pneu?");
                string tipoPneu = Console.ReadLine();
                Console.WriteLine("Qual nome do piloto?");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual idade do piloto??");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual peso do piloto??");
                double peso = double.Parse(Console.ReadLine());
                Carros[contador] = new Carro(modelo, potenciaDoMotor, tipoPneu, new Piloto(nome, idade, peso));
            }
        }

        public Carro VerificarGanhador(){
            Carro carroTeste = Carros[0];
            for(int contador = 0; contador < Carros.Length; contador++){
                if(carroTeste.CalcularTempoEmSegundos(Distancia, Clima) > Carros[contador].CalcularTempoEmSegundos(Distancia, Clima)){
                    carroTeste = Carros[contador];
                    Carros[contador].TempoRealizadoNaCorrida = Carros[contador].CalcularTempoEmSegundos(Distancia, Clima);
                }
            }
            return carroTeste;
        }

        /*public void DefinePodium(){
            Carros.OrderBy(TempoRealizadoNaCorrida);
        }*/
        public void IniciarCorrida(){
            Console.WriteLine($"Bem vindos a corrida de hoje! Quem será o vencedor da {NomePista} esta noite?");
            Console.WriteLine("E é dado a largada! Os carros disparam em direção a linha de chegada.");
            Console.WriteLine("Que corrida alucinante senhoras e senhores, o resultado está completamente aberto...");
            Console.WriteLine("E la vem eles, que emoção, estão disputando palmo a palmo, estão chegando...");
            CarroGanhador = VerificarGanhador();
            Console.WriteLine($"E o vencedor é..: {CarroGanhador.Modelo}, pilotada por {CarroGanhador.Piloto.Nome}");
            Console.WriteLine("Que corrida memorável meus amigos! Dito isto, encerramos a transmição. Tenham todos uma boa noite!");
        }


    }
}