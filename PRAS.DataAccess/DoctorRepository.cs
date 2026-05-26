using MySql.Data.MySqlClient;
using PRAS.Core;
using System.Data;

namespace PRAS.DataAccess
{
    public class DoctorRepository
    {
        // Fetches a specific doctor record for login verification
        public Doctor GetDoctor(string email, string password)
        {
            Doctor? doctor = null;
            using (MySqlConnection connection = DB.getConnection())
            {
                MySqlCommand comm = new("SELECT * FROM tb_doctor WHERE email=@email AND password=@password", connection);
                _ = comm.Parameters.AddWithValue("@email", email);
                _ = comm.Parameters.AddWithValue("@password", password);

                connection.Open();
                using MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    doctor = new Doctor
                    {
                        Id = reader.GetInt32(0),
                        Email = reader.GetString("email"),
                        Password = reader.GetString("password"),

                    };
                }
            }
            return doctor;
        }

        // Retrieves all doctors from the database to populate UI data grids
        public DataTable GetAllDoctors()
        {
            DataTable dt = new();
            using (MySqlConnection connection = DB.getConnection())
            {
                MySqlCommand comm = new("SELECT id, name, surname, email, phoneNumber, field FROM tb_doctor", connection);
                connection.Open();
                using MySqlDataAdapter da = new(comm);
                _ = da.Fill(dt);
            }
            return dt;
        }

        // Inserts a new doctor or updates an existing one based on the existence of the ID
        public void AddOrUpdateDoctor(string firstName, string lastName, string email, int phoneNumber, string field, int id)
        {
            using MySqlConnection connection = DB.getConnection();
            MySqlCommand comm = new("SELECT * FROM tb_doctor WHERE id=@id", connection);
            _ = comm.Parameters.AddWithValue("@id", id);

            connection.Open();
            using MySqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                reader.Close(); // Close the reader before executing a new command on the same connection

                comm = new MySqlCommand("UPDATE tb_doctor SET name=@name, surname=@surname, email=@email, phoneNumber=@phoneNumber, field=@field WHERE id=@id", connection);
                _ = comm.Parameters.AddWithValue("@name", firstName);
                _ = comm.Parameters.AddWithValue("@surname", lastName);
                _ = comm.Parameters.AddWithValue("@email", email);
                _ = comm.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                _ = comm.Parameters.AddWithValue("@field", field);
                _ = comm.Parameters.AddWithValue("@id", id);
                _ = comm.ExecuteNonQuery();
            }
            else
            {
                reader.Close(); // Close the reader before executing the insert command

                comm = new MySqlCommand("INSERT INTO tb_doctor (name, surname, email, password, phoneNumber, field) VALUES (@name, @surname, @email, @password, @phoneNumber, @field)", connection);
                _ = comm.Parameters.AddWithValue("@name", firstName);
                _ = comm.Parameters.AddWithValue("@surname", lastName);
                _ = comm.Parameters.AddWithValue("@email", email);
                _ = comm.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                _ = comm.Parameters.AddWithValue("@field", field);
                _ = comm.Parameters.AddWithValue("@password", "PRAS" + firstName + lastName); // Auto-generated default password
                _ = comm.ExecuteNonQuery();
            }
        }

        // Deletes a doctor record and clears their scheduled appointments to prevent constraints errors
        public void DeleteDoctor(int id)
        {
            using MySqlConnection connection = DB.getConnection();
            connection.Open();

            // Remove existing appointments for the doctor first
            MySqlCommand comm = new("DELETE FROM tb_appointment WHERE dID=@id", connection);
            _ = comm.Parameters.AddWithValue("@id", id);
            _ = comm.ExecuteNonQuery();

            // Delete the doctor record
            comm = new MySqlCommand("DELETE FROM tb_doctor WHERE id=@id", connection);
            _ = comm.Parameters.AddWithValue("@id", id);
            _ = comm.ExecuteNonQuery();
        }

        // Finds and selects a random doctor ID based on the specified medical field
        public string? FindRandomDoctorByField(string field)
        {
            DataTable dt = new();
            using MySqlConnection connection = DB.getConnection();
            MySqlCommand comm = new("SELECT id FROM tb_doctor WHERE field=@field", connection);
            _ = comm.Parameters.AddWithValue("@field", field);

            connection.Open();
            using MySqlDataAdapter da = new(comm);
            _ = da.Fill(dt);
            int rowCount = dt.Rows.Count;

            if (rowCount == 0)
            {
                return null; // Return null if no doctor matches the specified field
            }

            Random random = new();
            int randomIndex = random.Next(0, rowCount);
            string selectedDoctorId = dt.Rows[randomIndex][0].ToString();

            return selectedDoctorId;
        }
    }
}