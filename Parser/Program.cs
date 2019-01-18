using System;
using System.Text;

namespace Parser {
	class Program {
		static void Main(string[] args) {
			CSVParser parser = new CSVParser("example.csv") {
				Delimiter = ',',
				LeaveQuote = true,
				ParserEncoding = Encoding.UTF8
			};
			parser.ReadTable();

			Console.ReadKey();
		}
	}
}
