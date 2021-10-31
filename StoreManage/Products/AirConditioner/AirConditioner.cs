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
        public InverterService Inverter = new InverterService();
        public AntibacterialService Antibacterial = new AntibacterialService();
        public DeodorizationService Deodorization = new DeodorizationService();
        public abstract double _DefaultCost(); 
        public override void Input()
        {
            base.Input();
            Helper.AddService(Inverter);

        }
        
    }
}