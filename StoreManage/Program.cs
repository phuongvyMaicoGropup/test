using StoreManage.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManage
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu menu = new Menu();
            menu.Input(); 

        }
        
    }
}
