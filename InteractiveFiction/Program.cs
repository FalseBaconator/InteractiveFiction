﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    internal class Program
    {

        static string[] story = new string[]{
            "Test 1 AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA;Test 2;Test 3;1;2",
            //"Test 1; Test 2; Test 3;1;2",
            "Test 2",
            "Test 3 ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz 1234567891011121314151617181920"
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
