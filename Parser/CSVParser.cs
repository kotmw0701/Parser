using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Parser {
	class CSVParser {
		private string file = "example.csv";
		private string[,] parsed;
		private int rowSize, columnSize;

		public Encoding ParserEncoding { get; set; } = Encoding.UTF8;
		public char Delimiter { get; set; } = ',';
		public bool LeaveQuote { get; set; } = false;

		public CSVParser(string file) => this.file = file;

		public string[] ReadRows() {
			Read();
			for (int y = 0; y < rowSize; y++) {
				for (int x = 0; x < columnSize; x++) {
					Console.Write(parsed[y, x]);
					if (x == columnSize-1) Console.WriteLine("Last: " + parsed[y, x]);
				}
			}
			return null;
		}

		public string[] ReadColumns() {
			return null;
		}

		public string[,] ReadTable() {
			return null;
		}

		private void Read() {
			var chars = File.ReadAllText(file, ParserEncoding).ToCharArray();
			List<List<string>> rows = new List<List<string>>();
			List<string> fields = new List<string>();
			StringBuilder field = new StringBuilder();
			bool escapeFlag = false;
			for (int i = 0; i < chars.Length; i++) {
				char chara = chars[i];
				if (chara == '"') {
					if (chars[i + 1] == '"') i++;
					else escapeFlag = !escapeFlag;
				}
				if (!escapeFlag) {
					if (chara == '\r' && chars[i + 1] == '\n') {
						rows.Add(fields);
						if (fields.Count > columnSize) columnSize = fields.Count;
						fields = new List<string>();
						continue;
					}
					if (chara == Delimiter) {
						fields.Add(field.ToString());
						field = new StringBuilder();
						continue;
					}
				}
				field.Append(chara);
			}
			rowSize = rows.Count;
			parsed = new string[rowSize, columnSize];
			for (int x = 0; x < rowSize; x++) {
				for (int y = 0; y < columnSize; y++) {
					parsed[x, y] = rows[x][y];
				}
			}
		}

		/* メモ
		 *   実装のパターン
		 *   ・file名指定の配列で返すパターン
		 *   ・パーサークラス(ユーザー各位自作)に自動で入れちゃうパターン
		 *   
		 *   ・というかまずファイル名指定じゃなくてStreamReader入れられるようにして自動close(usingで囲むアレ)を使う側で使えるようにする
		 *   
		 *   ・ReadAllTextのほうが早いらしい
		 * 
		 * 規則
		 * ・"値"のようにダブルクオートで囲まれた中は全部値になる
		 * ・改行が含まれる値の改行コードは\n
		 * ・""値""ダブルクオートのエスケープはダブルクオートを重ねる
		 * ・バックスラッシュがあった場合は容赦なくその後の文字を値にする
		 * ・
		 * 
		 * 
		 */
	}
}
