﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Models

{
	public class Item
	{
		public int ItemId { get; set; }
		public string Name { get; set; } = string.Empty;
		public decimal Price { get; set; }
		[Required]
		public string? Description { get; set; }
		[Required]
        public string? ImageUrl { get; set; }
	}
}

