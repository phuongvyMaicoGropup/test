using StoreManage.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console; 

namespace StoreManage.Products
{
    public abstract class Product 
    {
        protected string _id;
        protected string _name;
        protected string _provider;
        protected int _amount;
        protected string _sResult ="";
        public string SResult => _sResult;
        public int Amount => _amount;
        public string Provider => _provider;
        public string Id => _id;
        public string Name => _name; 


        public virtual void Input()
        {
            Helper.InputCheck("\t\t\tNhập mã : ",ref _id);
            Helper.InputCheck("\t\t\tTên sản phẩm: ",ref _name);
            Helper.InputCheck("\t\t\tNơi sản xuất: ", ref _provider);
        }


        public abstract double Price();
        public virtual void Output()
        {
            _sResult =  $"\tMã số sản phẩm  : {Id}\n";
            _sResult += $"\tTên sản phẩm    : {Name}\n";
            _sResult += $"\tNơi sản xuất    : {Provider}\n";
        }
        public virtual void Output2()
        {
            _sResult += $"\tĐơn giá         : {Price()} \n";
            _sResult += $"\tSố sản phẩm bán : {Amount}\n";
            _sResult += $"\tTổng tiền đơn   : {Amount * Price()}\n";
            _sResult += "\t--------------------------------------------------\n";
        }

      
        public void ToString(string[] k, int line)
        {
            throw new NotImplementedException();
        }
    }
}