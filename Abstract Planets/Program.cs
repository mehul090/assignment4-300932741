using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Mehul khosla
 * Date: july 26,2017
 * Description: Ths is the driver program class
 * Version:0.1 
 * */
namespace Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("JUPITER", 139822, 317.8, "GAS");
            GiantPlanet giantPlanet1 = new GiantPlanet("SATURN", 116464, 5.683, "GAS");
            GiantPlanet giantPlanet2 = new GiantPlanet("NEPTUNE", 49244, 1.024, "GAS");

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("EARTH",12742,5.9722,true);
            Console.WriteLine("******************************************************");
            Console.WriteLine("*            GIANT PLANETS ARE AS FOLLOWS:           *");
            Console.WriteLine("******************************************************");
            WAITFORANYKEY();
            giantPlanet.ToString();
            WAITFORANYKEY();
            giantPlanet1.ToString();
            WAITFORANYKEY();
            giantPlanet2.ToString();
            WAITFORANYKEY();
            Console.WriteLine("\n");
            Console.WriteLine("******************************************************");
            Console.WriteLine("*            TERRESTRIAL PLANET IS AS FOLLOWS:       *");
            Console.WriteLine("******************************************************");
            Program.WAITFORANYKEY();
            terrestrialPlanet.ToString();
            Program.WAITFORANYKEY();
        }
        static void WAITFORANYKEY()
        {
            Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            
        }
    }
}
