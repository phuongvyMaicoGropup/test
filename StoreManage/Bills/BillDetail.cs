using StoreManage.DataStructure;
using StoreManage.Helpers;
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

namespace StoreManage.Bills
{
    class BillDetail
    {
        private Customer Customer = new Customer();
        private string Id;
        private Date Created = new Date();
        private double Cost;
        private List<Product> Products = new List<Product>();
        private int Count;

        public Date GetDateCreate => Created;
        public string GetId => Id;
        public double GetTotalCost => Cost;
        public List<Product> GetProducts => Products;
        public Customer GetCustomer => Customer;
        Product product;
        public void Input(int index)
        {
            WriteLine($"\tNhập chi tiết hóa đơn thứ {index+1}: ");
            Write("\t - Mã hóa đơn:");
            Id = ReadLine();

            WriteLine("\t - Ngày lập hóa đơn: ");
            Helper.AddQuantity("\t  + Nhập ngày  : ", ref Created.Day);
            Helper.AddQuantity("\t  + Nhập tháng : ", ref Created.Month);
            Helper.AddQuantity("\t  + Nhập năm   : ", ref Created.Year);

            WriteLine(); 
            WriteLine("\t - Thông tin khách hàng:");
            Customer.Input();

            int Answer = -1;
            Helper.AddQuantity("\t - Nhập số lượng chi tiết trong danh sách cac chi tiết hóa đơn : ", ref Count);
            for (int i = 0; i < Count; i++)
            {
                Helper.ChooseTwoOption(1, 2, "\t\tChọn loại thiết bị điện (1-máy quạt, 2- máy lạnh):", ref Answer);
                if (Answer == 1)
                {

                    int TypeOfFan = -1;
                    Helper.ChooseThreeOption(1, 2, 3, "\t\t + Chọn loại máy quạt (1-máy quạt đứng,2- máy quạt hơi nước,3 – máy quạt sạc điện): ", ref TypeOfFan);
                    switch (TypeOfFan)
                    {
                        case 1:
                            product = new DefaultFan();
                            break;
                        case 2:
                            product = new SteamFan();
                            break;
                        case 3:
                            product = new ElectricFan();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    int TypeOfAirConditioner = -1;
                    Helper.ChooseTwoOption(1, 2, "\t\t + Chọn loại máy lạnh (1-máy lạnh một chiều,2- máy lạnh hai chiều ):", ref TypeOfAirConditioner);
                    switch (TypeOfAirConditioner)
                    {
                        case 1:
                            product = new OneWayAirConditioner();
                            break;
                        case 2:
                            product = new TwoWayAirConditioner();
                            break;
                        default:
                            break;
                    }

                }
                product.Input();
                Cost += product.Price() * product.GetAmount;
                product.Output();
                Products.Add(product);
            }
            WriteLine("\t******************************************");

        }

        
    }
}
