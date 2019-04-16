using System;
using System.Collections;
using System.Collections.Generic;

namespace MasterChef.Core
{
	public class Recipe
	{
		public Category Category { get; set; }

		public int CategoryRecipeId { get; internal set; }

		public string Description { get; set; }

		public string Directions { get; set; }

		public byte[] Photo { get; set; }

		public int Id { get; set; }

		public string Ingredients { get; set; }

		public ICollection<Tag> Tags { get; set; }

		public string Title { get; set; }
	}
}
