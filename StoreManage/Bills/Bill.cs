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

namespace StoreManage
{
    public class Bill
    {
        
        private Customer Customer = new Customer();
        private string Id;
        private Date DateCreate = new Date();
        private double TotalCost;
        private Product[] products;
        private int TotalProduct;

        public Date GetDateCreate => DateCreate; 
        public string GetId => Id;
        public double GetTotalCost => TotalCost;
        public Product[] GetProducts => products;
        public Customer GetCustomer => Customer;
        public int GetTotalProduct;

        public void InputBill()
        {
            Write("Mã hóa đơn:");
            Id = ReadLine();

            WriteLine("Ngày lập hóa đơn: ");
            Helper.AddQuantity("-Nhập ngày  : ", ref DateCreate.Day);
            Helper.AddQuantity("-Nhập tháng : ", ref DateCreate.Month);
            Helper.AddQuantity("-Nhập năm   : ", ref DateCreate.Year);
            

            WriteLine("Thông tin khách hàng:");
            Customer.InputInfo();

            WriteLine("Nhập danh sách các chi tiết hóa đơn: ");
            Helper.AddQuantity("\tSố lượng chi tiết trong danh sách cac chi tiết hóa đơn:", ref TotalProduct);
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
            Helper.ChooseTwoOption(1, 2, "\t\tChọn loại thiết bị điện (1-máy quạt, 2- máy lạnh):", ref Answer);
            
            if (Answer == 1)
            {

                int TypeOfFan = -1;
                Helper.ChooseThreeOption(1, 2, 3, "\t\t\tChọn loại máy quạt (1-máy quạt đứng,2- máy quạt hơi nước,3 – máy quạt sạc điện): ", ref TypeOfFan);
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
                Helper.ChooseTwoOption(1, 2, "\t\t\tChọn loại máy lạnh (1-máy lạnh một chiều,2- máy lạnh hai chiều ):", ref TypeOfAirConditioner);
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
            products[index].ReturnInfoProduct();
                                
        }
        public void PrintBill(int TotalBill)
        {
            
        }
    }
}
