using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    internal class Program
    {

        static string[] story = new string[]{
            "You awake in a dark and foggy forest. The forest is dense besides a small dirt road before you.;Follow the trail;Try the woods;1;0",                                           //0
            "You follow the trail to a fork in the road. To your left is the sound of running water, and to your right a faint light.;Go left;Go right;2;0",                                //1
            "You come across a rushing river. The river seems to have washed up a few dead trees;Swim Across;Make a bridge;3;4",                                                            //2
            "As you attempt to swim accross, the strong river ends up pulling you under. The last thing you see are the rocks under the river.",                                            //3
            "You place a dead tree accross the river and cross it. You hear a howling from the woods, much lowder than an ordinary wolf.;Keep to the trail;Hide in the woods;5;0",          //4
            "You follow the trail, eventually finding an abandonned campsite, with two closed tents and a still burning campfire.;Examine the camp;Move on;6;0",                            //5
            "The tent on the left is completely empty, but the one on the left has a dead body within it. There's something in it's hand.;Look closer;Leave it alone;7;0",                  //6
            "Looking closer you see that it's a dagger, if the engraving on the side is to be believed it's made of pure silver;Take it; Leave it alone;8;0",                               //7
            "The dagger has a bit of weight to it. As you continue down the trail you see another fork in the road. Both paths seem identical.;Go left;Go right;9;0",                       //8
            "You continue walking down the trail when you hear a branch snap to your left. You only have a moment to prepare to...;Attack;Run;10;24",                                       //9
            "A monstrous mockery of a wolf jumps out at you when you slash at it with the dagger, cutting it's arm. It falls to the ground.;Examine it;Run;11;12",                          //10
            "As you get closer to the figure it suddenly lashes out at you. It's claws tear at your ankle as you fall down beside it.",                                                     //11
            "With the creature injured you take your chance to make a break for it. As you run the thing gets back up and begins to chase you.;Duck into the forest;Attack again;13;14",    //12
            "You duck into the forest in an attempt to lose the creature. You realize you failed when a claw sinks into your shoulder.",                                                    //13
            "As you prerpare to attack again you see the figure jump at you. Before you can attack you need to avoid being attacked.;Roll;Duck;15;16",                                      //14
            "You roll to the side as the creature soars past and falls to the ground. It begins to get back up, hindered by it's injured arm.;Stab it's side;Stab it's head;17;18",         //15
            "As you duck beneath it's claws, the rest of it simply falls on top of you. It gets off you before, again, you see it's claws.",                                                //16
            "You stab it in the upper torso below it's arms hoping to cause some damage. It seems to work as the creature stops trying to get up.;Finish it;Just leave;19;20",              //17
            "You try to stab it in the head, but stabs it's shoulder instead. A sudden hit to your side sends you hurtling into a tree.",                                                   //18
            "You quickly grab the dagger from it's side and stab it in the neck. With one last swipe it gives you a small cut on the arm.;Follow the trail;Take a breather;21;22",          //19
            "As you turn to leave the creature uses the last of it's energy to bite your ankle, shattering it. The creature dies finally dies;Follow the trail;Take a breakther;23;22",     //20
            "You walk down the trail to find your car of all things. You drive to the hospital hoping your small cut doesn't get infected.",                                                //21
            "You lie against the creature for a quick breather. When you get up to leave you find that the silver dagger now burns your hand.",                                             //22
            "As you try to walk, your shattered ankle makes you collapse. While you may have defeated the creature, you aren't leaving.",                                                   //23
            "A monstrous mockery of a wolf jumps out of the woods and begins to chase after you. It quickly catches up and jumps at you;Block;Dodge;25;36",                                 //24
            "You raise your arm right as the creature bites it. You fall back with the creature on top of you.;Stab it; Bite it;26;27",                                                     //25
            "You stab the creature in the eye causing it to lurch back, tearing half your arm off as it does.;Stab it again;Run;28;35",                                                     //26
            "You bite the creatures nose. This proves unhelpful as it tears your arm off, and a clawed hand is run through your chest.",                                                    //27
            "As you go to stab it again, the creature starts flailing its arms wildly preventing you from getting closer.;Wait for an opening;Rush in anyways;29;30",                       //28
            "As you wait for an opening you notice that the silver dagger seems to be getting hotter in your hand. Soon it will start to burn.;Drop it;Throw it;31;32",                     //29
            "You rush in anyways, only for a clawed hand to slash you accross the face before another one bats you towards a tree.",                                                        //30
            "You drop the dagger and turn to run when you stop in your tracks. You look down to see a clawed hand coming out of your chest.",                                               //31
            "You throw the dagger right into the creature's throat. The creature falls dead. Now you just need to find a way to patch up your arm.;Use sweater;Use leaves;33;34",           //32
            "You tie your sweater around your arm to try and stop the bleeding. You leave the forest and find your car. How are you gonna drive?",                                          //33
            "You tie leaves around your arm as tightly as you can and continue down the trail. You start getting dizzy and take a long nap.",                                               //34
            "Luckily the creature doesn't seem to notice you, now more concerned with it's injury. You still have to patch up your arm though.;Use sweater;Use leaves;33;34",               //35
            "You try to dodge only to trip on a root. You get up as quickly as you can only to feel claws slash at your back.",                                                             //36





            "The End!"
        };

        static bool gameOver = false;

        static string[] page;
        static int currentPage = 0;
        static int menuPos = 5;
        static ConsoleKeyInfo input;

        static void Main(string[] args)
        {
            Console.SetWindowSize(49, 13);
            WritePage(currentPage);
            while(gameOver == false)
            {
                input = Console.ReadKey(true);
                if(input.Key == ConsoleKey.LeftArrow || input.Key == ConsoleKey.A){
                    DrawCursor(0);
                }else if (input.Key == ConsoleKey.RightArrow || input.Key == ConsoleKey.D)
                {
                    DrawCursor(1);
                }else if(input.Key == ConsoleKey.Escape)
                {
                    gameOver = true;
                }else if(input.Key == ConsoleKey.Enter)
                {
                    if(menuPos == 0 || menuPos == 1)
                    {
                        WritePage(int.Parse(page[3 + menuPos]));
                    }
                }
            }
            Console.ReadKey(true);
            WritePage(story.Length - 1);
            Console.ReadKey(true);
        }

        static void DrawCursor(int pos)
        {
            menuPos = pos;
            if(pos == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red; //
                Console.SetCursorPosition(2, 8);            //
                Console.Write("+--------------------+");    //
                Console.SetCursorPosition(2, 9);            //
                Console.Write("|");                         //  Draw Current Menu Pos
                Console.SetCursorPosition(23, 9);           //
                Console.Write("|");                         //
                Console.SetCursorPosition(2, 10);           //
                Console.Write("+--------------------+");    //

                Console.SetCursorPosition(25, 8);               //
                Console.Write("                      ");        //
                Console.SetCursorPosition(25, 9);               //
                Console.Write(" ");                             //  Erase Old Menu Pos
                Console.SetCursorPosition(46, 9);               //
                Console.Write(" ");                             //
                Console.SetCursorPosition(25, 10);              //
                Console.Write("                      ");        //
            }
            else if(pos == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(25, 8);               //
                Console.Write("+--------------------+");        //
                Console.SetCursorPosition(25, 9);               //
                Console.Write("|");                             //  Draw Current Menu Pos
                Console.SetCursorPosition(46, 9);               //
                Console.Write("|");                             //
                Console.SetCursorPosition(25, 10);              //
                Console.Write("+--------------------+");        //

                Console.SetCursorPosition(2, 8);            //
                Console.Write("                      ");    //
                Console.SetCursorPosition(2, 9);            //
                Console.Write(" ");                         //  Erase Old Menu Pos
                Console.SetCursorPosition(23, 9);           //
                Console.Write(" ");                         //
                Console.SetCursorPosition(2, 10);           //
                Console.Write("                      ");    //
            }
        }

        static void DrawUI()
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine(" +---------------------------------------------+");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" |                                             |"); //line is 43 characters long
            }
            Console.WriteLine(" +----------------------+----------------------+");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" |                      |                      |");
            }
            Console.WriteLine(" +----------------------+----------------------+");
        }

        static void WritePage(int pageNum)
        {
            menuPos = 5;
            Console.ResetColor();
            Console.Clear();
            DrawUI();
            currentPage = pageNum;
            page = story[pageNum].Split(';');


            List<string> pageContents = new List<string>                    //
            {                                                               //
                                                                            //
            };                                                              //
            List<char> tempPageContents = new List<char>                    //
            {                                                               //
                                                                            //
            };                                                              //
            for (int i = 0; i < page[0].Length; i++)                        //  Text Wrapping
            {                                                               //
                tempPageContents.Add(page[0][i]);                           //
                if(tempPageContents.Count >= 43)                            //
                {                                                           //
                    pageContents.Add(string.Concat(tempPageContents));      //
                    tempPageContents.Clear();                               //
                }                                                           //
            }                                                               //
            pageContents.Add(string.Concat(tempPageContents));              //
            
            if (page.Length == 5)
            {
                
                for (int i = 0; i < 3; i++)
                {
                    Console.SetCursorPosition(3, 3 + i);
                    if(pageContents.Count > i)
                    {
                        Console.WriteLine(pageContents[i]);
                    }
                }

                Console.SetCursorPosition(3, 9);
                Console.Write(page[1]);
                Console.SetCursorPosition(26, 9);
                Console.Write(page[2]);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.SetCursorPosition(3, 3 + i);
                    if (pageContents.Count > i)
                    {
                        Console.WriteLine(pageContents[i]);
                    }
                }
                gameOver = true;
            }
        }



    }
}
