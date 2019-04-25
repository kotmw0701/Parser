using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace kotmwParser {
	/// <summary>
	/// Jsonパーサーつくりたい
	/// </summary>
	class JSONParser : Parser {
		public JSONParser(string file) : base(file) {}

		public const char openObject = '{';
		public const char openArray = '[';
		public const char closeObject = '}';
		public const char closeArray = ']';
		public const char memberSeparator = ':';
		public const char valueSeparator = ',';

		public const char Quotation = '"';
		public const char Escape = '\\';


		public void Parse() {
			var chars = File.ReadAllText(file, Encoding.UTF8).ToCharArray();
			foreach (char chara in chars) {
				if (chara == '{') {

				} else if (chara == '[') {

				}
			}
		}
		/*
		 * {
			  "particle": "パーティクル名(必須)",
			  "color": "色コード(#からの16進数，colorかparamsは一方必須，color優先)",
			  "params": [
				  "offsetX",
				  "offsetY",
				  "offsetZ",
				  "<speed>",
				  "<amount>(<>で囲まれた系はなくても良い)"
				],
			  "shapes": [
				{
				  "type": "図形タイプ(circle/line/polygon/star)",
				  "radius": "半径(単位はブロック)",
				  "quantity": "頂点の数(star, polygonのみ)",
				  "particle": "パーティクル名(無くても良い)",
				  "color": "色コード(無くても良い)",
				  "position": {
					"type": "始点指定タイプ(Polar_Coordinate/Coordinate)",
					"pos": [
					  "radius / x",
					  "theta  / y",
					  "phi    / z"
					],
					"angle": "図形を回転させるときの角度",
					"repeat": {
					  "angle": "等間隔に置いて行く角度，max180",
					  "limit": "繰り返し上限値，これ以上の回数が繰り返されない場合は使用されない",
					  "rotation": "繰り返しと一緒に図形を回すか(true/false)"
					}
				  }
				}
			  ]
			}
		 * 
		 */
	}
}
