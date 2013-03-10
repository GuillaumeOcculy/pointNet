using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MP2NETS1__145196___OCCULY___PARIS
{
    class Monster
    {
        private string name;
        private int attackRate;
        private string attackName;
        private int missRate;
        private int hP;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int AttackRate
        {
            get { return attackRate; }
            set { attackRate = value; }
        }

        public int MissRate
        {
            get { return missRate; }
            set { missRate = value; }
        }

        public int HP
        {
            get { return hP; }
            set { hP = value; }
        }

        public string AttackName
        {
            get { return attackName; }
            set { attackName = value; }
        }

        public void Choubaka()
        {
            Name = "Choubaka";
            HP = 350;
            AttackRate = 100;
            AttackName = "Chubaka attackes you with his stinky breath ! ";
        }

        public void Bogeyman()
        {
            Name = "Bogeyman";
            HP = 300;
            AttackRate = 88;
            AttackName = "Bogeyman eats you like a candy ! ";
        }

        public void Zombie()
        {
            Name = "Zombie";
            HP = 60;
            AttackRate = 110;
            AttackName = "Zombie eats you  ! ";
        }

        public void Vampire()
        {
            Name = "Vampire";
            HP = 350;
            AttackRate = 350;
            AttackName = "Vampire, sucks you as a prostitute ! ";
        }
    }
}
