using System;

namespace HotelManagement.Extensions
{
    public class DisplayNameAttribute : Attribute
    {
        public string DisplayName { get; private set; }

        public DisplayNameAttribute(string displayName)
        {
            this.DisplayName = displayName;
        }
    }

    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum value)
        {
            Type type = value.GetType();

            System.Reflection.FieldInfo fieldInfo = type.GetField(value.ToString());

            if (fieldInfo == null) return null;

            DisplayNameAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(DisplayNameAttribute), false) as DisplayNameAttribute[];

            return attribs.Length > 0 ? attribs[0].DisplayName : null;

        }
    }
}
