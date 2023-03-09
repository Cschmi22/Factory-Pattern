using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Kitchen
    {
        public IDinner GetFood(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "mahi mahi":
                    return new Mahi();
                case "chicken":
                    return new Chicken();
                case "short ribs":
                    return new ShortRibs();
                default:
                    return new ShortRibs();
            }
        }
    }
}
