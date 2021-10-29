
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace StoreManage.Products.AirConditioner
{
    class OneWayAirConditioner : AirConditioner
    {
        int isInverter = 0; 
        public override void InputProduct()
        {
            base.InputProduct();
            bool check; 
            do
            {
                try
                {
                    check = true;
                    Write("\t\t\tThêm công nghệ inverter (1 - Có sử dụng , 0 - Không sử dụng): ");
                    isInverter = Convert.ToInt32(ReadLine());
                }
                catch (Exception error)
                {
                    WriteLine("\t\t" + error.Message + " Sai định dạng ");
                    check = false;
                }
            } while (isInverter != 0 && isInverter != 1 || check == false);
            do
            {
                try
                {
                    check = true;
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
            return 1000+ 500*isInverter;
        }

        public override string ReturnInfoProduct()
        {

            string output = $"\t\tMã sản phẩm {id} ";
            output += $" .Loại máy lạnh 2 chiều {Name} . Sản xuất tại {MadeIn}.";

            if (isInverter == 1) output += " Sử dụng công nghệ Inverter .";

            output += $" Đơn giá {Price()}. Số lượng {amount} . Tổng đơn giá {Price() * amount} \n";
            return output;
        }
    }
}
