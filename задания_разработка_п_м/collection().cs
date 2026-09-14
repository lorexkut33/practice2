//namespace задания_разработка_п_м
//{
//    using System.Collections.Concurrent;
//    using System.Linq;
//    using static System.Net.Mime.MediaTypeNames;

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Укажите количество задач:");
//            int n = Convert.ToInt32(Console.ReadLine());
//            List<string> list = new List<string>(n);


//            // Ввод задач с консоли
//            Console.WriteLine("Введите задачи:");
//            for (int i = 0; i < n; i++)
//            {
//                string task = Console.ReadLine();
//                list.Add(task);
//            }

//            Console.Write($"Список задач:");
//            foreach (var tasks in list)
//            {
//                Console.Write($" {tasks},");
//            }
//            if (list.Count > 0)
//            {
//                list.RemoveAt(0);
//            }
//            else
//            {
//                Console.WriteLine("Список задач пуст, удаление невозможно.");
//            }


//            Console.Write("\nПосле удаления первой задачи:");
//            foreach (var tasks in list)
//            {
//                Console.Write($" {tasks},");
//            }







//            //Console.WriteLine("Укажите количество задач:");
//            //int n = Convert.ToInt32(Console.ReadLine());
//            //if (n <= 0)
//            //{
//            //    Console.WriteLine("Количество задач должно быть положительным числом.");
//            //    return;
//            //}

//            //Stack<string> taskStack = new Stack<string>(n);
//            //Console.WriteLine("Введите задачи:");
//            //for (int i = 0; i < n; i++)
//            //{
//            //    string task = Console.ReadLine();
//            //    taskStack.Push(task);
//            //}
//            //Console.Write("Задачи в стеке:");
//            //foreach (var task in taskStack)
//            //{
//            //    Console.Write($" {task} ");
//            //}
//            //Console.WriteLine("\nХотите удалить последнюю задачу? (y/n)");
//            //string choice = Console.ReadLine();
//            //if (choice.ToLower() == "y")
//            //{
//            //    taskStack.Pop();
//            //    Console.WriteLine("Последняя задача удалена.");
//            //}
//            //else if (choice.ToLower() == "n")
//            //{
//            //    Console.WriteLine("последняя задача не удалена.");
//            //}
//            //else { Console.WriteLine("Некорректный ввод."); }
//            //foreach (var task in taskStack)
//            //{
//            //    Console.Write($" {task} ");
//            //}













//            //string text = "За гремучую доблесть грядущих веков, За высокое племя людей, Я лишился и чаши на пире отцов, И веселья, и чести своей";
//            //Console.WriteLine($"Исходный текст:\n{text}\n");

//            //char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '-', '(', ')', '"', '\n', '\r', '\t' };

//            //string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);

//            //Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

//            //foreach (string word in words)
//            //{
//            //    if (wordFrequency.ContainsKey(word))
//            //    {
//            //        wordFrequency[word]++;
//            //    }
//            //    else
//            //    {
//            //        wordFrequency[word] = 1;
//            //    }
//            //}

//            //Console.WriteLine("Частота уникальных слов в тексте:");
//            //Console.WriteLine("--------------------------------");
//            //foreach (var (word, count) in wordFrequency)
//            //{
//            //    Console.WriteLine($"{word} -> {count}");
//            //}
//        }
//    }
//}