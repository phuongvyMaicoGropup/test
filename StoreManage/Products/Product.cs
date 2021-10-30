using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console; 

namespace StoreManage.Products
{
    public abstract class Product
    {
        public string Id;
        public string Name;
        public string MadeIn;
        public int Amount;
        public string Output=""; 


        public virtual void InputProduct()
        {
            Write("\t\t\tNhập mã : ");
            Id = ReadLine();
            Write("\t\t\tTên sản phẩm: ");
            Name = ReadLine();
            Write("\t\t\tNơi sản xuất: ");
            MadeIn = ReadLine(); 
        }


        public abstract double Price();
        public virtual void ReturnInfoProduct()
        {
            Output = $"\tMã số sản phẩm : {Id,-60}\n";
            Output += $"\tTên sản phẩm : {Name,-60}\n";
            Output += $"\tNơi sản xuất: {MadeIn,-60}\n";
        }
        public virtual void AddInfoProduct()
        {
            Output += $"\tĐơn giá : {Price(),-60} \n";
            Output += $"\tSố sản phẩm bán : {Amount,-60}\n";
            Output += $"\tTổng tiền đơn : {Amount * Price(),-60}\n";
            Output += "\t--------------------------------------------------\n";
        }
    }
}