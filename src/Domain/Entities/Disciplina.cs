
namespace Domain.Entities
{
    public class Disciplina
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int Creditos { get; set; }
        public List<Disciplina>? PreRequisitos { get; set; }
    }
}
