namespace Net.Tcgdex.Sdk
{
    public enum Quality
    {
        HIGH,
        LOW
    }

    public static class QualityExtensions
    {
        public static string GetValue(this Quality quality) => quality.ToString().ToLower();
    }
}
