using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    public interface ICampainService
    {
        void CampainAdd(Game game);
        void CampainUpdate(Game game);
        void CampainDelete(Game game);

    }
}
