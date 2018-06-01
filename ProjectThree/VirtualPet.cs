using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    class VirtualPet
    {
        //Fields
        private int hunger, sleep, mood, health, exercise, thirst;

        //properties
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }
        public int Mood
        {
            get { return this.mood; }
            set { this.mood = value; }
        }
        public int Health
        {
            get{ return this.health; }
            set{ this.health = value; }
        }
        public int Exercise
        {
            get { return this.exercise; }
            set { this.exercise = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        
        //constructors
        public VirtualPet()
        {
            //default constructor
        }
        public VirtualPet(int hunger, int sleep, int mood, int health, int exercise, int thirst)
        {
            this.hunger = hunger;
            this.sleep = sleep;
            this.mood = mood;
            this.health = health;
            this.exercise = exercise;
            this.thirst = thirst;
        }

        //Activity Methods
        public void FeedPet()
        {
            hunger-=50;
            thirst+=10;
            sleep += 10;
            mood++;
        }
        public void Water()
        {
            hunger -= 5;
            thirst += 50;
            sleep -= 5;
        }
        public void BedTime()
        {
            hunger += 25;
            thirst += 25;
            health += 10;
            sleep -= 100;
            health += 10;
        }
        public void Play()
        {
            hunger += 10;
            thirst += 20;
            exercise += 25;
            sleep += 25;
            mood++;
            health += 5;
        }
        public void Doctors()
        {
            health += 25;
            mood -= 50;
        }
        
        //Retaliance Value
        public int Retaliance()
        {
            int retaliance;
            Random r = new Random();
            retaliance = r.Next(1, 100);
            return retaliance;
        }

            

    }
}
