using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Core
{
	public class Category
	{
		public string Description { get; set; }

		public int Id { get; set; }

		public ICollection<Recipe> Recipes { get; set; }

		public string Title { get; set; }
	}
}
