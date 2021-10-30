
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using StoreManage.Services; 

namespace StoreManage.Products.AirConditioner
{
    class OneWayAirConditioner : AirConditioner
    {        
        
        public override void InputProduct()
        {
            base.InputProduct();
            Helpers.AddFeature(Inverter);
            Helpers.AddQuantity("\t\t\tNhập số lượng hàng : ", ref Amount); 
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
