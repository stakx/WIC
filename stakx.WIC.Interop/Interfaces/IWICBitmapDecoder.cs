using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICBitmapDecoder)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapDecoder
    {
        void QueryCapability(
            [In] IStream pIStream,
            [Out] out WICBitmapDecoderCapabilities pdwCapability);

        void Initialize(
            [In] IStream pIStream,
            [In] WICDecodeOptions cacheOptions);

        void GetContainerFormat(
            [Out] out Guid pguidContainerFormat);

        void GetDecoderInfo(
            [Out] out IWICBitmapDecoderInfo ppIDecoderInfo);

        void CopyPalette(
            [In] IWICPalette pIPalette);

        void GetMetadataQueryReader(
            [Out] out IWICMetadataQueryReader ppIMetadataQueryReader);

        void GetPreview(
            [Out] out IWICBitmapSource ppIBitmapSource);

        void GetColorContexts(
            [In] int cCount,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 0)] IWICColorContext[] ppIColorContexts,
            [Out] out int pcActualCount);

        void GetThumbnail(
            [Out] out IWICBitmapSource ppIThumbnail);

        void GetFrameCount(
            [Out] out int pCount);

        void GetFrame(
            [In] int index,
            [Out] out IWICBitmapFrameDecode ppIBitmapFrame);
    }
}
