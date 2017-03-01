using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Shopko
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			Thread.Sleep(2000);
			app.Tap(x => x.Class("android.widget.ImageView").Index(6));
			app.Screenshot("Tapped on 'Transfer Rx'");

			app.Tap("btnGuestUser");
			app.Screenshot("Tapped on 'Continue as a Guest user'");

			app.Tap("tvEnterRxDetails");
			app.Screenshot("Tapped on 'Enter Prescription details");

			app.Tap("etPrescriptionName");
			app.Screenshot("Tapped 'Prescription Name' Text Field");

			app.EnterText("Shopko");
			app.Screenshot("Typed in my prescription, 'Shopko'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("etRxNumber");
			app.Screenshot("Tapped 'Rx Number' Text Field");

			app.EnterText("94111");
			app.Screenshot("Entered in my 'Rx Number', '94111'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("tvSelectedPharmacy");
			app.Screenshot("Tapped on 'Select Pharmacy' Select Field");

			app.Tap("CVS");
			app.Screenshot("Entered in my pharmacy, 'CVS'");

			app.Tap("etPharmacyPhoneNumber");
			app.Screenshot("Tapped on 'Pharmacy Phone number' Text Field");

			app.EnterText("4158888888");
			app.Screenshot("Entered in pharmacy phone number, '415-888-8888'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("btnNext");
			app.Screenshot("Tapped on 'Next' Button");

			app.Tap("etGuestUserFirstName");
			app.Screenshot("Tapped on 'First Name' Text Field");

			app.EnterText("Bill");
			app.Screenshot("Typed in my first name, 'Bill'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("etGuestUserLastName");
			app.Screenshot("Tapped on 'Last Name' Text Field");

			app.EnterText("Gates");
			app.Screenshot("Typed in my last name, 'Gates'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
		}

	}
}
