﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022._1_EntityFrameworkDemo
{
    internal class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        
    }
}
