namespace PrimeiroProjetoComClasses.Exercicios.ProjetoQuaseTrêsLanches
{
    public class PedidoQuaseTresLanches
    {
        public string NomeDoCliente {get; set;}
        public Prato PratoEscolhido {get; set;}
        public PedidoQuaseTresLanches(){

        }
        public PedidoQuaseTresLanches(string nomeDoCliente, Prato pratoEscolhido){
            NomeDoCliente = nomeDoCliente;
            PratoEscolhido = pratoEscolhido;
        }
        public Prato EscolherPrato(){
            Prato pratoMenu = new Prato("Frango");
            Console.WriteLine("Qual prato você escolhe? 1-Pizza 2-Lanche 3-Salgadinho");
            int escolhaMenu = int.Parse(Console.ReadLine());
            string recheio;
            int escolhaAdcional;
            switch (escolhaMenu){
                case 1:
                Console.WriteLine("Você escolheu: Pizza. Qual o sabor da sua pizza?");
                recheio = Console.ReadLine();
                Console.WriteLine($"Você escolheu o sabor: {recheio}. Gostaria de adicionar borda recheada? 1-Sim 2-Não");
                escolhaAdcional = int.Parse(Console.ReadLine());
                if(escolhaAdcional == 1){
                    pratoMenu = new Pizza(recheio, true);
                    pratoMenu.CalcularPreco();
                }else if(escolhaAdcional == 2){
                    pratoMenu = new Pizza(recheio, false);
                    pratoMenu.CalcularPreco();
                }else{
                    Console.WriteLine("Opção inválida!");
                }
                break;
                case 2:
                Console.WriteLine("Você escolheu: Lanche. Qual o sabor do seu lanche?");
                recheio = Console.ReadLine();
                Console.WriteLine($"Você escolheu o sabor: {recheio}. Gostaria de levar um lanche duplo? 1-Sim 2-Não");
                escolhaAdcional = int.Parse(Console.ReadLine());
                if(escolhaAdcional == 1){
                    pratoMenu = new Lanche(recheio, true);
                }else if(escolhaAdcional == 2){
                    pratoMenu = new Lanche(recheio, false);
                }else{
                    Console.WriteLine("Opção inválida!");
                }
                break;
                case 3:
                Console.WriteLine("Você escolheu: Salgadinho. Qual o sabor do seu salgadinho?");
                recheio = Console.ReadLine();
                Console.WriteLine($"Você escolheu o sabor: {recheio}. De que tipo ele vai ser? 1-Assado 2-Frito");
                escolhaAdcional = int.Parse(Console.ReadLine());
                if(escolhaAdcional == 1){
                    pratoMenu = new Salgadinho(recheio, "Assado");
                }else if(escolhaAdcional == 2){
                    pratoMenu = new Salgadinho(recheio, "Frito");
                }else{
                    Console.WriteLine("Opção inválida!");
                }
                break;
                
                default:
                Console.WriteLine("Opção de prato inválida!");
                break;
            }
            pratoMenu.CalcularPreco();
            return pratoMenu;
        }
        public string PerguntaNomeDoCliente(){
            Console.WriteLine("Qual seu nome?");
            string nomeInformado = Console.ReadLine();
            return nomeInformado;
        }
        public void realizarPagamento(double valorAPagar){
            Console.WriteLine($"Valor total a pagar: {valorAPagar}. Qual a forma de pagamento?");
            Console.WriteLine("1-Cartão Crédito 2-Cartão Débito 3-Pix 4-Dinheiro");
            int formaPagamento = int.Parse(Console.ReadLine());
            switch (formaPagamento){
                case 1:
                Console.WriteLine("Pagamento realizado com sucesso!");
                break;
                case 2:
                Console.WriteLine("Pagamento realizado com sucesso!");
                break;
                case 3:
                Console.WriteLine("Pagamento realizado com sucesso!");
                break;
                case 4:
                Console.WriteLine("Você escolheu pagar no dinheiro, precisa de troco? 1-Sim 2-Não");
                int precisaTroco = int.Parse(Console.ReadLine());
                if(precisaTroco == 1){
                    Console.WriteLine("Troco para quanto?");
                    double valorClienteTem = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O troco para {valorClienteTem} será de: {valorClienteTem-valorAPagar}");
                }else if(precisaTroco == 2){
                    Console.WriteLine("Ok, só passar o valor para nosso entregador.");
                }else{
                    Console.WriteLine("Opção sobre troco inválida!");
                }
                break;
                default:
                Console.WriteLine("Opção de pagamento inválida!");
                break;
            }
        }
        public bool QuerFazerNovoPedido(){
            int novoPedido;
            Console.WriteLine("Gostaria de fazer um novo pedido? 1-Sim 2-Não");
            novoPedido = int.Parse(Console.ReadLine());
            if(novoPedido == 1){
                return true;
            }else if(novoPedido == 2){
                Console.WriteLine("Obrigado por escolher nossa comida!!");
                return false;
            }else{
                Console.WriteLine("Opção inválida");
                Console.WriteLine("Obrigado por escolher nossa comida!!");
                return false;
            }
        }
        public void RealizarPedido(){
            do{
                Console.WriteLine("Seja bem vindo ao app de delivery da QuaseTrêsLanches!!");
                PedidoQuaseTresLanches pedidoQuase = new PedidoQuaseTresLanches(PerguntaNomeDoCliente(), EscolherPrato());
                pedidoQuase.realizarPagamento(pedidoQuase.PratoEscolhido.Preco);
            }while(QuerFazerNovoPedido() == true);
        }
    }
}