using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class OrderManager : ICampainService
    {
        public void CampainAdd(Game game)
        {
            Console.WriteLine("Ürüne kapmanya indirimi eklendi.");
        }

        public void CampainDelete(Game game)
        {
            Console.WriteLine("Ürüne eklenen kapmanya indirimi silindi.");
        }

        public void CampainUpdate(Game game)
        {
            Console.WriteLine("Ürüne eklenen kapmanya indirimi güncellendi.");
        }
    }
}
