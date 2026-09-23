//using System;
//using System.Collections.Generic;
//using System.Text;

////namespace задания_разработка_п_м
//{
//    //internal class Practice1
//    {
//        //static void Main(string[] args)
//        {
//            // 1. Ввод количества операций
//            int count = 0;
//            while (true)
//            {
//                Console.Write("Сколько операций записать (от 2 до 40): ");
//                count = int.Parse(Console.ReadLine());

//                if (count >= 2 && count <= 40)
//                {
//                    break;
//                }
//                Console.WriteLine("Ошибка! Нужно ввести число от 2 до 40.");
//            }

//            // Два простых списка под названия и цены
//            List<string> names = new List<string>();
//            List<double> prices = new List<double>();

//            Console.WriteLine("\nВводи траты по шаблону: Товар; Цена");
//            Console.WriteLine("Пример: Влажные салфетки \"Лента\"; 235\n");

//            // 2. Ввод данных
//            for (int i = 0; i < count; i++)
//            {
//                while (true)
//                {
//                    Console.Write($"Операция {i + 1}: ");
//                    string input = Console.ReadLine();

//                    if (input.Contains(";"))
//                    {
//                        string[] parts = input.Split(';');
//                        string name = parts[0].Trim();
//                        double price = double.Parse(parts[1].Trim().Replace('.', ','));

//                        names.Add(name);
//                        prices.Add(price);
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Неверный формат! Не забывай точку с запятой ';'");
//                    }
//                }
//            }

//            // 3. Главное меню
//            while (true)
//            {
//                Console.WriteLine("\n=== МЕНЮ ===");
//                Console.WriteLine("1. Вывод данных");
//                Console.WriteLine("2. Статистика");
//                Console.WriteLine("3. Сортировка по цене (пузырек)");
//                Console.WriteLine("4. Конвертация валюты");
//                Console.WriteLine("5. Поиск по названию");
//                Console.WriteLine("0. Выход");
//                Console.Write("Выбери пункт: ");


//                ConsoleKeyInfo key = Console.ReadKey(true);
//                if (key.Key == ConsoleKey.Escape)
//                {
//                    Console.WriteLine("\nПока!");
//                    return;
//                }

//                int choice = key.KeyChar - '0';
//                Console.WriteLine(choice);

//                switch (choice)
//                {
//                    case 1:
//                        Console.WriteLine("\n--- Твои траты ---");
//                        for (int i = 0; i < names.Count; i++)
//                        {
//                            Console.WriteLine($"{i + 1}. {names[i]} — {prices[i]} руб.");
//                        }
//                        break;

//                    case 2:
//                        double sum = 0;
//                        double min = prices[0];
//                        double max = prices[0];

//                        for (int i = 0; i < prices.Count; i++)
//                        {
//                            sum += prices[i];
//                            if (prices[i] < min) min = prices[i];
//                            if (prices[i] > max) max = prices[i];
//                        }

//                        double avg = sum / prices.Count;

//                        Console.WriteLine("\n--- Статистика ---");
//                        Console.WriteLine($"Сумма: {sum} руб.");
//                        Console.WriteLine($"Среднее: {avg:F2} руб.");
//                        Console.WriteLine($"Минимум: {min} руб.");
//                        Console.WriteLine($"Максимум: {max} руб.");
//                        break;

//                    case 3:
//                        // пузырек
//                        for (int i = 0; i < prices.Count - 1; i++)
//                        {
//                            for (int j = 0; j < prices.Count - i - 1; j++)
//                            {
//                                if (prices[j] > prices[j + 1])
//                                {
//                                    double tempPrice = prices[j];
//                                    prices[j] = prices[j + 1];
//                                    prices[j + 1] = tempPrice;

//                                    string tempName = names[j];
//                                    names[j] = names[j + 1];
//                                    names[j + 1] = tempName;
//                                }
//                            }
//                        }

//                        Console.WriteLine("\nОтсортировано по возрастанию цены!");
//                        for (int i = 0; i < names.Count; i++)
//                        {
//                            Console.WriteLine($"{i + 1}. {names[i]} — {prices[i]} руб.");
//                        }
//                        break;

//                    case 4:
//                        Console.WriteLine("\nВ какую валюту перевести?");
//                        Console.WriteLine("1 - Доллары ($)");
//                        Console.WriteLine("2 - Свой курс");

//                        ConsoleKeyInfo curKey = Console.ReadKey(true);
//                        double rate = 1;
//                        string curName = "руб.";

//                        if (curKey.KeyChar == '1')
//                        {
//                            rate = 90;
//                            curName = "$";
//                        }
//                        else if (curKey.KeyChar == '2')
//                        {
//                            Console.Write("\nВведи курс к рублю: ");
//                            rate = double.Parse(Console.ReadLine().Replace('.', ','));
//                            curName = "ед.";
//                        }

//                        Console.WriteLine("\n--- В пересчете ---");
//                        for (int i = 0; i < names.Count; i++)
//                        {
//                            double converted = prices[i] / rate;
//                            Console.WriteLine($"{names[i]} — {converted:F2} {curName}");
//                        }
//                        break;

//                    case 5:
//                        Console.Write("\nВведи слово для поиска: ");
//                        string search = Console.ReadLine().ToLower();

//                        Console.WriteLine("\nРезультаты поиска:");
//                        bool found = false;

//                        for (int i = 0; i < names.Count; i++)
//                        {
//                            if (names[i].ToLower().Contains(search))
//                            {
//                                Console.WriteLine($"{names[i]} — {prices[i]} руб.");
//                                found = true;
//                            }
//                        }

//                        if (!found)
//                        {
//                            Console.WriteLine("Ничего не найдено.");
//                        }
//                        break;

//                    case 0:
//                        Console.WriteLine("\nПока!");
//                        return;

//                    default:
//                        Console.WriteLine("\nНет такого пункта, жми от 0 до 5!");
//                        break;
//                }
//            }
//        }
//    }
//}
