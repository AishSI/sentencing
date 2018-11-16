namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            int lastNumber = count % 10;
            int tenNumber = count % 100;
            if (tenNumber >= 11 && tenNumber <= 20) return "рублей";
            else
            {
                if (lastNumber == 1) return "рубль";
                else if (lastNumber == 2 || lastNumber == 3 || lastNumber == 4) return "рубля";
                else return "рублей";
            }
        }
    }
}