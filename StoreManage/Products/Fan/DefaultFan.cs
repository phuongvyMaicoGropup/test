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
        public override void InputProduct()
        {
            base.InputProduct();
            bool check = true;
            do
            {
                try
                {
                    Write("\t\tSố lượng bán ra : ");
                    amount = Convert.ToInt32(ReadLine());
                    if (amount <= 0) check = false;
                }
                catch (Exception error)
                {
                    WriteLine("\t\t" + error.Message + " Sai định dạng ");
                }
            } while (check == false);
        }

        public override double Price()
        {
            return 500;
        }

        public override string ReturnInfoProduct()
        {
            return $" \t\tMã sản phẩm {id}. Quạt đứng {name} . Sản xuất tại  {madeIn} . Đơn giá {Price()} . Số lượng {amount} . Tổng giá {Price() * amount} \n ";
        }
    }
}
