using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Model
{
	/// <summary>
	/// Represents a "Property" on a class we will generate.
	/// </summary>
	public class PropertySpec
	{
		public string PropertyName { get; set; }
		public string TypeName { get; set; }
		public string ColumnName { get; set; }
		public string Comments { get; set; }
	}
}
