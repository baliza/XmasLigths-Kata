namespace XmasLigths_Kata.Domain
{
	public class TurnOnSwitch : ElectricitySwitch
	{
		public override void Switch(ILight bulb)
		{
			bulb.TurnOn();
		}
	}
}