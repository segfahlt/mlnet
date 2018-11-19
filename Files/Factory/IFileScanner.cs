using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files.Factory
{
	public interface IFileScanner
	{
		string FilePath { get; set; }
		FileFormatTypeEnum FormatType { get; set; }
		int ScanNumberOfLines { get; set; }
		bool HasHeaderLine { get; set; }
	}
}
