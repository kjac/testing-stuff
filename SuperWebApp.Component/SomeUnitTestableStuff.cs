using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperWebApp.Component {
	public class SomeUnitTestableStuff {
		public static bool StartsWithUmbraco(string text, bool caseInsensitive = false) {
			return caseInsensitive 
				? text.ToLowerInvariant().StartsWith("umbraco") 
				: text.StartsWith("Umbraco");
		}
	}
}
