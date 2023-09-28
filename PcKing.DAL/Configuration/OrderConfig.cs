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
	internal class OrderConfig : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasIndex(x => x.Code).IsUnique();
			builder.Property(x => x.Reciver).HasColumnType("nvarchar(255)");
			builder.Property(x => x.Phones).HasColumnType("varchar(255)");
			builder.Property(x => x.Address).HasColumnType("nvarchar(255)");
			builder.Property(x => x.Description).HasColumnType("nvarchar(255)").IsRequired(false);
			builder.Property(x => x.ModifyNote).HasColumnType("nvarchar(255)").IsRequired(false);
			builder.Property(x=>x.ModifyDate).IsRequired(false);
			builder.Property(x=>x.AcceptDate).IsRequired(false);
			builder.Property(x=>x.DeliveryDate).IsRequired(false);
			builder.Property(x=>x.ReciveDate).IsRequired(false);
			builder.Property(x=>x.PaymentDate).IsRequired(false);
			builder.HasOne(x=>x.User).WithMany(x=>x.Orders).HasForeignKey(x=>x.Id_User).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x=>x.StatusOrder).WithMany(x=>x.Orders).HasForeignKey(x=>x.Id_Status).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
