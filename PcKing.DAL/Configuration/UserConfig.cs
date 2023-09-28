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
	internal class UserConfig : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasIndex(x => x.Code).IsUnique();
			builder.Property(x => x.Img).HasColumnType("varchar(255)").IsRequired(false);
			builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
			builder.Property(x => x.Birth).HasColumnType("date");
			builder.HasIndex(x => x.Phones).IsUnique();
			builder.HasIndex(x => x.Email).IsUnique();
			builder.Property(x => x.Address).HasColumnType("nvarchar(255)");
			builder.HasIndex(x => x.UserName).IsUnique();
			builder.Property(x => x.Password).HasColumnType("varchar(255)");
			builder.HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.Id_Role).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
