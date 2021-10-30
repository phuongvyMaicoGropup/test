using StoreManage.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManage
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu menu = new Menu();
            menu.Input(); 

        }
        public static void Menu()
        {
            
           
            while (true)
            {
                Console.WriteLine("\tMenu : ");
                Console.WriteLine("\t\tEnter :  Thoát màn hình : ");
                Console.WriteLine("\t\tTab   :  Hiển thị đường dẫn file lưu hóa đơn : ");
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Kết thúc chương trình");
                    break;
                }
                if (input.Key == ConsoleKey.Tab)
                {
                    Console.WriteLine("\t\t=>Đường dẫn: "+Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt");
                    Console.ReadLine(); 
                 
                }
            }

        }
    }
}
