using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Card_Problem_Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            bool gamerunning = false;
            do
            {
                Console.WriteLine("1.Play Game");
                Console.WriteLine("2.Exit");
                option = int.Parse(Console.ReadLine());
                Console.Clear();

                while (gamerunning) ;
                Deck obj = new Deck();
                if (option == 1)
                {
                    gamerunning = true;
                    int score = 0;
                    obj.shuffle();
                    Card pcard = obj.dealcard(); //Picking a card from shuffled cards
                    while (gamerunning)
                    {
                        int remain_check = obj.cardleft();
                        Card card2 = obj.dealcard();
                        Console.WriteLine("**********************************");
                        Console.WriteLine(pcard.getvalueasstring());
                        Console.WriteLine("");
                        Console.WriteLine("****Remaining Cards****: " + remain_check);
                        Console.WriteLine("Enter 1 if the next card is higher: ");
                        Console.WriteLine("Enter 2 if the next card is lower: ");
                        int card_check = int.Parse(Console.ReadLine());
                        if (card_check == 1)
                        {
                            if (pcard.getvalue() >= card2.getvalue())
                            {
                                score++;
                                card2 = pcard;
                            }
                            else
                            {
                                gamerunning = false;
                                Console.WriteLine("You Lose.");
                                Console.WriteLine("The card was: " + card2.getvalueasstring());
                                Console.WriteLine("The Score is: " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if (card_check == 2)
                        {
                            if (pcard.getvalue() < card2.getvalue())
                            {
                                score++;
                                card2 = pcard;
                            }
                            else
                            {
                                gamerunning = false;
                                Console.WriteLine("You Lose.");
                                Console.WriteLine("The card was: " + card2.getvalueasstring());
                                Console.WriteLine("The Score is: " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if (obj.cardleft() == 0 && obj.dealcard() == null)
                        {
                            gamerunning = false;
                            Console.WriteLine("Congrats! You have scored Maximum.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
            }

            while (option != 2);
        }
    }
}
