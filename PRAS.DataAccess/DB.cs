using MySql.Data.MySqlClient;

namespace PRAS.DataAccess
{
    public static class DB
    {
        static DB()
        {
            // Combines the base directory path with the .env file name
            string envPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");

            // Loads the environment variables into memory if the .env file exists
            if (File.Exists(envPath))
            {
                _ = DotNetEnv.Env.Load(envPath);
            }
        }

        public static MySqlConnection getConnection()
        {
            // Retrieves the connection string using the PRAS_CONN_STR key from the .env file
            string connectionString = DotNetEnv.Env.GetString("PRAS_CONN_STR");

            // Throws an exception to prevent system failure if the connection string is missing
            return string.IsNullOrEmpty(connectionString)
                ? throw new Exception("Error: Connection string (PRAS_CONN_STR) could not be found in the .env file!")
                : new MySqlConnection(connectionString);
        }
    }
}