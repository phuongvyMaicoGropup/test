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
        public new string Name = "Quạt đứng";
        public override void InputProduct()
        {
            base.InputProduct();
            Helpers.AddQuantity("\t\t\tNhập số lượng hàng : ", ref Amount);
        }

        public override double Price() => 500;

        public override void ReturnInfoProduct()
        {
            base.ReturnInfoProduct();
            base.AddInfoProduct();

        }

    }
}
