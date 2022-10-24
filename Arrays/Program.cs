using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {

        static string[] weaponList = new string[] { "Revolver", "Shot Gun", "Rifle" };
        static int[] maxAmmos = new int[] { 6, 2, 10 };
        static int[] currentAmmos = new int[]{6, 2, 10};
        static int[] BackUpAmmos = new int[] { 12, 4, 20 };

        static int currentWeapon = 0;

        static void Main(string[] args)
        {
            ShowHud();
            Fire();
            Fire();
            Reload();
            Fire();
            Fire();
            Fire();
            Fire();
            Fire();
            Reload();
            SwitchWeapon(1);
            Fire();
            Fire();
            Fire();
            Reload();
            Fire();
            Fire();
            Reload();
            Fire();
            Fire();
            Reload();
            FindAmmo();
            Reload();
            Fire();
            SwitchWeapon(2);
            Fire();
            Fire();
            SwitchWeapon(1);    //Shotgun now empty
            Fire();
        }

        static void ShowHud()
        {
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine("Current Weapon: " + weaponList[currentWeapon]);
            Console.WriteLine("Current Ammo: " + currentAmmos[currentWeapon] + "/" + maxAmmos[currentWeapon]);
            Console.WriteLine("Stored Ammo: " + BackUpAmmos[currentWeapon]);
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.ReadKey(true);
        }

        static void Fire()
        {
            if (currentAmmos[currentWeapon] > 0)
            {
                currentAmmos[currentWeapon]--;
                Console.WriteLine("BANG!");
            }
            else
            {
                currentAmmos[currentWeapon] = 0;
                Console.WriteLine("click");
            }
            ShowHud();
        }

        static void Reload()
        {
            if (BackUpAmmos[currentWeapon] >= maxAmmos[currentWeapon])
            {
                Console.WriteLine("Reloading!");
                BackUpAmmos[currentWeapon] -= (maxAmmos[currentWeapon] - currentAmmos[currentWeapon]);
                currentAmmos[currentWeapon] = maxAmmos[currentWeapon];
            }else if (BackUpAmmos[currentWeapon] > 0)
            {
                Console.WriteLine("Reloading!");
                currentAmmos[currentWeapon] = BackUpAmmos[currentWeapon];
                BackUpAmmos[currentWeapon] = 0;
            }
            else
            {
                Console.WriteLine("No Stored Ammo");
            }
            ShowHud();
        }

        static void SwitchWeapon(int switchTo)
        {
            currentWeapon = switchTo;
            Console.WriteLine("Switching to " + weaponList[currentWeapon] + "!");
            ShowHud();
        }

        static void FindAmmo()
        {
            BackUpAmmos[currentWeapon] += maxAmmos[currentWeapon];
            Console.WriteLine("Found Ammo!");
            ShowHud();
        }

    }
}
