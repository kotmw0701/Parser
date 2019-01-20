using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Parser {
	class JSONParser : Parser {
		public JSONParser(string file) : base(file) {}

		public void Read() {
			var chars = File.ReadAllText(file, ParserEncoding).ToCharArray();
		}
	}
}
