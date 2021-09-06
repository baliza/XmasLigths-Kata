using System;
using XmasLigths_Kata.Domain;

namespace VU.Kata.XmasLigths
{
	internal class Program
	{
		private static ILigthsPanel _panel;

		private static void Main(string[] args)
		{
			int _columns = 1000;
			int _rows = 1000;
			_panel = LigthsPanelFactory.CreateLigthsPanel(_columns, _rows);
			Console.WriteLine(@"
turnon 0.0 999.999 would turn on(or leave on) every light.
toggle 0.0 999.0 would toggle the first line of 1000 lights, turning off the ones that were on, and turning on the ones that were off.
turnoff 499.499 500.500 would turn off(or leave off) the middle four lights.
				");
			while (true)
			{
				PrintPanel();

				var instruccions = Console.ReadLine().Split(" ");
				var command = instruccions[0];
				var start = GetPosition(instruccions[1]);
				var end = GetPosition(instruccions[2]);
				if (command == "turnOn")
					_panel.TurnOn(start, end);
				else if (command == "turnOff")
					_panel.TurnOff(start, end);
				else if (command == "toggle")
					_panel.Toggle(start, end);
			}
		}

		private static void PrintPanel()
		{
			var on = _panel.CountLigthsOn();
			var total = _panel.TotalLigts;
			Console.WriteLine($"total: {total}; turned on: {on}; turned off: {total - on}");
		}

		private static PanelPosition GetPosition(string instruccion)
		{
			var column = int.Parse(instruccion.Split(".")[0]);
			var row = int.Parse(instruccion.Split(".")[1]);
			return new PanelPosition(column, row);
		}

		private static void PrintPanelStatus()
		{
			var on = _panel.CountLigthsOn();
			var total = _panel.TotalLigts;
			Console.WriteLine($"total: {total}; turned on: {on}; turned off: {total - on}");
		}
	}
}