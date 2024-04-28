using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class Table : IFamilyOfFurniture
    {
        public string FamilyNameOfFurniture()
        {
            return "Table";
        }
    }
}
