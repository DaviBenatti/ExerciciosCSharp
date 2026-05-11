using BibliotecaAPI.Domains;

namespace BibliotecaAPI.Interfaces
{
    public interface ILivroRepository
    {
        List<Livro> Listar();
        Livro? BuscarPorId(int id);

        Livro Adicionar(Livro livro);

        bool Atualizar(int id, Livro livro);

        bool remover(int id);
    }
}
