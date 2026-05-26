using PRAS.DataAccess;
using System.Data;

namespace PRAS.Business
{
    public class PatientManager
    {
        // Reference to the DataAccess layer repository
        private readonly PatientRepository _patientRepository = new();

        // Fetches the entire list of patients to populate UI data grids
        public DataTable GetAllPatients()
        {
            return _patientRepository.GetAllPatients();
        }

        // Retrieves a single patient's profile details based on their unique National ID
        public DataTable GetPatientByTc(string pNID)
        {
            // Business Rule: Ensure National ID is valid before processing
            return pNID.Length <= 0 || pNID.ToString().Length != 11
                ? throw new ArgumentException("Please enter a valid 11-digit National ID!")
                : _patientRepository.GetPatientByTc(pNID);
        }

        // Validates and processes a patient profile before adding or updating it in the system
        public void SavePatient(string firstName, string lastName, int phoneNumber, string pNID, int id)
        {
            // Business Rule: Check for empty essential identity properties
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("Patient name and surname fields cannot be left blank!");
            }

            if (pNID.Length is <= 0 or not 11)
            {
                throw new Exception("National ID must be exactly 11 digits long!");
            }

            if (phoneNumber <= 0)
            {
                throw new Exception("Please provide a valid phone number!");
            }

            // Forward clean data parameters down to the DataAccess layer repository
            _patientRepository.AddOrUpdatePatient(firstName, lastName, phoneNumber, pNID, id);
        }

        // Coordinates the safe removal sequence of a patient profile and associated data logs
        public void RemovePatient(int id, int pNID)
        {
            if (id <= 0 || pNID <= 0)
            {
                throw new ArgumentException("Invalid processing identifiers supplied for deleting the patient profile!");
            }

            _patientRepository.DeletePatient(id, pNID);
        }

        // Processes an appointment registration slip after passing strict scheduling system constraints
        public void BookAppointment(int pNID, int doctorId, string date, string time)
        {
            // Business Rule: Basic scheduling format validations
            if (pNID.ToString().Length != 11)
            {
                throw new Exception("Cannot book an appointment without a valid 11-digit National ID!");
            }

            if (doctorId <= 0)
            {
                throw new Exception("A valid target medical doctor must be assigned to the slot allocation!");
            }

            if (string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(time))
            {
                throw new Exception("Appointment schedule date and target hour slot allocations cannot be left blank!");
            }

            // Commit the booking transaction downward
            _patientRepository.BookAppointment(pNID, doctorId, date, time);
        }

        // Fetches all historically generated appointment slips matching a unique patient card index
        public DataTable GetAppointmentsByPatient(string pNID)
        {
            return pNID.Length != 11
                ? throw new ArgumentException("Invalid target identity card index used to scan appointment lists!")
                : _patientRepository.GetAppointmentsByPatient(pNID);
        }
    }
}