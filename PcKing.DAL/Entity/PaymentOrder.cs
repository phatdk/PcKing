using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class PaymentOrder : EntityBase
	{
		public Guid Id { get; set; }
		public Guid Id_Order { get; set; }
		public Guid Id_Payment { get; set; }
		public int PaymentAmount { get; set; }
		public virtual Order Order { get; set; }
		public virtual Payment Payment { get; set; }
	}
}
