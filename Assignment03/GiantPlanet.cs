///------------------------------------------------------------------------------------------
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   February 27, 2015
///   
///   Class description:    An object of the planet abstract class that has gas,
///                         or ice as an option.
///------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    // GiantPlanet subclass of Planet abstract class
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // INSTANCE VARIABLES ******************************************
        private string _type; // describes the type of planet: gas or ice

        // CONSTRUCTOR(S) ******************************************
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
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

        // returns true if the ring count is greater than zero
        public bool HasRings()
        {
            if (this.RingCount == 0)
            {
                return false;
            }

            return true;
        }
    }
}
