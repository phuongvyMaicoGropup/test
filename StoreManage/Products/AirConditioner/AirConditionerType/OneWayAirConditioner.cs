
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
            Helper.AddQuantity("\t\t\tNhập số lượng hàng : ", ref Amount); 
        }

        public override double Price() => _DefaultCost + _Inverter.Cost();

        public override void Output()
        {
            base.Output();
            if (_Inverter.Add == true)
            {
                SResult += "\tThêm công nghệ : \n";
                SResult += $"\t  +{_Inverter.Name()} \n";
            }
            base.Output2();
        }


    }
}
