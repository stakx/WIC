using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICBitmapEncoder)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapEncoder
    {
        void Initialize(
            [In] IStream pIStream,
            [In] WICBitmapEncoderCacheOption cacheOption);

        void GetContainerFormat(
            [Out] out Guid pguidContainerFormat);

        void GetEncoderInfo(
            [Out] out IWICBitmapEncoderInfo ppIEncoderInfo);

        void SetColorContexts(
            [In] int cCount,
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 0)] IWICColorContext[] ppIColorContext);

        void SetPalette(
            [In] IWICPalette pIPalette);

        void SetThumbnail(
            [In] IWICBitmapSource pIThumbnail);

        void SetPreview(
            [In] IWICBitmapSource pIPreview);

        void CreateNewFrame(
            [Out] out IWICBitmapFrameEncode ppIFrameEncode,
            [In, Out] IPropertyBag2 ppIEncoderOptions);

        void Commit();

        void GetMetadataQueryWriter(
            [Out] out IWICMetadataQueryWriter ppIMetadataQueryWriter);
    }
}
