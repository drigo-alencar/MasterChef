using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterChef.Core.TypeConfigurations
{
    public class RecipeEntityTypeConfiguration : IEntityTypeConfiguration<Recipe>
	{
		public void Configure(EntityTypeBuilder<Recipe> builder)
		{
			builder.HasKey(r => r.Id);

			builder.HasOne(r => r.Category).WithMany(c => c.Recipes).HasForeignKey(fk => fk.CategoryRecipeId);
			
			builder.Property(r => r.Description).IsRequired();
			builder.Property(r => r.Directions).IsRequired();
			builder.Property(r => r.Ingredients).IsRequired();
			builder.Property(r => r.Photo);
			builder.Property(r => r.Title);
		}
	}
}
