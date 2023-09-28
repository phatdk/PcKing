using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class CartDetail
	{
		public Guid Id { get; set; }
		public Guid Id_User { get; set; }
		public Guid Id_Product { get; set; }
		public int Quantity { get; set; }

		public virtual Cart Cart { get; set; }
		public virtual Product Product { get; set; }
	}
}
