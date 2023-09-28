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
	internal class ImageConfig : IEntityTypeConfiguration<Image>
	{
		public void Configure(EntityTypeBuilder<Image> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.ImgUrl).HasColumnType("nvarchar(255)");
			builder.HasOne(x=>x.Product).WithMany(x => x.Images).HasForeignKey(x => x.Id_Product).OnDelete(DeleteBehavior.Cascade);
		}
	}
}
