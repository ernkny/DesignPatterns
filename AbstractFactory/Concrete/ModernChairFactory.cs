using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class ModernChairFactory : IFurnitureFactory
    {
        public IFamilyOfFurniture familyOfFurniture()
        {
            return new Chair();
        }

        public ITypeOfFurniture typeOfFurniture()
        {
            return new Modern();
        }
    }
}

