﻿using System;
using System.Collections.Generic;

namespace NorthWindProject_MVC.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
