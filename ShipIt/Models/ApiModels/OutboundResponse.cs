using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShipIt.Models.ApiModels
{
    public class OutboundResponse : Response
    {
        public int CountOfTrucks { get; set; }
       
        public OutboundResponse() { }
        
        public OutboundResponse(int countOfTrucks) {
            CountOfTrucks = countOfTrucks;
            Success = true;
        }
    }
}