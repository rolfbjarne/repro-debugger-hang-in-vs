using System;

using Mono.Cecil;

namespace awegwaawehg {
	class MainClass {
		public static void Main (string [] args)
		{
			Check ("/Users/rolf/work/maccore/main/xamarin-macios/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.iOS/Xamarin.iOS.dll");
			Check ("/Users/rolf/work/maccore/xcode12.2/xamarin-macios/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.iOS/Xamarin.iOS.dll");

			Console.WriteLine ("Hello World!");
		}

		static void Check (string filename)
		{
			Console.WriteLine (filename);
			var asm = AssemblyDefinition.ReadAssembly (filename);
			var n = "QuickLook.IQLPreviewItem";
			var t = asm.MainModule.GetType (n);
			Console.WriteLine (t.CustomAttributes.Count);
		}
	}
}
