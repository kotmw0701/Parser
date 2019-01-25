using System;
using System.Collections.Generic;
using System.Text;

namespace kotmwParser {
	/// <summary>
	/// パース後のデータを格納するクラス
	/// </summary>
	class CSVObject {
		private string[][] parsed;
		public CSVObject(string[][] data) {
			parsed = data;
		}

		public string[] this[string key] {
			get {
				return null;
			}
			set {

			}
		}

		public string this[string key, int row] {
			get {
				return null;
			}
			set {

			}
		}

		public string[] this[int row] {
			get {
				return null;
			}
			set {

			}
		}
	}
}
