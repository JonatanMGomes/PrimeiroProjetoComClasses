namespace PrimeiroProjetoComClasses.Exercicios.ProjetoLojaVirtualEletronicos{
    public class CarrinhoCompras{
        public Usuario Usuario {get; set;}
        public Produto[] ProdutosEscolhidos {get; set;}
        public double ValorTotal {get; set;}
        public int EstoqueCelular {get; set;}
        public int EstoqueComputador {get; set;}
        public int EstoqueVideoGame {get; set;}
        public int QtdDeJogos {get; set;}
        public CarrinhoCompras(Usuario usuario){
            Usuario = usuario;
            ProdutosEscolhidos = new Produto[5];
            EstoqueCelular = 5;
            EstoqueComputador = 5;
            EstoqueVideoGame = 5;
            QtdDeJogos = 0;
        }
        public bool VerificaEspacoCarrinho(){
            bool temEspaco;
            if (ProdutosEscolhidos[ProdutosEscolhidos.Length - 1] != null){
                temEspaco = false;
            }else{
                temEspaco = true;
            }
            return temEspaco;
        }
        public void AdicionarNovoProduto(int escolha){
            if(VerificaEspacoCarrinho() == true){
                switch(escolha){
                    case 1:
                        if(EstoqueCelular > 0){
                            for (int contador = 0; contador < ProdutosEscolhidos.Length; contador++){
                                if(ProdutosEscolhidos[contador] == null){
                                    ProdutosEscolhidos[contador] = new Celular(EstoqueCelular);
                                    break;
                                }
                            }
                            EstoqueCelular--;
                        }else{
                            Console.WriteLine("Produto esgotado, por favor escolha outro produto ou aguarde repormos nosso estoque.");
                        }
                    break;
                    case 2:
                        if(EstoqueComputador > 0){
                            for (int contador = 0; contador < ProdutosEscolhidos.Length; contador++){
                                if(ProdutosEscolhidos[contador] == null){
                                    ProdutosEscolhidos[contador] = new Computador(EstoqueComputador);
                                    break;
                                }
                            }
                            EstoqueComputador--;
                        }else{
                            Console.WriteLine("Produto esgotado, por favor escolha outro produto ou aguarde repormos nosso estoque.");
                        }
                    break;
                    case 3:
                    if(EstoqueVideoGame > 0){
                        for (int contador = 0; contador < ProdutosEscolhidos.Length; contador++){
                            if(ProdutosEscolhidos[contador] == null){
                                ProdutosEscolhidos[contador] = new VideoGame(EstoqueVideoGame);
                                break;
                            }
                        }
                        EstoqueVideoGame--;
                        Console.WriteLine("Gostaria de aproveitar e comprar alguns jogos? 1-Sim 2-Não");
                        int escolhaComprarJogos = int.Parse(Console.ReadLine());
                            if(escolhaComprarJogos == 1){
                                ComprarJogosJunto(true);
                            }else if(escolhaComprarJogos == 2){
                                ComprarJogosJunto(false);
                            }else{
                                Console.WriteLine("Opção inválida!");
                            }
                    }else{
                        Console.WriteLine("Produto esgotado, por favor escolha outro produto ou aguarde repormos nosso estoque.");
                    }
                    break;
                    default:
                    Console.WriteLine("Opção inválida!");
                    break;
                }
            }else{
                Console.WriteLine("Carrinho lotado! Finalize esta compra para poder liberar espaço no carrinho.");
            }
        }
        public void FecharCompra(){
            double valorDoCarrinho = 0;
            for (int contador = 0; contador < ProdutosEscolhidos.Length; contador++){
                if(ProdutosEscolhidos[contador] != null){
                    valorDoCarrinho = valorDoCarrinho+ProdutosEscolhidos[contador].Valor;
                }
            }
            ValorTotal = valorDoCarrinho+(QtdDeJogos*30);
        }
        public bool ContinuarCompras(){
            int escolha;
            Console.WriteLine("Deseja continaur comprando? 1-Sim 2-Não");
            escolha = int.Parse(Console.ReadLine());
            if(escolha == 1){
                return true;
            }else if(escolha == 2){
                return false;
            }else{
                Console.WriteLine("Escolha invalida!");
                return false;
            }
        }
        public void ComprarJogosJunto(bool escolha){
            if(true){
                Console.WriteLine("Quantos jogos gostaria de levar?");
                int quantosJogos = int.Parse(Console.ReadLine());
                Console.WriteLine($"Certo, {quantosJogos} jogos foram adicionados ao seu pedido.");
                QtdDeJogos = quantosJogos;
            }else{
                Console.WriteLine("Ok, vamos prosseguir com o pedido.");
            }
        }
        public void IniciarCompras(){
            bool continuarComprando;
            Console.WriteLine($"Olá {Usuario.Nome}, Seja bem vindo a nossa loja!!");
             do{
                 AdicionarNovoProduto(Usuario.EscolherProduto());
                 continuarComprando = ContinuarCompras();
             }while(continuarComprando == true);
             FecharCompra();
             Console.WriteLine($"O valor total das suas compras {Usuario.Nome}, é de: {ValorTotal}");
        }
    }
}