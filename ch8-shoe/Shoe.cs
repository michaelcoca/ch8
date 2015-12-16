using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8_shoe
{
    class Shoe
    {
        public Style Style;
        public string Color;
    }

    enum Style
    {
        Sneakers,
        Loafers,
        Sandals,
        Flipflops,
        Wingtips,
        Clogs,
    }
}
