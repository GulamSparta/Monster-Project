using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            if (Monster.Scare() == true)
            {
                Console.WriteLine("Scared");
            }
            Monster s1 = new Monster("1", "2", "3", "4", "5");
            Monster s2 = new Monster("1", "2", "3", "4", "5");
            MonsterCohourt MH = new MonsterCohourt();
            MH.addMonster(s1);
            MH.addMonster(s2);
            MH.importMonster();
            MH.listMonster();
            Console.Read();
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

        public void importMonster()
        {
            //Creates the read stream
            StreamReader file = new StreamReader (@"C:\Users\Monster_Students.txt");

            string line; //Stores the data in this var

            while ((line = file.ReadLine()) != null) {
                string[] words = line.Split(',');
                listOfMonster.Add(new Monster(words[0], words[1], words[2], words[3], words[4]));
            }

            file.Close();
        }

    }
}