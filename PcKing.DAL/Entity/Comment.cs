using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class Comment : EntityBase
	{
		public Guid Id { get; set; }
		public string Content { get; set; }
		public Guid Id_User { get; set; }
		public Guid Id_Product { get; set; }
		public virtual User User { get; set; }
		public virtual OrderDetail OrderDetail { get; set; }
	}
}
