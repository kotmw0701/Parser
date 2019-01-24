using System;
using System.Collections.Generic;
using System.Text;

namespace kotmwParser {
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
