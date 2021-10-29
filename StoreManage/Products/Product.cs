using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console; 

namespace StoreManage.Products
{
    public abstract class Product
    {
        protected string id;
        protected string name;
        protected string madeIn;
        protected int amount;

        public string Id
        {
            set => id = value;
            get => id;
        }

        public string Name
        {
            set => name = value;
            get => name;
        }

        public string MadeIn
        {
            set => madeIn = value;
            get => madeIn;
        }

        public int Amount
        {
            set => amount = value;
            get => amount;
        }


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
        public abstract string ReturnInfoProduct(); 
    }
}