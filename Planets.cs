using System;

namespace Tema_Laborator_3_Robot_Object
{
    public class Planets
    {
        public static Random rnd = new Random();
        public static string choice;
        public static Target Target;
        public static Robots KillerRobot = new Robots();

        public static void planetSelector()
        {
            switch (choice)
            {
                case "Earth":
                    Target = new Target("Superhero",100, rnd.Next(3,6), 3);
                    break;
                case "Mars":
                    Target = new Target("Alien", 100, rnd.Next(7,10), 5);
                    break;
                case "Cybertron":
                    Target = new Target("Giant Friendly Robot", 150, rnd.Next(8, 12), 10);
                    break;
                default:
                    break;
            }
        }

        public string getChoice
        {
            get
            {
                return choice;
            }
        }

    }
}
