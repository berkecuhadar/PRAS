using MySql.Data.MySqlClient;
using System.Data;

namespace PRAS.DataAccess
{
    public class AppointmentRepository
    {
        // Retrieves a list of specific appointments matching patient National ID and Doctor ID
        public DataTable GetAppointmentList(int patientNID, int doctorId)
        {
            DataTable dt = new();
            using (MySqlConnection connection = DB.getConnection())
            {
                string query = "SELECT id, dID, pNID, date, time, chief_complaint, diagnosis, lab_results " +
                               "FROM tb_appointment WHERE pNID=@patientNID AND dID=@doctorId ORDER BY id";

                MySqlCommand comm = new(query, connection);
                _ = comm.Parameters.AddWithValue("@patientNID", patientNID);
                _ = comm.Parameters.AddWithValue("@doctorId", doctorId);

                connection.Open();
                using MySqlDataAdapter da = new(comm);
                _ = da.Fill(dt);
            }
            return dt;
        }

        // Adds or updates the Chief Complaint of Patient
        public void UpdateChiefComplaint(string cc, int appointmentId)
        {
            using MySqlConnection connection = DB.getConnection();
            MySqlCommand comm = new("SELECT COUNT(*) FROM tb_appointment WHERE id=@id", connection);
            _ = comm.Parameters.AddWithValue("@id", appointmentId);

            connection.Open();
            long count = Convert.ToInt64(comm.ExecuteScalar());

            if (count > 0)
            {
                MySqlCommand updateComm = new("UPDATE tb_appointment SET chief_complaint=@cc WHERE id=@id", connection);
                _ = updateComm.Parameters.AddWithValue("@cc", cc);
                _ = updateComm.Parameters.AddWithValue("@id", appointmentId);
                _ = updateComm.ExecuteNonQuery();
            }
        }

        // Adds or updates the doctor's diagnosis
        public void UpdateDoctorDiagnosis(string diagnosis, int appointmentId)
        {
            using MySqlConnection connection = DB.getConnection();
            MySqlCommand comm = new("SELECT COUNT(*) FROM tb_appointment WHERE id=@id", connection);
            _ = comm.Parameters.AddWithValue("@id", appointmentId);

            connection.Open();
            long count = Convert.ToInt64(comm.ExecuteScalar());

            if (count > 0)
            {
                MySqlCommand updateComm = new("UPDATE tb_appointment SET diagnosis=@diagnosis WHERE id=@id", connection);
                _ = updateComm.Parameters.AddWithValue("@diagnosis", diagnosis);
                _ = updateComm.Parameters.AddWithValue("@id", appointmentId);
                _ = updateComm.ExecuteNonQuery();
            }
        }

        // Adds or updates the patient analysis/lab results
        public void UpdateLabResults(string lab_results, int appointmentId)
        {
            using MySqlConnection connection = DB.getConnection();
            MySqlCommand comm = new("SELECT COUNT(*) FROM tb_appointment WHERE id=@id", connection);
            _ = comm.Parameters.AddWithValue("@id", appointmentId);

            connection.Open();
            long count = Convert.ToInt64(comm.ExecuteScalar());

            if (count > 0)
            {
                MySqlCommand updateComm = new("UPDATE tb_appointment SET lab_results=@lab_results WHERE id=@id", connection);
                _ = updateComm.Parameters.AddWithValue("@lab_results", lab_results);
                _ = updateComm.Parameters.AddWithValue("@id", appointmentId);
                _ = updateComm.ExecuteNonQuery();
            }
        }
    }
}