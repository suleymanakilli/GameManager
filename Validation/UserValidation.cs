using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingGameBackend
{
    class UserValidation
    {
        public bool IsValid(User user)
        {
            if (user.TC == "12345678910" && user.Name == "Süleyman" && user.Surname == "AKILLI" && user.BirthYear == 2000)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
