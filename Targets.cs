using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Tema_Laborator_3_Robot_Object
{
    public class Target
    {
        
        private int health;
        private int dmg;
        private int armor;
        private int energy = 0;
        private string type;
        


        //private bool isTargeted;
        private bool isAlive = true;


        //the damage of the Target's attack after armor reduction applies
        public int RefinedDmg 
        {
            get
            {
                return dmg - Planets.KillerRobot.ARMOR;
            }
        }

        //health > 0
        public bool IsAlive
        { 
            get
            {
                return isAlive;
            }
            set
            {
                if(health <= 0)
                isAlive = false;
            }
        }

        //starting with 0 and when it reaches 5 it uses ULTIMATE
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

        //the name of the target/ type of it (Superhero, Alien, Giant Friendly Robot)
        public string NAME
        {
            get
            {
                return type;
            }

        }

        //the armor of the target
        public int ARMOR
        {
            get
            {
                return armor;
            }

        }

        //the hp of the target
        public int HP
        {
            get
            {
                return health;
            }
        }

        //the damage of the target
        public int DMG
        {
            get
            {
                return dmg;
            }
        }

        public int ULTIMATE
        {
            get
            {
                return dmg * 2;
            }
            set
            {
                if (ENERGY == 5)
                    dmg = dmg * 2;
            }

        }


        public Target(string TYPE, int HEALTH,int DAMAGE,int ARMOR)
        {
            health = HEALTH;
            dmg = DAMAGE;
            armor = ARMOR;
            type = TYPE;
            
            //TODO WHY IT DOESN'T WORK???
            //Console.WriteLine($"Target instantiated: HP = {Planets.tinta.health} Armour = {Planets.tinta.armor} DMG = {Planets.tinta.dmg}*");
            
        }
    }
}
