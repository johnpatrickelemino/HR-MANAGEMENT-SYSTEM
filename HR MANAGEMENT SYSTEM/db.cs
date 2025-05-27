using MySql.Data.MySqlClient;
using System.Data;

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
        public bool UpdatePassword(string username, string oldPassword, string newPassword)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @oldPassword";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@oldPassword", oldPassword);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            return false;
                        }
                    }
                    string updateQuery = "UPDATE admin SET password = @newPassword WHERE username = @username";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@username", username);
                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        //saan sa mga class mo or form 
        public bool applicants(string fullname, string address, string gmail, int age, string sex, string jobtitle, Image image, string resumePath)
        {
            try //
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
                        cmd.Parameters.AddWithValue("@image", image);

                        cmd.Parameters.AddWithValue("@file", resumePath);
                        //longblob

                        cmd.ExecuteNonQuery();
                    }         
                }//try mo ulit
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting applicant info: " + ex.Message);
                return false;
            }
        }
        public void UpdateNameByUsername(string fname, string add, string gmail, int age, string sex, string job)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query =  "INSERT INTO applicants (fullname, address, gmail, age, sex, jobtitle) VALUES (@full , @add, @gmail, @age, @sex, @job)";
                    
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@full", fname);
                        cmd.Parameters.AddWithValue("@add", add);
                        cmd.Parameters.AddWithValue("@gmail", gmail); //isa isa hin mo
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@sex", sex);
                        cmd.Parameters.AddWithValue("@job", job); //try mo
                   

                        //using (MemoryStream ms = new MemoryStream())
                        //{
                        //    profile.Save(ms, profile.RawFormat); // Save image to memory stream
                        //    byte[] imageBytes = ms.ToArray();
                        //    cmd.Parameters.AddWithValue("@image", imageBytes);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error10: " + ex.Message);
            }
        }
        public bool ProfessorForm(byte[] diplomaFile, byte[] licenseFile, byte[] transcriptFile, byte[] validIdFile)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string fileQuery = @"INSERT INTO professor_files 
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
                    string query = @"INSERT INTO nurse_files (diplomaFile, licenseFile, transcriptFile, validIdFile) VALUES (@diplomaFile, @licenseFile, @transcriptFile, @validIdFile)";
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
                    string query = @"INSERT INTO librarian_files (diploma_file, license_file, transcript_file, valid_id_file) VALUES (@diplomaFile, @licenseFile, @transcriptFile, @validIdFile)";
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
