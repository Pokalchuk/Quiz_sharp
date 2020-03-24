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
        private string Password { get; set; }
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
        public void WriteRegistationInfo()
        {
            #region FirstTry
            //string filePath = "RegistationInfo.txt";
            //using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Write))
            //{
            //    byte[] writeBytes = Encoding.Default.GetBytes(Nickname + Password + birthDate.ToString());
            //    fs.Write(writeBytes, 0, writeBytes.Length);
            //}
            #endregion
            string filePath = "RegistationInfo.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                var writer = new BinaryWriter(fs);
                writer.Write(Nickname);
                writer.Write(Password);
            }
        }
        public void ReadRegistationInfo()
        {
            #region Other
            //string filePath = "RegistationInfo.txt";
            //using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            //{
            //    byte[] readBytes = new byte[(int)fs.Length];
            //    fs.Read(readBytes, 0, readBytes.Length);
            //    string info = Encoding.Default.GetString(readBytes);
            //    Console.WriteLine(info);
            //}
            #endregion
            string filePath = "RegistationInfo.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var reader = new BinaryReader(fs);
                string nickname = reader.ReadString();
                string password = reader.ReadString();
                //string birthdate = reader.ReadString();
                Console.WriteLine(nickname);
                Console.WriteLine(password);
                //Console.WriteLine(birthdate);
            }
        }
        public void Login()
        {
            int choice = 0;
            Console.WriteLine("Hello, do you have an account?");
            Console.WriteLine("[1]Yes\n[2]No");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter your nickname: "); Nickname = Console.ReadLine();
                Console.Write("Enter your password: "); Password = Console.ReadLine();
            }
            if (choice == 2)
            {
                Console.Write("Enter your nickname: "); Nickname = Console.ReadLine();
                Console.Write("Enter your password: "); Password = Console.ReadLine();
                Console.Write("Enter your birthdate\n"); birthDate.EnterDate();
            }
            else Console.WriteLine("Choice 1 or 2");

        }
    }
}
