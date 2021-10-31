
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using StoreManage.Services;
using StoreManage.Helpers;

namespace StoreManage.Products.AirConditioner
{
    class OneWayAirConditioner : AirConditioner
    {

        public new string Name = "Máy lạnh một chiều "; 
        public override void Input()
        {
            base.Input();
            Helper.AddQuantity("\t\t\tNhập số lượng hàng : ", ref _amount); 
        }

        public override double Price() => _DefaultCost() + Inverter.Cost();

        public override void Output()
        {
            base.Output();
            if (Inverter.Add == true)
            {
                _sResult += "\tThêm công nghệ : \n";
                _sResult += $"\t  +{Inverter.Name()} \n";
            }
            base.Output2();
        }

        public override double _DefaultCost() => 1000; 
    }
}
