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
            bool check; 
            do
            {
                try
                {
                    check = true;
                    Console.Write("Số lượng hóa đơn muốn nhập: ");
                    BillCount = Convert.ToInt32(Console.ReadLine());
                    if (BillCount <= 0) check = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine("\t\t" + error.Message + " Sai định dạng ");
                    check = false;
                }
            } while (check == false);
            
            Bill[] totalBill = new Bill[BillCount];

            for (int i = 0; i<BillCount; i++) 
            {
                totalBill[i] = new Bill();
                totalBill[i].InputBill();
                totalBill[i].PrintBill(i+1);
            }
        }
    }
}
