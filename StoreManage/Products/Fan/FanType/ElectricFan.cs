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
        protected int _battery = 0;
        public new string Name = "Quạt cắm sạc ";
        public int Battery => _battery; 
        public override void Input()
        {
            base.Input();
            Helper.AddQuantity("\t\t\tNhập dung lượng pin: ", ref _battery);
            Helper.AddQuantity("\t\t\tNhập số lượng hàng: ", ref _amount);
        }

        public override double Price() => Battery * 500;

        public override void Output()
        {
            base.Output();
            _sResult += $"\tDung lượng pin: {Battery}\n";
            base.Output2();
        }
    }
}
