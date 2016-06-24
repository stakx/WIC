using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICBitmapSource)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IWICBitmapSource
    {
        void GetSize(
            [Out] out int puiWidth,
            [Out] out int puiHeight);

        void GetPixelFormat(
            [Out] out Guid pPixelFormat);

        void GetResolution(
            [Out] out double pDpiX,
            [Out] out double pDpiY);

        void CopyPalette(
            [In] IWICPalette pIPalette);

        unsafe void CopyPixels(
            [In] WICRect* prc,
            [In] int cbStride,
            [In] int cbBufferSize,
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 2)] byte* pbBuffer);
    }
}
