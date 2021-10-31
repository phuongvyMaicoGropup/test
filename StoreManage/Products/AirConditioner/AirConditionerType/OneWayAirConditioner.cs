
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
                _sResult.Insert(3,"\tThêm công nghệ : \n");
                _sResult.Insert(4,$"\t  +{Inverter.Name()} \n");
            }
        }

        public override double _DefaultCost() => 1000;

        public override string TypeProduct() => "Máy lạnh một chiều";
    }
}
