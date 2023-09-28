using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class Cart : EntityBase
	{
		public Guid Id_User { get; set; }

		public virtual User User { get; set; }
		public virtual List<CartDetail> CartDetails { get; set; }
	}
}
