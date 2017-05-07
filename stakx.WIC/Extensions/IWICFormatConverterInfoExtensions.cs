﻿using System;
using System.ComponentModel;

namespace stakx.WIC
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class IWICFormatConverterInfoExtensions
    {
        public static Guid[] GetPixelFormats(this IWICFormatConverterInfo formatConverterInfo)
        {
            FetchIntoBuffer<Guid> fetcher = formatConverterInfo.GetPixelFormats;
            return fetcher.FetchArray();
        }

    }
}
