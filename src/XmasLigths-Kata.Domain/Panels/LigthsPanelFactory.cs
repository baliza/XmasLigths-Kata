namespace XmasLigths_Kata.Domain
{
	public static class LigthsPanelFactory
	{
		public static ILigthsPanel CreateLigthsPanel(int columns, int rows)
		{
			return new BulbsPanel(columns, rows);
		}
	}
}