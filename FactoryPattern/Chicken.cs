using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Chicken : IDinner
    {
        public Chicken() { }

        public void Cook()
        {
            Console.WriteLine("Roasted Chicken Thighs with Curry Butternut Puree topped with Yukon Hash and a Cilantro Maple Apple Salad");
        }

    }
}
