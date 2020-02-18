﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTinyCRMApi.Options
{
    public class CreateOrderOptions
    {
        public int CustomerId { get; set; }
        public List<Guid> ProductIds { get; set; }
        public decimal TotalGross { get; set; }
    }
}
