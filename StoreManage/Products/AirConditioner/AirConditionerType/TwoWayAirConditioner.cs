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
            _name = "Máy lạnh hai chiều " + _name;
            base.Output();
            int index = 3; 
            if (Inverter.Add == true ||Antibacterial.Add == true || Deodorization.Add == true)
                 _sResult.Insert(index++,"\tThêm công nghệ: \n");
            if (Inverter.Add == true) _sResult.Insert(index++, $"\t  +{Inverter.Name()} \n");
            if (Antibacterial.Add == true) _sResult.Insert(index++,$"\t  +{Antibacterial.Name()} \n");
            if (Deodorization.Add == true) _sResult.Insert(index++,$"\t  +{Deodorization.Name()} \n");
        }

        public override double _DefaultCost() => 2000; 
    }
}
