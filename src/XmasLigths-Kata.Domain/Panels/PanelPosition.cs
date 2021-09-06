namespace XmasLigths_Kata.Domain
{
	public class PanelPosition
	{
		public PanelPosition(int column, int row)
		{
			Column = column;
			Row = row;
		}

		public int Column { get; private set; }
		public int Row { get; private set; }
	}
}