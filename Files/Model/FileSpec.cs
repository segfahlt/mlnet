using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files.Model
{
	public class FileSpec
	{
		public int Size { get; set; }
		public int LineCount { get; set; }
		public FileFormatTypeEnum FormatType { get; set; }
		public Dictionary<string,Type> Columns { get; set; }
	}
}
