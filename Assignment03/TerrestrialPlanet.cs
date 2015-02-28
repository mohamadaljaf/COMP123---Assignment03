///------------------------------------------------------------------------------------------
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   February 27, 2015
///   
///   Class description:    An object of the planet abstract class that has oxygen as an
///                         option.
///------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    // TerrestrialPlanet subclass of Planet abstract class
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // INSTANCE VARIABLES ******************************************
        private bool _oxygen;

        // CONSTRUCTOR(S) ******************************************
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
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
