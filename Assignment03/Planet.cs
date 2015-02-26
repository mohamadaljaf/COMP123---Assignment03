using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Planet
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
            this._diameter = diameter;
            this._mass = mass;
        }

        // OVERRIDDEN METHODS ******************************************
        public override string ToString()
        {
            return String.Format("Name: {0}\nDiameter: {1}\nMass: {2}\n", this._name, this._diameter, this._mass);
        }
    }
}
