using CrmZapex.Models;

namespace CrmZapex.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel>Adicionar(UsuarioModel model);
        Task<UsuarioModel>Atualizar(UsuarioModel model, int id);
        Task<bool> Apagar(int id);
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
    }
}
