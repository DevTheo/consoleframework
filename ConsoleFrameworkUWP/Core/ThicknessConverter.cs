using System;
//using ConsoleFramework.Xaml;

namespace ConsoleFramework.Core
{
    /// <summary>
    /// Converter for XAML. Supports only String -> Thickness conversion now.
    /// </summary>
    public static class ThicknessConverter //: ITypeConverter
    {
        public static bool CanConvertFrom(this Thickness thickness, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            return false;
        }

        public static bool CanConvertTo(this Thickness thickness, Type destinationType)
        {
            return false;
        }

        public static object ConvertFrom(this Thickness thickness, object value)
        {
            if (value is String)
            {
                string[] parts = ((string) value).Split(',');
                if (parts.Length == 1)
                {
                    return new Thickness(int.Parse((string) value));
                }
                else if (parts.Length == 2)
                {
                    return new Thickness(
                        int.Parse(parts[0]),
                        int.Parse(parts[1]),
                        int.Parse(parts[0]),
                        int.Parse(parts[1])
                    );
                }
                else if (parts.Length == 4)
                {
                    return new Thickness(
                        int.Parse(parts[0]),
                        int.Parse(parts[1]),
                        int.Parse(parts[2]),
                        int.Parse(parts[3])
                    );
                }
            }
            throw new NotSupportedException();
        }

        public static object ConvertTo(this Thickness thickness, object value, Type destinationType)
        {
            throw new NotSupportedException();
        }
    }
}
