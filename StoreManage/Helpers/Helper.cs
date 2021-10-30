using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Helpers
{
    public static class Helper
    {
        public static void AddFeature(Service service)
        {
            bool check;
            int value = -1; 
            do
            {
                try
                {
                    check = true;
                    Console.Write($"\t\t\tThêm {service.Name()} ( Không sử dụng - 0 , Có sử dụng - 1  ): ");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\t\tNhập sai định dạng (chỉ cho phép nhập số).Vui lòng nhập lại ! ");
                    check = false;
                }
            } while (value != 0 && value != 1 || check == false);
            if (value == 1) service.Add = true; 
        }
        public static void AddQuantity(string content, ref int value)
        {
            bool check;
            do
            {
                try
                {
                    check = true;
                    Console.Write($"{content}");
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value <= 0)
                    {
                        Console.WriteLine($"\t\tChỉ được nhập giá trị lớn hơn 0 . Vui lòng nhập lại !");
                        check = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\t\tNhập sai định dạng (chỉ cho phép nhập số). Vui lòng nhập lại !  ");
                    check = false;
                }
            } while (check == false);
        }
        public static void ChooseTwoOption(int Option1, int Option2,string Question, ref int Answer)
        {
            bool check; 
            do
            {
                try
                {
                    check = true;
                    Console.Write(Question);
                    Answer = Convert.ToInt32(Console.ReadLine());
                    if (Answer != Option1 && Answer != Option2)
                        Console.WriteLine($"\t\tChỉ được phép nhập hai giá trị {Option1} và {Option2} Vui lòng nhập lại !  ");
                }
                catch (Exception)
                {
                    Console.WriteLine("\t\tNhập sai định dạng (chỉ cho phép nhập số). Vui lòng nhập lại !  ");
                    check = false;
                }
            } while (Answer != Option1 && Answer != Option2|| check == false);
        }
        public static void ChooseThreeOption(int Option1, int Option2, int Option3, string Question, ref int Answer)
        {
            bool check;
            do
            {
                try
                {
                    check = true;
                    Console.Write(Question);
                    Answer = Convert.ToInt32(Console.ReadLine());
                    if (Answer != Option1 && Answer != Option2 && Answer != Option3)
  
                        Console.WriteLine($"\t\tChỉ được phép nhập ba giá trị {Option1} , {Option2} và {Option3} Vui lòng nhập lại !  ");

                }
                catch (Exception)
                {
                    Console.WriteLine("\t\tNhập sai định dạng (chỉ cho phép nhập số). Vui lòng nhập lại !  ");
                    check = false;
                }
            } while (Answer != Option1 && Answer != Option2 && Answer != Option3 || check == false);
        }

        
    }
}
