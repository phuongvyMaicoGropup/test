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
        public override void InputProduct()
        {
            base.InputProduct();

        }
        public double DefaultCost = 1000; 
        
    }
}