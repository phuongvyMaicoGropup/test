using StoreManage.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace StoreManage.Products.Fan
{
    class SteamFan : Fan
    {
        private int _volume = 0;
        public int Volume => _volume; 
        public override void Input()
        {
            base.Input();
            Helper.AddQuantity("\t\t\tNhập dung tích nước (lít) : ", ref _volume);
            Helper.AddQuantity("\t\t\tSố lượng hàng bán : ", ref _amount); 
        }

        public override double Price() => Volume * 400;

        public override void Output()
        {
            base.Output();
            _sResult.Insert(3, $"\tThông số kĩ thuật: \n");
            _sResult.Insert(3, $"\t + Dung tích nước: {Volume}\n");
        }

        public override string TypeProduct() => "Quạt hơi nước";
    }
}
