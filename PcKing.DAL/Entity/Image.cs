using PcKing.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Entity
{
	public class Image : EntityBase
	{
		public Guid Id { get; set; }
		public string ImgUrl { get; set; }
		public Guid Id_Product { get; set; }
		public virtual Product Product { get; set; }
	}
}
