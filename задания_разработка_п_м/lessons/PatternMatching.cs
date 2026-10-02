//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace задания_разработка_п_м.lessons
//{
//    internal class PatternMatching
//    {
//        static void Main(string[] args)
//        {
//            List<Person> persons = new List<Person>
//            {
//                new Teacher("Math", "Anna", 35 ),
//                new Student("John", 18, "3ISIP-124"),
//                new Guest("Guest", 0, 1)
//            };
//            foreach(var people in persons)
//            {
//                string message = people switch
//                {
//                    Student s => $"Student: {s.Name}, age: {s.Age}, Group: {s.Group}",
//                    Teacher t => $"Subject: {t.Lesson_lid}, Name: {t.Name}, Age: {t.Age}",
//                    Guest g => $"{g.Name}: age: {g.Age}, Id: {g.Id}"
//                };
//                Console.WriteLine(message);
//            }
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public Person(string name, int age)
//        {
//            Age = age;
//            Name = name;
//        }
//    }
//    public class Teacher : Person
//    {
//        public string Lesson_lid { get; set; }
//        public Teacher(string lesson_lid, string name, int age) : base(name, age)
//        {
//            Lesson_lid = lesson_lid;
//        }
//    }
//    public class Student : Person
//    {
//        public string Group { get; set; }
//        public Student(string name, int age,  string group) : base(name, age)
//        {
//            Group = group;
//        }
//    }
//    public class Guest : Person
//    {
//        public int Id { get; set; }
//        public Guest(string name, int age, int id) : base(name, age)
//        {
//            Id = id;
//        }
//    }
//}
