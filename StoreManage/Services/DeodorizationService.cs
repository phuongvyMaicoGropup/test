using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Services
{
    public class DeodorizationService : Service
    {
        public override double Cost()
        {
            if (Add == true) return 500;
            else return 0;
        }

        public override string Name() => "Công nghệ khử mùi";
       
    }
}
