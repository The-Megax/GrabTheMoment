using System;

namespace GrabTheMoment.Framework.Config
{
    public static class Consts
    {
        public const string GrabTheMomentDescription = "Grab The Moment";
#if DEBUG
        public const string GrabTheMomentConfiguration = "Debug";
#else
        public const string GrabTheMomentConfiguration = "Release";
#endif
        public const string GrabTheMomentCompany = "Yeahunter Productions";
        public const string GrabTheMomentProduct = "GrabTheMoment";
        public const string GrabTheMomentCopyright = "Copyright (C) 2013-2014 Yeahunter Team <http://yeahunter.hu/>";
        public const string GrabTheMomentTrademark = "?";
        public const string GrabTheMomentVersion = "1.0.0";
        public const string GrabTheMomentFileVersion = "1.0.0.0";
    }
}