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
	internal class ReturnOrderConfig : IEntityTypeConfiguration<ReturnOrder>
	{
		public void Configure(EntityTypeBuilder<ReturnOrder> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Note).HasColumnType("nvarchar(255)");
			builder.HasOne(x => x.Order).WithMany(x=>x.ReturnOrders).HasForeignKey(x=>x.Id_Order).OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(x => x.OrderDetail).WithMany(x=>x.ReturnOrders).HasForeignKey(x=>x.Id_OrderDetail).OnDelete(DeleteBehavior.Cascade);
		}
	}
}
