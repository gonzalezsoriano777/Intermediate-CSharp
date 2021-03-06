﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public class Order
    {
        // fields used for Shipping details (finalization)
        public int ID { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        
        
        public bool isShipped
        {
            get { return Shipment != null;  }
        }
        
    }
}
