using System;

namespace human {

    public class Human
    {
        public string name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string n) 
        {
            name = n;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
    
        public Human(string n, int str, int intel, int dex, int hp)
        {
            name = n;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }

         public void attack(object target)
        {
            Human enemy = target as Human;

            if(target == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    
    
    }
}