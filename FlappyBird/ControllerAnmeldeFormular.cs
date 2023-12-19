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
        ModelAnmeldeFormular model = new ModelAnmeldeFormular();

        private static string connectionString = "Server=localhost;Port=3306;Database=FlappyBird;Uid=root;Pwd=;";

        public bool userRegistrierung(string benutzername, string passwort)
        {
            if (!model.benutzerExsistiert(benutzername))
            {
                string salt = model.generiereSalt();
                string hashedPasswort = model.hashPasswort(passwort, salt);
                return model.userInDatenbankEinfuegen(benutzername, hashedPasswort, salt);


            }
            throw new NotImplementedException();

        }

        public bool userAnmeldung(string benutzername, string passwort)
        {
            if (model.benutzerExsistiert(benutzername))
            {
                User user = model.userAusDatenbankLesen(benutzername);
                if (user != null)
                {
                    if (model.hashPasswort(passwort, user.Salt) == user.HashPasswort)
                    {
                        ControllerGame.userData = user;
                        return true;
                    }
                }
                else
                {
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}

  