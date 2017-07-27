using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Mehul khosla
 * Date: july 24,2017
 * Description: Ths is the TerrestrialPlanet class which inherts from Planet class
 * Version:0.1 created GiantPlanet class
 * */
namespace Abstract_Planets
{
    /// <summary>
    /// this is terrestrial planet class
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoon, IHabital
    {
        //private instance variable
        private bool _oxygen;
        //public properties

        /// <summary>
        /// this is constructor for Terrestrial planet
        /// it takes four argument - name(string) - diameter(double) - mass(double) - oxygen(bool) 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        //constructor--------------
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        public bool HasMoon()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
    }
}