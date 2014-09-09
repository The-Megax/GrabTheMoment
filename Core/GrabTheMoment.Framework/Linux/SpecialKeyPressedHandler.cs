#if __MonoCS__
using System;

namespace GrabTheMoment.Framework.Linux
{
    public delegate void SpecialKeyPressedHandler(object o, SpecialKey key, Gdk.ModifierType ModeMask);
}
#endif