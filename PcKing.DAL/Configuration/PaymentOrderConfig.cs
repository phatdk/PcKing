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
	internal class PaymentOrderConfig : IEntityTypeConfiguration<PaymentOrder>
	{
		public void Configure(EntityTypeBuilder<PaymentOrder> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasOne(x=>x.Order).WithMany(x=>x.PaymentOrders).HasForeignKey(x=>x.Id_Order).OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(x=>x.Payment).WithMany(x=>x.PaymentOrders).HasForeignKey(x=>x.Id_Payment).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
