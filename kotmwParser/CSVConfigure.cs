using System;
using System.Collections.Generic;
using System.Text;

namespace kotmwParser {
	internal class CSVConfigure {
		public char Delimiter { get; set; } = ',';
		public bool LeaveQuote { get; set; } = true;
		public bool HasHeader { get; set; } = true;
		public Encoding ParserEncoding { get; set; } = Encoding.UTF8;
	}
}
