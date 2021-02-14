using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class CampainManager : ICampainService

    {
        public void CampainAdd(Game game)
        {
            Console.WriteLine(game.GameName + " %10 indirim kampanyaya Eklendi");
        }

        public void CampainDelete(Game game)
        {
            Console.WriteLine(game.GameName + " %10 indirim kampanyaya Silindi");

        }

        public void CampainUpdate(Game game)
        {
            Console.WriteLine("%10 indirim kampanyaya Güncellendi.");

        }
    }
}
