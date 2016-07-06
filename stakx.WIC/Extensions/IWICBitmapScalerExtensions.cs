using System.ComponentModel;

namespace stakx.WIC.Interop
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class IWICBitmapScalerExtensions
    {
        public static void Initialize(this IWICBitmapScaler bitmapScaler, IWICBitmapSource pISource, Size size, WICBitmapInterpolationMode mode)
        {
            bitmapScaler.Initialize(pISource, size.Width, size.Height, mode);
        }
    }
}
