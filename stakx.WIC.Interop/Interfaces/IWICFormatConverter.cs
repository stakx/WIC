using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICFormatConverter)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IWICFormatConverter : IWICBitmapSource
    {
        #region Members inherited from `IWICBitmapSource`

        new void GetSize(
            [Out] out int puiWidth,
            [Out] out int puiHeight);

        new void GetPixelFormat(
            [Out] out Guid pPixelFormat);

        new void GetResolution(
            [Out] out double pDpiX,
            [Out] out double pDpiY);

        new void CopyPalette(
            [In] IWICPalette pIPalette);

        new unsafe void CopyPixels(
            [In] WICRect* prc,
            [In] int cbStride,
            [In] int cbBufferSize,
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 2)] byte* pbBuffer);

        #endregion

        void Initialize(
            [In] IWICBitmapSource pISource,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid dstFormat,
            [In] WICBitmapDitherType dither,
            [In] IWICPalette pIPalette,
            [In] double alphaThresholdPercent,
            [In] WICBitmapPaletteType paletteTranslate);

        void CanConvert(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid srcPixelFormat,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid dstPixelFormat,
            [Out] out bool pfCanConvert);
    }
}
