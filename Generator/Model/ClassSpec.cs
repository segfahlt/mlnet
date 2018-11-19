using System.Collections.Generic;

namespace Generator.Model
{
	public class ClassSpec
	{
		public string ClassName { get; set; }

		public List<PropertySpec> Properties { get; set; }

		public ClassSpec()
		{
			Properties = new List<PropertySpec>();
		}

	}
}
