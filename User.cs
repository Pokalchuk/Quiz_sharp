using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA
{
    struct BirthDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public void EnterDate()
        {
            Console.Write("Enter day: "); Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: "); Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: "); Year = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"{Day}.{Month}.{Year}";
        }
    }
    class User
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public BirthDate birthDate;
        public User()
        {
            Nickname = "";
            Password = "";
        }
        public void ShowDate()
        {
            Console.WriteLine(birthDate.ToString());
        }
        public void RegistrationUser()
        {
            Console.Write("Enter your nickname: "); Nickname = Console.ReadLine();
            string filePath = $"{Nickname}.txt";
            if (File.Exists(filePath))
            {
                throw new Exception("User already exist!!!");
            }
            else
            {
                Console.Write("Enter your password: "); Password = Console.ReadLine();
                Console.Write("Enter your birthdate\n"); birthDate.EnterDate();
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Write))
                {
                    var writer = new BinaryWriter(fs);
                    writer.Write(Nickname);
                    writer.Write(Password);
                }
            }
        }
        public void CheckRegistation()
        {
            Console.Write("Enter your nickname: "); Nickname = Console.ReadLine();
            string filePath = $"{Nickname}.txt";
            if (!File.Exists(filePath))
            {
                throw new Exception("User NOT exist!!!");
            }
            else
            {
                Console.Write("Enter your password: "); Password = Console.ReadLine();
                StreamReader streamReader = new StreamReader(filePath);
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var reader = new BinaryReader(fs);
                    string nickname = reader.ReadString();
                    string password = reader.ReadString();
                    //string birthdate = reader.ReadString();
                    if (Nickname == nickname && Password == password)
                    {
                        Console.WriteLine("TRUEEE");
                    }
                    else Console.WriteLine("Bad reg");
                }

            }
        }

        public void Login()
        {
            int choice = 0;
            Console.WriteLine("Hello, do you have an account?");
            Console.WriteLine("[1]Yes\n[2]No");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice != 1 && choice != 2)
            {
                while (choice != 1 && choice != 2)
                {
                    Console.Clear();
                    Console.WriteLine("Hello, do you have an account?");
                    Console.WriteLine("[1]Yes\n[2]No");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
            }
            else if (choice == 1)
            {
                CheckRegistation();
            }
            else if (choice == 2)
            {
                RegistrationUser();
            }
                
        }
    }

}
