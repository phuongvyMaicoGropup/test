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
        // Helper.AddService(_Antibacterial);
        public static void AddService(Service service)
        {
            bool check;
            int value = -1; 
            do
            {
                try
                {
                    check = true;
                    Console.Write($"\t\t\tThêm {service.Name()} ( Không sử dụng - 1 , Có sử dụng - 2  ): ");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\t\tNhập sai định dạng (chỉ cho phép nhập số).Vui lòng nhập lại ! ");
                    check = false;
                }
            } while (value != 1 && value != 2 || check == false);
            if (value == 2) service.Add = true; 
        }

        //Helper.AddQuantity("\t - Nhập số lượng chi tiết trong danh sách cac chi tiết hóa đơn : ", ref _count);

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

        //Helper.ChooseTwoOption(1, 2, "\t\tChọn loại thiết bị điện (1-máy quạt, 2- máy lạnh):", ref Answer);
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

         // Helper.ChooseThreeOption(1, 2, 3, "\t\t + Chọn loại máy quạt (1-máy quạt đứng,2- máy quạt hơi nước,3 – máy quạt sạc điện): ", ref TypeOfFan);
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
        // Helper.InputCheck("\t\t\tNhập mã : ",ref _id);
        public static void InputCheck(string content , ref string value)
        {
            value = "";
            do
            {
                Console.Write(content);
                value = Console.ReadLine();
                if (string.IsNullOrEmpty(value)) Console.WriteLine("Nội dung không được bổ trống. Vui lòng nhập lại. "); 
            } while (string.IsNullOrEmpty(value));
        }

        
    }
}
