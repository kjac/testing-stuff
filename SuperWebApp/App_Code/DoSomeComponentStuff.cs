using SuperWebApp.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperWebApp.App_Code {
	public class DoSomeComponentStuff {
		public static string SomeComponentStuff() {
			var component = new SomeUmbracoStuff();
			return component.SomeMethod();
		}
	}
}