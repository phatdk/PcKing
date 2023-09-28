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
	internal class AttributeConfig : IEntityTypeConfiguration<CustomAttribute>
	{
		public void Configure(EntityTypeBuilder<CustomAttribute> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.AttributeName).HasColumnType("nvarchar(255)");
			builder.Property(x => x.DataType).HasColumnType("nvarchar(255)");
		}
	}
}
