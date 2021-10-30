using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Helpers
{
    public static class UI
    {
        public static void Clear()
        {
            Console.WriteLine("\t Nhấn phím bất kì để tiếp tục  ");
            Console.ReadKey();
            Console.Clear(); // Xóa màn hình
        }
        
        public static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
