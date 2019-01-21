﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace kotmwParser {
	class CSVParser : Parser {
		private string[][] parsed;
		private int rowSize, columnSize;
		
		public char Delimiter { get; set; } = ',';
		public bool LeaveQuote { get; set; } = true;

		public CSVParser(string file) : base(file) { }

		public string[][] ReadTable() {
			Read();
			return null;
		}

		private void Read() {
			var chars = File.ReadAllText(file, ParserEncoding).ToCharArray();
			StringBuilder field = new StringBuilder();
			List<string> fields = new List<string>();
			bool escapeFlag = false;
			for (int i = 0; i < chars.Length; i++) {
				char chara = chars[i];
				if (chara == '"') {
					if (chars[i + 1] == '"') i++;
					else escapeFlag = !escapeFlag;
					if (LeaveQuote) continue;
				}
				if (!escapeFlag) {
					if ((chara == Delimiter) || (chara == '\r' && chars[i + 1] == '\n')) {
						if (rowSize == 0) columnSize++;
						if (chara == '\r') {
							rowSize++;
							i++;
						}
						//Console.WriteLine(field);
						fields.Add(field.ToString());
						field = new StringBuilder();
						continue;
					}
				}
				field.Append(chara);
			}
			fields.Add(field.ToString());
			rowSize++;
			int column = 0, row = 0;
			parsed = new string[rowSize][];
			foreach (string data in fields) {
				if (column == 0) parsed[row] = new string[columnSize];
				parsed[row][column] = data;
				column++;
				if (columnSize == column) {
					row++;
					column = 0;
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