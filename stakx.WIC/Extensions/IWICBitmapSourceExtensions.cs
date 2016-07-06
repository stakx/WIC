using System.ComponentModel;

namespace stakx.WIC.Interop
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class IWICBitmapSourceExtensions
    {
        public static void CopyPixels(this IWICBitmapSource bitmapSource, int cbStride, byte[] pbBuffer, WICRect? prc = null)
        {
            using (var prcPtr = CoTaskMemPtr.From(prc))
            {
                bitmapSource.CopyPixels(prcPtr, cbStride, pbBuffer.Length, pbBuffer);
            }
        }
    }
}
