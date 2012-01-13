namespace app.utility
{
    public static class StringExtensions
    {
        public static string format_using(this string str, params object[] parameters)
        {
            return string.Format(str, parameters);
        }
    }
}