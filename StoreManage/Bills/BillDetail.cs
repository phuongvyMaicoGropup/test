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
        public Product Product;
        public void Input(int index)
        {
            WriteLine($"\tNhập chi tiết hóa đơn thứ {index+1}: ");
            Helper.InputCheck("\t - Mã hóa đơn:",ref _id);
            Helper.InputDate("\t - Ngày lập hóa đơn: ", ref _created);
            WriteLine(); 
            WriteLine("\t - Thông tin khách hàng:");
            Customer.Input();

            int answer = -1;
            Helper.AddQuantity("\t - Nhập số lượng chi tiết trong danh sách cac chi tiết hóa đơn : ", ref _count);
            for (int i = 0; i < _count; i++)
            {
                Helper.ChooseTwoOption(1, 2, "\t\tChọn loại thiết bị điện (1-máy quạt, 2- máy lạnh):", ref answer);
                if (answer == 1)
                {

                    int typeOfFan = -1;
                    Helper.ChooseThreeOption(1, 2, 3, "\t\t + Chọn loại máy quạt (1-máy quạt đứng,2- máy quạt hơi nước,3 – máy quạt sạc điện): ", ref typeOfFan);
                    switch (typeOfFan)
                    {
                        case 1:
                            Product = new DefaultFan();
                            break;
                        case 2:
                            Product = new SteamFan();
                            break;
                        case 3:
                            Product = new ElectricFan();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    int typeOfAirConditioner = -1;
                    Helper.ChooseTwoOption(1, 2, "\t\t + Chọn loại máy lạnh (1-máy lạnh một chiều,2- máy lạnh hai chiều ):", ref typeOfAirConditioner);
                    switch (typeOfAirConditioner)
                    {
                        case 1:
                            Product = new OneWayAirConditioner();
                            break;
                        case 2:
                            Product = new TwoWayAirConditioner();
                            break;
                        default:
                            break;
                    }

                }
                Product.Input();
                _cost += Product.Price() * Product.Amount;
                Product.Output();
                Products.Add(Product);
            }
            WriteLine("\t******************************************");

        }

        
    }
}
