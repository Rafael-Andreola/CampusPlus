namespace Domain.Entities
{
    public class PreRequisito
    {
        public required long id { get; set; }
        public long disciplina_cod { get; set; }
        public long prereq_cod { get; set; }
    }
}
