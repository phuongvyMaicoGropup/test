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
        private Customer _customer = new Customer();
        private string _id;
        private Date _created = new Date();
        private double _cost;
        private List<Product> _products = new List<Product>();
        private int _count;

        public Date DateCreate => _created;
        public string Id => _id;
        public double TotalCost => _cost;
        public List<Product> Products => _products;
        public Customer Customer => _customer;
        public Product product;
        public void Input(int index)
        {
            WriteLine($"\tNhập chi tiết hóa đơn thứ {index+1}: ");
            Helper.InputCheck("\t - Mã hóa đơn:",ref _id);

            do
            {
                WriteLine("\t - Ngày lập hóa đơn: ");
                Helper.AddQuantity("\t  + Nhập ngày  : ", ref _created.Day);
                Helper.AddQuantity("\t  + Nhập tháng : ", ref _created.Month);
                Helper.AddQuantity("\t  + Nhập năm   : ", ref _created.Year);
                if (_created.Day > 31 || _created.Month > 12 || _created.Year < 1900)
                {
                    WriteLine("\t => Ngày nhập không hợp lệ : (ngày <=31 , tháng < 12 , năm > 1900 )");
                }
            } while (_created.Day > 31 || _created.Month > 12 || _created.Year < 1900); 

            WriteLine(); 
            WriteLine("\t - Thông tin khách hàng:");
            Customer.Input();

            int Answer = -1;
            Helper.AddQuantity("\t - Nhập số lượng chi tiết trong danh sách cac chi tiết hóa đơn : ", ref _count);
            for (int i = 0; i < _count; i++)
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
                _cost += product.Price() * product.Amount;
                product.Output();
                Products.Add(product);
            }
            WriteLine("\t******************************************");

        }

        
    }
}
