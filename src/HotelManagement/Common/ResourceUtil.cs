﻿using HotelManagement.Const;
using HotelManagement.Enums;
using System.Drawing;

namespace HotelManagement.Common
{
    public static class ResourceUtil
    {
        public static Bitmap GetMenuIcon(Display display)
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            return new Bitmap(
                myAssembly.GetManifestResourceStream($"{Constants.AppName}.Resources.Images.icon_{display.ToString().ToLower()}.png"));
        }
    }
}
