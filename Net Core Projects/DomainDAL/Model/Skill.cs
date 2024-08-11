namespace DomainDAL.Model
{
    public class Skill
    {
        public Guid Id { get; set; } = new Guid();

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
