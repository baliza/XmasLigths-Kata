namespace XmasLigths_Kata.Domain
{
	public interface ILight
	{
		bool IsOn { get; }

		void Command(ElectricitySwitch command);
		void Toggle();
		void TurnOff();
		void TurnOn();
	}
}