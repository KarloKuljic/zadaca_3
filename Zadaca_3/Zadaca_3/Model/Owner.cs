using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_3.Model
{
    public class Owner
    {
            public string Username { get; }

            public string Password { get; }

            public Owner()
            {
                Username = "Marko Marulić";
                Password = "lozinka123";
            }

            public bool CheckPassword(string password)
            {
                return Password == password;
            }
        }
    }

