using PRAS.Core;
using PRAS.DataAccess;
using System.Data;

namespace PRAS.Business
{
    public class DoctorManager
    {
        // Reference to the DataAccess layer repository
        private readonly DoctorRepository _doctorRepository = new();

        // Validates input fields and authenticates a doctor profile login attempt
        public Doctor LoginDoctor(string email, string password)
        {
            // Business Rule: Validate credentials are not blank before querying database
            return string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)
                ? throw new ArgumentException("Email and password fields cannot be empty!")
                : _doctorRepository.GetDoctor(email, password);
        }

        // Fetches the entire grid of doctors from the database for UI view components
        public DataTable GetAllDoctors()
        {
            return _doctorRepository.GetAllDoctors();
        }

        // Applies strict business criteria on profile parameters before writing to persistence storage
        public void SaveDoctor(string firstName, string lastName, string email, int phoneNumber, string field, int id)
        {
            // Business Rule: Prevent empty identities from passing downstream
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("Doctor name and surname fields cannot be left blank!");
            }

            // Business Rule: Enforce primitive validation checks on the e-mail address syntax
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                throw new Exception("Please enter a valid e-mail address!");
            }

            // Business Rule: Ensure a field is properly assigned
            if (string.IsNullOrWhiteSpace(field))
            {
                throw new Exception("A clinical field specialty must be selected for the doctor!");
            }

            if (phoneNumber <= 0)
            {
                throw new Exception("Please provide a valid phone number!");
            }

            // Route safe values down to the DataAccess layer
            _doctorRepository.AddOrUpdateDoctor(firstName, lastName, email, phoneNumber, field, id);
        }

        // Controls safety parameters before executing a profile drop sequence
        public void RemoveDoctor(int id)
        {
            // Business Rule: Block impossible record identifier dropped triggers
            if (id <= 0)
            {
                throw new ArgumentException("Invalid doctor identifier reference specified for profile deletion!");
            }

            _doctorRepository.DeleteDoctor(id);
        }

        // Resolves a random doctor identifier reference assigned to a target medical clinic specialty
        public string? GetRandomDoctorByField(string field)
        {
            // Business Rule: Block lookups against clean or missing specialty values
            return string.IsNullOrWhiteSpace(field)
                ? throw new ArgumentException("Field name must be provided to balance triage requests!")
                : _doctorRepository.FindRandomDoctorByField(field);
        }
    }
}