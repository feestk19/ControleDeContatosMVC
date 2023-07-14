using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Cadastrar(ContatoModel contato);

        ContatoModel Alterar(ContatoModel contato);

        bool Apagar(int id);

        ContatoModel ListarPorId(int id);

        List<ContatoModel> BuscarTodos();


    }
}
