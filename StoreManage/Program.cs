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
            Helpers.AddQuantity("Số lượng hóa đơn muốn nhập : ", ref BillCount);
            
            
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
