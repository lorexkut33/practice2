//using System;
//using System.Collections.Generic;
//using System.Net.Http.Headers;
//using System.Text;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace задания_разработка_п_м.lessons
//{
//    internal class GenericClass
//    {
//        static List<Product> products = new List<Product>
//        {
//            new Product(1, "Молоко", 89.9m, 5),
//            new Product(2, "Xleb", 50m, 5),
//            new Product(3, "Яйца", 60m, 10)
//        };
        
//        public static Result<Product> FindProducts(int id)
//        {
//            foreach (Product item in products)
//            {
//                if (item.Id == id)
//                {
//                    return Result<Product>.Success(item);
//                } 
//            }
//            return Result<Product>.Failure($"Товара с идентификационным номером: {id} нет");
//        }
//        static void Main(string[] args)
//        {
//            Result<Product> resul = FindProducts(200);
//            if (resul.IsSuccess)
//            {
//                Console.WriteLine($"Ваш товар найден: {resul.Value.Name}");
//            } else
//            {
//                Console.WriteLine($"товар не найден: {resul.Error}");
//            }
//        }
//    }

//    public class Result<T>
//    {
//        public bool IsSuccess { get; private set; }
//        public T? Value { get; private set; }
//        public string? Error { get; private set; }

//        public static Result<T> Success(T value)
//        {
//            return new Result<T> { IsSuccess = true, Value = value };
//        }

//        public static Result<T> Failure(string error)
//        {
//            return new Result<T> { IsSuccess = false, Error = error };
//        }
//    }
//    public class Product
//    {
//        public string Name { get; set; }
//        public decimal Price { get; set; }
//        public int Id { get; init; }
//        public int Count { get; set; }
//        public Product(int id, string name, decimal price, int count)
//        {
//            Id = id;
//            Name = name;
//            Price = price;
//            Count = count;
//        }
//    }
//}
