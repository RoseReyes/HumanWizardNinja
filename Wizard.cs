using System;

namespace human 
{
    public class Wizard : Human
    {
        // Wizard should have a default health of 50 and intelligence of 25
        public Wizard(string n) : base(n)
        {
            health = 50;
            intelligence = 25;
        }

        // Wizard should have a method called heal, which when invoked, heals the Wizard by 10 * intelligence
        public void Heal()
        {
            health += 10 * intelligence;
        }

        // Wizard should have a method called fireball, which when invoked, decreases the health of whichever object it attacked by some random integer between 20 and 50
        public void Fireball(object target)
        {
            Random randInt = new Random();
            Human victim = target as Human;
            Ninja victim2 = target as Ninja;
            Wizard victim3 = target as Wizard;
            Samurai victim4 = target as Samurai;
           
            if( target == victim)
            {
                victim.health -= randInt.Next(20, 50);
            }
            if( target == victim2)
            {
                victim2.health -= randInt.Next(20,50);
            }
            if( target == victim3)
            {
                victim3.health -= randInt.Next(20,50);
            }
            if( target == victim4)
            {
                victim4.health -= randInt.Next(20,50);
            }
            else
            {
                Console.WriteLine("Failed Attack");
            }
        }
    }
}