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
        int addFea1=0, addFea2=0, isInverter=0;

        public override void InputProduct()
        {
            base.InputProduct();
            bool check = true; 
            do
            {
                try
                {
                    Write("\t\t\tThêm hỗ trợ công nghệ khử mùi (1 - Có sử dụng , 0 - Không sử dụng): ");
                    addFea1 = Convert.ToInt32(ReadLine());
                    check = true; 
                }
                catch (Exception error)
                {
                    WriteLine("\t\t" + error.Message + " Sai định dạng ");
                    check = false; 

                }
            } while (addFea1 != 0 && addFea1 != 1 || check == false);
            do
            {
                try
                {
                    Write("\t\t\tThêm hỗ trợ công nghệ kháng khuẩn (1 - Có sử dụng , 0 - Không sử dụng): ");
                    addFea2 = Convert.ToInt32(ReadLine());
                    check = true;
                }
                catch (Exception error)
                {
                    WriteLine("\t\t" + error.Message + " Sai định dạng ");
                    check = false;

                }
            } while (addFea2 != 0 && addFea2 != 1 || check == false);
            
            do
            {
                try
                {
                    Write("\t\t\tThêm công nghệ inverter (1 - Có sử dụng , 0 - Không sử dụng): ");
                    isInverter = Convert.ToInt32(ReadLine());
                    check = true; 
                }
                catch (Exception error)
                {
                    WriteLine("\t\t" + error.Message + " Sai định dạng ");
                    check = false; 
                }
            } while (isInverter != 0 && isInverter != 1 || check == false );
             
            do
            {
                try
                {
                    Write("\t\tSố lượng bán ra : ");
                    amount = Convert.ToInt32(ReadLine());
                    check = true;
                    if (amount <=0) check = false; 
                }
                catch (Exception error)
                {
                    WriteLine("\t\t" + error.Message + " Sai định dạng ");
                    check = false;
                }
            } while (check ==false);
            
        }

        public override double Price()
        {
            return 500 * (addFea1 + addFea2 + isInverter) +1000; 
        }

        public override string ReturnInfoProduct()
        {
            string output = $"\t\tMã sản phẩm {id} ";
            output += $" .Loại máy lạnh 2 chiều {Name} . Sản xuất tại {MadeIn}.";

            if (addFea1 == 1) output += " Sử dụng công nghệ khử mùi .";
            if (addFea2 == 1) output += " Sử dụng công nghệ kháng khuẩn .";
            if (isInverter == 1) output += " Sử dụng công nghệ Inverter ."; 

            output += $" Đơn giá {Price()}. Số lượng {amount} . Tổng đơn giá {Price() * amount} \n";
            return output; 

        }
    }
}
