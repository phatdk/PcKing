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
	internal class CommentConfig : IEntityTypeConfiguration<Comment>
	{
		public void Configure(EntityTypeBuilder<Comment> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Content).HasColumnType("nvarchar(255)");
			builder.HasOne(x => x.User).WithMany(x=>x.Comments).HasForeignKey(x=>x.Id_User).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.OrderDetail).WithMany(x=>x.Comments).HasForeignKey(x=>x.Id_Product).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
