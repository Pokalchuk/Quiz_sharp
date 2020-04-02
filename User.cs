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
        static public BirthDate GetFromString(string birthdate)
        {
            string[] birth= birthdate.Split(new char[] { '.'});
            var dateForReturn = new BirthDate();
            dateForReturn.Day= Convert.ToInt32(birth[0]);
            dateForReturn.Month = Convert.ToInt32(birth[1]);
            dateForReturn.Year = Convert.ToInt32(birth[2]);
            return dateForReturn;
        }
    }
    class User
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        private BirthDate birthDate;
        public User()
        {
            Nickname = "";
            Password = "";
        }
        public void ShowDate()
        {
            Console.WriteLine(birthDate.ToString());
        }
        public void ChangeDate()
        {
            string filePath = $@"F:\C#\KURSOVA\Files\Users\{Nickname}.txt";
            string birthdate = "";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string nickname = reader.ReadLine();
                string password = reader.ReadLine();
                birthdate = reader.ReadLine();
                Console.WriteLine($"Birthdate: {birthdate}");
            }
            Console.WriteLine("Enter new birthdate: ");
            birthDate.EnterDate();
            string new_birthdate = birthDate.ToString();
            File.Delete(filePath);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                new_birthdate.Replace(birthdate, new_birthdate);
                writer.WriteLine(Nickname);
                writer.WriteLine(Password);
                writer.WriteLine(birthDate.ToString());
            }
            birthDate=BirthDate.GetFromString(new_birthdate);
        }
        public void ChangePassword()
        {
            string filePath = $@"F:\C#\KURSOVA\Files\Users\{Nickname}.txt";
            Console.WriteLine("Enter your current password: ");
            string currentPass = Console.ReadLine();
            if (Password != currentPass)
            {
                Console.WriteLine("Passwords don't match");
                while (Password != currentPass)
                {
                    Console.WriteLine("Enter your current password: ");
                    currentPass = Console.ReadLine();
                }
            }
            string new_pass = "";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string nickname = reader.ReadLine();
                string password = reader.ReadLine(); 
                birthDate = BirthDate.GetFromString(reader.ReadLine());
                //string birthdate = reader.ReadLine();
                Console.WriteLine($"Password: {Password}");
            }
            Console.WriteLine("Enter new password: ");
            new_pass = Console.ReadLine();
            Password = new_pass;
            File.Delete(filePath);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(Nickname);
                writer.WriteLine(Password);
                writer.WriteLine(birthDate.ToString());
            }
        }
        public void RegistrationUser()
        {
            Console.Write("Enter your nickname: "); Nickname = Console.ReadLine();
            string filePath = $@"F:\C#\KURSOVA\Files\Users\{Nickname}.txt";
            if (File.Exists(filePath)) throw new Exception("User already exist!!!");
            else
            {
                Console.Write("Enter your password: "); Password = Console.ReadLine();
                Console.Write("Enter your birthdate\n"); birthDate.EnterDate();
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(Nickname);
                    writer.WriteLine(Password);
                    writer.WriteLine(birthDate.ToString());
                }
            }
        }
        public void CheckRegistation()
        {
            Console.Write("Enter your nickname: "); Nickname = Console.ReadLine();
            string filePath = $@"F:\C#\KURSOVA\Files\Users\{Nickname}.txt";
            if (!File.Exists(filePath))
            {
                throw new Exception("User NOT exist!!!");
            }
            else
            {
                Console.Write("Enter your password: "); Password = Console.ReadLine();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string nickname = reader.ReadLine();
                    string password = reader.ReadLine();
                    string birthdate = reader.ReadLine();
                    if (Nickname == nickname && Password == password)
                    {
                        Console.WriteLine("Successful login");
                    }
                    else throw new Exception("Incorrect password");
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
                    Console.WriteLine("c[1]Yes\n[2]No");
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
