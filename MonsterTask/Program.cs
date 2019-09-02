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
            if(Monster.Jump() == true)
            {
                Console.WriteLine("Jump");
            }
        }
    }

    class Monster
    {
        public string id;
        public string eyes;
        public string hair;
        public string scaryLevel;
        public string specialAbility;
        public Monster(string idIn, string eyesIn, string hairsIn, string scaryLevelIn, string specialAbilityIn)
        {
            this.id = idIn;
            this.eyes = eyesIn;
            this.hair = hairsIn;
            this.scaryLevel = scaryLevelIn;
            this.specialAbility = specialAbilityIn;
        }

        public static bool Jump()
        {
            return true;
        }

        public static bool Scare()
        {
            return true;
        }
    }

    class MonsterCohourt
    {
        private string subject;
        private string startDate;
        List<Monster> listOfMonster = new List<Monster>();
        public void addMonster(Monster monsterIn)
        {
            listOfMonster.Add(monsterIn);
        }

        public void listMonster()   
        {
            foreach(Monster m in listOfMonster)
            {
                Console.WriteLine(m.id);
            }
        }

    }
}