using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    //hiçbir class çıplak kalmayacak! (inheritance veya implamantasyon alacak!)
    //MicroService 
    //Manager sınıfı içinde manager sınıfı kullanacaksan onu new'leme!!!
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService; //Gamermanager içide doğrulama servisi kullanılacak

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
