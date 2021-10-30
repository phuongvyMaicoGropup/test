using StoreManage.Helpers;
using System;
using System.Text;

namespace StoreManage
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int BillCount = 0;
            Helper.AddQuantity("Số lượng hóa đơn muốn nhập : ", ref BillCount);


            Bill[] Bills = new Bill[BillCount];

            for (int i = 0; i<BillCount; i++) 
            {
                Bills[i] = new Bill();
                Bills[i].InputBill();
            }
            BillHelpers.PrintBillToFile(Bills,BillCount);
            Menu(); 
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
