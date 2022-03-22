namespace PrimeiroProjetoComClasses.Exercicios.ProjetoLojaVirtualEletronicos{
    public class Produto{
        public double Valor {get;set;}
        public int QtdDisponivel {get; set;}
        public string Marca {get; set;}
        public Produto(double valor, int qtdDisponivel){
            Valor = valor;
            QtdDisponivel = qtdDisponivel;
        }
        /*public int ProdutoDisponivel(){
            if(QtdDisponivel > 0){
                return QtdDisponivel;
            }else{
                return 0;
            }
        }
        public void AtualizaEstoqueProdutoPosCompra(){
            QtdDisponivel = QtdDisponivel-1;
        }*/
    }
}