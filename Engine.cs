using System;

namespace Tema_Laborator_3_Robot_Object
{

    public class Engine
    {
        public static int rounds = 1;


        //Welcoming starting text
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("   ██████╗░░█████╗░██████╗░░█████╗░████████╗  ██╗░░██╗██╗██╗░░░░░██╗░░░░░███████╗██████╗");
            Console.WriteLine("   ██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝  ██║░██╔╝██║██║░░░░░██║░░░░░██╔════╝██╔══██╗");
            Console.WriteLine("   ██████╔╝██║░░██║██████╦╝██║░░██║░░░██║░░░  █████═╝░██║██║░░░░░██║░░░░░█████╗░░██████╔╝");
            Console.WriteLine("   ██╔══██╗██║░░██║██╔══██╗██║░░██║░░░██║░░░  ██╔═██╗░██║██║░░░░░██║░░░░░██╔══╝░░██╔══██╗");
            Console.WriteLine("   ██║░░██║╚█████╔╝██████╦╝╚█████╔╝░░░██║░░░  ██║░╚██╗██║███████╗███████╗███████╗██║░░██║");
            Console.WriteLine("   ╚═╝░░╚═╝░╚════╝░╚═════╝░░╚════╝░░░░╚═╝░░░  ╚═╝░░╚═╝╚═╝╚══════╝╚══════╝╚══════╝╚═╝░░╚═╝");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello player! Welcome to the newest world destroying simulator of 2021!" +
                "In this simulation you witness the destruction of the mighty ROBOT KILLER");
            Console.WriteLine();
            Console.ResetColor();

            inputSelection();
        }

        // Setting the value of choice for planetSelector parammeter
        public static void inputSelection()
        {
            Console.WriteLine("Choose a simulation scenario by selecting the wanted planet on which you want the simulation to happen: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Earth/");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Mars/");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cybertron");
            Console.ResetColor();

            Console.Write("Selection: "); Planets.choice = Console.ReadLine();

            if (!(Planets.choice == "Earth" || Planets.choice == "Mars" || Planets.choice == "Cybertron"))
            {
                Console.WriteLine("Wrong selections.. please try selecting one of the 3 planets");
                Console.ReadKey();
                Console.Clear();
                Welcome();
            }
        }

        //
        public static void startFight(Target Target, Robots Killer)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"So it would seam that you chose the scenario happening on the planet {Planets.choice}. \n" +
                $"In this scenario the Giant Killer Robot will fight the fearsome {Planets.Target.NAME} and will try to take down as many as possible. \n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"INSTRUCTIONS: After every event happening you have to press SPACEBAR");
            Console.ResetColor();


        }

        //TBD
        public static void showHealth(Target Target, Robots Killer)
        {
            //hp bar killer
            Console.Write($"[|");
            if (Killer.IsAlive)
            {
                for (int i = 0; i < Killer.HP/10; i++)
                {
                    Console.Write("█|");
                }
            }
            Console.Write("]");


            //hp bar target
            Console.Write("                          [|");

            if (Target.IsAlive)
            {
                for (int i = 0; i < Target.HP / 10; i++)
                {
                    Console.Write("█|");
                }
            }
            Console.Write("]");
        }


        public static void repeatRounds(Target Target, Robots Killer)
        {
            while (Killer.IsAlive && Target.IsAlive)
            {
                statsAndRounds(Target, Killer);
                Console.ReadKey();

                if (Target.ENERGY==5)
                {
                    Target.HP = Target.HP - Killer.ULTIMATE;
                    Target.ENERGY = 0;
                }
                else
                {
                    Target.HP = Target.HP - Killer.DMG;
                }

                if (Killer.ENERGY == 5)
                {
                    Killer.HP = Killer.HP - Target.ULTIMATE;
                    Killer.ENERGY = 0;
                }
                else
                {
                    Killer.HP = Killer.HP - Target.DMG;
                }

                
            }
            
            if(!Killer.IsAlive)
            {
                Console.Clear();

                Console.WriteLine($"{Target.NAME} wins!");
            }
            else if (!Target.IsAlive)
            {
                Console.Clear();

                Console.WriteLine($"{Killer.NAME} wins!");
            }
            else if (!Killer.IsAlive && !Target.IsAlive)
            {
                Console.Clear();

                Console.WriteLine($"ITS A TIE!");
            }



        }

        //interface of the simulation
        public static void statsAndRounds(Target Target , Robots Killer)
        {
            

            Console.WriteLine();
            Console.WriteLine($"                     Round {rounds}                ");
            Console.WriteLine($"Name: {Killer.NAME}             Name: {Target.NAME}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"HP: {Killer.HP}                        HP: {Target.HP}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Damage: {Killer.DMG}                     Damage: {Target.DMG}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Armor: {Killer.ARMOR}                       Armor: {Target.ARMOR}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Energy: {Killer.ENERGY}                        Energy: {Target.ENERGY}");
            Console.ResetColor();
            rounds++;
            Killer.ENERGY++;
            Target.ENERGY++;
        }

    }



}
