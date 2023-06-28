using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio14
{
	public class Product
	{
		public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
		public double Price { get; set; }
		public DateTime ExpirationDate { get; set; }
	}
}

