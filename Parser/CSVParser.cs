using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Parser {
	class CSVParser {
		private object[,] parsed;

		public char Delimiter { get; set; } = ',';

		public CSVParser(string file, Encoding encoding) {

		}

		public string[] getRow() {
			return null;
		}

		public string[] getColumn() {
			return null;
		}
		
		public string[,] getTable() {
			return null;
		}
	}
}
