using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment shipment { get; set; }
        public float TotalPrice { get; set; }
        
        
    }
}
