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
	internal class ValueConfig : IEntityTypeConfiguration<Value>
	{
		public void Configure(EntityTypeBuilder<Value> builder)
		{
			builder.HasKey(x=> x.Id);
			builder.Property(x => x.AttributeValue).HasColumnType("nvarchar(255)");
			builder.HasOne(x=>x.Product).WithMany(x=>x.Values).HasForeignKey(x=>x.Id_Product).OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(x=>x.Attribute).WithMany(x=>x.Values).HasForeignKey(x=>x.Id_Attribute).OnDelete(DeleteBehavior.Cascade);
		}
	}
}
