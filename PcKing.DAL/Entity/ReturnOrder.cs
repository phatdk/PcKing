using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class ReturnOrder : EntityBase
	{
		public Guid Id { get; set; }
		public string Note { get; set; }
		public Guid Id_OrderDetail { get; set; }
		public Guid Id_Order { get; set; }
		public virtual Order Order { get; set; }
		public virtual OrderDetail OrderDetail { get; set; }
	}
}
