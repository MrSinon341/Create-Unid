using System;

namespace PR_New_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Задача:");
            Console.WriteLine(" С клавиатуры вводится строка S. Вывести строку, содержащую символы строки S ");
            Console.WriteLine(" между которыми вставлено по одному пробелу.");

            Console.WriteLine(); // отступ абзац;

            string text = ""; // резеврируем место под переменную;
                       
            Console.Write(" Введите стоку S: ");
            text = Console.ReadLine();
                        
            Console.WriteLine(); // отступ абзац;

            Console.Write(" Результат выполненного задания: ");

            char[] ch = text.ToCharArray();

            foreach (char c in ch)
            {
               Console.Write(c + " ");
            }
                           
            Console.WriteLine(); // отступ абзац;
                        
        }
    }
}
