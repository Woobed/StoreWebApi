﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Adress { get; set; }
        public string? Created { get; set; }

        public string? Note { get; set; }

    }
}
