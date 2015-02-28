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
///                         2015-02-27: Finishing touches
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
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 116464, 95.16, "Gas");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mars", 6779, 0.107, false);

            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine(@"                                                                      ..;===+.
                                                                  .:=iiiiii=+=
                                                               .=i))=;::+)i=+,
                                                            ,=i);)I)))I):=i=;
                                                         .=i==))))ii)))I:i++
                                                       +)+))iiiiiiii))I=i+:'
                                  .,:;;++++++;:,.       )iii+:::;iii))+i='
                               .:;++=iiiiiiiiii=++;.    =::,,,:::=i));=+'
                             ,;+==ii)))))))))))ii==+;,      ,,,:=i))+=:
                           ,;+=ii))))))IIIIII))))ii===;.    ,,:=i)=i+
                          ;+=ii)))IIIIITIIIIII))))iiii=+,   ,:=));=,
                        ,+=i))IIIIIITTTTTITIIIIII)))I)i=+,,:+i)=i+
                       ,+i))IIIIIITTTTTTTTTTTTI))IIII))i=::i))i='
                      ,=i))IIIIITLLTTTTTTTTTTIITTTTIII)+;+i)+i`
                      =i))IIITTLTLTTTTTTTTTIITTLLTTTII+:i)ii:'
                     +i))IITTTLLLTTTTTTTTTTTTLLLTTTT+:i)))=,
                     =))ITTTTTTTTTTTLTTTTTTLLLLLLTi:=)IIiii;
                    .i)IIITTTTTTTTLTTTITLLLLLLLT);=)I)))))i;
                    :))IIITTTTTLTTTTTTLLHLLLLL);=)II)IIIIi=:
                    :i)IIITTTTTTTTTLLLHLLHLL)+=)II)ITTTI)i=
                    .i)IIITTTTITTLLLHHLLLL);=)II)ITTTTII)i+
                    =i)IIIIIITTLLLLLLHLL=:i)II)TTTTTTIII)i'
                  +i)i)))IITTLLLLLLLLT=:i)II)TTTTLTTIII)i;
                +ii)i:)IITTLLTLLLLT=;+i)I)ITTTTLTTTII))i;
               =;)i=:,=)ITTTTLTTI=:i))I)TTTLLLTTTTTII)i;
             +i)ii::,  +)IIITI+:+i)I))TTTTLLTTTTTII))=,
           :=;)i=:,,    ,i++::i))I)ITTTTTTTTTTIIII)=+'
         .+ii)i=::,,   ,,::=i)))iIITTTTTTTTIIIII)=+
        ,==)ii=;:,,,,:::=ii)i)iIIIITIIITIIII))i+:'
       +=:))i==;:::;=iii)+)=  `:i)))IIIII)ii+'
     .+=:))iiiiiiii)))+ii;
    .+=;))iiiiii)));ii+
   .+=i:)))))))=+ii+
  .;==i+::::=)i=;
  ,+==iiiiii+,
  `+=+++;`");

            Console.WriteLine(terrestrialPlanet.ToString());
            waitForAnyKey();
        }

        // pauses the program and waits for the user to confirm exit
        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please hit any key to exit...");
            
            Console.ReadKey();
        }
    }
}
