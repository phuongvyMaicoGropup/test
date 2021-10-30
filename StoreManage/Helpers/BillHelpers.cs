using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Helpers
{
    static class BillHelpers
    {
        public static void PrintBillToFile(Bill[] bills, int TotalBill)
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt", FileMode.Create);

            StreamWriter sWriter = new StreamWriter(fs);
            for (int i = 0; i < TotalBill; i++)
            {
                sWriter.WriteLine("\t-------------------------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine($"\tThông tin hóa đơn thứ {i + 1} : ");
                sWriter.WriteLine($"\t Mã hóa đơn : {bills[i].GetId}");
                sWriter.WriteLine($"\t Ngày lập   : {bills[i].GetDateCreate.Day}/{bills[i].GetDateCreate.Month}/{bills[i].GetDateCreate.Year}");
                sWriter.WriteLine($"\t Tổng giá   : {bills[i].GetTotalCost}");
                sWriter.WriteLine();
                sWriter.WriteLine("\t--------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine($"\tThông tin khách hàng :");
                sWriter.WriteLine(bills[i].GetCustomer.PrintInfo());
                sWriter.WriteLine();
                sWriter.WriteLine($"\t--------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine("\tDanh sách chi tiết các hóa đơn :");
                sWriter.WriteLine();
                for (int j = 0; j < bills[i].GetProducts.Length; j++)
                {
                    sWriter.Write("\tChi tiết hóa đơn thứ "+ j+1);
                    sWriter.Write(bills[i].GetProducts[j].GetOutput);
                }
                sWriter.WriteLine();
            }
            sWriter.Flush();
            fs.Close();
        }
        public static void PrintBillToConsole(Bill[] bills, int TotalBill)
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt", FileMode.Create);

            StreamWriter sWriter = new StreamWriter(fs);
            for (int i = 0; i < TotalBill; i++)
            {
                sWriter.WriteLine("\t-------------------------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine($"\tThông tin hóa đơn thứ {i + 1} : ");
                sWriter.WriteLine($"\t Mã hóa đơn : {bills[i].GetId}");
                sWriter.WriteLine($"\t Ngày lập   : {bills[i].GetDateCreate.Day}/{bills[i].GetDateCreate.Month}/{bills[i].GetDateCreate.Year}");
                sWriter.WriteLine($"\t Tổng giá   : {bills[i].GetTotalCost}");
                sWriter.WriteLine();
                sWriter.WriteLine("\t--------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine($"\tThông tin khách hàng :");
                sWriter.WriteLine(bills[i].GetCustomer.PrintInfo());
                sWriter.WriteLine();
                sWriter.WriteLine($"\t--------------------------------------------------");
                sWriter.WriteLine();
                sWriter.WriteLine("\tDanh sách chi tiết các hóa đơn :");
                sWriter.WriteLine();
                for (int j = 0; j < bills[i].GetProducts.Length; j++)
                {
                    sWriter.Write("\tChi tiết hóa đơn thứ " + j + 1);
                    sWriter.Write(bills[i].GetProducts[j].GetOutput);
                }
                sWriter.WriteLine();
            }
            sWriter.Flush();
            fs.Close();
        }
    }
}
