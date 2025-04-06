namespace Net.Tcgdex.Sdk
{
    public enum Extension
    {
        PNG,
        JPG,
        WEBP
    }

    public static class ExtensionMethods
    {
        public static string GetValue(this Extension extension) => extension.ToString().ToLower();
    }
}
