using System;
using System.IO;

using Mono.Cecil;

namespace awegwaawehg {
	class MainClass {
		public static void Main (string [] args)
		{
			var dir = Path.GetDirectoryName (System.Reflection.Assembly.GetExecutingAssembly ().Location);
			string path = null;
			do {
				path = Path.Combine (dir, "Xamarin.iOS.dll");
				if (File.Exists (path))
					break;
				dir = Path.GetDirectoryName (dir);
			} while (true);


			Check (path);
		}

		static void Check (string filename)
		{
			Console.WriteLine (filename);
			var asm = AssemblyDefinition.ReadAssembly (filename, new ReaderParameters { ReadingMode = ReadingMode.Deferred });
			var n = "QuickLook.IQLPreviewItem";
			var t = asm.MainModule.GetType (n);
			Console.WriteLine (t.CustomAttributes.Count);
		}
	}
}
