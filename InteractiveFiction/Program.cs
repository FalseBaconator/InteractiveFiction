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
            "Test 1;Test 2;Test 3;1;2",
            "Test 2",
            "Test 3"
        };

        static bool gameOver = false;

        static string[] page;
        static int currentPage = 0;
        static int menuPos;
        static char

        static void Main(string[] args)
        {
            Console.SetWindowSize(49, 13);
            while(gameOver == false)
            {
                WritePage(currentPage);

            }
            
        }


        static void DrawUI()
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine(" +---------------------------------------------+");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" |                                             |");
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
            Console.Clear();
            DrawUI();
            page = story[pageNum].Split(';');
            if (page.Length == 5)
            {
                Console.SetCursorPosition(3, 3);
                Console.Write(page[0]);
                Console.SetCursorPosition(3, 9);
                Console.Write(page[1]);
                Console.SetCursorPosition(26, 9);
                Console.Write(page[2]);
            }
            else
            {
                Console.SetCursorPosition(2, 2);
                Console.WriteLine(story[pageNum]);
                gameOver = true;
            }
        }



    }
}
