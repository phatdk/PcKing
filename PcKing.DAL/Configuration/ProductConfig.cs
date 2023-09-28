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
	internal class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.ProductName).HasColumnType("nvarchar(255)");
			builder.Property(x => x.Description).HasColumnType("nvarchar(255)").IsRequired(false);
			builder.HasOne(x => x.Brand).WithMany(x => x.Products).HasForeignKey(x => x.Id_Brand).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x=>x.Category).WithMany(x => x.Products).HasForeignKey(x=>x.Id_Category).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
