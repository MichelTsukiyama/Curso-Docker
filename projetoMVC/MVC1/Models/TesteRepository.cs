namespace MVC1.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[]
        {
            new Produto { ProdutoId=10, Nome="Caneta", Categoria="Material", Preco=2.00M },
            new Produto { ProdutoId=20, Nome="Borracha", Categoria="Material", Preco=1.50M },
            new Produto { ProdutoId=30, Nome="Estojo", Categoria="Material", Preco=3.00M }
        };

        public IEnumerable<Produto> Produtos {get => produtos; }
    }
}