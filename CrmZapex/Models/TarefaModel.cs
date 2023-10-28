using CrmZapex.Enums;

namespace CrmZapex.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public StatusTarefa Status { get; set; }

    }
}
