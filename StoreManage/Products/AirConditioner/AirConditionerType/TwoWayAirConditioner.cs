using StoreManage.Helpers;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace StoreManage.Products.AirConditioner
{
    class TwoWayAirConditioner : AirConditioner
    {
        public new string Name = "Máy lạnh hai chiều ";

        public override void InputProduct()
        {
            base.InputProduct();
            Helper.AddFeature(Antibacterial);
            Helper.AddFeature(Deodorization);
            Helper.AddFeature(Inverter);
            Helper.AddQuantity("\t\t\tNhập số lượng hàng : ", ref Amount);

        }
        
        public override double Price()
        {
            return DefaultCost + Antibacterial.Cost() + Deodorization.Cost() + Inverter.Cost(); 
        }

        public override void ReturnInfoProduct()
        {
            base.ReturnInfoProduct();
            if (Inverter.Add == true || Antibacterial.Add == true || Deodorization.Add == true)
                 Output += "\tThêm công nghệ: \n";
            if (Inverter.Add == true) Output += $"\t  +{Inverter.Name()} \n";
            if (Antibacterial.Add == true) Output += $"\t  +{Antibacterial.Name()} \n";
            if (Deodorization.Add == true) Output += $"\t  +{Deodorization.Name()} \n";
            base.AddInfoProduct();
        }
    }
}
