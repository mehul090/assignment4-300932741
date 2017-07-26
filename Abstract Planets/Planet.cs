using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Mehul khosla
 * Date: july 17,2017
 * Description: Ths is the abstract Planet class
 * Version:0.2 - editted overide ToString() 
 * */

namespace Abstract_Planets
{
    /// <summary>
    /// this is abstract Planet class
    /// </summary>
    public abstract class Planet
    {
        //Private instance variable (fields)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPlanet;
        private int _ringCount;
        private double _rotationPeriod;

        //public properties
        public double Diameter
        {
            get { return this._diameter; }

        }

        public double Mass
        {
            get { return this._mass; }
            
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get { return this._name; }
           
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPlanet;
            }
            set
            {
                this._orbitalPlanet = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationalPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //constructor--------------------------------------
        /// <summary>
        /// this is the main constructor for Planet class.
        /// it takes three parameters - name(string) , diameter(double) , mass(double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }


       

        public override string ToString()
        {
            string output = "The planet " + this.Name + " has a diameter of " + this.Diameter + "km " + " and has a mass of : " + this.Mass + " x 10^24 kg";
            Console.WriteLine(output);
            return output;
        }


    }
}