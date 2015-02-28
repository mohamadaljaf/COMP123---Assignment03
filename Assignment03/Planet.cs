///------------------------------------------------------------------------------------------
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   February 27, 2015
///   
///   Class description:    An abstract class used as the foundation for subclasses of this
///                         class.
///------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    // Planet abstract class - blueprint for planet subclasses
    abstract class Planet
    {
        // INSTANCE VARIABLES ******************************************
        private double _diameter, _mass;
        private double _orbitalPeriod, _rotationPeriod;
        private int _moonCount, _ringCount;
        private string _name;

        // PROPERTIES ******************************************
        public double Diameter { get { return this._diameter; } } // Read-Only
        public double Mass { get { return this._mass; } } // Read-Only
        public string Name { get { return this._name; } } // Read-Only
        public double OrbitalPeriod { get { return this._orbitalPeriod; } set { this._orbitalPeriod = value; } }
        public double RotationPeriod { get { return this._rotationPeriod; } set { this._rotationPeriod = value; } }
        public int MoonCount { get { return this._moonCount; } set { this._moonCount = value; } }
        public int RingCount { get { return this._ringCount; } set { this._ringCount = value; } }

        // CONSTRUCTOR(S) ******************************************
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter; // in km
            this._mass = mass; // relative to Earth's mass
        }

        // OVERRIDDEN METHODS ******************************************
        public override string ToString()
        {
            return String.Format("Name: {0}\nDiameter (km): {1}\nMass (Earth mass): {2}\n", this._name, this._diameter, this._mass);
        }
    }
}
