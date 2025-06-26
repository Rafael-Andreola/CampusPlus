
namespace Domain.Entities
{
    public class Disciplina
    {
        public required string codigo { get; set; }
        public string nome { get; set; }
        public long creditos { get; set; }
        public List<Disciplina>? PreRequisitos { get; set; }
    }
}
