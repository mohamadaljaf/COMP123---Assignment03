///------------------------------------------------------------------------------------------
///   Project:              Assignment 03 - Abstract Planets
/// 
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   Februrary 27, 2015
///   
///   Program description:  A program that utilizes an abstract class called Planet to create
///                         two subclasses called GiantPlanet and TerrestrialPlanet. Displays
///                         the specifications of each Planet object to the console.
///                         
///   Revision History:     2015-02-26: Initial build
///                         2015-02-26: Completed Planet class
///                         2015-02-26: Completed GiantPlanet class
///                         2015-02-26: Completed TerrestrialPlanet class
///                         2015-02-27: Added 3 Interfaces, IHabitable, IHasRings, IHasMoons
///------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 139822, 317, "Gas");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mars", 6779, 0.107, false);

            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine(terrestrialPlanet.ToString());

            waitForAnyKey();
        }

        // pauses the program and waits for the user to confirm exit
        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }
    }
}
