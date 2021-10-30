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
            Helper.AddService(_Antibacterial);
            Helper.AddService(_Deodorization);
            Helper.AddQuantity("\t\t\tNhập số lượng hàng : ", ref Amount);

        }
        
        public override double Price()
        {
            return _DefaultCost + _Antibacterial.Cost() + _Deodorization.Cost() + _Inverter.Cost(); 
        }

        public override void Output()
        {
            base.Output();
            if (_Inverter.Add == true || _Antibacterial.Add == true || _Deodorization.Add == true)
                 SResult += "\tThêm công nghệ: \n";
            if (_Inverter.Add == true) SResult += $"\t  +{_Inverter.Name()} \n";
            if (_Antibacterial.Add == true) SResult += $"\t  +{_Antibacterial.Name()} \n";
            if (_Deodorization.Add == true) SResult += $"\t  +{_Deodorization.Name()} \n";
            base.Output2();
        }

    }
}
