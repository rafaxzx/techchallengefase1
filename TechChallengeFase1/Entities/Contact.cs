namespace TechChallengeFase1.Entities
{
    public class Contact : BaseEntity
    {
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public int DDDId { get; set; }

        public DDD Ddd { get; set; }
    }

}
