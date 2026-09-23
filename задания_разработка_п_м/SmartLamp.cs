//using System;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using System.Text;

//namespace задания_разработка_п_м
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            SmartLamp smartLamp = new SmartLamp();
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("1 - Включить лампу");
//                Console.WriteLine("2 - Выключить лампу");
//                Console.WriteLine("3 - Установить яркость");
//                Console.WriteLine("4 - Установить температуру цвета");
//                Console.WriteLine("5 - Применить сцену");
//                Console.WriteLine("6 - Вывести информацию о лампе");
//                Console.WriteLine("0 - Выйти");
//                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

//                // compare the key pressed 
//                switch (keyInfo.KeyChar)
//                {
//                    case '1':
//                        smartLamp.TurnOn();
//                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                        Console.ReadKey(true);
//                        break;
//                    case '2':
//                        smartLamp.TurnOff();
//                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                        Console.ReadKey(true);
//                        break;
//                    case '3':
//                        Console.WriteLine("Введите яркость (0-100): ");
//                        if (int.TryParse(Console.ReadLine(), out int brightness))
//                        {
//                            smartLamp.SetBrightness(brightness);
//                        }
//                        else
//                        {
//                            Console.WriteLine("Введите яркость ЦИФРАМИ!");
//                        }
//                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                        Console.ReadKey(true);
//                        break;

//                    case '4':
//                        Console.WriteLine("Введите температуру цвета (2700-6500): ");
//                        if (int.TryParse(Console.ReadLine(), out int colorTemperature))
//                        {
//                            smartLamp.SetColorTemperature(colorTemperature);
//                        }
//                        else
//                        {
//                            Console.WriteLine("Введите температуру цвета ЦИФРАМИ!");
//                        }
//                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                        Console.ReadKey(true);
//                        break;

//                    case '5':
//                        Console.WriteLine("Введите название сцены (ночь, чтение, день): ");
//                        string scene = Console.ReadLine() ?? "";
//                        if (!string.IsNullOrWhiteSpace(scene) && !int.TryParse(scene, out _))
//                        {
//                            smartLamp.ApplyScene(scene.Trim().ToLower());
//                        }
//                        else
//                        {
//                            Console.WriteLine("Введите название сцены БУКВАМИ!");
//                        }
//                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                        Console.ReadKey(true);
//                        break;
//                    case '6':
//                        smartLamp.PrintInfo();
//                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                        Console.ReadKey(true);
//                        break;
//                    case '0':
//                        return;
//                    default:
//                        Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
//                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                        Console.ReadKey(true);
//                        break;
//                }
//            }
//        }
//    }

//    internal class SmartLamp
//    {
//        static int _counter = 1;
//        public int Id { get; private set; }

//        //Constructor for counter ID
//        public SmartLamp()
//        {
//            Id = _counter;
//            _counter++;
//            IsOn = false;
//            _brightness = 0;
//            _colorTemperature = 2700;
//        }

//        public bool IsOn { get; private set; }

//        private int _brightness;
//        public int Brightness
//        {
//            get => _brightness;
//            set
//            {
//                if (value < 0 || value > 100)
//                {
//                    Console.WriteLine("Введите корректные данные яркости (от 0 до 100)!");
//                }
//                else
//                {
//                    _brightness = value;
//                    Console.WriteLine($"Яркость установлена: {_brightness}%");
//                }
//            }
//        }

//        private int _colorTemperature;
//        public int ColorTemperature
//        {
//            get => _colorTemperature;
//            set
//            {
//                if (value < 2700 || value > 6500)
//                {
//                    Console.WriteLine("Введите корректные данные температуры цвета (от 2700 до 6500)!");
//                }
//                else
//                {
//                    _colorTemperature = value;
//                    Console.WriteLine($"Температура цвета установлена: {_colorTemperature}K");
//                }
//            }
//        }

//        public string Mode => ColorTemperature switch
//        {
//            <= 3000 => "Ночь",
//            <= 5000 => "Чтение",
//            _ => "День"
//        };

//        //methods controlling the lamp
//        public void TurnOn()
//        {
//            IsOn = true;
//            Console.WriteLine("Лампа включена");
//        }

//        public void TurnOff()
//        {
//            IsOn = false;
//            Console.WriteLine("Лампа выключена");
//        }

//        public void SetBrightness(int value)
//        {
//            if (IsOn == false)
//            {
//                Console.WriteLine("Сначала включи лампу!");
//            }
//            else
//            {
//                Brightness = value;
//            }
//        }

//        public void SetColorTemperature(int value)
//        {
//            if (IsOn == false)
//            {
//                Console.WriteLine("Сначала включи лампу!");
//            }
//            else
//            {
//                ColorTemperature = value;
//            }
//        }

//        public void ApplyScene(string scene)
//        {
//            if (IsOn == false)
//            {
//                Console.WriteLine("Сначала включи лампу!");
//                return;
//            }

//            switch (scene.ToLower())
//            {
//                case "ночь":
//                    Brightness = 10;
//                    ColorTemperature = 3000;
//                    Console.WriteLine("Применена сцена «Ночь».");
//                    break;

//                case "чтение":
//                    Brightness = 40;
//                    ColorTemperature = 4500;
//                    Console.WriteLine("Применена сцена «Чтение».");
//                    break;

//                case "день":
//                    Brightness = 100;
//                    ColorTemperature = 6000;
//                    Console.WriteLine("Применена сцена «День».");
//                    break;

//                default:
//                    Console.WriteLine($"Неизвестная сцена «{scene}». Доступны: ночь, чтение, день.");
//                    break;
//            }
//        }

//        public void PrintInfo()
//        {
//            Console.WriteLine($"Лампа {Id}:\n- Включена: {IsOn}\n- Яркость: {Brightness}%\n- Температура цвета: {ColorTemperature}K\n- Режим: {Mode}");
//        }
//    }
//}