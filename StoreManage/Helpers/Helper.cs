using StoreManage.DataStructure;
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
                    Console.WriteLine("\t\t\tNhập sai định dạng (chỉ cho phép nhập số).Vui lòng nhập lại ! ");
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
                if (string.IsNullOrEmpty(value)) Console.WriteLine("\tNội dung không được bổ trống. Vui lòng nhập lại. "); 
            } while (string.IsNullOrEmpty(value));
        }
        //Helper.InputNumber("\t + Số điện thoại  : ", ref _phoneNumber);
        public static void InputPhoneNumber(string content, ref string number)
        {
            bool check; 
            do
            {
                check = true; 
                Console.Write(content);
                number = Console.ReadLine();
                if (number.Length < 10 || number.Length > 11) 
                {
                    Console.WriteLine("\tSố điện thoại sai định dạng. Yêu cầu số điện thoại dài từ 10 đến 11 số . Vui lòng nhập lại.");
                    check = false;
                }
                else
                {

                     for (int i = 0; i<number.Length; i++)
                     {
                         if (number[i] >='a' && number[i]<='z'|| number[i] >= 'A' && number[i] <= 'Z')
                         {
                            Console.WriteLine("\tChỉ được phép nhập số .Vui lòng thử lại. ");
                            check = false;
                            break; 
                         }
                }
                if (check == true) break; 
                 
                }
            } while (check==false);
        }

        //Helper.InputDate("\t - Ngày lập hóa đơn: ", ref _created);
        public static void InputDate(string content, ref Date date )
        {
            bool check;
            do
            {
                check = true; 
                Console.WriteLine(content);
                do
                {
                    AddQuantity("\t  + Nhập ngày  : ", ref date.Day);
                    if (date.Day > 31) Console.WriteLine("\t=> Ngày không quá 31 ngày. Vui lòng nhập lại. ");
                } while (date.Day > 31);
                do
                {
                    AddQuantity("\t  + Nhập tháng : ", ref date.Month);
                    if (date.Month > 12) Console.WriteLine("\t=> Tháng không quá 12 tháng. Vui lòng nhập lại. ");
                } while (date.Month > 12);
                do
                {
                    AddQuantity("\t  + Nhập năm   : ", ref date.Year);
                    if (date.Year < 1000) Console.WriteLine("\t=> Năm không dưới 1000. Vui lòng nhập lại. ");
                } while (date.Year <1000);
                if (date.Day == 29 && date.Month == 2)
                {
                    if (!(date.Year % 400 == 0 || (date.Year % 4 == 0 && date.Year % 100 != 0)))
                    {
                        check = false;
                        Console.WriteLine("\tTháng 2 chỉ có 28 ngày. Vui lòng nhập lại. ");
                    }
                }
                else if (date.Day > 29 && date.Month == 2)
                {
                    check = false;
                    Console.WriteLine("\tTháng 2 chỉ có 28 ngày. Vui lòng nhập lại. ");
                }    
                if (date.Month == 4 || date.Month == 6 || date.Month == 9 || date.Month == 11)
                {
                    if (date.Day == 31)
                    {
                        Console.WriteLine("\tCác tháng 4,6,9,11 không có tồn tại ngày thứ 31. Vui lòng nhập lại! ");
                        check = false; 
                    }
                }

            } while (check == false);

        }

    }
}
