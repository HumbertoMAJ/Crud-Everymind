using NunesSports.Data;
using NunesSports.Models;

namespace NunesSports.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ProdutoDbContext _ProdutoDbContext;
        public ProdutoRepositorio(ProdutoDbContext produtoDbContext)
        {
            _ProdutoDbContext = produtoDbContext;
        }

        public Produto ListarPorId(int id)
        {
            return _ProdutoDbContext.Produtos.FirstOrDefault(x => x.Id == id);
        }

        public List<Produto> BuscarTodos()
        {
            return _ProdutoDbContext.Produtos.ToList();
        }

        public Produto Adicionar(Produto produto)
        {
            _ProdutoDbContext.Produtos.Add(produto);

            _ProdutoDbContext.SaveChanges();

            return produto;
        }

        public Produto Atualizar(Produto produto)
        {
            Produto produtoDb = ListarPorId(produto.Id);

            if (produtoDb == null) throw new System.Exception("Houve um erro ao na atualização do produto");

            produtoDb.Nome = produto.Nome;
            produtoDb.Descricao = produto.Descricao;
            produtoDb.Codigo = produto.Codigo;
            produtoDb.Preco = produto.Preco;

            _ProdutoDbContext.Produtos.Update(produtoDb);
            _ProdutoDbContext.SaveChanges();

            return produtoDb;


        }

        public bool Apagar(int id)
        {
            Produto produtoDb = ListarPorId(id);

            if (produtoDb == null) throw new System.Exception("Houve um erro na deleção do produto");

            _ProdutoDbContext.Produtos.Remove(produtoDb);
            _ProdutoDbContext.SaveChanges();

            return true;
        }
    }
}
