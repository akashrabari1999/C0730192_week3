using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730192
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Countryside
    {
        Village Alst;
        Village Maeland;
        Village Schenig;

        public void InitializeMap()
        {
            Alst = new Village();
            Alst.VillageName = "alst';"
            Maeland = new Village();
            Maeland.isAstrildeHere = true;
            Schenig = new Village();

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;
            Schenig.VillageName = "schenig";
        }

        public void WalkAround()
        {
            Village InitialVillage = this.Maeland;
        }
    }

    class Village
    {
        public Village PreviousVillage;
        public Village NextVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
        public Village() { }
    }
}