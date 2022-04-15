using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            string myName;
            Console.WriteLine("Введите свое имя : ");
            myName = Console.ReadLine();
            string myFamilyName;
            Console.WriteLine("Введите свою фамилию : ");
            myFamilyName = Console.ReadLine();
            string myAge;
            Console.WriteLine("Введите свой возраст : ");
            myAge = Console.ReadLine();
            string myWork;
            Console.WriteLine("Введите свою работу : ");
            myWork = Console.ReadLine();
            string myHobby;
            Console.WriteLine("Введите свое хобби : ");
            myHobby = Console.ReadLine();
            Console.WriteLine("Вас зовут " + myName + myFamilyName + ", " + " вам " + myAge + " года " + ", " + " вы работаете " + myWork + " и ваше хобби " + myHobby + ".");
        }
    }
}
    

