namespace XmasLigths_Kata.Domain
{
	public class ToggleSwitch : ElectricitySwitch
	{
		public override void Switch(ILight bulb)
		{
			bulb.Toggle();
		}
	}
}