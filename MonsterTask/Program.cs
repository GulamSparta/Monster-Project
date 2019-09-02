using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTask
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Monster
    {
        private string id;
        private string eyes;
        private string hair;
        private string scaryLevel;
        private string specialAbility;
        public MonsterInk(string idIn, string eyesIn, string hairsIn, string scaryLevelIn, string specialAbilityIn)
        {
            this.id = idIn;
            this.eyes = eyesIn;
            this.hair = hairsIn;
            this.scaryLevel = scaryLevelIn;
            this.specialAbility = specialAbilityIn;
        }

        public bool Jump()
        {
            return true;
        }

        public bool Scare()
        {
            return true;
        }
    }

    class MonsterCohourt
    {
        public MonsterCohourt 
        {

        }       
    }
