using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KURSOVA
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Start();
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.Clear();
            User user = new User();
            Quiz quiz = new Quiz();
            user.Login();
            //quiz.ReadQuestions(user);
            quiz.ReadFromTop20(user);

            //quiz.CreateQuestion();
            //quiz.ResultInFile(user);
            //quiz.ReadResults(user);
            //quiz.ChoiceQuiz();

        }
    static void Start()
    {
        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.Red;

        const int TIMECLOCK = 175;

        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("         ▐█▀█ ▐█▀▀█▌ ▐█ ▐▀  ▄█▀▄  ██    ▐█▀█ ▐█ ▐█ █ █ ▐█ ▐▀     " + "  ▄█▀▄  █▀▀▄ █▀█▀█ ▐█▀▀ ▐██▄ ▄██▌");
        Console.WriteLine("         ▐█▄█ ▐█  █▌ ▐██▌  ▐█▄▄▐█ ██    ▐█   ▐████ █ █ ▐██▌      " + " ▐█▄▄▐█ █ ▐█   █   ▐█▀▀  █  █  █ ");
        Console.WriteLine("         ▐█   ▐██▄█▌ ▐█ ▐▄ ▐█  ▐█ ██▄▄█ ▐█▄█ ▐█ ▐█ ▀▄▀ ▐█ ▐▄     " + " ▐█  ▐█ █▀▄▄  ▄█▄  ▐█▄▄ ▐█     █▌");



        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                                             ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                                             ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                                             ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                                             ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                                             ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                                                ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(2500);
        Console.Clear();
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                             ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                                             ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                                             ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                                             ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                                             ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                                                ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("                                             ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                                             ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                                             ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                                             ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                                             ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                                                ╚╝╚═══╝╚══╝╚════╝");


        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.WriteLine(); Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("                                             ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                                             ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                                             ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                                             ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                                             ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                                                ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("                                             ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                                             ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                                             ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                                             ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                                             ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                                                ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("                                         ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                                         ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                                         ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                                         ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                                         ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                                            ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                     ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                                     ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                                     ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                                     ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                                     ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                                        ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("                                 ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                                 ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                                 ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                                 ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                                 ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                                    ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("                             ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                             ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                             ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                             ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                             ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                                ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("                         ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                         ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                         ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                         ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                         ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                            ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                     ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                     ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                     ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                     ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                     ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                        ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                 ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("                 ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("                 ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("                 ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("                 ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("                    ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("            ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("            ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("            ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("            ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("            ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("               ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("        ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("        ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("        ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("        ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("        ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("           ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("    ╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("    ║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("    ║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("    ║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("    ╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("       ╚╝╚═══╝╚══╝╚════╝");

        Thread.Sleep(TIMECLOCK);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("╔═══╗╔╗ ╔╗╔══╗╔════╗");
        Console.WriteLine("║╔═╗║║║ ║║╚╣─╝╚══╗═║");
        Console.WriteLine("║║ ║║║║ ║║ ║║   ╔╝╔╝");
        Console.WriteLine("║╚═╝║║║ ║║ ║║  ╔╝╔╝");
        Console.WriteLine("╚══╗║║╚═╝║╔╣─╗╔╝═╚═╗");
        Console.WriteLine("   ╚╝╚═══╝╚══╝╚════╝");

        Console.Clear();
        Console.CursorVisible = true;
        }
    }
}
