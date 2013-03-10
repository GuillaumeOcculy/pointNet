using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MP2NETS1__145196___OCCULY___PARIS
{
    class Player
    {
        private String name;
        private int xP = 0;
        private int hP = 1200;
        private int maxHP = 1200;
        private int level = 1;

        public Player(string name, int xP, int hP, int maxHp, int level)
        {
            this.name = name;
            this.xP = xP;
            this.hP = hP;
            maxHP = maxHp;
            this.level = level;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int XP
        {
            get { return xP; }
            set { xP = value; }
        }

        public int HP
        {
            get { return hP; }
            set { hP = value; }
        }

        public int MaxHp
        {
            get { return maxHP; }
            set { maxHP = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }



        public void playerInfo(Player player)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("HP : " + hP);
            Console.WriteLine("Experience : " + xP);
            Console.WriteLine("Level : " + level);
        }

    }
}
