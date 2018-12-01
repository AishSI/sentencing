namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			int lastNumber = count % 10;
			int penultimateNumber = (count / 10) % 10;

			if (penultimateNumber != 1 && lastNumber == 1) return "рубль";
			if (penultimateNumber != 1 && (lastNumber == 2 || lastNumber == 3 || lastNumber == 4)) return "рубля";
			return "рублей";
		}
	}
}