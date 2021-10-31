using StoreManage.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace StoreManage.Products.Fan
{
    class DefaultFan : Fan
    {
        public new string Name = "Quạt đứng ";
        public override void Input()
        {
            base.Input();
            Helper.AddQuantity("\t\t\tNhập số lượng hàng : ", ref _amount);
        }

        public override double Price() => 500;

        public override void Output()
        {
            base.Output();
            base.Output2();
        }

    }
}
