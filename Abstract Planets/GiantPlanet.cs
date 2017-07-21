using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Mehul khosla
 * Date: july 17,2017
 * Description: Ths is the GiantPlanet class which inherts from Planet class
 * Version:0.1 created GiantPlanet class
 * */
namespace Abstract_Planets
{
    /// <summary>
    /// this is the GiantPlanet class
    /// </summary>
    public class GiantPlanet : Planet,IHasMoon,IHasRings
    {
        //private instance variable
        private string _type;

        //public properties
        public bool MoonCount
        {
            get { return this._type; }
            set { this._type = value; }
        }

        public bool RingCount
        {
            get { return this._type; }
            set { this._type = value; }
        }

        //constructor--------------
        /// <summary>
        /// this is the constructor for GiantPlanet
        /// it takes three argument - name(string) - diameter(double) - mass(double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public GiantPlanet(string name ,double diameter , double mass , bool MoonCount , bool RingCount)
            :base(name,diameter,mass)
        {
            this.MoonCount = MoonCount;
            this.RingCount = RingCount;
        }

        
    }
}