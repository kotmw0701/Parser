using System;
using System.Collections.Generic;
using System.Text;

namespace Parser {
	class Parser {
		protected readonly string file = "";

		public Encoding ParserEncoding { get; set; } = Encoding.UTF8;

		public Parser(string file) => this.file = file;
	}
}
