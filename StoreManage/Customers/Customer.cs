using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using StoreManage.Helpers; 

namespace StoreManage
{
    public class Customer 
    {
        protected string _id;
        protected string _userName;
        protected string _phoneNumber;
        protected string _address;

        public string Id => _id;
        public string PhoneNumber => _phoneNumber;
        public string Address => _address;
        public string UserName => _userName;

        public void Input() 
        {
            Helper.InputCheck("\t + Mã khách hàng  : ", ref _id);
            Helper.InputCheck("\t + Tên khách hàng : ", ref _userName);
            Helper.InputCheck("\t + Địa chỉ        : ", ref _address);
            Helper.InputPhoneNumber("\t + Số điện thoại  : ", ref _phoneNumber);
        }
        public string Output()
        {
            string Output = "";
            Output += $"\tMã khách hàng             : {Id}\n";
            Output += $"\tTên khách hàng            : {UserName}\n";
            Output += $"\tĐịa chỉ khách hàng        : {Address}\n";
            Output += $"\tSố điện thoại khách hàng  : {PhoneNumber}\n";
            return Output; 
        }

        

    }
}