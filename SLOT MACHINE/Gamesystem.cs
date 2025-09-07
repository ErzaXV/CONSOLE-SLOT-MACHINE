using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLOT_MACHINE
{
    internal class Gamesystem
    {
        public void system()
        {
            {
                Console.WriteLine("ENTER USERNAME");
                String Username = Console.ReadLine();
                Console.WriteLine("ENTER PASSWORD");
                String Password = Console.ReadLine();
                Console.WriteLine("ENTER MONEY");
                int Cash = Convert.ToInt32(Console.ReadLine());
                USER_DATA uSER_DATA = new USER_DATA(Username, Password, Cash);

                int count = 0;

                while (true)
                {
                    Random random = new Random();
                    string[] symbols = { "7","CHERRY","LEMON"};

                    string random1 = symbols[random.Next(symbols.Length)];
                    string random2 = symbols[random.Next(symbols.Length)];
                    string random3 = symbols[random.Next(symbols.Length)];

                    Console.WriteLine("PRESSS A TO START GAMBLE");
                    Console.WriteLine(uSER_DATA.Publiccash);
                    string START = Console.ReadLine();

                    if (START == "A")
                        {
                            if (random1 == "7" && random2 == "7" && random3 == "7")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("_________________________________");
                                Console.WriteLine(random1);
                                Console.WriteLine(random2);
                                Console.WriteLine(random3);
                                Console.WriteLine("jackpot");
                                Console.WriteLine("_________________________________");
                                uSER_DATA.Publiccash += 10;
                            }
                            else if (count == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("_________________________________");
                                Console.WriteLine("7");
                                Console.WriteLine("7");
                                Console.WriteLine("7");
                                Console.WriteLine("jackpot");
                                Console.WriteLine("_________________________________");
                                uSER_DATA.Publiccash += 10;
                                count = 0;
                            }
                            else if (uSER_DATA.Publiccash == 0)
                            {
                                Console.WriteLine("You have no money left");
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("_________________________________");
                                Console.WriteLine(random1);
                                Console.WriteLine(random2);
                                Console.WriteLine(random3);
                                Console.WriteLine("not jackpot");
                                Console.WriteLine("_________________________________");
                                uSER_DATA.Publiccash -= 10;
                                count++;
                            }
                        }
                }
            }

        }
    }
}
