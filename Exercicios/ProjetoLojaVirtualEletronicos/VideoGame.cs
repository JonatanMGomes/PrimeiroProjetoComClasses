namespace PrimeiroProjetoComClasses.Exercicios.ProjetoLojaVirtualEletronicos{
    public class VideoGame : Produto{
        //public Jogo[] Jogos;
        public VideoGame(int qtdDisponivel) : base(1500, qtdDisponivel){
            //Jogos = new Jogo[20];
        }
        /*public void NovoJogo(Jogo novoJogo){
            if(VerificaEspacoParaJogo() == true){
                for (int contador = 0; contador < Jogos.Length; contador++){
                    if(Jogos[contador] == null){
                        Jogos[contador] = novoJogo;
                    }
                }
            }else{
                Console.WriteLine("Sem espaço para o novo jogo!");
            }
        }
        public bool VerificaEspacoParaJogo(){
            bool temEspaco;
            if (Jogos[Jogos.Length - 1] != null){
                temEspaco = false;
            }else{
                temEspaco = true;
            }
            return temEspaco;
        }*/
    }
}