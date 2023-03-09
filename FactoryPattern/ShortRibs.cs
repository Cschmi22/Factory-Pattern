using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ShortRibs : IDinner
    {
        public ShortRibs() { }
        public void Cook()
        {
            Console.WriteLine("Birria Braised Short Ribs in Black Garlic BBQ Sauce with Lima Bean Hummus and Confit Beech Mushrooms");
        }
    }
}
