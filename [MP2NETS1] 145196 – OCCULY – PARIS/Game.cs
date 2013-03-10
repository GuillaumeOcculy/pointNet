using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MP2NETS1__145196___OCCULY___PARIS
{
    class Game
    {
        public void start()
        {
            Introduction();
            Menu();
            playGame();
            Console.ReadLine();
        }







        private void Introduction()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###############################################################################");
            Console.WriteLine("#                                   Asthenia                                  #");
            Console.WriteLine("#                              2NET - Mini-Projet                             #");
            Console.WriteLine("###############################################################################");
            Console.ResetColor();
            
        }

        private void Menu()
        {
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("MAIN MENU :");
            Console.WriteLine("1. Create New Game");
            Console.WriteLine("2. Load Save Game");
            Console.WriteLine("3. About");
            Console.WriteLine("4. Exit");
            


            int choiceMenu = 0;
       

            while (choiceMenu>4 || choiceMenu<1)
            {
                Console.Write(">");
               choiceMenu = int.Parse(Console.ReadLine());
                switch (choiceMenu)
                {
                    case 1:
                        Console.WriteLine("You chose to create a new Game");
                        initialisePlayer();
                        break;

                    case 2:
                        Console.WriteLine("You chose to load a game");
                        break;

                    case 3:
                        Console.WriteLine("About");
                        break;

                    case 4:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Please choose a number between 1 and 4 : ");
                        break;
                        
                }

            }

            

        }

        public void initialisePlayer()
        {
            string name = "";
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("What's your name ?");
                Console.Write(">");
                name = Console.ReadLine();
            }
                   
            Player player = new Player(name, 0, 1200, 1200, 1);

            player.playerInfo(player);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
           
        }

        public void playGame(Player player, Map map)
        {
            
            map.cardLand(player);
        }


    }
}
