using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet PetOne = new VirtualPet(50,50,50,50,50,50,10);

            Console.Write("Name your pet! ");
            string name = Console.ReadLine(); Console.WriteLine();

            Console.WriteLine("Meet {0}! Here are {0}'s current stats!",name);
            PetOne.Tic();

            Console.WriteLine("type '0' to quit the game\ntype in '6' to check {0}'s status\n",name);
            int activity;
            do
            {
                Console.WriteLine("pick an activity to do with {0}, by typing in the number!", name);
                Console.WriteLine("1:Feed\n2:Water\n3:Play\n4:Put to Bed\n5:Go to Doctor");
                activity = int.Parse(Console.ReadLine());
                switch (activity)
                {
                    case 1:
                        PetOne.FeedPet();
                        PetOne.Tic();
                        Console.WriteLine(name + ": Thanks for the Food!");                        
                        break;
                    case 2:
                        PetOne.Water();
                        PetOne.Tic();
                        Console.WriteLine(name + ": Thanks for the Water!");
                        break;
                    case 3:
                        PetOne.Play();
                        PetOne.Tic();
                        Console.WriteLine(name + ": I had fun!");
                        break;
                    case 4:
                        PetOne.BedTime();
                        PetOne.Tic();
                        Console.WriteLine(name + ": Im feeling well rested!");
                        break;
                    case 5:
                        PetOne.Doctors();
                        PetOne.Tic();
                        Console.WriteLine(name + ": The doctors scare me, I dont want to go again!");
                        break;
                    case 6:
                        PetOne.CheckStatus();
                        break;
                }
  
            } while (activity != 0);
            Console.WriteLine("\nGAME OVER!");
            Console.WriteLine("your final stats are:");
            PetOne.CheckStatus();

        }
    }
}
