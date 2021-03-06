﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETong.CoreOrder.Client.Model 
{

    public class FinishOrderResponse
    {
        public string sign { get; set; }
        public string reqTime { get; set; }
        public FinishOrderDatamap dataMap { get; set; }
        public string respCode { get; set; }
        public string respMsg { get; set; }
        public string respTime { get; set; }
    }

    public class FinishOrderDatamap
    {
        public string memberId { get; set; }
    }

}
