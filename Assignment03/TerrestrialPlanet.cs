using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class TerrestrialPlanet : Planet
    {
        // INSTANCE VARIABLES ******************************************
        private bool _oxygen;

        // CONSTRUCTOR(S) ******************************************
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // PUBLIC METHODS ******************************************
        // returns true if the moon count is greater than zero
        public bool HasMoons()
        {
            if (this.MoonCount == 0)
            {
                return false;
            }

            return true;
        }

        // returns true if the oxygen variable is set to true
        public bool Habitable()
        {
            return this._oxygen;
        }
    }
}
