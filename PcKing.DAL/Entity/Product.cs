using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class Product : EntityBase
	{
		public Guid Id { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get; set; }
		public int Price { get; set; }
		public int ImportPrice { get; set; }
		public string? Description { get; set; }

		public Guid? Id_Brand { get; set; }
		public Guid Id_Category { get; set; }
		public virtual Brand Brand { get; set; }
		public virtual Category Category { get; set; }
		public virtual List<Value> Values { get; set; }
		public virtual List<Image> Images { get; set; }
		public virtual List<CartDetail> CartDetails { get; set; }
		public virtual List<OrderDetail> OrderDetails { get; set; }
	}
}
