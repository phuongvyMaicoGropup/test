using StoreManage.Helpers;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console; 

namespace StoreManage.Products.AirConditioner
{
    abstract class AirConditioner : Product
    {
        public InverterService _Inverter = new InverterService();
        public AntibacterialService _Antibacterial = new AntibacterialService();
        public DeodorizationService _Deodorization = new DeodorizationService();
        public double _DefaultCost = 1000; 
        public override void Input()
        {
            base.Input();
            Helper.AddService(_Inverter);

        }
        
    }
}