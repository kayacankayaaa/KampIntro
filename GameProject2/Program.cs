using System;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer {
                Id = 1, 
                BirthYear = 1995, 
                FirstName = "KAYACAN", 
                LastName = "KAYA", 
                IdendityNumber = 12345 
            });

            GameManager gameManager = new GameManager();
            gameManager.Order(new Gamer
            {
                Id = 2,
                BirthYear = 1996,
                FirstName = "ÖZGE",
                LastName = "YIKICI",
                IdendityNumber = 234567

            });

            CampainManager campainManager = new CampainManager();
            campainManager.CampainAdd(new Game
            {
                Id = 1,
                GameName = "Fifa",
                UnitPrice = 10
            });
            campainManager.CampainDelete(new Game
            {
                Id = 2,
                GameName = "PES",
                UnitPrice = 15
            });



        }
    }
}
