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
        enum Game 
        {
            StartQuiz=1,
            AddQuestion,
            ShowPreviousResults,
            ShowTop20,
            ChangePassword,
            ChangeBirthdate,
            Exit=0
        };
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           
            Start();
            User user = new User();
            Quiz quiz = new Quiz();
            user.Login();
            Game game = new Game();
            while(true)
            {
                Console.WriteLine($"[{(int)Game.StartQuiz}]{Game.StartQuiz}\n[{(int)Game.AddQuestion}]{Game.AddQuestion}\n[{(int)Game.ShowPreviousResults}]{Game.ShowPreviousResults}\n[{(int)Game.ShowTop20}]{Game.ShowTop20}\n[{(int)Game.ChangePassword}]{Game.ChangePassword}\n[{(int)Game.ChangeBirthdate}]{Game.ChangeBirthdate}\n[{(int)Game.Exit}]{Game.Exit}");
                game = (Game)int.Parse(Console.ReadLine());
                switch (game)
                {
                    case Game.StartQuiz:
                        Console.Clear();
                        quiz.ReadQuestions(user);
                        break;
                    case Game.AddQuestion:
                        quiz.CreateQuestion();
                        break;
                    case Game.ShowPreviousResults:
                        quiz.ReadResults(user);
                        break;
                    case Game.ShowTop20:
                        quiz.ReadFromTop20(user);
                        break;
                    case Game.ChangePassword:
                        user.ChangePassword();
                        break;
                    case Game.ChangeBirthdate:
                        user.ChangeDate();
                        break;
                    case Game.Exit:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"From{(int)Game.Exit} to {(int)Game.ChangeBirthdate}");
                        break;
                }
            }
           
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
