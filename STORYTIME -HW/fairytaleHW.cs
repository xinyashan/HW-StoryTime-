using System;

namespace Homework_StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GAME BEGIN...!");
        }
    }
}

Console.WriteLine("Zombie apocalypse in wonderland");
            Console.WriteLine("Hello citezen... it seems that the town has been caught up in a zombie war. Buildings are destroyed, there's almost no food left, and the place is infested with zombies.");
            Console.WriteLine("The once joyous wonderland has been turned upside down. There is a glimpse of hope left however.");
            Console.WriteLine("You have beens supplied with the following items: Half eaten sandwhich, potions, and a first aid kit.");
            Console.WriteLine("There is a merchant over there in the corner. Please trade your items with him wisely so that you can be ready for your mission!");
            Console.WriteLine("This merchant will ask you some tricky questons so be careful...");

            String character1;
character1 = "Hello";
            Console.WriteLine(character1);



            //COMPLETED 

            int numbers;

string trade;


int prices;

string characteritem;





trade = Console.ReadLine();
            Console.WriteLine("MERCHANT: I see you want to trade. I am interested in your sandwhich as i am starving from working so hard. Answer this for me... How many sandwhiches does it take before I am full?");
            numbers = Convert.ToInt32(Console.ReadLine());
            if (numbers >= 100)
            {
                Console.WriteLine("Yes " + trade + "your" + trade + "correct!");



            }

            else
            {
                Console.WriteLine("Well to each to their own.");
            }
            Console.WriteLine("Interesting answer I see I see.");


         


            characteritem = Console.ReadLine();
            Console.WriteLine("MERCHANT: I am pleased with the trade you have made me. How about another trade?");
            Console.WriteLine("It appears I am in need of a first aid kit. I will trade you this twenty dollars! What is your answer? ");
            Console.WriteLine("[Please enter the amount of cash you are willing to accept!");
           prices = Convert.ToInt32(Console.ReadLine());
            if (prices >= 100)
            {
                Console.WriteLine("Yes " + trade + "this" + prices + "item is now mine");

            }



            else
            {
                Console.WriteLine("Well you don't want to take too much now but this fair for now.");
            }



            Console.WriteLine("Yes");

            characteritem = Console.ReadLine();
            Console.WriteLine("MERCHANT: Trading with you have also helped me acquire some items I need so I can fend off the zombies.");
            Console.WriteLine("This city is known for having the best food in town. Makes sense why zombies want to take over now right?");
            Console.WriteLine("Our city is has a captivating history as it is called LE SOUL FOOD!  ");
            Console.WriteLine("The capital city that has the best food in the world! Food is truly happiness but these zombies have invaded their way into our land.");
            Console.WriteLine("Enough chit chat lets continue to trade so you can be on your way to save the city");

            characteritem = Console.ReadLine();
            Console.WriteLine("MERCHANT: Alright now that I have more energy from the sandwhich you gave me let us begin.");
            Console.WriteLine("A word of warning zombies have a sharps sense of smell. I recommend you buy this demon spray.");
            Console.WriteLine("It defiantly costs all the money I gave you earlier but looking");
            Console.WriteLine("at a time like this...I guess I will bargain with you. Enter your price!"); 


            prices = Convert.ToInt32(Console.ReadLine());

            if (prices >= 500)
            {
                Console.WriteLine("Very well I will gladly take it");

            }



            else
            {
                Console.WriteLine("Hmm not what i am expecting...");
            }

        }

    }

}