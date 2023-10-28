using CrmZapex.Models;

namespace CrmZapex.Repositorios.Interfaces
{
    public interface ITarefasRepositorio
    {
        Task<TarefaModel>BuscarPorId(int id);
        Task<TarefaModel>Adicionar(TarefaModel model);
        Task<TarefaModel>Atualizar(TarefaModel model, int id);
        Task<bool> Apagar(int id);
        Task<List<TarefaModel>>BuscarTodasTarefas();
    }
}
