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

namespace StoreManage
{
    public class Bill
    {
        public class Date
        {
            public int Day;
            public int Month;
            public int Year;
            
        }
        public Customer customer = new Customer();
        private string id;
        private Date dateCreate = new Date();
        private double TotalCost;
        private Product[] products;
        private int TotalProduct;

        public string Id;
        public string Name ;

        public void InputBill()
        {
            Write("Mã hóa đơn:");
            Id = ReadLine();

            WriteLine("Ngày lập hóa đơn: ");
            Helpers.AddQuantity("-Nhập ngày  : ", ref dateCreate.Day);
            Helpers.AddQuantity("-Nhập tháng : ", ref dateCreate.Month);
            Helpers.AddQuantity("-Nhập năm   : ", ref dateCreate.Year);
            

            WriteLine("Thông tin khách hàng:");
            customer.InputInfo();

            WriteLine("Nhập danh sách các chi tiết hóa đơn: ");
            Helpers.AddQuantity("\tSố lượng chi tiết trong danh sách cac chi tiết hóa đơn:", ref TotalProduct);
            products = new Product[TotalProduct]; 
            for (int i = 0; i< TotalProduct; i++)
            {
                InputDetailBill(i);
                
                
            }

            
        }

        public void InputDetailBill(int index)
        {
            WriteLine($"\tNhập chi tiết hóa đơn thứ {index+1}: ");
            int Answer = -1;
            Helpers.ChooseTwoOption(1, 2, "\t\tChọn loại thiết bị điện (1-máy quạt, 2- máy lạnh):", ref Answer);
            
            if (Answer == 1)
            {

                int TypeOfFan = -1;
                Helpers.ChooseThreeOption(1, 2, 3, "\t\t\tChọn loại máy quạt (1-máy quạt đứng,2- máy quạt hơi nước,3 – máy quạt sạc điện): ", ref TypeOfFan);
                switch (TypeOfFan)
                {
                    case 1:
                        products[index] = new DefaultFan();
                        break;
                    case 2:
                        products[index] = new SteamFan();
                        break;
                    case 3:
                        products[index] = new ElectricFan();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                int TypeOfAirConditioner = -1;
                Helpers.ChooseTwoOption(1, 2, "\t\t\tChọn loại máy lạnh (1-máy lạnh một chiều,2- máy lạnh hai chiều ):", ref TypeOfAirConditioner);
                switch (TypeOfAirConditioner)
                {
                    case 1:
                        products[index] = new OneWayAirConditioner();
                        break;
                    case 2:
                        products[index] = new TwoWayAirConditioner();
                        break;
                    default:
                        break;
                }

            }
            products[index].InputProduct();
            TotalCost += products[index].Price() * products[index].Amount;
        }
        public void PrintBill(int index)
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don_" + (index + 1) + ".txt", FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs);
            sWriter.WriteLine("\t--------------------------------------------------");
            sWriter.WriteLine($"\tThông tin hóa đơn:");
            sWriter.WriteLine($"\t Mã hóa đơn : {Id}");
            sWriter.WriteLine($"\t Ngày lập   : {dateCreate.Day}/{dateCreate.Month}/{dateCreate.Year}");
            sWriter.WriteLine($"\t Tổng giá   : {TotalCost}");
            sWriter.WriteLine("\t--------------------------------------------------");
            sWriter.WriteLine($"\tThông tin khách hàng :");
            sWriter.WriteLine(customer.PrintInfo());
            sWriter.WriteLine($"\t--------------------------------------------------");
            sWriter.WriteLine();
            sWriter.WriteLine("Danh sach cac chi tiet hoa don:");

            for (int i = 0; i < TotalProduct; i++)
            {
                products[i].ReturnInfoProduct();
                sWriter.WriteLine(products[i].Output);
            }
            sWriter.Flush();
            fs.Close();
        }
    }
}
