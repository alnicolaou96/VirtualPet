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
            PetOne.Tic(); Console.WriteLine();
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
                        break;
                    case 2:
                        PetOne.Water();
                        PetOne.Tic();
                        break;
                    case 3:
                        PetOne.Play();
                        PetOne.Tic();
                        break;
                    case 4:
                        PetOne.BedTime();
                        PetOne.Tic();
                        break;
                    case 5:
                        PetOne.Doctors();
                        PetOne.Tic();
                        break;

                }
            } while (activity != 0);

        }
    }
}
