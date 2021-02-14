using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    //yapılacak doğrulama işinin şablonu
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
