//namespace DtxFileCryptography
//{
//	class Program
//	{
//		static void Main()
//		{
//			System.Console.WriteLine("Hello, World!");
//		}
//	}
//}

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

			foreach (string arg in args)
			{
				System.Console.WriteLine(arg);
			}

			return 0;
		}
	}
}
