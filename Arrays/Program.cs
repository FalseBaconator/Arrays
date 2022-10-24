using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {

        static string[] weaponList = new string[] {"Revolver", "Shot Gun", "Rifle"};
        static int[] maxAmmos = new int[]{6, 2, 10};

        static int currentWeapon = 1;
        static int currentAmmo = 6;

        static void Main(string[] args)
        {
            Console.WriteLine("Arrays:");
            Console.WriteLine();

            Console.ReadKey(true);

        }

        static void ShowHud()
        {
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine("Current Weapon: " + weaponList[currentWeapon]);
            Console.WriteLine("Current Ammo:" + currentAmmo + "/" + maxAmmos[currentWeapon]);
            Console.WriteLine("----------");
            Console.WriteLine();
        }

        static void Fire()
        {
            if(currentAmmo > 0)
            {
                currentAmmo--;
                Console.WriteLine("BANG!");
            }
            else
            {
                currentAmmo = 0;
                Console.WriteLine("click");
            }
            ShowHud();
        }

        static void Reload()
        {
            currentAmmo = maxAmmos[currentWeapon];
        }

    }
}
