namespace TechChallengeFase1.Entities
{
    public class DDD : BaseEntity
    {
        public required int Number { get; set; }
        public required string Regiao { get; set; }
        public ICollection<Contact> Contacts { get; set; }

    }
}