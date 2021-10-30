using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Services
{
    public abstract class Service
    {
        public abstract string Name();
        public abstract double Cost();
        public bool Add =  false; 
    }
}
