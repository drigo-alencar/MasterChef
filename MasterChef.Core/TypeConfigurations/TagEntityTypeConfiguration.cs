using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Core.TypeConfigurations
{
	public class TagEntityTypeConfiguration : IEntityTypeConfiguration<Tag>
	{
		public void Configure(EntityTypeBuilder<Tag> builder)
		{
			builder.HasKey(t => t.Id);

			builder.Property(t => t.Name).IsRequired();

			//builder.has(t => t.Recipes).OwnsMany(r => r.Tags);
		}
	}
}
