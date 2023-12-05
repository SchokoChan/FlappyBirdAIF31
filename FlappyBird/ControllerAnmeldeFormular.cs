using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using Konscious.Security.Cryptography;
using Microsoft.Win32;

namespace FlappyBird
{
    internal class ControllerAnmeldeFormular
    {

        private static string connectionString = "Server=localhost;Port=3306;Database=FlappyBird;Uid=root;Pwd=;";

        public static int userRegistrierung(string benutzername,string passwort)
        {
            bool usernameNichtVergeben = false;

            if(passwort.Length !< 7)
            {
                return 100;
            }
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    return 1;
                }

                string mySqlTest = "SELECT COUNT(*) FROM User where Username='"+ benutzername + "';";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(mySqlTest, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            usernameNichtVergeben = true;
                        }
                        else
                        {
                            usernameNichtVergeben = false;
                        }

                    }
                }
                catch
                {
                    return 50;
                }
                if (usernameNichtVergeben)
                {
                    string salt = generiereSalt();
                    string hashedPasswort = hashPasswort(passwort,salt);

                    if(hashedPasswort == "-1"){return 3;}

                    mySqlTest = "INSERT INTO User VALUES (Null,'"+benutzername+"','"
                        + hashedPasswort+ "','"+ salt+ "',0,0);";
                    MySqlCommand cmd = new MySqlCommand(mySqlTest,conn);
                    int datensaetzeBeeinflusst = -1;
                    try
                    {
                        datensaetzeBeeinflusst = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        return 50;
                    }

                    if(datensaetzeBeeinflusst > 0) {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }

                }
                else
                {
                    return 2;
                }


            }

        }
        private static string generiereSalt()
        {
            char[] characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            Random random = new Random();
            char[] salt = new char[8];
            for (int i = 0; i<8;i++)
            {
                salt[i] = characters[random.Next(characters.Length)];
            }

            return new string(salt);
        }
        
        private static string hashPasswort(string passwort,string salt)
        {

            passwort += salt;

            try
            {
                using (var hash = new Argon2id(Encoding.UTF8.GetBytes(passwort)))
                {
                    hash.Iterations = 20;
                    hash.MemorySize = 65536;
                    hash.DegreeOfParallelism = 4;
                    byte[] hashBytes = hash.GetBytes(32);
                    return Convert.ToBase64String(hashBytes);
                }
            }catch (Exception ex) 
            {
                Console.WriteLine(ex.Message.ToString());
                return "-1";
            }
        }
        
        public static int userAnmeldung(string benutzername, string passwort)
        {
            string userHashPasswort = "-1";
            string userSalt = "-1";
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                }catch
                (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    return 1;
                }
                string mySqlCommandString = "SELECT COUNT(*) FROM USER WHERE Username = '" + benutzername + "';";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(mySqlCommandString, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            return 5;
                        }
                        else if (count == 1) { }
                        else
                        {
                            return 200;
                        }
                    }
                }catch
                {
                    return 50;
                }
                mySqlCommandString = "Select PasswortSalt,PasswortHash from User where Username ='"+benutzername+"';";
                try
                {
                    using(MySqlCommand cmd = new MySqlCommand(mySqlCommandString, conn))
                    {
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userSalt = reader["PasswortSalt"].ToString();
                                userHashPasswort = reader["PasswortHash"].ToString();
                            }
                        }
                    }
                }
                catch
                {
                    return 50;
                }
                if(userHashPasswort=="-1" || userSalt =="-1")
                {
                    return 6;
                }

                if(hashPasswort(passwort,userSalt) == userHashPasswort)
                {
                    //User muss noch Übergeben werden ans Game Form
                    return 0;
                }
                else
                {
                    return 5;
                }





            }

        }

    }
}
