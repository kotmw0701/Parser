﻿using System;
using System.Text;

namespace kotmwParser {
	class Program {
		static void Main(string[] args) {
			CSVParser parser = new CSVParser("example.csv") {
				Delimiter = ',',
				LeaveQuote = false,
				ParserEncoding = Encoding.UTF8
			};
			parser.ReadTable();

			Console.ReadKey();
		}
	}
}