using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "KAYACAN" 
                && gamer.LastName =="KAYA" && gamer.IdendityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
