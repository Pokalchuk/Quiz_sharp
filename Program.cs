﻿using System;
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
            user.Login();
            user.ChangeDate();
            //user.ChangePassword();

 
            //Quiz quiz = new Quiz();
            //quiz.ReadQuestions();
            //quiz.ChoiceQuiz();

        }
    }
}
