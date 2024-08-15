using NunesSports.Models;

namespace NunesSports.Repositorio
{
    public interface IProdutoRepositorio
    {

        Produto ListarPorId(int id);
        List<Produto> BuscarTodos();
        Produto Adicionar(Produto produto);

        Produto Atualizar(Produto produto);

        bool Apagar(int id);

    }
}
