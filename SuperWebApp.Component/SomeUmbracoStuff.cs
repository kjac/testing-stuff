using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web;

namespace SuperWebApp.Component {
	public class SomeUmbracoStuff {
		public string SomeMethod() {
			var helper = new UmbracoHelper(UmbracoContext.Current);
			return helper.TypedContentAtRoot().First().Name;
		}
	}
}
