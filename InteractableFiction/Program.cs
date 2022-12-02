using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractableFiction
{
    internal class Program
    {
        static string[] pageElements;
        static bool GameOver = false;
        static ConsoleKeyInfo choice;

        //the story, choices and page numbers
        static string[] story = new string[16]
        {
            "0After weeks of travelling, you finally arrive at the cave of wishes. You enter the cave and assess your options: Before you lies two entrances. A tunnel deeper into the cave, and a passage to the left...;Take the passage to the left;Take the tunnel down;1;2",
            "1You take the passage to the left and find yourself in a room covered in spiderwebs. You can keep moving, or try to peel the webs off a treasure chest...;Keep moving;Open the treasure chest;3;5",
            "2You find yourself in a room more beautiful than you thought was possible. The walls are made of white and blue crystals, reflecting brilliant light all over. You see a magnificently carved crystal door on the other side of the room, but in the middle of the enormous room is a small pond, aand you realize you are quite thirsty...; Approach the door; Have a drink and then approach the door;7;6",
            "3You move through the spider room, and follow a passage that seems to run deeper into the cave. You think you see a light down one passage, but you suddenly hear someone call out 'Hello? Can anyone hear me? Please Help! I've been lost for days!' Down another passage...; Follow the calls for help;Ignore them and follow the light;4;2",
            "4You follow the voice down the passage. As you creep through the tight tunnel, the voice becomes more and more desperate. You finally arrive, and see who was calling for help: Chris Pratt's Mario. His teeth glimmer as he bares his fangs in a cruel smile. Before you can react, he cackles and lunges at you. Your face got eaten, BETTER LUCK NEXT TIME",
            "5As you start peeling off the spiderwebs, the chest rumbles and bursts open, letting thousands of spiders the size of hands crawl onto you. You are bitten hundreds of times before you finally die.You got killed by enough venom to kill, like, a thousand elephants, BETTER LUCK NEXT TIME",
            "6You kneel down to get a handful of water and instantly die. It turns out, that wasn't water. It was sulfur, and as soon as you kneeled down, you inhaled some of the invisible sulfur gas that was floating lower than the air. You didn't notice it at first, because sulfur is heavier than normal air, but once you inhaled a bit of it, it killed you instantly. Maybe you should have paid more attention in chemistry. You were killed by science, BETTER LUCK NEXT TIME",
            "7You approach the door, getting ready to open it, when it opens for you...;Go home because that was kind of creepy;Enter the final room of the cave;8;9",
            "8You decide that this whole adventure just isn't worth it, and that you can live without a magical wish. As soon as you step outside, you are greeted by fresh air, a beautiful, warm sunshine, and a knife to the ribs. You realize the assassin who blames you for his family's death has finally found you, and you suddenly remember why you needed to make a wish in the first place. You were killed by a simple misunderstanding, BETTER LUCK NEXT TIME",
            "9Inside the room stands a great, stone giant. He smiles and asks you why you have come.; I've come for a wish; Be sarcastic;10;11",
            "10The giant nods and tells you 'if you want a wish, you must answer my riddle'. He pulls out his phone and reads a riddle off of Reddit. 'What do you call a cat that has too many whiskers?';Ask him if you can skip the riddle;Pull out your own phone to look up the answer;12;13",
            "11Intimidated by the giant, you stammer out 'B-b-b-be sarcastic'. Realizing you just said that out loud, you literally die of cringe. BETTER LUCK NEXT TIME",
            "12The giant says 'Yeah that's fine' and asks you what you wish for; Wish for an end to your death loop; Wish for a popiscle that never melts;14;15",
            "13Your Tesla phone explodes in your hand. You were killed by the Twitter CEO, BETTER LUCK NEXT TIME",
            "14You tell him that you don't want to be immortal anymore, and that the next time you die you don't want to restart at an ealier point in life. You tell him all the ways you've tried top die. You fed yourself to spiders, you inhaled sulfur, but none of it worked. You even killed the family of a notorious assassin in the hopes that HE could kill you, because you want to finally die and be with your family. The giant tells you that because you killed innocent people and feel no remorse, it is unlikely that you will see the same afterlife as your family. Realizing this, you decline to wish, and leave the cave. The giant, knowing you'll be back when you feel you've redeemed yourself, tells you 'BETTER LUCK NEXT TIME'",
            "15You try to lick your ever-cold popsicle, but as soon as your tongue touches it, it sucks all the heat from your body and you die. You realize now that popsicles need to melt to be eaten. You were killed by a bad idea, BETTER LUCK NEXT TIME."
        };

        static int currentPage=0;
        static void Main(string[] args)
        {
            //the game loop
            while (GameOver == false)
            {
                Console.Clear();

                DisplayScreen();

                choice = Console.ReadKey(true);
                if (choice.KeyChar == 'a')
                {
                    currentPage = int.Parse(pageElements[3]);
                }

                if(choice.KeyChar == 'b')
                {
                    currentPage=int.Parse(pageElements[4]);
                }

                
            }

        }
        //What is written on the screen
        static void DisplayScreen()
        {
            pageElements = story[currentPage].Split(';');
            
            Console.WriteLine(pageElements[0]);
            //when it's not an ending
            if(pageElements.Length > 1)
            {
                Console.WriteLine("WHAT DO YOU DO?");
                Console.Write("Press A:");
                Console.WriteLine(pageElements[1]);
                Console.Write("Press B:");
                Console.WriteLine(pageElements[2]);
            }

            
            //when it is an ending
            else
            {
                //if it's the true ending.
                if (currentPage == 14)
                {
                    Console.WriteLine("Press any key (aside from A or B) to quit the game");
                    Console.ReadKey(true);
                    GameOver = true;
                }
                //if it's a normal ending
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press Any Key (aside from A or B) to restart");

                    Console.ReadKey(true);

                    currentPage = 0;
                }
            }

        }
    }
}
