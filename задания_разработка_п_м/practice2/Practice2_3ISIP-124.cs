using System;
using System.Collections.Generic;
using System.Text;
using static задания_разработка_п_м.practice2.ProductCategory;

namespace задания_разработка_п_м.practice2
{
    internal class Practice2_3ISIP_124
    {
        static List<Product> products = new List<Product>();
        static Stack<SaleRecord> salesHistory = new Stack<SaleRecord>();
        static List<SaleRecord> allSales = new List<SaleRecord>();

        static void Main(string[] args)
        {
            // 5 тестовых товаров
            products.Add(new Product("Молоко", 89.90m, 15, ProductCategory.Groceries));
            products.Add(new Product("Хлеб", 45.00m, 20, ProductCategory.Groceries));
            products.Add(new Product("Наушники", 2490.00m, 5, ProductCategory.Electronics));
            products.Add(new Product("Мышь проводная", 850.00m, 8, ProductCategory.Electronics));
            products.Add(new Product("Стиральный порошок", 420.00m, 12, ProductCategory.HouseholdChemicals));

            while (true)
            {
                Console.Clear();
                Console.WriteLine("====== УЧЁТ ТОВАРОВ В МАГАЗИНЕ ======");
                Console.WriteLine("1 - Показать все товары");
                Console.WriteLine("2 - Добавить товар");
                Console.WriteLine("3 - Удалить товар");
                Console.WriteLine("4 - Заказать поставку (пополнить склад)");
                Console.WriteLine("5 - Продать товар");
                Console.WriteLine("6 - Поиск товаров");
                Console.WriteLine("7 - Отменить последнюю продажу (*)");
                Console.WriteLine("8 - Отчёт о продажах (*)");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("=====================================");
                Console.Write("Выберите действие: ");

                ConsoleKeyInfo key = Console.ReadKey(true);
                Console.WriteLine(key.KeyChar);

                switch (key.KeyChar)
                {
                    case '1':
                        ShowAllProducts();
                        break;
                    case '2':
                        AddProduct();
                        break;
                    case '3':
                        DeleteProduct();
                        break;
                    case '4':
                        RestockProduct();
                        break;
                    case '5':
                        SellProduct();
                        break;
                    case '6':
                        SearchProduct();
                        break;
                    case '7':
                        UndoLastSale();
                        break;
                    case '8':
                        ShowSalesReport();
                        break;
                    case '0':
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Неверная команда!");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey(true);
            }
        }

        static void ShowAllProducts()
        {
            Console.Clear();
            Console.WriteLine("=== СПИСОК ТОВАРОВ НА СКЛАДЕ ===\n");
            if (products.Count == 0)
            {
                Console.WriteLine("Склад пуст!");
                return;
            }

            foreach (var item in products)
            {
                item.PrintInfo();
            }
        }

        static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("=== ДОБАВЛЕНИЕ НОВОГО ТОВАРА ===\n");

            string name;
            while (true)
            {
                Console.Write("Введите название: ");
                name = Console.ReadLine()?.Trim() ?? "";
                if (!string.IsNullOrWhiteSpace(name))
                    break;
                Console.WriteLine("Название не может быть пустым!");
            }

            decimal price;
            while (true)
            {
                Console.Write("Введите цену (> 0): ");
                if (decimal.TryParse(Console.ReadLine(), out price) && price > 0)
                    break;
                Console.WriteLine("Ошибка: введите положительное число!");
            }

            int quantity;
            while (true)
            {
                Console.Write("Введите начальное количество (>= 0): ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
                    break;
                Console.WriteLine("Ошибка: количество не может быть отрицательным!");
            }

            Console.WriteLine("\nВыберите категорию:");
            Console.WriteLine("1 - Продукты");
            Console.WriteLine("2 - Электроника");
            Console.WriteLine("3 - Бытовая химия");

            ProductCategory category = ProductCategory.Groceries;
            while (true)
            {
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();
                if (choice == "1") { category = ProductCategory.Groceries; break; }
                if (choice == "2") { category = ProductCategory.Electronics; break; }
                if (choice == "3") { category = ProductCategory.HouseholdChemicals; break; }
                Console.WriteLine("Неверный номер категории. Введите 1, 2 или 3.");
            }

            Product newProduct = new Product(name, price, quantity, category);
            products.Add(newProduct);
            Console.WriteLine($"\nТовар «{name}» успешно добавлен с кодом {newProduct.Id}!");
        }

        static void DeleteProduct()
        {
            Console.Clear();
            Console.WriteLine("=== УДАЛЕНИЕ ТОВАРА ===\n");
            Console.Write("Введите код товара для удаления: ");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Код должен быть числом!");
                return;
            }

            Product product = FindById(id);
            if (product == null)
            {
                Console.WriteLine($"Товар с кодом {id} не найден.");
                return;
            }

            products.Remove(product);
            Console.WriteLine($"Товар «{product.Name}» успешно удален!");
        }

        static void RestockProduct()
        {
            Console.Clear();
            Console.WriteLine("=== ПОСТАВКА ТОВАРА ===\n");
            Console.Write("Введите код товара: ");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Код должен быть числом!");
                return;
            }

            Product product = FindById(id);
            if (product == null)
            {
                Console.WriteLine($"Товар с кодом {id} не найден.");
                return;
            }

            Console.Write($"Сколько штук товара «{product.Name}» прибыло: ");
            if (int.TryParse(Console.ReadLine(), out int amount) && amount > 0)
            {
                product.Quantity += amount;
                Console.WriteLine($"Поставка принята. Теперь на складе: {product.Quantity} шт.");
            }
            else
            {
                Console.WriteLine("Ошибка: количество должно быть больше 0!");
            }
        }

        static void SellProduct()
        {
            Console.Clear();
            Console.WriteLine("=== ПРОДАЖА ТОВАРА ===\n");
            Console.Write("Введите код товара: ");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Код должен быть числом!");
                return;
            }

            Product product = FindById(id);
            if (product == null)
            {
                Console.WriteLine($"Товар с кодом {id} не найден.");
                return;
            }

            if (!product.IsInStock)
            {
                Console.WriteLine($"Товара «{product.Name}» нет на складе!");
                return;
            }

            Console.WriteLine($"В наличии: {product.Quantity} шт. Цена за шт.: {product.Price:C}");
            Console.Write("Сколько штук продать: ");

            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine("Ошибка: введите положительное число штук!");
                return;
            }

            if (count > product.Quantity)
            {
                Console.WriteLine($"Ошибка: нельзя продать {count} шт., на складе всего {product.Quantity} шт.!");
                return;
            }

            product.Quantity -= count;
            decimal totalCost = count * product.Price;

            SaleRecord sale = new SaleRecord(product.Id, product.Name, count, totalCost);
            salesHistory.Push(sale);
            allSales.Add(sale);

            Console.WriteLine($"\nУспешно продано {count} шт. «{product.Name}» на сумму {totalCost:C}.");
            Console.WriteLine($"Остаток на складе: {product.Quantity} шт.");
        }

        static void SearchProduct()
        {
            Console.Clear();
            Console.WriteLine("=== ПОИСК ТОВАРОВ ===");
            Console.WriteLine("1 - По коду");
            Console.WriteLine("2 - По названию");
            Console.WriteLine("3 - По категории");
            Console.Write("Выберите вариант поиска: ");

            string choice = Console.ReadLine();
            List<Product> found = new List<Product>();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите код: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        Product p = FindById(id);
                        if (p != null) found.Add(p);
                    }
                    break;

                case "2":
                    Console.Write("Введите часть названия: ");
                    string query = Console.ReadLine()?.Trim().ToLower() ?? "";
                    foreach (var p in products)
                    {
                        if (p.Name.ToLower().Contains(query))
                            found.Add(p);
                    }
                    break;

                case "3":
                    Console.WriteLine("Категории: 1 - Продукты, 2 - Электроника, 3 - Бытовая химия");
                    Console.Write("Введите цифру категории: ");
                    string catChoice = Console.ReadLine();
                    ProductCategory? targetCat = catChoice switch
                    {
                        "1" => ProductCategory.Groceries,
                        "2" => ProductCategory.Electronics,
                        "3" => ProductCategory.HouseholdChemicals,
                        _ => null
                    };

                    if (targetCat.HasValue)
                    {
                        foreach (var p in products)
                        {
                            if (p.Category == targetCat.Value)
                                found.Add(p);
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Неверный вариант.");
                    return;
            }

            Console.WriteLine("\n=== РЕЗУЛЬТАТЫ ПОИСКА ===");
            if (found.Count == 0)
            {
                Console.WriteLine("Ничего не найдено.");
                return;
            }

            foreach (var item in found)
            {
                item.PrintInfo();
            }
        }

        static void UndoLastSale()
        {
            Console.Clear();
            Console.WriteLine("=== ОТМЕНА ПОСЛЕДНЕЙ ПРОДАЖИ ===\n");

            if (salesHistory.Count == 0)
            {
                Console.WriteLine("Истории продаж пока нет, отменять нечего!");
                return;
            }

            SaleRecord lastSale = salesHistory.Pop();

            Product product = FindById(lastSale.ProductId);
            if (product != null)
            {
                product.Quantity += lastSale.Quantity;
            }

            allSales.Remove(lastSale);

            Console.WriteLine($"Отменена продажа товара «{lastSale.ProductName}» ({lastSale.Quantity} шт.).");
            Console.WriteLine($"Товар возвращен на склад. Сумма к возврату: {lastSale.TotalPrice:C}.");
        }

        static void ShowSalesReport()
        {
            Console.Clear();
            Console.WriteLine("=== ОТЧЁТ О ПРОДАЖАХ ===\n");

            if (allSales.Count == 0)
            {
                Console.WriteLine("Продаж пока не было.");
                return;
            }

            int totalItems = 0;
            decimal totalRevenue = 0;

            foreach (var s in allSales)
            {
                Console.WriteLine($"- {s.ProductName}: {s.Quantity} шт. на сумму {s.TotalPrice:C}");
                totalItems += s.Quantity;
                totalRevenue += s.TotalPrice;
            }

            Console.WriteLine(new string('=', 35));
            Console.WriteLine($"Всего продано товаров: {totalItems} шт.");
            Console.WriteLine($"Общая сумма выручки:    {totalRevenue:C}");
        }

        static Product FindById(int id)
        {
            foreach (var p in products)
            {
                if (p.Id == id)
                    return p;
            }
            return null;
        }
        //gitigigr
    }
}
