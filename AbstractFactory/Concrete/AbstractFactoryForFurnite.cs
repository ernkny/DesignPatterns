using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public  class AbstractFactoryForFurnite
    {
        private readonly IFamilyOfFurniture _familyOfFurniture;
        private readonly ITypeOfFurniture _typeOfFurniture;
        public AbstractFactoryForFurnite(IFurnitureFactory furnitureFactory)
        {
            _familyOfFurniture = furnitureFactory.familyOfFurniture();
            _typeOfFurniture = furnitureFactory.typeOfFurniture();
        }
        public string GetNameOfFurniture()
        {
            return _familyOfFurniture.FamilyNameOfFurniture();
        }
        public string GetTypeOfFurniture()
        {
           return _typeOfFurniture.TypeNameOfFurniture();
        }

    }
}
