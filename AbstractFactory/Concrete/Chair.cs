using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class Chair : IFamilyOfFurniture
    {
        public string FamilyNameOfFurniture()
        {
            return "Sandalye";
        }
    }
}
