using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Switchel_PWA.Classes
{
    public class OpenOrder
    {
        //[Key]
        public int orderNumber { get; set; }
        public string recipient { get; set; }
        public string productName { get; set; }
        public DateTime day { get; set; }

        public string status = "Pending";
    }
}
