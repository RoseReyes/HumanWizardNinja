using System;

namespace human
{
     public class Samurai : Human
    {
        public Samurai(string n) : base(n)
        {
            // Samurai should have a default health of 200
            health = 200;
        }

        // Samurai should have a method called death_blow, which when invoked should attack an object and decreases its health to 0 if it has less than 50 health
        public void death_blow(object target)
        {
            Human human_victim = target as Human;
            Wizard wizard_victim = target as Wizard;
            Samurai samurai_victim = target as Samurai;
            Ninja ninja_victim = target as Ninja;

            if(target == wizard_victim || target == human_victim || target == samurai_victim || target == ninja_victim)
            {
                attack(target);
                // if(human_victim.health < 50)
                // {
                //     human_victim.health = 0;
                // }

                // if(human_victim.health < 50)
                // {
                //     human_victim.health = 0;
                // }
            }
        }

        // Samurai should have a method called meditate, which when invoked, heals the Samurai back to full health
        public void Meditate()
        {
            health = 200;
       }
    }
}