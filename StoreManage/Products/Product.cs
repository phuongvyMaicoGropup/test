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
        protected string Output="";
        public string GetOutput => Output; 


        public virtual void InputProduct()
        {
            Write("\t\t\tNhập mã : ");
            Id = ReadLine();
            Write("\t\t\tTên sản phẩm: ");
            Name = Name + ReadLine();
            Write("\t\t\tNơi sản xuất: ");
            MadeIn = ReadLine(); 
        }


        public abstract double Price();
        public virtual void ReturnInfoProduct()
        {
            Output =  $"\tMã số sản phẩm  : {Id}\n";
            Output += $"\tTên sản phẩm    : {Name}\n";
            Output += $"\tNơi sản xuất    : {MadeIn}\n";
        }
        public virtual void AddInfoProduct()
        {
            Output += $"\tĐơn giá         : {Price()} \n";
            Output += $"\tSố sản phẩm bán : {Amount}\n";
            Output += $"\tTổng tiền đơn   : {Amount * Price()}\n";
            Output += "\t--------------------------------------------------\n";
        }
    }
}