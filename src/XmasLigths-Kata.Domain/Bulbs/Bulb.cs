namespace XmasLigths_Kata.Domain
{
	public class Bulb : ILight
	{
		private bool _isOn;

		public bool IsOn { get => _isOn; private set => _isOn = value; }

		public void Command(ElectricitySwitch command)
		{
			command.Switch(this);
		}

		public void TurnOff()
		{
			IsOn = false;
		}

		public void Toggle()
		{
			IsOn = !IsOn;
		}

		public void TurnOn()
		{
			IsOn = true;
		}
	}
}