using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class OrderDetail
	{
		public Guid Id { get; set; }
		public Guid Id_Order { get; set; }
		public Guid Id_Product { get; set; }
		public int Quantity { get; set; }
		public int Price { get; set; }
		public virtual Order Order { get; set; }
		public virtual Product Product { get; set; }
		public virtual List<Comment> Comments { get; set; }
		public virtual List<ReturnOrder> ReturnOrders { get; set; }
	}
}
