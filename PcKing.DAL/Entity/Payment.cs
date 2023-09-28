using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class Payment : EntityBase
	{
		public Guid Id { get; set; }
		public string PaymentMethod { get; set; }
		public virtual List<PaymentOrder> PaymentOrders { get; set; }
	}
}
