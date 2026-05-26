namespace PRAS.Core
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        public string National_ID { get; set; }
        public string PhoneNumber { get; set; }
        public Patient() { }
        public Patient(int id_, string name_, string surname_, string nID_, string phoneNumber_)
        {
            Id = id_;
            Name = name_;
            Surname = surname_;
            National_ID = nID_;
            PhoneNumber = phoneNumber_;
        }
    }
}
