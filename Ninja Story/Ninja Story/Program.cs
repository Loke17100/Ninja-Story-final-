using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja_Story
{
    class Program
    {
        static void Main(string[] args)
        {
            int introLoop = 2;
            int NameLoop = 0;
            int GameLoop = 0;
            int BattleLoop = 0;
            string name;
            string input;
            string gameinput;
            name = "";
            gameinput = "";
            input = "";
            Player Mainplayer = new Player();
            Monster Slugmonster = new Monster();

            Slugmonster.
            Mainplayer.PlayerHealth = 100;


            while (introLoop == 2)
            {
                Console.WriteLine("Welcome to ninja Story!");
                Console.WriteLine("for a New game click: 1");
                Console.WriteLine("to quit click on: Q");
                input = Console.ReadLine();
                if (input == "1")
                {
                    introLoop = 3;
                    NameLoop = 2;

                }
                else
                {
                    //exit the game(ask the teacher.)

                }
            }


            while (NameLoop == 2)
            {

                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();

                if (name != null)
                {
                    Console.WriteLine("Welcome " + name + " to your ninja story!");
                    Console.WriteLine("press Q at anytime to quit the game!");
                    Console.WriteLine("Press C to continue.");

                    NameLoop = 3;
                    GameLoop = 2;

                }

            }

            while (GameLoop == 2)
            {


                if (Mainplayer.PlayerHealth != 0)
                {
                    gameinput = Console.ReadLine();
                    if (gameinput == "q")
                    {
                        //then exit game 
                        Console.WriteLine("hello, its me....");
                        GameLoop = 1;
                        Mainplayer.PlayerHealth = 0;
                    }
                    else
                    {


                        Console.WriteLine("Father: hello my son " + name + " you must eneter the cave of dreams");
                        Console.WriteLine("inorder to test your ninja skills,");
                        Console.WriteLine("I will be at the end of the cave to greet you.");
                        Console.WriteLine("You Enter the cave and you find too doors");
                        Console.WriteLine("pick a to enter the right door pick b to enter the left door.");
                        gameinput = Console.ReadLine();



                        if (gameinput == "a")
                        {

                            Console.WriteLine("you enter the room to find a chest in the middle of the room.");
                            Console.WriteLine("click a to open the chest or click b to keep moving");
                            gameinput = Console.ReadLine();
                            if (gameinput == "a")
                            {
                                Console.WriteLine("you find a Katana! your weapon damage goes up by 30 and you gain one level!");
                                Console.WriteLine("you then leave the room.");
                                Console.WriteLine("you enter the room, in the far left there is a Giant Slug what do you do!? ");

                                Console.WriteLine("use Katana: a");
                                Console.WriteLine("use basic attack: b");
                                Console.WriteLine("use Special attack: c");
                                gameinput = Console.ReadLine();






                            }
                            else 
                            {
                                Console.WriteLine("you enter the room, in the far left there is a Giant Slug what do you do!? ");

                                Console.WriteLine("attack using your weapon: a");
                                Console.WriteLine("use basic attack: b");
                                Console.WriteLine("use Special attack: c");
                                gameinput = Console.ReadLine();


                            }



                        }


                    }

                }
                else
                {
                    Console.WriteLine("GameOver!");
                    GameLoop = 100;
                }

            }






        }
    }
}
