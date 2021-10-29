using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace StoreManage.Products.Fan
{
    class ElectricFan : Fan
    {
        int battery = 0;    
        public override void InputProduct()
        {
            base.InputProduct();
            bool check = true;
            do
            {
                try
                {
                    Write("\t\t\tDung lượng pin: ");
                    battery = Convert.ToInt32(ReadLine());
                    if (battery <= 0) check = false;
                }
                catch (Exception error)
                {
                    WriteLine("\t\t" + error.Message + " Sai định dạng ");
                    check = false;
                }
            } while (check == false);
            
            check = true;
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
                    check = false;
                }
            } while (check == false);
        }

        public override double Price()
        {           
             return battery * 500;
        }

        public override string ReturnInfoProduct()
        {
            return $" \t\tMã sản phẩm {id}. Quạt sạc pin {name} dung lượng {battery}. Sản xuất tại  {madeIn} . Đơn giá {Price()} . Số lượng {amount} . Tổng giá {Price() * amount} \n ";
        }
    }
}
