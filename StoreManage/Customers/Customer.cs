using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console; 

namespace StoreManage
{
    public class Customer
    {
        private string Id;
        private string UserName;
        private string PhoneNumber;
        private string Address;

        public string GetId => Id;

        public string GetPhoneNumber => PhoneNumber;

        public string GetAddress => Address;

        public string GetUserName => UserName;

        public void InputInfo()
        {
            
            Write("\tMã khách hàng: ");
            Id = ReadLine();
            Write("\tTên khách hàng: ");
            UserName = ReadLine();
            Write("\tĐịa chỉ: ");
            Address = ReadLine();
            Write("\tSố điện thoại: ");
            PhoneNumber = ReadLine(); 

        }
        public string PrintInfo()
        {
            string Output = "";
            Output += $"\tMã khách hàng             : {GetId}\n";
            Output += $"\tTên khách hàng            : {GetUserName}\n";
            Output += $"\tĐịa chỉ khách hàng        : {GetAddress}\n";
            Output += $"\tSố điện thoại khách hàng  : {GetPhoneNumber}\n";
            return Output; 
        }
      

    }
}