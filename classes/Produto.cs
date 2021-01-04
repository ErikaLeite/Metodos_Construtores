namespace Metodos_Construtores.classes
{
    public class Produto
    {
        //Acessores de Atributos
        //(criam atributos "fantasmas", esse modo diminui a quantidade de linhas de código e facilita na identificação de cada acesso concedido)

        public int Codigo {get;set;}
        public int Estoque {get;set;}
        public string Nome {get;set;}
        public string Descricao {get;set;}

        //Métodos Construtores
        //Devem ter o mesmo nome da classe onde se encontram e são executados automaticamente no Program ao serem instanciados, têm semelhanças com sobrecargas

        public Produto()
        {

        }

        public Produto(int cod)//Para acessá-lo de forma correta é preciso atribuir um valor inteiro ao ser instanciado
        {
            Codigo = cod;
        }

        public Produto(int cod, string name, string definicao, int estocagem)//inseridos abreviações e sinonimos diferentes às variaveis, para evitar confusão com os acessores (no ex tá estranho)
        {
            Codigo = cod;
            Estoque = estocagem;
            Nome = name;
            Descricao = definicao;
        }
    }
}