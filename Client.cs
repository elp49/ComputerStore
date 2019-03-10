using System;

namespace ComputerStore
{

	public class Client
	{
		public static void Main(string[] args) {
			BaseComputerFactory computerFactory = new ComputerFactory();
			Computer standardComputer = computerFactory.CreateComputer("standard");
			Console.WriteLine();
			Computer advancedComputer = computerFactory.CreateComputer("advanced");
			Console.WriteLine();
		}
	}

}