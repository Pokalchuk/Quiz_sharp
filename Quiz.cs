using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA
{
    class FullQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string RightAnswer { get; set; }

        public string[] answers = new string[3];

        public int GetArrSize() { return 3; }
    }
    interface IQuiz
    {
        void ReadQuestions();
        string ChoiceQuiz();
        void CreateQuestion();
    }
    class Quiz:IQuiz
    {
        public enum typeQuiz
        {
            Geography=1,
            History,
            Maths,
            MythsAncientGreece
        }
        public FullQuestion question = new FullQuestion();
        public List<FullQuestion> fullQuestions = new List<FullQuestion>();
        static int countRightAnswers = 0;
        public void ReadQuestions()
        {
            Console.WriteLine("Hello what type of quiz you want to start");
            string filePath = $@"F:\C#\KURSOVA\Files\Quizzes\{ChoiceQuiz()}\Questions.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var reader = new StreamReader(fs);
                while(!reader.EndOfStream)
                {
                    question.Question = reader.ReadLine();
                    question.Answer = reader.ReadLine();
                    question.answers = question.Answer.Split(new char[] { '[', ']', 'I'}, StringSplitOptions.RemoveEmptyEntries);
                    question.RightAnswer = reader.ReadLine();
                    Console.WriteLine(question.Question);
                    string symb_for_plus = "I";
                    string symb = "I";
                    string s = "[";
                    string l = "]";
                    for (int i = 0; i < question.answers.Length; ++i)
                    {
                        Console.WriteLine(s+ symb_for_plus + l+question.answers.GetValue(i));
                        symb_for_plus += symb;
                    }
                    //part for enter answer
                    int answerInt = Convert.ToInt32(Console.ReadLine());
                    if(answerInt==1 || answerInt==2 || answerInt==3)
                    {
                        if(question.answers[answerInt-1]==question.RightAnswer)
                        {
                            ++countRightAnswers;
                            Console.WriteLine($"Count: {countRightAnswers}");
                        }
                        else Console.WriteLine($"Right answer: {question.RightAnswer}");
                    }
                    else Console.WriteLine("1 or 2 or 3");

                    question.Question = null;
                    question.Answer = null;
                    question.answers = null;
                    question.RightAnswer = null;
                }
            }
        }
        public string ChoiceQuiz()
        {
            typeQuiz ts = new typeQuiz();
            Console.WriteLine($"[{(int)typeQuiz.Geography}]{typeQuiz.Geography}\n[{(int)typeQuiz.History}]{typeQuiz.History}\n[{(int)typeQuiz.Maths}]{typeQuiz.Maths}\n[{(int)typeQuiz.MythsAncientGreece}]{typeQuiz.MythsAncientGreece}");
            ts = (typeQuiz)int.Parse(Console.ReadLine());
            switch (ts)
            {
                case typeQuiz.Geography:
                    return @"\Geography\";
                    break;
                case typeQuiz.History:
                    return @"\History\";
                    break;
                case typeQuiz.Maths:
                    return @"\Maths\";
                    break;
                case typeQuiz.MythsAncientGreece:
                    return @"\MythsAncientGreece\";
                    break;
                default:
                    throw new Exception("Choice from 1 to 4!");
                    break;
            }
        }
        public void CreateQuestion()
        {
            Console.WriteLine("Hello in what type of quiz you want to add question");
            string filePath = $@"F:\C#\KURSOVA\Files\Quizzes\{ChoiceQuiz()}\Questions.txt";
            using(StreamWriter writer = new StreamWriter(filePath,true,Encoding.UTF8))
            {
                Console.WriteLine("Enter question ");
                question.Question = Console.ReadLine();
                Console.WriteLine("Enter three answers, one of them must be right");
                for (int i = 0; i < question.answers.Length; ++i)
                {
                    Console.Write($"Enter {i + 1} answer: ");
                    question.answers[i] = Console.ReadLine();
                }
                Console.WriteLine("What answer was right?");
                int rightAnswer = Convert.ToInt32(Console.ReadLine());
                if (rightAnswer == 1 || rightAnswer == 2 || rightAnswer == 3)
                {
                    question.RightAnswer = question.answers[rightAnswer - 1].ToString();
                }
                else
                {
                    throw new Exception("From 1 to 3");
                }
                Console.WriteLine($"Right: {question.RightAnswer}");

                writer.WriteLine(question.Question);
                string symb_for_plus = "I";
                string symb = "I";
                string s = "[";
                string l = "]";
                for (int i = 0; i < question.answers.Length; ++i)
                {
                    writer.Write((s + symb_for_plus + l + question.answers.GetValue(i)));
                    symb_for_plus += symb;
                }
                writer.WriteLine();
                writer.WriteLine(question.RightAnswer);
            }
        }
    }
}

