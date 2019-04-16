using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Core.TypeConfigurations
{
	public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(c => c.Id);

			builder.HasMany(c => c.Recipes).WithOne(r => r.Category).HasForeignKey(fk => fk.CategoryRecipeId);

			builder.Property(c => c.Description).IsRequired();
			builder.Property(c => c.Title).IsRequired();
		}
	}
}
