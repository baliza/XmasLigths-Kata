namespace XmasLigths_Kata.Domain
{
	public interface ILigthsPanel
	{
		int TotalLigts { get; }

		int CountLigthsOn();
		void Toggle(PanelPosition start, PanelPosition end);
		void TurnOff(PanelPosition start, PanelPosition end);
		void TurnOn(PanelPosition start, PanelPosition end);
	}
}