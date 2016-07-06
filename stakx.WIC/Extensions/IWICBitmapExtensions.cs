using System.ComponentModel;

namespace stakx.WIC.Interop
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class IWICBitmapExtensions
    {
        public static IWICBitmapLock Lock(this IWICBitmap bitmap, WICBitmapLockFlags flags, WICRect? prcLock = null)
        {
            using (var prcLockPtr = CoTaskMemPtr.From(prcLock))
            {
                return bitmap.Lock(prcLockPtr, flags);
            }
        }
    }
}
