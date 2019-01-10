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
			ReadCSV();
			return null;
		}

		public string[] ReadColumns() {
			return null;
		}

		public string[,] ReadTable() {
			return null;
		}

		private void ReadCSV() {
			string text = File.ReadAllText(file, ParserEncoding);
			string[] rows = text.Split(Environment.NewLine, StringSplitOptions.None);
			List<string> fields = new List<string>();
			foreach (string row in rows) {
				var chars = row.ToCharArray();
				string field = "";
				bool escapeFlag = false;
				for (int i = 0; i < chars.Length; i++) {
					char chara = chars[i];
					if (chara == '"' || chara == '\\') {
						if (chars[i + 1] == '"') i++;
						else escapeFlag = !escapeFlag;
					} else if (chara == Delimiter && !escapeFlag) {
						fields.Add(field);
						field = "";
						continue;
					}
					field += chara;
				}
				Console.WriteLine(string.Join("|", fields));
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
		 */
	}
}
