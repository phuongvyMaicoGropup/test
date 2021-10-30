using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console; 

namespace StoreManage.Products
{
    public abstract class Product 
    {
        protected string Id;
        protected string Name;
        protected string Provider;
        protected int Amount;
        protected string SResult ="";
        public string GetSResult => SResult;
        public int GetAmount => Amount;
        public string GetProvider => Provider;
        public string GetId => Id;
        public string GetName => Name; 


        public virtual void Input()
        {
            Write("\t\t\tNhập mã : ");
            Id = ReadLine();
            Write("\t\t\tTên sản phẩm: ");
            Name =  ReadLine();
            Write("\t\t\tNơi sản xuất: ");
            Provider = ReadLine(); 
        }


        public abstract double Price();
        public virtual void Output()
        {
            SResult =  $"\tMã số sản phẩm  : {Id}\n";
            SResult += $"\tTên sản phẩm    : {Name}\n";
            SResult += $"\tNơi sản xuất    : {Provider}\n";
        }
        public virtual void Output2()
        {
            SResult += $"\tĐơn giá         : {Price()} \n";
            SResult += $"\tSố sản phẩm bán : {Amount}\n";
            SResult += $"\tTổng tiền đơn   : {Amount * Price()}\n";
            SResult += "\t--------------------------------------------------\n";
        }

      
        public void ToString(string[] k, int line)
        {
            throw new NotImplementedException();
        }
    }
}