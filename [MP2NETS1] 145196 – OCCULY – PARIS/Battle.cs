using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MP2NETS1__145196___OCCULY___PARIS
{
    class Battle
    {
        private int numberMonster;
        private int attackPlayer;
        private int degatPlayer;
        private int degatMonster;

        private Random random = new Random();

        public Battle(Player player)
        {   
            invokeMonster(player);
        }



        public void fight(Player player, Monster monster)
        {
            Console.WriteLine("");
            Console.WriteLine("What do you do ? ");
            Console.WriteLine("1. Fist flash");
            Console.WriteLine("2. Facial cumshot");
            Console.WriteLine("3. Inventory");
            Console.WriteLine("4. Run like a coward");

            do
            {

                attackPlayer = int.Parse(Console.ReadLine());


                switch (attackPlayer)
                {
                    case 1:
                        degatPlayer = random.Next(1, 50);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You fisted the monster on his face !");
                        Console.WriteLine("You dealt " + degatPlayer + " of degats");

                        monster.HP = Math.Abs(monster.HP - degatPlayer);

                        Console.WriteLine("Il reste " + monster.HP + " HP au " + monster.Name);
                        Console.ResetColor();

                        degatMonster = random.Next(1, 35);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Yellow;

                        Console.WriteLine("");
                        Console.WriteLine(monster.AttackName);
                        Console.WriteLine("Il vous a infligé " + degatMonster + "degats");

                        player.HP = Math.Abs(player.HP - degatMonster);

                        Console.WriteLine("Il vous reste " + player.HP + "de vie");
                        Console.ResetColor();
                        break;

                    case 2:

                        degatPlayer = random.Next(1, 75);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vous vous infiltrez dans le dos du monstre et lui faites un german suplex");

                        Console.WriteLine("Vous avez infligé " + degatPlayer + " degats");

                        monster.HP = Math.Abs(monster.HP - degatPlayer);

                        Console.WriteLine("Il reste " + monster.HP + " HP au " + monster.Name);
                        Console.ResetColor();

                        degatMonster = random.Next(1, 35);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Yellow;

                        Console.WriteLine("");
                        Console.WriteLine(monster.AttackName);

                        Console.WriteLine("Il vous a infligé " + degatMonster + "degats");

                        player.HP = Math.Abs(player.HP - degatMonster);

                        Console.WriteLine("Il vous reste " + player.HP + "de vie");
                        Console.ResetColor();
                        break;

                    case 3:
                        Console.WriteLine("Sorry I have nothing for you right now :) ");
                        break;
                }


            } while (monster.HP > 0 && player.HP > 0);


            if (monster.HP < 1)
            {
                Console.WriteLine("GREAT you killed " + monster.Name + " !!!");
            }

            if (player.HP < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("You died !");
                Console.WriteLine("");
                Console.ResetColor();
            }

        }







        public void invokeMonster(Player player)
            {
                 Monster monster = new Monster();

            Random typemonst = new Random();

            numberMonster = typemonst.Next(4);


                switch (numberMonster)
                {
                    case 0:

                        monster.Choubaka();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Choubaka appears !");
                Console.ResetColor();
                fight(player, monster);

                        break;

                    case 1:

                        monster.Zombie();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zombie appears !");
                Console.ResetColor();
                fight(player, monster);
                        break;

                    case 2:

                        monster.Bogeyman();
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bogeyman appears !");
                Console.ResetColor();
                fight(player, monster);

                        break;

                    case 3:
                    monster.Vampire();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vampire appears !");
                Console.ResetColor();
                fight(player, monster);
                        break;

                }
         
        }

    }

}
