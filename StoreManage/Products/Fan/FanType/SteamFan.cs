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
        int Volume = 0;
        public new string Name = "Quạt hơi nước ";

        public override void InputProduct()
        {
            base.InputProduct();
            Helper.AddQuantity("\t\t\tNhập dung tích nước (lít) : ", ref Volume);
            Helper.AddQuantity("\t\t\tSố lượng hàng bán : ", ref Amount); 
        }

        public override double Price() => Volume * 400;

        public override void ReturnInfoProduct()
        {
            base.ReturnInfoProduct();
            Output += $"\tDung tích nước: {Volume,-80}\n";
            base.AddInfoProduct();
        }
    }
}
