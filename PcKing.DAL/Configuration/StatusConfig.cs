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
	internal class StatusConfig : IEntityTypeConfiguration<StatusOrder>
	{
		public void Configure(EntityTypeBuilder<StatusOrder> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.StatusName).HasColumnType("nvarchar(255)");
		}
	}
}
