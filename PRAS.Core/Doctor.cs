namespace PRAS.Core
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Field { get; set; }

        public Doctor() { }

        public Doctor(int id_, string name_, string surname_, string email_, string password_, string phoneNumber_, string field_)
        {
            Id = id_;
            Name = name_;
            Surname = surname_;
            Email = email_;
            Password = password_;
            PhoneNumber = phoneNumber_;
            Field = field_;
        }

    }
}
