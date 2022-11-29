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
            "Forest Story;Start;Quit;2;1",                                                                                                                                                  //0
            "",                                                                                                                                                                             //1
            "You awake in a dark and foggy forest. The forest is dense besides a small dirt road before you.;Follow the trail;Try the woods;3;84",                                          //2
            "You follow the trail to a fork in the road. To your left is the sound of running water, and to your right a faint light.;Go left;Go right;4;57",                               //3
            "You come across a rushing river. The river seems to have washed up a few dead trees;Swim Across;Make a bridge;5;6",                                                            //4
            "As you attempt to swim accross, the strong river ends up pulling you under. The last thing you see are the rocks under the river.",                                            //5
            "You place a dead tree accross the river and cross it. You hear a howling from the woods, much lowder than an ordinary wolf.;Keep to the trail;Hide in the woods;7;85",         //6
            "You follow the trail, eventually finding an abandonned campsite, with two closed tents and a still burning campfire.;Examine the camp;Move on;8;51",                           //7
            "The tent on the left is completely empty, but the one on the left has a dead body within it. There's something in it's hand.;Look closer;Leave it alone;9;51",                 //8
            "Looking closer you see that it's a dagger, if the engraving on the side is to be believed it's made of pure silver;Take it; Leave it alone;10;51",                             //9
            "The dagger has a bit of weight to it. As you continue down the trail you see another fork in the road. Both paths seem identical.;Go left;Go right;11;39",                     //10
            "You continue walking down the trail when you hear a branch snap to your left. You only have a moment to prepare to...;Attack;Run;12;26",                                       //11
            "A monstrous mockery of a wolf jumps out at you when you slash at it with the dagger, cutting it's arm. It falls to the ground.;Examine it;Run;13;15",                          //12
            "As you get closer to the figure it suddenly lashes out at you. It's claws tear at your ankle as you fall down beside it.",                                                     //13
            "With the creature injured you take your chance to make a break for it. As you run the thing gets back up and begins to chase you.;Duck into the forest;Attack again;15;16",    //14
            "You duck into the forest in an attempt to lose the creature. You realize you failed when a claw sinks into your shoulder.",                                                    //15
            "As you prerpare to attack again you see the figure jump at you. Before you can attack you need to avoid being attacked.;Roll;Duck;17;18",                                      //16
            "You roll to the side as the creature soars past and falls to the ground. It begins to get back up, hindered by it's injured arm.;Stab it's side;Stab it's head;19;20",         //17
            "As you duck beneath it's claws, the rest of it simply falls on top of you. It gets off you before, again, you see it's claws.",                                                //18
            "You stab it in the upper torso below it's arms hoping to cause some damage. It seems to work as the creature stops trying to get up.;Finish it;Just leave;21;22",              //19
            "You try to stab it in the head, but stabs it's shoulder instead. A sudden hit to your side sends you hurtling into a tree.",                                                   //20
            "You quickly grab the dagger from it's side and stab it in the neck. With one last swipe it gives you a small cut on the arm.;Follow the trail;Take a breather;23;24",          //21
            "As you turn to leave the creature uses the last of it's energy to bite your ankle, shattering it. The creature dies finally dies;Follow the trail;Take a breather;25;24",      //22
            "You walk down the trail to find your car of all things. You drive to the hospital hoping your small cut doesn't get infected.",                                                //23
            "You lie against the creature for a quick breather. When you get up to leave you find that the silver dagger now burns your hand.",                                             //24
            "As you try to walk, your shattered ankle makes you collapse. While you may have defeated the creature, you aren't leaving.",                                                   //25
            "A monstrous mockery of a wolf jumps out of the woods and begins to chase after you. It quickly catches up and jumps at you;Block;Dodge;27;38",                                 //26
            "You raise your arm right as the creature bites it. You fall back with the creature on top of you.;Stab it; Bite it;28;29",                                                     //27
            "You stab the creature in the eye causing it to lurch back, tearing half your arm off as it does.;Stab it again;Run;30;37",                                                     //28
            "You bite the creatures nose. This proves unhelpful as it tears your arm off, and a clawed hand is run through your chest.",                                                    //29
            "As you go to stab it again, the creature starts flailing its arms wildly preventing you from getting closer.;Wait for an opening;Rush in anyways;31;32",                       //30
            "As you wait for an opening you notice that the silver dagger seems to be getting hotter in your hand. Soon it will start to burn.;Drop it;Throw it;33;34",                     //31
            "You rush in anyways, only for a clawed hand to slash you accross the face before another one bats you towards a tree.",                                                        //32
            "You drop the dagger and turn to run when you stop in your tracks. You look down to see a clawed hand coming out of your chest.",                                               //33
            "You throw the dagger right into the creature's throat. The creature falls dead. Now you just need to find a way to patch up your arm.;Use sweater;Use leaves;35;36",           //34
            "You tie your sweater around your arm to try and stop the bleeding. You leave the forest and find your car. How are you gonna drive?",                                          //35
            "You tie leaves around your arm as tightly as you can and continue down the trail. You start getting dizzy and take a long nap.",                                               //36
            "Luckily the creature doesn't seem to notice you, now more concerned with it's injury. You still have to patch up your arm though.;Use sweater;Use leaves;35;36",               //37
            "You try to dodge only to trip on a root. You get up as quickly as you can only to feel claws slash at your back.",                                                             //38
            "You continue down the path to your right. As you do you come accross a poorly furnished cave.;Examine;Go back;40;10",                                                          //39
            "You see wrecked bed and a hacked up couch. As you explore the cave you end up stepping in a bear trap, it snaps shut.;Pry it open;Amputate;41;42",                             //40
            "You pry the trap open with the dagger and make it through relatively safely, but you hear leaves rustling behind you;Hide;Fight;43;44",                                        //41
            "You begin to slash at your trapped leg. It takes much longer than you would like. Suddenly you feel a slash agaisnt your back.",                                               //42
            "You limp to the couch and hide behind it, dagger at the ready. As you steady your breathing you hear footsteps approaching.;Attack;Stay hidden;45;46",                         //43
            "You stand your ground. When a monstrous mockery of a wolf steps out of the leaves you slash at it. It claws your face off.",                                                   //44
            "You jump out at what appears to be a monstrous mockery of a wolf. The thing is surprised by your attack as you slash it's neck.;Leave now;Take a breather;47;48",              //45
            "You stay hidden as what appears to be a monstrous mockery of a wolf rounds the corner and turns to look at you.;Attack;Run;49;50",                                             //46
            "You limp your way out of the forest and find your car. You drive to the hospital hoping to get your leg checked out",                                                          //47
            "You rest on the bed and patch up your leg. After a bit you leave the forest and find your car, finally driving home.",                                                         //48
            "You slash at the creature. Sadly it anticipated your attack and batted it aside, before slashing at your face.",                                                               //49
            "As you try to run away, you feel the creature's claws run through your back.",                                                                                                 //50
            "You leave. As you continue down the trail you see another fork in the road. Both paths seem identical.;Go left; Go right;52;53",                                               //51
            "Taking the left trail you think you see your car in the distance. As you pick up the pace you hear leaves rustling behind you;Run straight;Weave through trees;54;55",         //52
            "You continue down the path to your right. As you do you come accross a poorly furnished cave.;Examine;Go back;56;51",                                                          //53
            "As you run down the path, a monstrous mockery of a wolf jumps out from the trees and easily catches up to you, slashing at you.",                                              //54
            "You begin to weave between the trees, a monstrous mockery of a wolf jumps out and runs into a tree as you reach your car.",                                                    //55
            "As you examine the cave you step on a bear trap, snapping it shut. You find yourself defenseless against the thing approaching.",                                              //56
            "You come accross a cabin. The lights inside it are on and you think you can hear a generator.;Explore;Move on;58;51",                                                          //57
            "You see a room to either side and a hallway in front of you.;Enter a room;Go down hall;59;60",                                                                                 //58
            "Which room would you like to enter?;Left;Right;62;64",                                                                                                                         //59
            "You see two rooms, and a hallway behind you.;Enter a room;Go back;61;58",                                                                                                      //60
            "Which room would you like to enter?;Left;Right;67;70",                                                                                                                         //61
            "You find a room containing a gas powered generator, and the gas canisters needed for it.;Examine;Go back;63;58",                                                               //62
            "The generator seems to be running low on fuel, and the gas canisters seem to be empty;Go back;Go back;58;58",                                                                  //63
            "You find what appears to be a study, with a desk against the wall furthest from the door.;Examine;Go back;65;58",                                                              //64
            "A journal lies on top of the desk and makes mention of a werewolf living in the forest. The desk has drawers;Check drawer;Go back;66;58",                                      //65
            "You find a revolver in the drawer. The journal mentions a revolver loaded with silver bullets.;Take it;Go back;73;58",                                                         //66
            "You enter what appears to be a kitchen. There's a wood stove on the wall to your left and a window in far wall.;Examine;Go back;68;60",                                        //67
            "There is a pile of dirty dishes in a sink under the window, and a block of knives next to the stove.;Take a knife;Go back;69;60",                                              //68
            "As you grab a knife, a monstrous mockery of a wolf jumps through the window. The knife proves useless against it. It kills you.",                                              //69
            "You enter a bedroom. The bed is rather small, only big enough for one person. That person being the bloody corpse lying on it.;Examine;Go back;71;60",                         //70
            "The corpse seems to have been slashed and chewed by a very large creature. There are clumps of fur lying beside it.;Loot;Go back;72;60",                                       //71
            "You find an empty wallet before leaving the bedroom. You see two rooms, and a hallway behind you.;Enter a room;Go back;61;58",                                                 //72
            "As you pick up the gun, you hear the generator putter out as the cabin goes dark. You hear glass breaking elsewhere in the cabin.;Stay put;Investigate;74;75",                 //73
            "You stay put, pointing the gun at the door. The noises continue until the werewolf barges in. You shoot it on sight, killing it.;Shoot again;Just leave;82;83",                //74
            "You enter the now dark hallway. The hallway continues to your right, and a door in front of you.;Try the door;Go down hall;76;79",                                             //75
            "As you enter the room you find the now inactive generator. You hear loud footsteps approach the door.;Refuel generator;Turn and shoot;77;78",                                  //76
            "You try to pour fuel in the generator only to find the canister empty. Suddenly a claw runs through your stomach.",                                                            //77
            "You turn around and see the werewolf about to pounce at you. You shoot it before you can think, killing it.;Shoot again;Just leave;82;83",                                     //78
            "Going down the hallway you see a room to your left and a door to the right. The noises seem to be coming from your left.;Enter left room;Enter right room;80;81",              //79
            "As you enter the kitchen, you see the werewolf trying to fit through the window and shoot it with the revolver, killing it.;Shoot again;Just leave;82;83",                     //80
            "As you enter the bedroom, you see a bloody corpse on the bed. Suddenly the werewolf barges in and kills you.",                                                                 //81
            "You shoot the werewolf again, just to be sure. You once again travel through the woods, eventually finding your car and leaving.",                                             //82
            "You just leave, once again travelling through the woods. You eventuall find your car and leave the forest, driving home.",                                                     //83
            "You very quickly get lost in the forest. You eventually end up back on the trail at a fork in the road;Go left;Go right;52;53",                                                //84
            "The End!"                                                                                                                                                                      //85
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
