using System.ComponentModel;

namespace stakx.WIC.Interop
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class IWICBitmapFrameEncodeExtensions
    {
        public static IWICMetadataBlockWriter AsMetadataBlockWriter(this IWICBitmapFrameEncode bitmapFrameEncode)
        {
            return bitmapFrameEncode as IWICMetadataBlockWriter;
        }

        public static void Initialize(this IWICBitmapFrameEncode bitmapFrameEncode, IPropertyBag2 pIEncoderOptions = null)
        {
            bitmapFrameEncode.Initialize(pIEncoderOptions);
        }

        public static void WriteSource(this IWICBitmapFrameEncode bitmapFrameEncode, IWICBitmapSource pIBitmapSource, WICRect? prc = null)
        {
            using (var prcPtr = CoTaskMemPtr.From(prc))
            {
                bitmapFrameEncode.WriteSource(pIBitmapSource, prcPtr);
            }
        }

        public static void WritePixels(this IWICBitmapFrameEncode bitmapFrameEncode, int lineCount, int cbStride, byte[] pbPixels)
        {
            bitmapFrameEncode.WritePixels(lineCount, cbStride, pbPixels.Length, pbPixels);
        }
    }
}
