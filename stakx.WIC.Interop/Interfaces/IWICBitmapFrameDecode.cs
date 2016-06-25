using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICBitmapFrameDecode)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IWICBitmapFrameDecode : IWICBitmapSource
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

        void GetMetadataQueryReader(
            [Out] out IWICMetadataQueryReader ppIMetadataQueryReader);

        void GetColorContexts(
             [In] int cCount,
             [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 0)] IWICColorContext[] ppIColorContexts,
             [Out] out int pcActualCount);

        void GetThumbnail(
            [Out] out IWICBitmapSource ppIThumbnail);
    }
}
