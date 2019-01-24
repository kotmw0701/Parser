using System;
using System.Text;

namespace kotmwParser {
	class Program {
		static void Main(string[] args) {
			CSVObject parsed  = CSVParser.Parse("13tokyo.csv", new CSVConfigure() {
				Delimiter = ',',
				HasHeader = false,
				LeaveQuote = true,
				ParserEncoding = Encoding.UTF8
			});

			Console.ReadKey();
		}
	}
}
