using StoreManage.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Helpers
{
    public class Menu
    {
        public string Option;
        private Bill _Bill = new Bill();
        public void Input()
        {
            do
            { 
                Console.WriteLine("\t**************************");
                Console.WriteLine();
                Console.WriteLine("\tQuản lý cửa hàng B: ");
                Console.WriteLine("\t1. Nhập dữ liệu hóa đơn ");
                Console.WriteLine("\t2. Xem dữ liệu hóa đơn ");
                Console.WriteLine("\t3. Xuất dữ liệu hóa đơn ");
                Console.WriteLine("\t4. Thoát chương trình");
                Console.WriteLine();
                Console.WriteLine("\t**************************");
                Console.Write("\t=>Vui lòng nhập lựa chọn : ");
                Option = Console.ReadLine();
                if (Option == "1" || Option == "2" || Option == "3" || Option == "4") UI.Clear();

                switch (Option)
                {
                    case "1":
                        _Bill.Input();

                        UI.Clear(); 
                        break;
                    case "2":
                        _Bill.PrintConsole();
                        break;
                    case "3":
                        _Bill.PrintTxt();
                        Console.WriteLine("\t->Đã xuất hóa đơn tại : " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt");
                        
                        UI.Clear();
                        break;
                    case "4":
                        UI.Exit(); 
                        break;
                    default:
                        Console.WriteLine("\tVui lòng nhập lại . Chỉ được nhập 1 trong các mục trên! ");
                        break; 

                }

            } while ( Option != "4" );
        }
    }
}
