using System;
using System.Collections.Generic;
using System.Text;

namespace kotmwParser {
	class Parser {
		protected readonly string file = "";

		public Encoding ParserEncoding { get; set; } = Encoding.UTF8;

		public Parser(string file) => this.file = file;
	}
}
