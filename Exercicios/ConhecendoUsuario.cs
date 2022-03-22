namespace PrimeiroProjetoComClasses.Exercicios{
    public class ConhecendoUsuario{
        string nome, profissao;
        int idade, anoAtual;
        float altura, peso;

        public void setNome(){
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
        }
        public string getNome(){
            return nome;
        }

        public void setIdade(){
            Console.WriteLine("Qual idade completa esse ano?");
            idade = int.Parse(Console.ReadLine());
        }
        public int getIdade(){
            return idade;
        }

        public void setAltura(){
            Console.WriteLine("Qual sua altura?");
            altura = float.Parse(Console.ReadLine());
        }
        public float getAltura(){
            return altura;
        }

        public void setPeso(){
            Console.WriteLine("Qual seu peso?");
            peso = float.Parse(Console.ReadLine());
        }
        public float getPeso(){
            return peso;
        }

        public void setProfissao(){
            Console.WriteLine("Qual sua profissão?");
            profissao = Console.ReadLine();
        }
        public string getProfissao(){
            return profissao;
        }

        public void setAnoAtual(){
            Console.WriteLine("Em que ano estamos?");
            anoAtual = int.Parse(Console.ReadLine());
        }
        public int getAnoAtual(){
            return anoAtual;
        }

        public void exibeDados(){
            Console.WriteLine("Olá! " + nome + " você tem " + idade + " anos, é " + profissao + ", tem " + altura + " de altura e pesa " + peso + "kg");
        }

        public int descobreAnoNascimento(){
            return anoAtual-idade;
        }

        public void informaAnoNascimento(){
            Console.WriteLine("Agora vamos descobrir em que ano você nasceu...");
            Console.WriteLine("E pronto, você nasceu em: " + descobreAnoNascimento());
        }

        public void liberadoPraBeber(int idade){
            Console.WriteLine("Vamos ver com vai ser seu/sua finde/feriadão/folga:");
            if(idade >= 18){
            Console.WriteLine("Tá liberado, pode tomar umas! xD");
            } else{
            Console.WriteLine("Para beber, idade precisa você!");
            }
        }

        public void diasSemanasMesesVividos(int idade){
            int meses = idade*12;
            int semanas = idade*52;
            int dias = idade*365;
            Console.WriteLine("Uma curiosidade sobre você:");
            Console.WriteLine("Você já viveu " + meses + " meses, dentro de " + semanas + " semanas e incríveis " + dias + " dias!");
            Console.WriteLine("Legal né! =D");
        }

        public void IMC(float altura, float peso){
            Console.WriteLine("Agora vamos ver qual seu indice no IMC:");
            float IMC = peso / (altura*altura);
            switch (IMC){
                case <18.5f:
                Console.WriteLine("Sua condição física se enquadra na categoria: Magresa.");
                break;
                case <25f:
                Console.WriteLine("Sua condição física se enquadra na categoria: Normal.");
                break;
                case <30.1f:
                Console.WriteLine("Sua condição física se enquadra na categoria: Sobrepeso.");
                break;
                default:
                Console.WriteLine("Sua condição física se enquadra na categoria: Obesidade.");
                break;
            }
        }

        public void listaIdadeEmCadaAnoVivido(int anoNascimento, int anoAtual){
            int idadeContador = 0;
            for(int contador = anoNascimento; contador <= anoAtual; contador++ ){
                Console.WriteLine("No ano de " + contador + " Você tinha " + idadeContador + " anos.");
                idadeContador++;
            }
        }

        public void realizarExercicio(){
            Console.WriteLine("Olá! Tudo bem? espero que sim! ^-^");
            Console.WriteLine("Para começar, preciso de algumas informações:");
            Console.WriteLine("");
            setNome();
            setIdade();
            setAltura();
            setPeso();
            setProfissao();
            setAnoAtual();
            Console.WriteLine("");
            exibeDados();
            Console.WriteLine("");
            liberadoPraBeber(getIdade());
            Console.WriteLine("");
            diasSemanasMesesVividos(getIdade());
            Console.WriteLine("");
            IMC(getAltura(), getPeso());
            Console.WriteLine("");
            informaAnoNascimento();
            Console.WriteLine("");
            listaIdadeEmCadaAnoVivido(descobreAnoNascimento(), getAnoAtual());
            Console.WriteLine("");
            Console.WriteLine("Obrigado por utilizar nosso Programa!!");
            Console.WriteLine("");
        }
    }
}