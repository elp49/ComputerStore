using System;

namespace ComputerStore
{

	// COMPUTER PART CLASSES
	abstract class Monitor
	{
		public abstract string DisplayMonitorInformation();
	}

	abstract class CPU
	{
		public abstract string DisplayCPUInformation();
	}

	abstract class Keyboard
	{
		public abstract string DisplayKeyboardInformation();
	}

	class StandardMonitor : Monitor
	{
		public override string DisplayMonitorInformation() {
			return "Standard Monitor";
		}
	}

	class StandardCPU : CPU
	{
		public override string DisplayCPUInformation() {
			return "Standard CPU";
		}
	}

	class StandardKeyboard : Keyboard
	{
		public override string DisplayKeyboardInformation() {
			return "Standard Keyboard";
		}
	}

	class AdvancedMonitor : Monitor
	{
		public override string DisplayMonitorInformation() {
			return "Advanced Monitor";
		}
	}

	class AdvancedCPU : CPU
	{
		public override string DisplayCPUInformation() {
			return "Advanced CPU";
		}
	}

	class AdvancedKeyboard : Keyboard
	{
		public override string DisplayKeyboardInformation() {
			return "Advanced Keyboard";
		}
	}


	// COMPUTER CLASSES
	abstract class Computer
	{
		public Monitor monitor;
		public CPU cpu;
		public Keyboard keyboard;

		public abstract string GetComputerType();

		public abstract void AddComponents();

		public abstract void Assemble();

		public void DisplayInformation() {
			Console.WriteLine("Monitor Information:\t{0}", this.monitor.DisplayMonitorInformation());
			Console.WriteLine("CPU Information:\t{0}", this.cpu.DisplayCPUInformation());
			Console.WriteLine("Keyboard Information:\t{0}", this.keyboard.DisplayKeyboardInformation());
		}
	}


	class StandardComputer : Computer
	{
		public override string GetComputerType() {
			return "Standard";
		}

		public override void AddComponents() {
			Console.WriteLine("Preparing components for standard version");
		}

		public override void Assemble() {
			Console.WriteLine("Standard computer being assembled");
			this.monitor = new StandardMonitor();
			this.cpu = new StandardCPU();
			this.keyboard = new StandardKeyboard();
		}
	}


	class AdvancedComputer : Computer
	{
		public override string GetComputerType() {
			return "Advanced";
		}

		public override void AddComponents() {
			Console.WriteLine("Preparing components for advanced version");
		}

		public override void Assemble() {
			Console.WriteLine("Advanced computer being assembled");
			this.monitor = new AdvancedMonitor();
			this.cpu = new AdvancedCPU();
			this.keyboard = new AdvancedKeyboard();
		}
	}


	// COMPUTER PART FACTORIES
	abstract class BaseComputerPartsFactory
	{
		public abstract Monitor CreateMonitor();
		public abstract CPU CreateCPU();
		public abstract Keyboard CreateKeyboard();
	}


	class StandardComputerPartsFactory : BaseComputerPartsFactory
	{
		public override Monitor CreateMonitor() {
			Console.WriteLine("Creating standard monitor.");
			return new StandardMonitor();
		}

		public override CPU CreateCPU() {
			Console.WriteLine("Creating standard CPU.");
			return new StandardCPU();
		}

		public override Keyboard CreateKeyboard() {
			Console.WriteLine("Creating standard keyboard.");
			return new StandardKeyboard();
		}
	}


	class AdvancedComputerPartsFactory : BaseComputerPartsFactory
	{
		public override Monitor CreateMonitor() {
			Console.WriteLine("Creating advanced monitor.");
			return new AdvancedMonitor();
		}

		public override CPU CreateCPU() {
			Console.WriteLine("Creating advanced CPU.");
			return new AdvancedCPU();
		}

		public override Keyboard CreateKeyboard() {
			Console.WriteLine("Creating advanced keyboard.");
			return new AdvancedKeyboard();
		}
	}


	// COMPUTER FACTORIES
	abstract class BaseComputerFactory
	{
		public abstract Computer CreateComputer(string type);
	}


	class ComputerFactory : BaseComputerFactory
	{
		public override Computer CreateComputer(string type) {
			Computer computer;
			switch (type.ToLower()) {
				case "standard":
					computer = new StandardComputer();
					break;

				case "advanced":
					computer = new AdvancedComputer();
					break;

				default: throw new ArgumentException("No such computer.");
			}

			computer.AddComponents();
			computer.Assemble();
			computer.DisplayInformation();
			return computer;
		}
	}

}