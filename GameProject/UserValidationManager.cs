using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.Birthday == 1985 && gamer.FirstName == "ENGİN"
                && gamer.LastName =="DEMİROĞ" && gamer.IdentityNumber == 12345)
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
