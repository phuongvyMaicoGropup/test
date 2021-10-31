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
        protected string _option;
        protected Bill _bill = new Bill();
        public Bill Bill => _bill;
        public string Option => _option; 
        public void Input()
        {
            do
            { 
                Console.WriteLine("\t**************************");
                Console.WriteLine();
                Console.WriteLine("\tQuản lý cửa hàng B: ");
                Console.WriteLine("\t1. Thêm hóa đơn ");
                Console.WriteLine("\t2. Xem dữ liệu hóa đơn ");
                Console.WriteLine("\t3. Xuất dữ liệu hóa đơn ");
                Console.WriteLine("\t4. Thoát chương trình");
                Console.WriteLine();
                Console.WriteLine("\t**************************");
                Console.Write("\t=>Vui lòng nhập lựa chọn : ");
                _option = Console.ReadLine();
                if (_option == "1" || _option == "2" || _option == "3" || _option == "4") UI.Clear();

                switch (_option)
                {
                    case "1":
                        _bill.Input();

                        UI.Clear(); 
                        break;
                    case "2":
                        if (_bill.TotalBill == 0)
                        {
                            Console.WriteLine("\tChưa nhập hóa đơn. Vui lòng nhập lựa chọn khác!");
                            break;
                        }
                        _bill.PrintConsole();
                        break;
                    case "3":
                        if (_bill.TotalBill == 0)
                        {
                            Console.WriteLine("\tChưa nhập hóa đơn. Vui lòng nhập lựa chọn khác!");
                            break;
                        }
                        _bill.PrintTxt();
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

            } while (_option != "4" );
        }
    }
}
