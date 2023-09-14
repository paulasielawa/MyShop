﻿using System;
namespace MyShop.Models;

public class Order
{
	public int OrderId { get; set; }
	public string OrderDate { get; set; } = string.Empty;
	public int CustomerId { get; set; }
	// navigation property
	public Customer Customer { get; set; } = default!;
    // navigation property
	public virtual List<OrderItem>? OrderItems { get; set; }
	public decimal TotalPrice { get; set; }
}


