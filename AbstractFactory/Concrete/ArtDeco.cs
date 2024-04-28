using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class ArtDeco : ITypeOfFurniture
    {
        public string TypeNameOfFurniture()
        {
            return "Artistic Decoration";
        }
    }
}
