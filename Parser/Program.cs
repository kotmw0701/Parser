using System;
using System.Text;

namespace Parser {
	class Program {
		static void Main(string[] args) {
			CSVParser parser = new CSVParser("example.txt", Encoding.UTF8, ',');
			parser.ReadRows();

			Console.ReadKey();
		}
	}
}
