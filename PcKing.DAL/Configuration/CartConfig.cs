using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PcKing.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Configuration
{
	internal class CartConfig : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{
			builder.HasKey(x => x.Id_User);
			builder.HasOne(x => x.User).WithOne(x => x.Cart).HasForeignKey<Cart>(x=>x.Id_User).OnDelete(DeleteBehavior.Cascade);
		}
	}
}
