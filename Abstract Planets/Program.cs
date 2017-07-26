using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Mehul khosla
 * Date: july 26,2017
 * Description: Ths is the driver program class
 * Version:0.1 - added planets to driver class
 * */
namespace Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 139822, 317.8, "GAS");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("EARTH",12742,5.9722,true);
            giantPlanet.ToString();
            terrestrialPlanet.ToString();
            Program.WAITFORANYKEY();
        }
        static void WAITFORANYKEY()
        {
            Console.ReadLine();
        }
    }
}
