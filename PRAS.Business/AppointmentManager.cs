using PRAS.DataAccess;
using System.Data;

namespace PRAS.Business
{
    public class AppointmentManager
    {
        // Reference to the DataAccess layer repository
        private readonly AppointmentRepository _appointmentRepository = new();

        // Fetches a filtered list of appointments for a specific doctor and patient combination
        public DataTable GetAppointmentList(int pNID, int doctorId)
        {
            // Business Rule: Validate essential query parameters
            return pNID.ToString().Length != 11
                ? throw new ArgumentException("A valid 11-digit patient National ID is required to view records!")
                : doctorId <= 0
                ? throw new ArgumentException("Invalid doctor identifier reference specified for loading appointment streams!")
                : _appointmentRepository.GetAppointmentList(pNID, doctorId);
        }

        // Validates and saves the shared CC
        public void SaveChiefComplaint(string notes, int appointmentId)
        {
            // Business Rule: Block processing if tracking identity reference is corrupted
            if (appointmentId <= 0)
            {
                throw new ArgumentException("Invalid appointment tracking index specified!");
            }

            // Business Rule: Ensure notes aren't completely blank before hit to database
            if (string.IsNullOrWhiteSpace(notes))
            {
                throw new Exception("ChiefComplaint notes cannot be empty!");
            }

            _appointmentRepository.UpdateChiefComplaint(notes, appointmentId);
        }

        // Validates and saves the doctor's diagnosis
        public void SaveDiagnosis(string notes, int appointmentId)
        {
            if (appointmentId <= 0)
            {
                throw new ArgumentException("Invalid appointment tracking index specified!");
            }

            if (string.IsNullOrWhiteSpace(notes))
            {
                throw new Exception("Private clinical observation notes cannot be empty!");
            }

            _appointmentRepository.UpdateDoctorDiagnosis(notes, appointmentId);
        }

        // Validates and updates laboratory /analysis data results
        public void SaveLabResults(string results, int appointmentId)
        {
            if (appointmentId <= 0)
            {
                throw new ArgumentException("Invalid appointment tracking index specified!");
            }

            if (string.IsNullOrWhiteSpace(results))
            {
                throw new Exception("Laboratory and diagnostics test analysis field cannot be left blank!");
            }

            _appointmentRepository.UpdateLabResults(results, appointmentId);
        }
    }
}