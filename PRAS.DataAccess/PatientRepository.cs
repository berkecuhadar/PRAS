using MySql.Data.MySqlClient;
using System.Data;

namespace PRAS.DataAccess
{
    public class PatientRepository
    {
        // Retrieves all patients from the database to populate UI components
        public DataTable GetAllPatients()
        {
            DataTable dt = new();
            using (MySqlConnection connection = DB.getConnection())
            {
                MySqlCommand comm = new("SELECT id, name, surname, nID, phoneNumber FROM tb_patient", connection);
                connection.Open();
                using MySqlDataAdapter da = new(comm);
                _ = da.Fill(dt);
            }
            return dt;
        }

        // Fetches a single patient record filtered by their unique national identification number (National ID)
        public DataTable GetPatientByTc(string nID)
        {
            DataTable dt = new();
            using (MySqlConnection connection = DB.getConnection())
            {
                MySqlCommand comm = new("SELECT id, name, surname, nID, phoneNumber FROM tb_patient WHERE nID=@nID", connection);
                _ = comm.Parameters.AddWithValue("@nID", nID);

                connection.Open();
                using MySqlDataAdapter da = new(comm);
                _ = da.Fill(dt);
            }
            return dt;
        }

        // Handles both registering a new patient or updating existing patient profile data
        public void AddOrUpdatePatient(string firstName, string lastName, int phoneNumber, string nID, int id)
        {
            using MySqlConnection connection = DB.getConnection();
            MySqlCommand comm = new("SELECT COUNT(*) FROM tb_patient WHERE id=@id", connection);
            _ = comm.Parameters.AddWithValue("@id", id);

            connection.Open();
            long count = Convert.ToInt64(comm.ExecuteScalar());

            if (count > 0)
            {
                // Record exists, execute an update script
                MySqlCommand updateComm = new("UPDATE tb_patient SET name=@name, surname=@surname, nID=@nID, phoneNumber=@phoneNumber WHERE id=@id", connection);
                _ = updateComm.Parameters.AddWithValue("@name", firstName);
                _ = updateComm.Parameters.AddWithValue("@surname", lastName);
                _ = updateComm.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                _ = updateComm.Parameters.AddWithValue("@nID", nID);
                _ = updateComm.Parameters.AddWithValue("@id", id);
                _ = updateComm.ExecuteNonQuery();
            }
            else
            {
                // New record, execute insert statement (ID is handled automatically by database)
                MySqlCommand insertComm = new("INSERT INTO tb_patient (name, surname, nID, phoneNumber) VALUES (@name, @surname, @nID, @phoneNumber)", connection);
                _ = insertComm.Parameters.AddWithValue("@name", firstName);
                _ = insertComm.Parameters.AddWithValue("@surname", lastName);
                _ = insertComm.Parameters.AddWithValue("@nID", nID);
                _ = insertComm.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                _ = insertComm.ExecuteNonQuery();
            }
        }

        // Deletes a patient profile and purges their booked appointments to maintain data relational integrity
        public void DeletePatient(int id, int pNID)
        {
            using MySqlConnection connection = DB.getConnection();
            connection.Open();

            // First delete the scheduled appointments to bypass foreign key constraint errors
            MySqlCommand appointmentComm = new("DELETE FROM tb_appointment WHERE patient_id=@pNID", connection);
            _ = appointmentComm.Parameters.AddWithValue("@pNID", pNID);
            _ = appointmentComm.ExecuteNonQuery();

            // Now safely drop the patient account row
            MySqlCommand patientComm = new("DELETE FROM tb_patient WHERE id=@id", connection);
            _ = patientComm.Parameters.AddWithValue("@id", id);
            _ = patientComm.ExecuteNonQuery();
        }

        // Creates and logs a new appointment slot into the system mapping table
        public void BookAppointment(int patientTc, int doctorId, string date, string time)
        {
            using MySqlConnection connection = DB.getConnection();
            MySqlCommand comm = new("INSERT INTO tb_appointment (dID, patient_id, date, time) VALUES (@dID, @pNID, @date, @time)", connection);
            _ = comm.Parameters.AddWithValue("@dID", doctorId);
            _ = comm.Parameters.AddWithValue("@pNID", patientTc);
            _ = comm.Parameters.AddWithValue("@date", date);
            _ = comm.Parameters.AddWithValue("@time", time);

            connection.Open();
            _ = comm.ExecuteNonQuery();
        }

        // Returns all upcoming or archived scheduled appointments tied to a single patient identification card
        public DataTable GetAppointmentsByPatient(string pNID)
        {
            DataTable dt = new();
            using (MySqlConnection connection = DB.getConnection())
            {
                MySqlCommand comm = new("SELECT id, dID, patient_id, date, time FROM tb_appointment WHERE patient_id=@pNID", connection);
                _ = comm.Parameters.AddWithValue("@pNID", pNID);

                connection.Open();
                using MySqlDataAdapter da = new(comm);
                _ = da.Fill(dt);
            }
            return dt;
        }
    }
}