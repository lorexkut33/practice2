using System;
using System.Collections.Generic;
using System.Text;
using static задания_разработка_п_м.practice2.ProductCategory;

namespace задания_разработка_п_м.practice2
{
 public class Product
 {
     private static int _nextId = 1;

     public int Id { get; }
     public string Name { get; set; }
     public decimal Price { get; set; }
     public int Quantity { get; set; }
     public ProductCategory Category { get; set; }

     public bool IsInStock => Quantity > 0;

     public Product(string name, decimal price, int quantity, ProductCategory category)
     {
         Id = _nextId++;
         Name = name;
         Price = price;
         Quantity = quantity;
         Category = category;
     }

     public string GetCategoryDisplayName() => Category switch
     {
         ProductCategory.Groceries => "Продукты",
         ProductCategory.Electronics => "Электроника",
         ProductCategory.HouseholdChemicals => "Бытовая химия",
         _ => "Неизвестно"
     };

     public void PrintInfo()
     {
         Console.WriteLine($"[Код: {Id}] {Name}");
         Console.WriteLine($"  Категория:  {GetCategoryDisplayName()}");
         Console.WriteLine($"  Цена:       {Price:C}");
         Console.WriteLine($"  Количество: {Quantity} шт.");
         Console.WriteLine($"  На складе:  {(IsInStock ? "Да" : "Нет (закончился)")}");
         Console.WriteLine(new string('-', 35));
     }
 }
 
}
