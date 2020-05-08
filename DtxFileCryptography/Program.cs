namespace DtxFileCryptography
{
	class Program
	{
		static int Main(string[] args)
		{
			if (args == null)
			{
				System.Console.WriteLine("[args] is null!");
				return 1;
			}

			if (args.Length == 0)
			{
				System.Console.WriteLine("[args] length is zero!");
				return 2;
			}

			if (args.Length != 2)
			{
				System.Console.WriteLine("[args] length should be 2!");
				return 3;
			}

			//foreach (string arg in args)
			//{
			//	System.Console.WriteLine(arg);
			//}

			string sourcePath = args[0];
			string targetPath = args[1];

			if(System.IO.Directory.Exists(sourcePath) == false)
			{
				System.Console.WriteLine("[sourcePath] does not exits!");
				return 4;
			}

			if (System.IO.Directory.Exists(targetPath) == false)
			{
				System.Console.WriteLine("[targetPath] does not exits!");
				return 5;
			}

			System.IO.DirectoryInfo sourceDirectoryInfo =
				new System.IO.DirectoryInfo(path: sourcePath);

			foreach(System.IO.FileInfo currentFileInfo in sourceDirectoryInfo.GetFiles())
			{
				//System.Console.WriteLine(currentFileInfo.Name);
				System.Console.WriteLine(currentFileInfo.FullName);
			}

			return 0;
		}
	}
}
