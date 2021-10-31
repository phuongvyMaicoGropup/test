﻿using StoreManage.DataStructure;
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
        private List<BillDetail> _bills = new List<BillDetail>();
        private int _countBill;
        public int TotalBill => _countBill;
        

        public void Input()
        {
            Helper.AddQuantity("\tSố lượng hóa đơn muốn nhập : ", ref _countBill);
            WriteLine(); 
            for (int i = 0; i< _countBill; i++)
            {
                BillDetail bill = new BillDetail();
                bill.Input(i);
                _bills.Add(bill); 
            }

        }
        public void PrintTxt()
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt", FileMode.Create);

            StreamWriter sWriter = new StreamWriter(fs);
            int i = 0; 
            foreach (var bill in _bills)
            {
                i++;
                sWriter.WriteLine("\t**************************************************");
                sWriter.WriteLine();
                sWriter.WriteLine($"\tThông tin hóa đơn thứ {i} : ");
                sWriter.WriteLine($"\t Mã hóa đơn : {bill.Id}");
                sWriter.WriteLine($"\t Ngày lập   : {bill.DateCreate.Day}/{bill.DateCreate.Month}/{bill.DateCreate.Year}");
                sWriter.WriteLine($"\t Tổng giá   : {bill.TotalCost}");
                sWriter.WriteLine();
                sWriter.WriteLine("\t--------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine($"\tThông tin khách hàng :");
                sWriter.WriteLine(bill.Customer.Output());
                sWriter.WriteLine();
                sWriter.WriteLine($"\t--------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine("\tDanh sách chi tiết các hóa đơn :");
                sWriter.WriteLine();
                for (int j = 0; j < bill.Products.Count; j++)
                {
                    sWriter.WriteLine($"\tChi tiết hóa đơn thứ {j+1} " );
                    foreach (var s in bill.Products[j].SResult)
                    {
                        sWriter.Write(s);
                    }
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
            WriteLine("\tDanh sách các hóa đơn: "); 
            for (int t = 1; t <= _countBill; t++)
            {
                WriteLine($"\t {t}. Hiện hóa đơn thứ {t}."); 
            }
            Write($"\tNhập thứ tự hóa đơn muốn xem hiện tại : ");
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
                WriteLine($"\t Mã hóa đơn : {_bills[page].Id}");
                WriteLine($"\t Ngày lập   : {_bills[page].DateCreate.Day}/{_bills[page].DateCreate.Month}/{_bills[page].DateCreate.Year}");
                WriteLine($"\t Tổng giá   : {_bills[page].TotalCost}");
                WriteLine();
                WriteLine("\t--------------------------------------------------");
                WriteLine();
                WriteLine($"\tThông tin khách hàng :");
                WriteLine(_bills[page].Customer.Output());
                WriteLine();
                WriteLine($"\t--------------------------------------------------");
                WriteLine();
                WriteLine("\tDanh sách chi tiết các hóa đơn :");
                WriteLine();
                for (int j = 0; j < _bills[page].Products.Count; j++)
                {
                    WriteLine($"\tChi tiết hóa đơn thứ {j + 1} ");
                    foreach (var s in _bills[page].Products[j].SResult)
                    {
                        Write(s);
                    }
                }
                WriteLine();
                WriteLine("\t**************************************************");
                input = ReadKey();
                if (input.Key == ConsoleKey.RightArrow)
                {
                    if (page < _bills.Count-1) page++;
                    else page = 0; 
                }
                if (input.Key == ConsoleKey.LeftArrow)
                {
                    if (page > 0 ) page--;
                    else page = _countBill-1;
                }
                Clear();
            } while (input.Key != ConsoleKey.Enter);

        }
}
}
