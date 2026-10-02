//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace задания_разработка_п_м.lessons
//{
//    interface IBatteryPowered
//    {
//        int batterylevel { get; set; }
//        void Charge();
//    }
//    internal abstract class AbstractClass
//    {
//        static void Main(string[] args)
//        {
//            List<SmartDevice> list_device = new List<SmartDevice>()
//            {
//                new SmartLamp("Лампа", 70, 89),
//                new RobotVacuum("Пылесос", 100, 75),
//                new SmartLock("Замок", true, 50)
//            };
//            foreach (var device in list_device)
//            {
//                device.TurnOn();
//                device.GetStatus();
//                if (device is IBatteryPowered batteryDevice)
//                {
//                    batteryDevice.Charge();
//                }
//            }
//        }
//    }

//    public abstract class SmartDevice
//    {
//        public string? Name { get; set; }
//        public bool IsOn { get; protected set; }
//        public abstract void GetStatus();
//        public SmartDevice(string name)
//        {
//            Name = name;
//            IsOn = false;
//        }
//        public void TurnOn()
//        {
//            IsOn = true;
//            Console.WriteLine($"{Name}: включенo");
//        }
//        public void TurnOff()
//        {
//            IsOn = false;
//            Console.WriteLine($"{Name}: выключенo");

//        }
//    }
//    public class SmartLamp : SmartDevice, IBatteryPowered
//    {
//        public int Brightness { get; set; }
//        public int batterylevel { get; set; }
//        public SmartLamp(string name, int brightness, int ibatterylevel) : base(name)
//        {
//            Brightness = brightness;
//            batterylevel = ibatterylevel;
//        }
//        public override void GetStatus()
//        {
//            Console.WriteLine($"{Name}: {IsOn} яркость {Brightness}");
//        }
//        public void Charge()
//        {
//            if (batterylevel < 0)
//            {
//                Console.WriteLine("Введите корректные данные о заряде батареи");
//            } 
//            Console.WriteLine("заряжается");
//        }
//    }
//    public class RobotVacuum : SmartDevice, IBatteryPowered
//    {
//        public int SuctionPower { get; set; }
//        public int batterylevel { get; set; }
//        public RobotVacuum(string name, int suctionPower, int ibatterylevel) : base(name)
//        {
//            SuctionPower = suctionPower;
//            batterylevel = ibatterylevel;
//        }
//        public override void GetStatus()
//        {
//            Console.WriteLine($"{Name}: {IsOn}, \nСила всасывания: {SuctionPower}");
//        }
//        public void Charge()
//        {
//            Console.WriteLine($"заряжается");
//        }

//    }
//    public class SmartLock : SmartDevice, IBatteryPowered
//    {
//        public bool IsLocked { get; set; }
//        public int batterylevel { get; set; }
//        public SmartLock(string name, bool isLocked, int ibatterylevel) : base(name)
//        {
//            IsLocked = isLocked;
//            batterylevel = ibatterylevel;
//        }
//        public override void GetStatus()
//        {
//            Console.WriteLine($"{Name}: {IsOn}, \nЗаблокирован: {IsLocked}");
//        }
//        public void Charge()
//        {
//            Console.WriteLine($"заряжается");
//        }
//    }
//}

