using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        //MicroService
        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {

                Console.WriteLine("Kayıt oldu");
            }
            
            else
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
