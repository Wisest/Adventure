/*
 * [Dara Adventure]
 * by MrWisest, 15 of July 2018
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */
using System;
using System.Collections.Generic;

namespace Adventure
{
    static class Utility
    {
        public static void ColorTheme()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

        }
        public static void NextLine()
        {
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
            ColorTheme();
        }
    }
    public static class Game
    {
        static bool Run = true;
        static string PlayerName = "Dara";
        static int ScenesCount = 4;
        static List<string> Inventory = new List<string>();
        static Dictionary<string, int> InputDic = new Dictionary<string, int>() { { "a", 1 }, { "b", 2 }};
        static string[][] Scenes = new string[4][];

        static void FillScenes()
        {

        
            Scenes[0] = new string[]
            {

                //Choice introduction and options
                "Okay, now that I know your name, you're going to focus very hard on this part.\n" +
                    "It's not really hard, but you have to remember it for the rest of your life.\n" +
                    "Okay, now that I have your attention, I'm going to talk. Like... a lot.\n" +
                    "But each time I will ask you something, we'll have a little code between us.\n" +
                    "Really simple I promise. When there is two choices, you write a \"A\", for the first choice.\n" +
                    "And \"B\" for the second choice. If you understood, type \"A\", if you didn't, type \"B\".",

                // Depending on choice one of two paths is shown
                "Woaw, you're the very first to pass this test. Well, you are also the first to try.\n" +
                    "But don't think less of you, as you're gonna have the honor of trying the second test !",
                "I guess I'm with a little joker. Well, okay, it was funny. Now, let's be serious.\n" +
                    "Here goes the second test !",

                //Story continues (for both paths)
                "This one is a bit tricky, give it your all.\n" +
                    "Do you remember which one is the letter for the third choice ?",
                //Player has something different happen depending on choice made and path - perhaps finding an item (like a coin)
                "Sorry pal, I never talk about a third choice. It was a trap, and even though I'm sure you were tempted to write \"C\",\n" +
                    "You didn't, and shame on you. This story could have more than two choices at some point.\n" +
                    "So you'd better be prepared to adapt to the situation, I won't ever be there to help you !\n" +
                    "Well, as a manner of speach, because otherwise, I'll follow you everywhere.",
                /*"Sorry pal, I never talk about a third choice. It was a trap, and even though I'm sure you were tempted to write \"C\",\n" +
                    "You didn't, and shame on you. This story could have more than two choices at some point.\n" +
                    "So you'd better be prepared to adapt to the situation, I won't ever be there to help you !\n" +
                    "Well, as a manner of speach, because otherwise, I'll follow you everywhere.",*/
                "Oh my, we have a champion ! I didn't expect you to be this ressourceful and advanced.\n" +
                    "I never actually talked about a third choice, but you prove me that you can adapt to the situation.\n" +
                    "This is good, as in this story, there won't always be only two choices.",
                // text that will transition to the next part of the game
                "Now that you know more about how I work, let's dive into the story !",


            };
            Scenes[1] = new string[]
            {

                //Choice introduction and options
                "Would you like to play the story as Dara or her companion ?",

                // Depending on choice one of two paths is shown
                "You chose to play as Dara. Great !",
                "You chose to play with the companion. Sorry, but the question was rethoric.\n" +
                    "You actually HAVE TO play as Dara. As the jacket says : DARA and the Hobhan.\n" +
                    "Not The companion of Dara and the Hobhan. That would would have been ridiculous\n" +
                    "Please excuse us for the inconveniance",

                //Story continues (for both paths)
                "Okay, now that it's settled. Let's talk about what happens now.",
                //Player has something different happen depending on choice made and path - perhaps finding an item (like a coin)
                "As you chose Dara, you surely want to know more about her and why we're telling you her story.\n" +
                    "She's what you should expect from a child of ten years old.\n" +
                    "Joyful, always running everywhere and super curious about pretty much everything.\n" +
                    "She lives in a little village in the mountain named Baelmor.",
                "As you chose the companion of Dara, you surely want to know more about him and why we're including him in her story.\n" +
                    "Well, sorry, but it's a secret. Now, let's talk about Dara. She just turned ten last month.\n" + 
                    "As any child her age, she is joyful and running everywhere. Curiosity, O my lady.",
                // text that will transition to the next part of the game
                "Now that you know more about Dara, let's go and see what she's doing right now.",


            };
            Scenes[2] = new string[]
            {

                //Choice introduction and options
                "She is home right now. The sun is almost hidden by the mountain.\n" +
                    "We bet you didn't know you could influence her action ?\n" +
                    "Let's try. You could choose to get her out of bed and have a look at the setting sun.\n" + 
                    "Or you could choose to get her out of bed and play with her bow.\n" +
                    "Which will it be, play or look at the sun?",


                // Depending on choice one of two paths is shown
                "You chose to make her play with the bow.\n" +
                    "She's not very accurate yet, but with pratice, everything's possible.\n" +
                    "Playing with the bow made her hungry. Well played... Very well played.",
                "You chose to have her look at the sun. She think the sun looks like a big pommeroc who just got out the oven.\n" +
                    "Now, she's hungry. Well played... Very well played.",


                //Story continues (for both paths)
                "Okay, you made her hungry. Let's see what she choose to eat for herself without interfering.\n" +
                    "Just remember, every decision you make to influence her have consequencies. So, choose wisely,\n" +
                    "when, and what to do. Her life is in your hands now.\n" +
                    "No pressure.",
                //Player has something different happen depending on choice made and path - perhaps finding an item (like a coin)
                "Owh, look ! She's going in the direction of the field of pommeroc.\n" +
                    "It must be the setting sun which made her think about it.\n." + 
                    "It actually looks like a big pommeroc when it's going down behind the mountain. Orange, hot and kind of crumbly.\n" +
                    "We're talking about the pommeroc here, not the sun. Obviously.",
                "Owh, look ! She's going in the direction of the field of pommeroc.\n" +
                    "She actually want to make some now.",
                // text that will transition to the next part of the game
                "Only one of them would be enough as she took one as big as her head.\n" + 
                    "Whoops.. That's her father there, waiting by the door of their little wooden shack.\n" +
                    "It's not much to look at, but it protect them from the elements. That is all that matter.\n" +
                    "Let's hope her dad is not too worried.",


            };
            Scenes[3] = new string[]
            {

                //Choice introduction and options
                "Her dad just seems to be happy she is home safe and send her to bed.\n" +
                    "Would you like to make Dara insist on making hot pommeroc or respect her dad's wish ?",


                // Depending on choice one of two paths is shown
                "You chose to make her cook. She look at her dad with stars in the eyes, the pommeroc in her two little hands.\n" +
                    "It is not long before her dad grant her a last meal at the condition she doesn't do it too often.\n" +
                    "The oven still had some red embers. It didn't took long for Dara to make it burst into flame\n" +
                    "The pommeroc have to be put through rought flame to soften the skin and make the flesh crumbly.\n" +
                    "Otherwise, you would break your knife and then your teeth before having the chance of pleasing your delicate palate",
                "You chose to have her sleep. She look the pommeroc with a great appetite and hesitation.\n" +
                    "But rapidly, she reluctantly put it aside with the firm intention of having it tomorow.\n" +
                    "Her dad offer to help her and even suggest of having it with some fish from the next village.\n" +
                    "A detail which rapidly makes her rejoice.",


                //Story continues (for both paths)
                "Time to get her to bed. Her room is upstairs. Dara's bed is right by the only window of the room.\n" +
                    "She can see the night sky and the sunrise all year around.\n" +
                    "Oh, look, on the bed ! There is a book about fantastic beasts. No wonder a child her age have that sort of book.\n" +
                    "But, this one is special. It's about beasts of Argrimor. The kind you don't see everyday, nor twice in a life.\n" +
                    "She seems pretty interested in this one. The Hobhan... Hm, it reminds me of a story... Sorry, I can't remember.\n" +
                    "Classic me. Well, let her rest for now, we'll come back later. Let's have a look around the house while she sleeps.\n" +
                    "It may helps you understand the world around better.",
                //Player has something different happen depending on choice made and path - perhaps finding an item (like a coin)
                "Downstairs, her dad eats what's left of the hot pommeroc.\n" +
                    "He is still smiling, even laughting. Thinking about his own childhood.",
                "Downstairs, her dad is hungry too, but he knows what demons he would be against tomorow if he\n" +
                    "actually tried to eat her pommeroc. She reminds him of his own childhood.",
                // text that will transition to the next part of the game
                "Don't you wonder where her mother is ?",


            };
        }


        static void Choice()
        {
            for (int section = 0; section <= ScenesCount; section++)
                {

                    string strInput = "";
                    int i = 0;

                    Console.WriteLine(Scenes[section][0]);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write("Enter your choice: ");
                    //récupérer le string
                    strInput = Console.ReadLine();
                    strInput = strInput.ToLower();
                    //Puis obtenir dans le dictionnaire l'entier associé à ce string
                    int intInput = InputDic[strInput];

                    Console.ResetColor();


                    while (i < (Scenes[section].Length - 1))
                    {
                        i = CurrentIndex(intInput, i, section);
                    }
                }
        }
        static int CurrentIndex(int input, int i, int j)
        {
            i += input;
            Console.WriteLine(Scenes[j][i]);
            i += (InputDic.Count + 1) - input;
            Console.WriteLine(Scenes[j][i]);
            return i;
        }




        static void TitleScreen()
        {

            //print out game title and overview
            Console.Title = "Dara : l\'appel du Hobhan";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
                _____                                      _         _           
               (____ \                                    | |   _   | |          
                _   \ \ ____  ____ ____     ____ ____   _ | |  | |_ | | _   ____ 
               | |   | / _  |/ ___) _  |   / _  |  _ \ / || |  |  _)| || \ / _  )
               | |__/ ( ( | | |  ( ( | |  ( ( | | | | ( (_| |  | |__| | | ( (/ / 
               |_____/ \_||_|_|   \_||_|   \_||_|_| |_|\____|   \___)_| |_|\____)
                                                                         
                             _     _       _     _                 
                            | |   | |     | |   | |                
                            | |__ | | ___ | | _ | | _   ____ ____  
                            |  __)| |/ _ \| || \| || \ / _  |  _ \ 
                            | |   | | |_| | |_) ) | | ( ( | | | | |
                            |_|   |_|\___/|____/|_| |_|\_||_|_| |_|
                                                           


                      ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("              A deep adventure in the heart of the Argrimor Mountains");
            Console.WriteLine("              Press Enter to continue");
            Console.ReadKey();
            Utility.ColorTheme();
        }
        static void GetCharName()
        {

            //ask player for a name, and save it
            Console.WriteLine("What's your name ?");
            PlayerName = Console.ReadLine();
            Console.WriteLine("Then, welcome to Baelmor, " + PlayerName + " !");
        }

        static void EndGame()
        {
            //exit application
            Console.WriteLine("To be continued...");
            Console.WriteLine("While you wait for the next part of the story, here is what you made Dara find, or make :\n");
            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }

            if (Inventory.Contains("bow"))
            {
                Console.WriteLine("You let Dara play with her bow. She likes it very much. At least as much as a hot pommeroc");
            }
            else
            {
                Console.WriteLine("You didn't let Dara play with her bow. You're lucky she also like to look at a the sunset.");
            }
            if (Inventory.Contains("hot and crumbly pommeroc"))
            {
                Console.WriteLine("You let Dara cook the pommeroc. Even her dad liked it !");
            }
            else
            {
                Console.WriteLine("You let Dara go hungry. Now her dad is too. ");
            }

            Console.WriteLine("\nPress enter to exit the application");
            Console.ReadKey();
        }
        public static void Play()
        {
            TitleScreen();
            while (Run == true)
            {
                Choice();
            }
            EndGame();
        }
    }
    public class Item
{
    //constructor
    public Item()
    {
        Random randomNumber = new Random();
        int number;
        number = randomNumber.Next(Items.Length);
        Name = Items[number];
        Description = Descriptions[number];
    }
    public string Name = "Small pebble";
    public string Description = "Don't throw it on windows, it could break them.";

    string[] Items = { "pommeroc", "bow", "quiver", "arrows", "book" };
    string[] Descriptions =
    {
            "As hard as a rock if you don\'t put it in the fire",
            "This bow is made of simple wood",
            "A quiver made from some animal of the mountain",
            "Those arrows are just made of wood",
            "This book is actually speaking of the Hobhan"
        };



}
    class Program
    {
        static void Main(string[] args)
        {
            Game.Play();
        }
    }
}

