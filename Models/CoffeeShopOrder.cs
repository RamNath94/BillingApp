using System;
using System.Collections.Generic;

namespace Billing_App.Models;

public partial class CoffeeShopOrder
{
    public int Id { get; set; }

    public string Item { get; set; } = null!;

    public string Price { get; set; } = null!;

    public int Qty { get; set; }

    public DateTime PurchaseDate { get; set; }

    public int? BillNo { get; set; }
}
