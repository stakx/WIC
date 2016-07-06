using System.Collections.Generic;
using System.ComponentModel;

namespace stakx.WIC.Interop
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class IWICBitmapDecoderExtensions
    {
        public static IWICMetadataBlockReader AsMetadataBlockReader(this IWICBitmapDecoder bitmapDecoder)
        {
            return bitmapDecoder as IWICMetadataBlockReader;
        }

        public static IEnumerable<IWICBitmapFrameDecode> GetFrames(this IWICBitmapDecoder bitmapDecoder)
        {
            for (int i = 0, n = bitmapDecoder.GetFrameCount(); i < n; ++i)
            {
                yield return bitmapDecoder.GetFrame(i);
            }
        }
    }
}
