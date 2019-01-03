using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Parser {
	class CSVParser {
		private string file = "example.txt";
		private object[,] parsed;

		public Encoding ParserEncoding { get; set; } = Encoding.UTF8;
		public char Delimiter { get; set; } = ',';

		public CSVParser(string file, Encoding encoding, char delimiter) {
			this.file = file;
			this.ParserEncoding = encoding;
			this.Delimiter = delimiter;
		}

		public string[] ReadRows() {
			return null;
		}

		public string[] ReadColumns() {
			return null;
		}
		
		public string[,] ReadTable() {
			return null;
		}

		/* メモ
		 *   実装のパターン
		 *   ・file名指定の配列で返すパターン
		 *   ・パーサークラス(ユーザー各位自作)に自動で入れちゃうパターン
		 *   
		 *   ・というかまずファイル名指定じゃなくてStreamReader入れられるようにして自動close(usingで囲むアレ)を使う側で使えるようにする
		 * 
		 */
	}
}
