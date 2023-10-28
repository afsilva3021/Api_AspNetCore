using System.ComponentModel;

namespace CrmZapex.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        Afaze = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Tarefa Finalizada")]
        Concluido = 3
    }
}
