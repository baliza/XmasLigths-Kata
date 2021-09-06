using System;

namespace XmasLigths_Kata.Domain
{
	public class BulbsPanel : ILigthsPanel
	{
		private static Bulb[,] _lights;
		private readonly int _columns;
		private readonly int _rows;
		public int TotalLigts { get { return _columns * _rows; } }

		public BulbsPanel(int columns, int rows)
		{
			_columns = columns;
			_rows = rows;
			_lights = new Bulb[_columns, _rows];
			InitPanel();
		}

		private void InitPanel()
		{
			for (int c = 0; c < _columns; c++)
			{
				for (int r = 0; r < _rows; r++)
				{
					_lights[c, r] = new Bulb();
				}
			}

		}

		public int CountLigthsOn()
		{
			int on = 0;
			for (int c = 0; c < _columns; c++)
			{
				for (int r = 0; r < _rows; r++)
				{
					if (_lights[c, r].IsOn)
						on++;
				}
			}
			return on;
		}

		public void TurnOn(PanelPosition start, PanelPosition end)
		{
			ProcessCommand(new TurnOnSwitch(), start, end);
		}

		public void TurnOff(PanelPosition start, PanelPosition end)
		{
			ProcessCommand(new TurnOffSwitch(), start, end);
		}

		public void Toggle(PanelPosition start, PanelPosition end)
		{
			ProcessCommand(new ToggleSwitch(), start, end);
		}

		private void ProcessCommand<T>(T command, PanelPosition start, PanelPosition end) where T : ElectricitySwitch
		{
			for (int c = start.Column; c <= end.Column; c++)
			{
				for (int r = start.Row; r <= end.Row; r++)
				{
					command.Switch(_lights[c, r]);
				}
			}
		}
	}
}