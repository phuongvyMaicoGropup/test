using StoreManage.DataStructure;
using StoreManage.Products;
using StoreManage.Products.AirConditioner;
using StoreManage.Products.Fan;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using StoreManage.Helpers;
using StoreManage.Bills;

namespace StoreManage
{
    public class Bill
    {
        private List<BillDetail> Bills = new List<BillDetail>();
        private int CountBill;
        public int GetTotalBill => CountBill;
        

        public void Input()
        {
            Helper.AddQuantity("\tSố lượng hóa đơn muốn nhập : ", ref CountBill);
            Console.WriteLine(); 
            for (int i = 0; i< CountBill; i++)
            {
                BillDetail bill = new BillDetail();
                bill.Input(i);
                Bills.Add(bill); 
            }

        }
        public void PrintTxt()
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt", FileMode.Create);

            StreamWriter sWriter = new StreamWriter(fs);
            int i = 0; 
            foreach (var bill in Bills)
            {
                i++;
                sWriter.WriteLine("\t**************************************************");
                sWriter.WriteLine();
                sWriter.WriteLine($"\tThông tin hóa đơn thứ {i} : ");
                sWriter.WriteLine($"\t Mã hóa đơn : {bill.GetId}");
                sWriter.WriteLine($"\t Ngày lập   : {bill.GetDateCreate.Day}/{bill.GetDateCreate.Month}/{bill.GetDateCreate.Year}");
                sWriter.WriteLine($"\t Tổng giá   : {bill.GetTotalCost}");
                sWriter.WriteLine();
                sWriter.WriteLine("\t--------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine($"\tThông tin khách hàng :");
                sWriter.WriteLine(bill.GetCustomer.Output());
                sWriter.WriteLine();
                sWriter.WriteLine($"\t--------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine("\tDanh sách chi tiết các hóa đơn :");
                sWriter.WriteLine();
                for (int j = 0; j < bill.GetProducts.Count; j++)
                {
                    sWriter.WriteLine($"\tChi tiết hóa đơn thứ {j+1} " );
                    sWriter.Write(bill.GetProducts[j].GetSResult);
                }
                sWriter.WriteLine();
                sWriter.WriteLine("\t**************************************************");

            }


            sWriter.Flush();
            fs.Close();
        }
        public void PrintConsole()
        {
            int page = 0; 
            Write($"\tNhập thứ tự hóa đơn muốn xem hiện tại (yêu cầu : 0 < số thứ tự < {CountBill+1} ): ");
            page = Convert.ToInt32(ReadLine());

            var input = Console.ReadKey();
            page--; 

            do
            {
                WriteLine("\tSử dụng mũi tên trái phải để chuyển qua lại giữa các hóa đơn. Enter để kết thúc. ");
                WriteLine(); 
                WriteLine("\t**************************************************");
                WriteLine();
                WriteLine($"\tThông tin hóa đơn thứ {page+1} : ");
                WriteLine($"\t Mã hóa đơn : {Bills[page].GetId}");
                WriteLine($"\t Ngày lập   : {Bills[page].GetDateCreate.Day}/{Bills[page].GetDateCreate.Month}/{Bills[page].GetDateCreate.Year}");
                WriteLine($"\t Tổng giá   : {Bills[page].GetTotalCost}");
                WriteLine();
                WriteLine("\t--------------------------------------------------");
                WriteLine();
                WriteLine($"\tThông tin khách hàng :");
                WriteLine(Bills[page].GetCustomer.Output());
                WriteLine();
                WriteLine($"\t--------------------------------------------------");
                WriteLine();
                WriteLine("\tDanh sách chi tiết các hóa đơn :");
                WriteLine();
                for (int j = 0; j < Bills[page].GetProducts.Count; j++)
                {
                    WriteLine($"\tChi tiết hóa đơn thứ {j + 1} ");
                    Write(Bills[page].GetProducts[j].GetSResult);
                }
                WriteLine();
                WriteLine("\t**************************************************");
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.RightArrow)
                {
                    if (page < Bills.Count-1) page++;
                    else page = 0; 
                }
                if (input.Key == ConsoleKey.LeftArrow)
                {
                    if (page > 0 ) page--;
                    else page = CountBill-1;
                }
                Console.Clear();
            } while (input.Key != ConsoleKey.Enter);

        }
}
}
