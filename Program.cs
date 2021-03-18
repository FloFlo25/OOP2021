using System;

namespace Tema_Laborator_3_Robot_Object
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Engine.Welcome();
            Planets.planetSelector();
            Engine.startFight(Planets.Target, Planets.KillerRobot);
            //Engine.showHealth(Planets.target, Planets.KillerRobot);
            //starts the round
            //Engine.statsAndRounds(Planets.Target, Planets.KillerRobot);

            //round repeater
            Engine.repeatRounds(Planets.Target, Planets.KillerRobot);
        }

    }
}
