using System.Collections.Generic;

namespace MasterChef.Core
{
	public class Tag
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public Recipe Recipe { get; set; }

		public int TagRecipeId { get; set; }
	}
}