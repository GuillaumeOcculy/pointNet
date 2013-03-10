using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MP2NETS1__145196___OCCULY___PARIS
{
    internal class Map
    {
        private string positionStart;
        private string positionEnd;
        private int positionX;
        private int positionY;
        private string positionPlayer;
        private string directionPlayer;
        private int monsterRate;
        private Random random = new Random();

        private string[,] card = new string[5,5];


        private const string road = "A road, you can go everywhere";
        private const string sand = "A sand, be careful, if you go to north, you can be attacked by a monster !";
        private const string wall = "A wall, change your direction";
        private const string volcano = "Oh my goooooood a volcano ! Leave this way NOW !!!";
        private const string noMansLand = "There are nothing here...Continue your way";


        public int PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }

        public int PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }

        public string Card
        {
            get { return card[positionX, positionY]; }
            set { card[positionX, positionY] = value; }
        }


        public void map()
        {
            card[0, 0] = positionStart;
            card[0, 1] = road;
            card[0, 2] = road;
            card[0, 3] = road;
            card[0, 4] = road;
            card[0, 5] = road;

            card[1, 0] = sand;
            card[1, 1] = sand;
            card[1, 2] = sand;
            card[1, 3] = sand;
            card[1, 4] = sand;
            card[1, 5] = sand;

            card[2, 0] = sand;
            card[2, 1] = sand;
            card[2, 2] = wall;
            card[2, 3] = wall;
            card[2, 4] = wall;
            card[2, 5] = wall;

            card[3, 0] = wall;
            card[3, 1] = wall;
            card[3, 2] = noMansLand;
            card[3, 3] = wall;
            card[3, 4] = volcano;
            card[3, 5] = volcano;

            card[4, 0] = volcano;
            card[4, 1] = volcano;
            card[4, 2] = volcano;
            card[4, 3] = volcano;
            card[4, 4] = noMansLand;
            card[4, 5] = noMansLand;

            card[5, 0] = noMansLand;
            card[5, 1] = noMansLand;
            card[5, 2] = noMansLand;
            card[5, 3] = noMansLand;
            card[5, 4] = noMansLand;
            card[5, 5] = positionEnd;

        }

        public void cardLand(Player player)
        {
            map();



            positionX = random.Next(0, 4);
            positionY = random.Next(0, 4);
            positionStart = card[positionX, positionY];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(positionStart);
            Console.ResetColor();
            movePlayer(player);
        }

        public void movePlayer(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose your direction");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("North");
            Console.WriteLine("South");
            Console.WriteLine("East");
            Console.WriteLine("West");
            Console.WriteLine("Info");
            Console.WriteLine("Quit");

            Console.Write(">");

            directionPlayer = Console.ReadLine();
            switch (directionPlayer)
            {
                case "North":
                case "north":
                    try
                    {
                        positionY++;
                        positionPlayer = card[positionX, positionY];

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(positionStart);
                        Console.ResetColor();


                        monsterRate = random.Next(0, 2);

                        if (monsterRate == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Be careful you are attacked !");
                            Console.ResetColor();

                            Battle battle = new Battle(player);

                        }
                        else
                        {
                            movePlayer(player);
                        }
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("There are nothing, change direction");
                        Console.ResetColor();

                        movePlayer(player);

                    }

                    break;

                case "South":
                case "south":

                    try
                    {
                        positionX++;
                        positionStart = card[positionX, positionY];
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(positionStart);
                        Console.ResetColor();

                        monsterRate = random.Next(0, 2);

                        if (monsterRate == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Attention ! Vous vous faîtes attaqué !");
                            Console.ResetColor();
                            Battle battle = new Battle(player);

                        }
                        else
                        {
                            movePlayer(player);
                        }
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Il n'y a que l'océan par là ,vous ne pouvez aller dans cette direction");
                        Console.ResetColor();

                        movePlayer(player);
                    }

                    break;

                case "West":
                case "west":


                    try
                    {
                        positionX--;
                        positionStart = card[positionX, positionY];
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(positionStart);
                        Console.ResetColor();

                        monsterRate = random.Next(0, 2);

                        if (monsterRate == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Attention ! Vous vous faîtes attaqué !");
                            Console.ResetColor();

                            Battle battle = new Battle(player);

                        }
                        else
                        {
                            movePlayer(player);
                        }
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Il n'y a que l'océan par là ,vous ne pouvez aller dans cette direction");
                        Console.ResetColor();

                        movePlayer(player);
                    }

                    break;

                case "Info":
                case "info":

                    player.playerInfo(player);
                    movePlayer(player);

                    break;

            }


        }
    }

}