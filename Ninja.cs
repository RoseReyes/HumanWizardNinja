using System;

namespace human
{
    public class Ninja : Human
        {
            public Ninja(string n) : base(n)
            {
                // Ninja should have a default dexterity of 175
                dexterity = 175;
            }
    
           // Ninja should have a steal method, which when invoked, attacks an object and increases the Ninjas health by 10
           public void Steal(object target)
            {
                Human human_victim = target as Human;
                Wizard wizard_victim = target as Wizard;
                Samurai samurai_victim = target as Samurai;
                Ninja ninja_victim = target as Ninja;

                if(target == wizard_victim || target == human_victim || target == samurai_victim || target == ninja_victim)
                {
                    attack(target);
                    health += 10;
                }
                else
                {
                    Console.WriteLine("Failed Attack");
                }
                
            }
    
            // Ninja should have a get_away method, which when invoked, decreases its health by 15
            public void Get_Away()
            {
                health -= 15;
            }
        }

}





















