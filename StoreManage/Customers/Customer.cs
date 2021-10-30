using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console; 

namespace StoreManage
{
    public class Customer 
    {
        protected string Id;
        protected string UserName;
        protected string PhoneNumber;
        protected string Address;

        public string GetId => Id;
        public string GetPhoneNumber => PhoneNumber;
        public string GetAddress => Address;
        public string GetUserName => UserName;

        public void Input() 
        {
            
            Write("\t + Mã khách hàng: ");
            Id = ReadLine();
            Write("\t + Tên khách hàng: ");
            UserName = ReadLine();
            Write("\t + Địa chỉ: ");
            Address = ReadLine();
            Write("\t + Số điện thoại: ");
            PhoneNumber = ReadLine(); 

        }
        public string Output()
        {
            string Output = "";
            Output += $"\tMã khách hàng             : {GetId}\n";
            Output += $"\tTên khách hàng            : {GetUserName}\n";
            Output += $"\tĐịa chỉ khách hàng        : {GetAddress}\n";
            Output += $"\tSố điện thoại khách hàng  : {GetPhoneNumber}\n";
            return Output; 
        }

        public override string ToString()
        {
            return $"Thông tin khác hàng: < Mã: {GetId} > < Tên: {GetUserName} > < Địa chỉ: {GetAddress} > < Số điện thoại: {GetPhoneNumber}>";
        }

    }
}