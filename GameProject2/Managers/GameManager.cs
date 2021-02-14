using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    public class GameManager : IGameService
    {
        public void Order(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Tarafından oyun Satışı Gerçekleşti.");
        }

       
    }
}
