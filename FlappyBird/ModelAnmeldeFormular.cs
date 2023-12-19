using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konscious.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace FlappyBird
{
    internal class ModelAnmeldeFormular
    {
        private string connectionString = "Server=localhost;Port=3306;Database=FlappyBird;Uid=root;Pwd=;";

        public bool benutzerExsistiert(String username)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string queryUsernameTesten = "SELECT COUNT(*) FROM User where Username='" + username + "';";
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(queryUsernameTesten, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }

                    }
                }
                catch (Exception ex)
                {
                    return true;
                }
                finally
                {
                    conn.Close();
                }
                
            }

        }
        public bool userInDatenbankEinfuegen(String username,String passwort,String salt)
        {
            String queryZumEinfuegenDesUsers = "INSERT INTO User VALUES (Null,'" + username + "','"
                        + passwort + "','" + salt + "',0,0);";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = queryZumEinfuegenDesUsers;
                try
                {
                    conn.Open();
                    if(cmd.ExecuteNonQuery() == 1)
                    {
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }

                }
                catch (Exception ex)
                {
                }
                finally
                {
                    conn.Close();

                }

                return false;
            }
        }

        public User userAusDatenbankLesen(String username)
        {
            string userSalt = "-1";
            string userHashPasswort = "-1";
            int score = -1, coins = -1;
            String query = "Select PasswortSalt,PasswortHash,Highscore,Coins from User where Username ='" + username + "';";

            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                coins = Convert.ToInt32(reader["Coins"].ToString());
                                score = Convert.ToInt32(reader["Highscore"].ToString());
                                userSalt = reader["PasswortSalt"].ToString();
                                userHashPasswort = reader["PasswortHash"].ToString();
                            }
                        }
                    }
                    conn.Close();
                    if(score != -1 && userHashPasswort != "-1" && userSalt != "-1" && coins != -1)
                    {
                        return new User(username,userHashPasswort,userSalt,score,coins);
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }

                return null;
            }
        }
        public string generiereSalt()
        {
            char[] characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            Random random = new Random();
            char[] salt = new char[8];
            for (int i = 0; i < 8; i++)
            {
                salt[i] = characters[random.Next(characters.Length)];
            }

            return new string(salt);
        }

        public string hashPasswort(string passwort, string salt)
        {

            passwort += salt;

            using (var hash = new Argon2id(Encoding.UTF8.GetBytes(passwort)))
            {
                hash.Iterations = 20;
                hash.MemorySize = 65536;
                hash.DegreeOfParallelism = 4;
                byte[] hashBytes = hash.GetBytes(32);
                return Convert.ToBase64String(hashBytes);
            }
        }

    }
}
