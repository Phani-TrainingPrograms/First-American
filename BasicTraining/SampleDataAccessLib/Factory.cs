using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataAccessLib
{
    public class Factory
    {
        public static ILaptopDB GetComponent() => new LaptopDataComponent();
        
    }
}
