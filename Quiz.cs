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
    }

    class HistoryQuiz:IQuiz
    {

        public FullQuestion questions = new FullQuestion();
        public List<FullQuestion> fullQuestions = new List<FullQuestion>();
        public void ReadQuestions()
        {
            string filePath = $@"F:\C#\KURSOVA\Files\Quizzes\History\Questions.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var reader = new StreamReader(fs);
                while(!reader.EndOfStream)
                {
                    questions.Question = reader.ReadLine();
                    questions.Answer = reader.ReadLine();
                    questions.answers = questions.Answer.Split(new char[] { '[', ']', 'I' }, StringSplitOptions.RemoveEmptyEntries);
                    questions.RightAnswer = reader.ReadLine();
                    Console.WriteLine(questions.Question);
                    for (int i = 0; i < questions.answers.Length; ++i)
                    {
                        Console.Write(questions.answers.GetValue(i));
                    }
                        
                    Console.WriteLine($"\n{questions.RightAnswer}");
                    fullQuestions.Add(questions);

                    Console.WriteLine(questions.answers[2]);

                    questions.Question = null;
                    questions.Answer = null;
                    questions.answers = null;
                    questions.RightAnswer = null;
                }
              
            }


        }
    }
}

