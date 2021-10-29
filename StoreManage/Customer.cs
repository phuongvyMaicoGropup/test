using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console; 

namespace StoreManage
{
    public class Customer
    {
        private string id;
        private string username;
        private string phonenumber;
        private string address;

        public string Id
        {
            get => id;
            set
            {
                id = value; 
            }
        }

        public string PhoneNumber
        {
            get => phonenumber;
            set
            {
                phonenumber = value; 
            }
        }

        public string Address
        {
            get => address;
            set
            {
                address = value; 
            }
        }

        public string UserName
        {
            get => username;
            set
            {
                username = value; 
            }
        }

        public void InputInfo()
        {
            WriteLine("Thông tin khách hàng:"); 
            Write("\tMã khách hàng");
            Id = ReadLine();
            Write("\tTên khách hàng:");
            UserName = ReadLine();
            Write("\tĐịa chỉ:");
            Address = ReadLine();
            Write("\tSố điện thoại: ");
            PhoneNumber = ReadLine(); 

        }
        public string PrintInfo()
        {
            return $"\t {Id} {UserName} {Address} {PhoneNumber} \n";
        }

    }
}