using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace kotmwParser {
	/// <summary>
	/// Jsonパーサーつくりたい
	/// </summary>
	class JSONParser : Parser {
		public JSONParser(string file) : base(file) {}

		public void Read() {
			var chars = File.ReadAllText(file, Encoding.UTF8).ToCharArray();

		}
	}
}
