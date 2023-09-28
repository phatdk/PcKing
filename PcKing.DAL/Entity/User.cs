using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class User : EntityBase
	{
		public Guid Id { get; set; }
		public string Code { get; set; }
		public string? Img { get; set; }
		public string Name { get; set; }
		public DateTime Birth { get; set; }
		public int Gender { get; set; }
		public string Phones { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }

		public Guid Id_Role { get; set; }
		public virtual Role Role { get; set; }
		public virtual Cart Cart { get; set; }
		public virtual List<Order> Orders { get; set; }
		public virtual List<Comment> Comments { get; set; }
	}
}
