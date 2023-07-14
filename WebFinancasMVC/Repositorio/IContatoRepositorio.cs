using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Cadastrar(ContatoModel contato);

        List<ContatoModel> BuscarTodos();
    }
}
