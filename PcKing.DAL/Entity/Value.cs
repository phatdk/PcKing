using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class Value
	{
		public Guid Id { get; set; }
		public string AttributeValue { get; set; }

		public Guid Id_Product { get; set; }
		public Guid Id_Attribute { get; set; }
		public virtual CustomAttribute Attribute { get; set; }
		public virtual Product Product { get; set; }
	}
}
