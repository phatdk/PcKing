using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class Role : EntityBase
	{
		public Guid Id { get; set; }
		public string RoleName { get; set; }

		public virtual List<User> Users { get; set; }
	}
}
