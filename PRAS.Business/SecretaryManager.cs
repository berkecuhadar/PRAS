using PRAS.Core;
using PRAS.DataAccess;
using System.Data;

namespace PRAS.Business
{
    public class SecretaryManager
    {
        // Reference to the DataAccess layer repository
        private readonly SecretaryRepository _secretaryRepository = new();

        // Validates credentials and verifies a secretary login attempt
        public Secretary LoginSecretary(string email, string password)
        {
            // Business Rule: Ensure fields are not blank before processing a login
            return string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)
                ? throw new ArgumentException("Email and password fields cannot be empty!")
                : _secretaryRepository.GetSecretary(email, password);
        }

        // Fetches the entire list of secretaries to populate UI data grids
        public DataTable GetAllSecretaries()
        {
            return _secretaryRepository.GetAllSecretaries();
        }

        // Processes and validates secretary profile details before committing to the database
        public void SaveSecretary(string firstName, string lastName, string email, int phoneNumber, int id)
        {
            // Business Rule: Validate required structural data
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("Secretary name and surname fields cannot be left blank!");
            }

            // Business Rule: Simple email syntax check
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                throw new Exception("Please enter a valid e-mail address!");
            }

            // Business Rule: Ensure a realistic phone number string/integer value was supplied
            if (phoneNumber <= 0)
            {
                throw new Exception("Please provide a valid phone number!");
            }

            // If all validation checks pass successfully, pass the data clean down to the DataAccess layer
            _secretaryRepository.AddOrUpdateSecretary(firstName, lastName, email, phoneNumber, id);
        }

        // Handles the business flow and safety constraints for removing a secretary profile
        public void RemoveSecretary(int id)
        {
            // Business Rule: Prevent processing drops on impossible system IDs
            if (id <= 0)
            {
                throw new ArgumentException("Invalid secretary ID provided for deletion!");
            }

            _secretaryRepository.DeleteSecretary(id);
        }
    }
}