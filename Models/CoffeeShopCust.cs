using System;
using System.Collections.Generic;

namespace Billing_App.Models;

public partial class CoffeeShopCust
{
    public int Id { get; set; }

    public string? CustName { get; set; }

    public int? CustMobile { get; set; }
}
