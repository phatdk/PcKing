using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class CustomAttribute
	{
		public Guid Id { get; set; }
		public string AttributeName { get; set; }
		public string DataType { get; set; }

		public virtual List<Value> Values { get; set; }

	}
}
