using System;
using System.Windows.Forms;
using GrabTheMoment.Framework.Logger;

namespace GrabTheMoment.ScreenMode
{
    public class FullScreen : PrintScreenType
    {
        public FullScreen()
        {
            SetFileName();
            Height = SystemInformation.VirtualScreen.Height;
            Width = SystemInformation.VirtualScreen.Width;

            SetXandY();
            CreatePic();

            SavePic();

            notifyIcon(7000, "FullScreen" + " + " + allmode.WhatClipboard(), FileName, ToolTipIcon.Info);
            Log.WriteEvent("FullScreen/Constructor: " + FileName + " elkészült!");
        }
    }
}
