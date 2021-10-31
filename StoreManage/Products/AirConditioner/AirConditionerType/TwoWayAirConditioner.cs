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

        public override void Input()
        {
            base.Input();
            Helper.AddService(Antibacterial);
            Helper.AddService(Deodorization);
            Helper.AddQuantity("\t\t\tNhập số lượng hàng : ", ref _amount);

        }
        
        public override double Price()
        {
            return _DefaultCost() + Antibacterial.Cost() + Deodorization.Cost() + Inverter.Cost(); 
        }

        public override void Output()
        {
            base.Output();
            if (Inverter.Add == true ||Antibacterial.Add == true || Deodorization.Add == true)
                 _sResult += "\tThêm công nghệ: \n";
            if (Inverter.Add == true) _sResult += $"\t  +{Inverter.Name()} \n";
            if (Antibacterial.Add == true) _sResult += $"\t  +{Antibacterial.Name()} \n";
            if (Deodorization.Add == true) _sResult += $"\t  +{Deodorization.Name()} \n";
            base.Output2();
        }

        public override double _DefaultCost() => 2000; 
    }
}
