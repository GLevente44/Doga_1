using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Gl_Doga_1
{
    internal class Program
    {
        public static void Penzugy()
        {
            Console.Write("Adjon meg egy vásárlási összeget: ");
            int osszeg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rendelkezel törzsvásárlói kártyával (igen/nem)? ");
            string torszvasarlo = Convert.ToString(Console.ReadLine());

            if (osszeg < 10000 ) 
            {
                Console.WriteLine("Nincs kedvezmény");
            }
            else if(osszeg >= 10000 && osszeg <= 50000 && torszvasarlo == "igen")
            {
                Console.WriteLine("5% kedvezményt kap.");
            }
            else if (osszeg >= 10000 && osszeg <= 50000 && torszvasarlo == "nem")
            {
                Console.WriteLine("Nincs kedvezmény.");
            }
            else if (osszeg > 50000 && torszvasarlo == "igen")
            {
                Console.WriteLine("10% kedvezményt kap.");
            }
            else if (osszeg > 50000 && torszvasarlo == "nem")
            {
                Console.WriteLine("5% kedvezményt kap.");
            }



            int vegso_osszeg5 = osszeg / 100;
            int vegso_osszeg5_2 = vegso_osszeg5 * 5;

            int vegso_osszeg10 = osszeg / 100;
            int vegso_osszeg10_2 = vegso_osszeg10 * 10;


            // eredmény 
            if (osszeg >= 10000 && osszeg <= 50000 && torszvasarlo == "igen")
            {
                Console.WriteLine("A fizetendő összeg: {0}",osszeg - vegso_osszeg5_2);
            }
            else if (osszeg >= 10000 && osszeg <= 50000 && torszvasarlo == "nem")
            {
                Console.WriteLine("A fizetendő összeg: {0}", osszeg);

            }

            else if (osszeg > 50000 && torszvasarlo == "igen") 
            {
                Console.WriteLine("A fizetendő összeg: {0}",osszeg - vegso_osszeg10_2);
            }
            else if (osszeg > 50000 && torszvasarlo == "nem")
            {
                Console.WriteLine("A fizetendő összeg: {0}",osszeg - vegso_osszeg5_2);
            }
            else if (osszeg < 10000)
            {
                Console.WriteLine("A fizetendő összeg: {0}", osszeg);
            }



        }
        static void Main(string[] args)
        {
            Penzugy();
        }
    }
}
