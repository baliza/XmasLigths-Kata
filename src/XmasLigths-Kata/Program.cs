using System;

namespace VU.Kata.XmasLigths
{
	internal class Program
	{
		private static int _columns = 1000;
		private static int _rows = 1000;
		private static bool[,] _lights;

		private static void Main(string[] args)
		{
			InitPanel();
			Console.WriteLine(@"
turnon 0.0 999.999 would turn on(or leave on) every light.
toggle 0.0 999.0 would toggle the first line of 1000 lights, turning off the ones that were on, and turning on the ones that were off.
turnoff 499.499 500.500 would turn off(or leave off) the middle four lights.
				");
			while (true)
			{
				PrintPanelStatus();

				var instrucction = Console.ReadLine().Split(" ");
				if (instrucction[0] == "turnon")
					TurnOn(instrucction[1], instrucction[2]);
				else if (instrucction[0] == "toggle")
					Toggle(instrucction[1], instrucction[2]);
				else if (instrucction[0] == "turnoff")
					TurnOff(instrucction[1], instrucction[2]);
			}
		}

		private static void TurnOff(string v1, string v2)
		{
			var startColumn = int.Parse(v1.Split(".")[0]);
			var startRow = int.Parse(v1.Split(".")[1]);
			var endColumn = int.Parse(v2.Split(".")[0]);
			var endRow = int.Parse(v2.Split(".")[1]);
			for (int c = startColumn; c <= endColumn; c++)
			{
				for (int r = startRow; r <= endRow; r++)
				{
					_lights[c, r] = false;
				}
			}
		}

		private static void Toggle(string v1, string v2)
		{
			var startColumn = int.Parse(v1.Split(".")[0]);
			var startRow = int.Parse(v1.Split(".")[1]);
			var endColumn = int.Parse(v2.Split(".")[0]);
			var endRow = int.Parse(v2.Split(".")[1]);
			for (int c = startColumn; c <= endColumn; c++)
			{
				for (int r = startRow; r <= endRow; r++)
				{
					_lights[c, r] = !_lights[c, r];
				}
			}
		}

		private static void TurnOn(string v1, string v2)
		{
			var startColumn = int.Parse(v1.Split(".")[0]);
			var startRow = int.Parse(v1.Split(".")[1]);
			var endColumn = int.Parse(v2.Split(".")[0]);
			var endRow = int.Parse(v2.Split(".")[1]);
			for (int c = startColumn; c <= endColumn; c++)
			{
				for (int r = startRow; r <= endRow; r++)
				{
					_lights[c, r] = true;
				}
			}
		}

		private static void PrintPanelStatus()
		{
			int on = 0;
			int off = 0;
			for (int c = 0; c < _columns; c++)
			{
				for (int r = 0; r < _rows; r++)
				{
					if (_lights[c, r])
						on++;
					else
						off++;
				}
			}
			Console.WriteLine($"turned on: {on}; turned off: {off}");
		}

		private static void InitPanel()
		{
			_lights = new bool[_columns, _rows];
		}
	}
}