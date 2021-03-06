﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTinyCRMApi.Options
{
    public class SearchProductOptions
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? PriceMax { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

    }
}
