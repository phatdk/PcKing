using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class Category : EntityBase
	{
		public Guid Id { get; set; }
		public string CategoryName { get; set; }
		public int Index { get; set; }
		public virtual List<Product> Products { get; set; }
	}
}
