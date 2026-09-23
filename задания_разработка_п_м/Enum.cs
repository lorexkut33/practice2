//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace задания_разработка_п_м
//{
//    internal class lesson9
//    {
//        static void Main(string[] args)
//        {
//            Role userRole = Role.Moderator;
//            foreach (var role in Enum.GetValues<Role>())
//            {
//                int value = (int)role;
//                Console.WriteLine($"Роль: {role}, Значение роли: {value}");
//            }
//            userRole = Role.Moderator;
//            AccessControl(userRole);
//        }
//        enum Role
//        { 
//            Admin,
//            Moderator,
//            User,
//            Guest
//        }

//        static void AccessControl(Role userRole)
//        {
//            string message = userRole switch
//            {
//                Role.Admin => "Полный доступ: управление системой",


//                Role.Moderator => "Доступ модератора: модерирование и удаление контента",


//                Role.User => "Доступ пользователя: создание и просмотр записей",


//                Role.Guest => "У вас гостевой доступ: просмотр разрешён"
//            };
//            Console.WriteLine(message);
//        }
//    }
//}
