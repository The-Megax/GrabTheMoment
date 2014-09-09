﻿using System;
using System.Drawing;
using System.Windows.Forms;
using GrabTheMoment.Framework.Logger;

namespace GrabTheMoment.ScreenMode
{
    public class ActiveWindow : PrintScreenType
    {
        public ActiveWindow(Rectangle rectangle)
        {
            SetFileName();
            X = rectangle.X;
            Y = rectangle.Y;

#if !__MonoCS__
            Width = rectangle.Width - X;
            Height = rectangle.Height - Y;
#else
            Width = rectangle.Width;
            Height = rectangle.Height;
#endif

            if (X == -8 && Y == -8)
            {
                X += 8;
                Y += 8;
                Width -= 16;
                Height -= 16;
            }
            Log.WriteEvent(String.Format("X: {0} | Y: {1} | Width: {2} | Height: {3}", X, Y, Width, Height));


            CreatePic();

            SavePic();

            notifyIcon(7000, "ActiveWindow" + " + " + allmode.WhatClipboard(), FileName, ToolTipIcon.Info);
            Log.WriteEvent("ActiveWindow/Constructor: " + FileName + " elkészült!");
        }
    }
}
