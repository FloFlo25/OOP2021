using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Tema_Laborator_3_Robot_Object
{
    public class Robots
    {
        private int hp = 150;
        private static int dmg = 10;
        private int armor = 5;
        private int energy = 0;
        private int ultimate = dmg * 2;
        private bool isAlive = true;
        private string name = "Robot Killer";

        public Robots()
        {
        }

        //the damage of the Target's attack after armor reduction applies
        public int RefinedDmg
        {
            get
            {
                return dmg - Planets.Target.ARMOR;
            }
        }

        public int ULTIMATE
        {
            get
            {
                return ultimate - Planets.Target.ARMOR;
            }

        }


        public int ENERGY
        {
            get
            {
                return energy;
            }

            set
            {
                energy = value;
            }
        }

        public string NAME
        {
            get
            {
                return name;
            }

        }

        public int ARMOR
        {
            get
            {
                return armor;
            }

        }

        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }

        public int DMG
        {
            get
            {
                return dmg;
            }

        }

        public bool IsAlive 
        {
            get
            {
                return isAlive;
            }
            set
            {
                if (hp<=0)
                {
                    isAlive = false;
                }
            }
            
        }

        
    }
}
