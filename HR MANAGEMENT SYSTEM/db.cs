using MySql.Data.MySqlClient;

namespace research
{
    class Connection
    {
        public string connectionString;

        public Connection()

        {
            string server = "localhost";
            string database = "hr";
            string uid = "root";
            string password = "";
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
        }
        public bool loginform(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;

            }
        }
        public bool applicants(string fullname, string address, string gmail, int age, string sex, string jobtitle, Image image, byte[] resumePdf)
        {
            try
            {
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string applicantQuery = @"INSERT INTO applicants 
                (fullname, address, gmail, age, sex, jobtitle, image, file) 
                VALUES (@fullname, @address, @gmail, @age, @sex, @jobtitle, @image, @file)";
                    using (MySqlCommand cmd = new MySqlCommand(applicantQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@fullname", fullname);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@gmail", gmail);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@sex", sex);
                        cmd.Parameters.AddWithValue("@jobtitle", jobtitle);
                        cmd.Parameters.AddWithValue("@image", imageBytes);
                        cmd.Parameters.AddWithValue("@file", resumePdf);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting applicant info: " + ex.Message);
                return false;
            }
        }

        public bool ProfessorForm(byte[] diplomaFile, byte[] licenseFile, byte[] transcriptFile, byte[] validIdFile)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string fileQuery = @"INSERT INTO Professor_files 
                (diploma_file, license_file, transcript_file, valid_id_file) 
                VALUES (@diplomaFile, @licenseFile, @transcriptFile, @validIdFile)";
                    using (MySqlCommand cmd = new MySqlCommand(fileQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@diplomaFile", diplomaFile);
                        cmd.Parameters.AddWithValue("@licenseFile", licenseFile);
                        cmd.Parameters.AddWithValue("@transcriptFile", transcriptFile);
                        cmd.Parameters.AddWithValue("@validIdFile", validIdFile);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting professor files: " + ex.Message);
                return false;
            }
        }


        public bool nurseForm(byte[] pdffile, byte[] diplomaFile, byte[] licenseFile, byte[] transcriptFile, byte[] validIdFile)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Nurse_files (diplomaFile, licenseFile, transcriptFile, validIdFile) VALUES (@diplomaFile, @licenseFile, @transcriptFile, @validIdFile)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@diplomaFile", diplomaFile);
                        cmd.Parameters.AddWithValue("@licenseFile", licenseFile);
                        cmd.Parameters.AddWithValue("@transcriptFile", transcriptFile);
                        cmd.Parameters.AddWithValue("@validIdFile", validIdFile);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool librarianForm(byte[] pdffile, byte[] diplomaFile, byte[] licenseFile, byte[] transcriptFile, byte[] validIdFile)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Librarian_files (diploma_file, license_file, transcript_file, valid_id_file) VALUES (@diplomaFile, @licenseFile, @transcriptFile, @validIdFile)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@diplomaFile", diplomaFile);
                        cmd.Parameters.AddWithValue("@licenseFile", licenseFile);
                        cmd.Parameters.AddWithValue("@transcriptFile", transcriptFile);
                        cmd.Parameters.AddWithValue("@validIdFile", validIdFile);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }



    }
}
