using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SuperWebApp.Component;

namespace SuperWebApp.UnitTests {
	[TestFixture]
	public class SomeUnitTest {
		[Test]
		public void UmbracoStartsWithUmbraco() {
			Assert.IsTrue(SomeUnitTestableStuff.StartsWithUmbraco("Umbraco for the win"));
		}

		[Test]
		public void UmbracoStartsWithUmbracoCaseInsensitive() {
			Assert.IsTrue(SomeUnitTestableStuff.StartsWithUmbraco("umbraco for the win", true));
		}

		[Test]
		public void UmbracoStartsWithUmbracoUppercase() {
			Assert.IsFalse(SomeUnitTestableStuff.StartsWithUmbraco("UMBRACO FOR THE WIN"));
		}

		[Test]
		public void UmbracoStartsWithUmbracoUppercaseCaseInsensitive() {
			Assert.True(SomeUnitTestableStuff.StartsWithUmbraco("UMBRACO FOR THE WIN", true));
		}

		[Test]
		public void SitecoreStartsWithUmbraco() {
			Assert.IsFalse(SomeUnitTestableStuff.StartsWithUmbraco("Sitecore for the loose"));
		}

		[Test]
		public void SitecoreStartsWithUmbracoCaseInsensitive() {
			Assert.IsFalse(SomeUnitTestableStuff.StartsWithUmbraco("Sitecore for the loose", true));
		}
	}
}
