using CrmZapex.Data;
using CrmZapex.Models;
using CrmZapex.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrmZapex.Repositorios
{
    public class TarefaRepositorio : ITarefasRepositorio
    {
        private readonly SistemaTarefasDBContext _dbContext;

        public TarefaRepositorio(SistemaTarefasDBContext sistemasTarefasDBContex)
        {
            _dbContext = sistemasTarefasDBContex;
        }

        public TarefaRepositorio()
        {

        }

        public async Task<TarefaModel> BuscarPorId(int id)
        {
            return await _dbContext.Tarefas.FirstOrDefaultAsync(y => y.Id == id);
        }

        public async Task<TarefaModel>Adicionar(TarefaModel model)
        {
            await _dbContext.Tarefas.AddAsync;
        }

        Task<TarefaModel> ITarefasRepositorio.Atualizar(TarefaModel model, int id)
        {
            throw new NotImplementedException();
        }

      

        Task<List<TarefaModel>> ITarefasRepositorio.BuscarTodasTarefas()
        {
            throw new NotImplementedException();
        }
        Task<bool> ITarefasRepositorio.Apagar(int id)
        {
            throw new NotImplementedException();
        }

    }
}
