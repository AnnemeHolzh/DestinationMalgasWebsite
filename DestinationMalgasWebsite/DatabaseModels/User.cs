namespace DestinationMalgasWebsite.DatabaseModels
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string AccountType { get; set; }
    }
}
