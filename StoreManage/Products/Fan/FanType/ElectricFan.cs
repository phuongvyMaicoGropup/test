using StoreManage.Helpers;
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
        public new string Name = "Quạt cắm sạc ";
        public override void Input()
        {
            base.Input();
            Helper.AddQuantity("\t\t\tNhập dung lượng pin: ", ref Battery);
            Helper.AddQuantity("\t\t\tNhập số lượng hàng: ", ref Amount);
        }

        public override double Price() => Battery * 500;

        public override void Output()
        {
            base.Output();
            SResult += $"\tDung lượng pin: {Battery}\n";
            base.Output2();
        }
    }
}
