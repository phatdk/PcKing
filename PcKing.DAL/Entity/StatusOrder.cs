using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class StatusOrder : EntityBase
	{
		public Guid Id { get; set; }
		public string StatusName { get; set; }
		public virtual List<Order> Orders { get; set; }
	}
}
