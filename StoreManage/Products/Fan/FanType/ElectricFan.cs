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
            _sResult.Insert(3, $"\tThông số kĩ thuật: {Battery}\n");
            _sResult.Insert(4,$"\t + Dung lượng pin: {Battery}\n");
        }

        public override string TypeProduct() => "Quạt cắm sạc";
    }
}
