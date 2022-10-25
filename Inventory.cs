using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverntoryManagment
{
    public class Inventory
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfPulse> typesOfPulse;
        public List<TypesOfWheat> typesOfWheat;
    }
    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesOfPulse
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int price;
    }
}
