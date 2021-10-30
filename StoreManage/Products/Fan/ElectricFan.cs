using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace StoreManage.Products.Fan
{
    class ElectricFan : Fan
    {
        int Battery = 0;
        public new string Name = "Quạt cắm sạc";
        public override void InputProduct()
        {
            base.InputProduct();
            Helpers.AddQuantity("\t\t\tNhập dung lượng pin: ", ref Battery);
            Helpers.AddQuantity("\t\t\tNhập số lượng hàng: ", ref Amount);
        }

        public override double Price() => Battery * 500;

        public override void ReturnInfoProduct()
        {
            base.ReturnInfoProduct();
            Output += $"\tDung lượng pin: {Battery,-80}\n";
            base.AddInfoProduct();
        }
    }
}
