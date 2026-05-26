using MySql.Data.MySqlClient;
using PRAS.Core;
using System.Data;

namespace PRAS.DataAccess
{
    public class SecretaryRepository
    {
        // Fetches a specific secretary record for login verification
        public Secretary GetSecretary(string email, string password)
        {
            Secretary? secretary = null;
            using (MySqlConnection connection = DB.getConnection())
            {
                MySqlCommand comm = new("SELECT id, email, password FROM tb_secretary WHERE email=@email AND password=@password", connection);
                _ = comm.Parameters.AddWithValue("@email", email);
                _ = comm.Parameters.AddWithValue("@password", password);

                connection.Open();
                using MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    secretary = new Secretary
                    {
                        Id = reader.GetInt32("id"),
                        Email = reader.GetString("email"),
                        Password = reader.GetString("password")
                    };
                }
            }
            return secretary;
        }

        // Retrieves all secretaries from the database to populate UI data grids
        public DataTable GetAllSecretaries()
        {
            DataTable dt = new();
            using (MySqlConnection connection = DB.getConnection())
            {
                MySqlCommand comm = new("SELECT id, name, surname, email, phoneNumber FROM tb_secretary", connection);
                connection.Open();
                using MySqlDataAdapter da = new(comm);
                _ = da.Fill(dt);
            }
            return dt;
        }

        // Inserts a new secretary profile or updates an existing record based on the ID's presence
        public void AddOrUpdateSecretary(string firstName, string lastName, string email, int phoneNumber, int id)
        {
            using MySqlConnection connection = DB.getConnection();
            MySqlCommand comm = new("SELECT COUNT(*) FROM tb_secretary WHERE id=@id", connection);
            _ = comm.Parameters.AddWithValue("@id", id);

            connection.Open();
            long count = Convert.ToInt64(comm.ExecuteScalar());

            if (count > 0)
            {
                // Record exists, execute the update sequence
                MySqlCommand updateComm = new("UPDATE tb_secretary SET name=@name surname=@surname, email=@email, phoneNumber=@phoneNumber WHERE id=@id", connection);
                _ = updateComm.Parameters.AddWithValue("@name", firstName);
                _ = updateComm.Parameters.AddWithValue("@surname", lastName);
                _ = updateComm.Parameters.AddWithValue("@email", email);
                _ = updateComm.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                _ = updateComm.Parameters.AddWithValue("@id", id);
                _ = updateComm.ExecuteNonQuery();
            }
            else
            {
                // New record, execute the insert statement (ID handled automatically by MySQL)
                MySqlCommand insertComm = new("INSERT INTO tb_secretary (name, surname, email, password, phoneNumber) VALUES (@name, @surname, @email, @password, @phoneNumber)", connection);
                _ = insertComm.Parameters.AddWithValue("@name", firstName);
                _ = insertComm.Parameters.AddWithValue("@surname", lastName);
                _ = insertComm.Parameters.AddWithValue("@email", email);
                _ = insertComm.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                _ = insertComm.Parameters.AddWithValue("@password", "PRAS" + firstName + lastName); // Auto-generated default password
                _ = insertComm.ExecuteNonQuery();
            }
        }

        // Deletes a secretary record completely from the target mapping table
        public void DeleteSecretary(int id)
        {
            using MySqlConnection connection = DB.getConnection();
            MySqlCommand comm = new("DELETE FROM tb_secretary WHERE id=@id", connection);
            _ = comm.Parameters.AddWithValue("@id", id);

            connection.Open();
            _ = comm.ExecuteNonQuery();
        }
    }
}