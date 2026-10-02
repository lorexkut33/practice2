//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace задания_разработка_п_м.lessons
//{
//    // Родительский класс (базовый)
//    public class Transport
//    {
//        public string type_of_Transport { get; set; }
//        public decimal HP { get; set; }
//        public int count_of_wheels { get; set; }
//        public int max_speed { get; set; }
//        public Transport(string typeOfTransport, decimal hp, int countOfWheels, int maxSpeed)
//        {
//            type_of_Transport = typeOfTransport;
//            HP = hp;
//            count_of_wheels = countOfWheels;
//            max_speed = maxSpeed;
//        }
//        public virtual void PrintInfo()
//        {
//            Console.WriteLine($"Transport Info: {type_of_Transport}");
//            Console.WriteLine($"HP: {HP}");
//            Console.WriteLine($"Wheels: {count_of_wheels}");
//            Console.WriteLine($"Max Speed: {max_speed}");
//        }
//    }
//    public class car : Transport
//    { 
//        public string brand { get; set; }
//        public string model { get; set; }
//        public int year_of_production { get; set; }
//        public car(string BRAND, string MODEL, int YEAROFPRODUCTION, string typeOfTransport, decimal hp, int CountOfWheels, int MaxSpeed)
//            : base("Car", 350, 4, 250)
//        {
//            brand = BRAND;
//            model = MODEL;
//            year_of_production = YEAROFPRODUCTION;
//        }
//        public override void PrintInfo()
//        {
//            base.PrintInfo();
//            Console.WriteLine($"Brand: {brand}, \nModel: {model}, \nYear Production: {year_of_production}");
//        }


//    }
//    public class bike : Transport
//    {
//        public string type_of_bike { get; set; }
//        public int volume_of_engine { get; set; }
//        public bike(string typeOfBike, int volumeOfEngine, string typeOfTransport, decimal hp, int CountOfWheels, int MaxSpeed)
//            : base("Bike", 150, 2, 100)
//        {
//            type_of_bike = typeOfBike;
//            volume_of_engine = volumeOfEngine;
//        }
//        public override void PrintInfo()
//        {
//            base.PrintInfo();
//            Console.WriteLine($"Type of bike: {type_of_bike}");
//            Console.WriteLine($"Volume of engine: {volume_of_engine}");
//        }
//    }
//    public class electro_scooter : Transport
//    {
//        public int battery { get; set; }
//        public string motor_place { get; set; }
//        public electro_scooter(int Battery, string MotorPlace, string typeOfTransport, decimal hp, int CountOfWheels, int MaxSpeed)
//            : base("Electro Scooter", 100, 4, 50)
//        {
//            battery = Battery;
//            motor_place = MotorPlace;
//        }
//        public override void PrintInfo() 
//        {
//            base.PrintInfo();
//            Console.WriteLine($"Battery: {battery}");
//            Console.WriteLine($"MotorPlace: {motor_place}");
//        }
//    }

//    internal class Program 
//    {
//        static void Main(string[] args)
//        {
//            var transport = new List<Transport>
//            {
//                new car("Toyota", "Land cruiser", 2022, "Car", 350, 4, 250),
//                new bike("Mountain", 250, "Bike", 150, 2, 100),
//                new electro_scooter(100, "Rear", "Electro Scooter", 100, 4, 50)
//            };
//            foreach (Transport transp in transport)
//            {
//                transp.PrintInfo();
//            }

//        }
//    }
//}
