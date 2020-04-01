using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            User user = new User();
            Quiz quiz = new Quiz();
            user.Login();


            //quiz.CreateQuestion();
            //quiz.ReadQuestions();
            //quiz.ResultInFile(user);
            quiz.ReadResults(user);
            //quiz.ChoiceQuiz();

        }
    }
}
