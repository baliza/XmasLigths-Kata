namespace XmasLigths_Kata.Domain
{
	public class TurnOffSwitch : ElectricitySwitch
	{
		public override void Switch(ILight bulb)
		{
			bulb.TurnOff();
		}
	}
}