using System;

namespace human
{
    public class Program
    {
       public static void Main(string[] args)
        {
             Human human1 = new Human("Bob");
             Wizard wizard1 = new Wizard("Gandalf");
             Ninja ninja1 = new Ninja("Raphael");
             Samurai samurai1 = new Samurai("Angel");


            //  System.Console.WriteLine("---------------- Attack Testing ------------------");
            //  System.Console.WriteLine(" ********** Before the Attack **********");
            //  Console.WriteLine("{0} has a health of {1}", ninja1.name, ninja1.health);
            //  Console.WriteLine("{0} has a health of {1}", wizard1.name, wizard1.health);
            //  wizard1.attack(ninja1);
            //  System.Console.WriteLine(" ********** After the Attack **********");
            //  Console.WriteLine("{0} has a health of {1}", ninja1.name, ninja1.health);
            //  Console.WriteLine("{0} decreases health of {1}", wizard1.name, wizard1.health);
             
            //  System.Console.WriteLine("---------------- Steal Testing ------------------");
            //  Console.WriteLine("{0} has a health of {1}", human1.name, human1.health);
            //  Console.WriteLine("{0} has a health of {1}", ninja1.name, ninja1.health);
            //  ninja1.Steal(human1);
            //  System.Console.WriteLine(" ********** After the Steal **********");
            //  Console.WriteLine("{0} has a health of {1}", human1.name, human1.health);
            //  Console.WriteLine("{0} has a health of {1}", ninja1.name, ninja1.health);

            //  System.Console.WriteLine("---------------- Fireball Testing ------------------");
            //  Console.WriteLine("{0} has a health of {1}", wizard1.name, wizard1.health);
            //  Console.WriteLine("{0} has a health of {1}", samurai1.name, samurai1.health);
            //  wizard1.Fireball(samurai1);
            //  System.Console.WriteLine(" ********** After the Fireball **********");
            //  Console.WriteLine("{0} has a health of {1}", wizard1.name, wizard1.health);
            //  Console.WriteLine("{0} has a health of {1}", samurai1.name, samurai1.health);

             Console.WriteLine("{0} has a health of {1}", wizard1.name, wizard1.health);
             Console.WriteLine("{0} has a health of {1}", samurai1.name, samurai1.health);
             samurai1.death_blow(wizard1); // need to modify this, it will not work
             Console.WriteLine("{0} has a health of {1}", wizard1.name, wizard1.health);
             Console.WriteLine("{0} has a health of {1}", samurai1.name, samurai1.health);
            //  samurai1.death_blow(wizard1);
            //  Console.WriteLine("{0} has a health of {1}", wizard1.name, wizard1.health);
            //  Console.WriteLine("{0} has a health of {1}", samurai1.name, samurai1.health);
        
         }
    }
}


