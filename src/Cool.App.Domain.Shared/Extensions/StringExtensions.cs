using System;

namespace Cool.App.Extensions;

public static class StringExtensions
{
    public static string TryFormat(this string str, params object[] parameters)
    {
        try
        {
            return string.Format(str, parameters);
        }
        catch (Exception)
        {
            return str;
        }
    }
}
