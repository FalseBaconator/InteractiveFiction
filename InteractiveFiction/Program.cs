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
            "You're walking in the woods. there's no one around and your phone is dead. Out of the corner of your eye you spot someone.;Approach;Stay Away;1;0",                    //0
            "You can now see that the figure is Shia LaBeouf. He gets down on all fours and breaks into a spring, he's gaining on you!;Look for your car;Just run;2;4",             //1
            "You're looking for your car but you're all turned around. He's almost upon you now and you can see there's blood on his face.;Inspect;Just run;3;4",                   //2
            "Upon further inspection you can see that the blood is mostly focused around his mouth and hands. He's also holding a knife.;Just run;Disarm him;4;5",                  //3
            "You're running for your life from Shia LaBeouf. As he gains on you, you realize you can't outrun him.;Zig zag;Duck under branch;6;7",                                  //4
            "As you reach to disarm him he swings his knife towards you, slashing you across the face. You fall to the ground.",                                                    //5
            "Now it's dark, and you seem to have lost him, but you're hopelessly lost yourself, creeping silently through the underbrush.;Look around;Follow own footsteps;8;0",    //6
            "You find a large branch and duck under it with the hope that Shia would duck under it. Sadly he ducks and lunges at you.",                                             //7
            "Aha! In the distance, a small cottage with a light on! Hope! You move carefully towards it...;Looking for Shia;Looking for danger;9;0",                                //8
            "You look around above the bushes and see no movement. But your leg, AH! It's caught in a beartrap!;Gnaw leg off;Open beartrap;10;0",                                   //9
            "You gnaw off your leg as quietly as possible before limping to the cottage. Through the door you see a blood soaked Shia Labeouf.;Run;Hide;0;11",                      //10
            "As you duck behind the doorway you realize that he hasn't seen you yet. You peek through the door to see him sharpening an axe.;Sneak in;Sneak away;12;0",             //11
            "You manage to sneak into the cottage and behind Shia LaBeouf",




            "As you go to walk in the other direction you hear a noise behind you. It sounds like the figure is running after you!;Look for your car;Just run;3;4",
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
