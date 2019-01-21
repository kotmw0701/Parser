using System;
using System.Text;

namespace kotmwParser {
	class Program {
		static void Main(string[] args) {
			CSVParser parser = new CSVParser("13tokyo.csv", new CSVConfigure() {
				Delimiter = ',',
				HasHeader = false,
				LeaveQuote = true,
				ParserEncoding = Encoding.UTF8
			});
			parser.ReadTable();

			Console.ReadKey();
		}
	}
}
