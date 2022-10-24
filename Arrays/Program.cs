using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {

        static string[] weaponList = new string[] {"Revolver", "Shot Gun", "Rifle", "Spray n' Pray" };
        static int[] maxAmmos = new int[]{6, 2, 10, 50};

        static int CurrentWeapon = 1;
        static int CurrentAmmo = 6;

        static void Main(string[] args)
        {
            Console.WriteLine("Arrays:");
            Console.WriteLine();

            Console.ReadKey(true);

        }

        static void ShowHud()
        {
            Console.Clear();
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine("Current Weapon: " + weaponList[CurrentWeapon]);
        }

    }
}
