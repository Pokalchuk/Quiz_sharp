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
        void ReadQuestions(User user);
        string ChoiceQuiz();
        void CreateQuestion();
    }
    class Quiz : IQuiz
    {
        public enum typeQuiz
        {
            Geography = 1,
            History,
            Maths,
            MythsAncientGreece,
            Mixed
        }
        private string choiceQuiz = "";
        public FullQuestion question = new FullQuestion();
        public List<FullQuestion> fullQuestions = new List<FullQuestion>();
        static int countRightAnswers = 0;
        public Dictionary<string, int> topPlayers = new Dictionary<string, int>();
        public SortedDictionary<int, string> topPlayersSorted = new SortedDictionary<int, string>();

        public void ReadQuestions(User user)
        {
            Console.WriteLine("Hello what type of quiz you want to start");
            choiceQuiz = ChoiceQuiz();
            string filePath = $@"F:\C#\KURSOVA\Files\Quizzes\{choiceQuiz}\Questions.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var reader = new StreamReader(fs);
                while (!reader.EndOfStream)
                {
                    question.Question = reader.ReadLine();
                    question.Answer = reader.ReadLine();
                    question.answers = question.Answer.Split(new char[] { '[', ']', 'I' }, StringSplitOptions.RemoveEmptyEntries);
                    question.RightAnswer = reader.ReadLine();
                    Console.WriteLine(question.Question);
                    string symb_for_plus = "I";
                    string symb = "I";
                    string s = "[";
                    string l = "]";
                    for (int i = 0; i < question.answers.Length; ++i)
                    {
                        Console.WriteLine(s + symb_for_plus + l + question.answers.GetValue(i));
                        symb_for_plus += symb;
                    }
                    //part for enter answer
                    int answerInt = Convert.ToInt32(Console.ReadLine());
                    if (answerInt == 1 || answerInt == 2 || answerInt == 3)
                    {
                        if (question.answers[answerInt - 1] == question.RightAnswer)
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
            string filePath2 = $@"F:\C#\KURSOVA\Files\Quizzes\{choiceQuiz}\TOP20.txt";
            using (var writer = new StreamWriter(filePath2,true))
            {
                writer.WriteLine(user.Nickname);
                writer.WriteLine(countRightAnswers);
            }
            WriteResults(user);
        }
        public string ChoiceQuiz()
        {
            typeQuiz ts = new typeQuiz();
            Console.WriteLine($"[{(int)typeQuiz.Geography}]{typeQuiz.Geography}\n[{(int)typeQuiz.History}]{typeQuiz.History}\n[{(int)typeQuiz.Maths}]{typeQuiz.Maths}\n[{(int)typeQuiz.MythsAncientGreece}]{typeQuiz.MythsAncientGreece}\n[{(int)typeQuiz.Mixed}]{typeQuiz.Mixed}");
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
                case typeQuiz.Mixed:
                    return @"\Mixed\";
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
            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
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
        public void WriteResults(User user)
        {
            string filePath = $@"F:\C#\KURSOVA\Files\Results\{user.Nickname}.txt";
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                writer.WriteLine(user.Nickname);
                writer.WriteLine(countRightAnswers);
            }
        }
        public void ReadFromTop20(User user)
        {
            Console.WriteLine("Enter in what category you want see top 20");
          
            string filePath2 = $@"F:\C#\KURSOVA\Files\Quizzes\{ChoiceQuiz()}\TOP20.txt";
            using (var reader = new StreamReader(filePath2))
            {
                while(!reader.EndOfStream)
                {
                    string _nickname = reader.ReadLine();
                    int _rightAnswers = Convert.ToInt32(reader.ReadLine());
                    if (topPlayers.ContainsKey(_nickname)) continue;
                    topPlayers.Add(_nickname, _rightAnswers);
                }
                foreach (var item in topPlayers)
                {
                    topPlayersSorted.Add(item.Value, item.Key);
                    
                }
                foreach (var item in topPlayersSorted.Reverse())
                {
                    Console.WriteLine(item.Value + " " + item.Key);

                }
            }
        }
        public void ReadResults(User user)
        {
            string filePath = $@"F:\C#\KURSOVA\Files\Results\{user.Nickname}.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                while(!reader.EndOfStream)
                {
                    string _nickname = reader.ReadLine();
                    int _rightCount = Convert.ToInt32(reader.ReadLine());
                    Console.WriteLine($"Your nickname: {_nickname}, your score: {_rightCount}/20");
                }
                
            }
        }
     

    }
}

