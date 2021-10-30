
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
        public override void InputProduct()
        {
            base.InputProduct();
            Helper.AddFeature(Inverter);
            Helper.AddQuantity("\t\t\tNhập số lượng hàng : ", ref Amount); 
        }

        public override double Price() =>DefaultCost + Inverter.Cost();

        public override void ReturnInfoProduct()
        {
            base.ReturnInfoProduct();
            if (Inverter.Add == true)
            {
                Output += "\tThêm công nghệ : \n";
                Output += $"\t  +{Inverter.Name()} \n";
            }
            base.AddInfoProduct();
        }

    }
}
