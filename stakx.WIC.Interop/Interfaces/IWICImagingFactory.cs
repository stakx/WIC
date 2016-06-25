using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICImagingFactory)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IWICImagingFactory
    {
        unsafe void CreateDecoderFromFilename(
            [In, MarshalAs(UnmanagedType.LPWStr)] string wzFilename,
            [In] Guid* pguidVendor,
            [In] StreamAccessMode dwDesiredAccess,
            [In] WICDecodeOptions metadataOptions,
            [Out] out IWICBitmapDecoder ppIDecoder);

        unsafe void CreateDecoderFromStream(
            [In] IStream pIStream,
            [In] Guid* pguidVendor,
            [In] WICDecodeOptions metadataOptions,
            [Out] out IWICBitmapDecoder ppIDecoder);

        unsafe void CreateDecoderFromFileHandle(
            [In] IntPtr hFile,
            [In] Guid* pguidVendor,
            [In] WICDecodeOptions metadataOptions,
            [Out] out IWICBitmapDecoder ppIDecoder);

        void CreateComponentInfo(
            [In] Guid clsidComponent,
            [Out] out IWICComponentInfo ppIInfo);

        unsafe void CreateDecoder(
            [In] Guid guidContainerFormat,
            [In] Guid* pguidVendor,
            [Out] out IWICBitmapDecoder ppIDecoder);

        unsafe void CreateEncoder(
            [In] Guid guidContainerFormat,
            [In] Guid* pguidVendor,
            [Out] out IWICBitmapEncoder ppIEncoder);

        void CreatePalette(
            [Out] out IWICPalette ppIPalette);

        void CreateFormatConverter(
            [Out] out IWICFormatConverter ppIFormatConverter);

        void CreateBitmapScaler(
            [Out] out IWICBitmapScaler ppIBitmapScaler);

        void CreateBitmapClipper(
            [Out] out IWICBitmapClipper ppIBitmapClipper);

        void CreateBitmapFlipRotator(
            [Out] out IWICBitmapFlipRotator ppIBitmapFlipRotator);

        void CreateStream(
            [Out] out IWICStream ppIWICStream);

        void CreateColorContext(
            [Out] out IWICColorContext ppIWICColorContext);

        void CreateColorTransformer(
            [Out] out IWICColorTransform ppIWICColorTransform);

        void CreateBitmap(
            [In] int uiWidth,
            [In] int uiHeight,
            [In] Guid pixelFormat,
            [In] WICBitmapCreateCacheOption option,
            [Out] out IWICBitmap ppIBitmap);

        void CreateBitmapFromSource(
            [In] IWICBitmapSource pIBitmapSource,
            [In] WICBitmapCreateCacheOption option,
            [Out] out IWICBitmap ppIBitmap);

        void CreateBitmapFromSourceRect(
            [In] IWICBitmapSource pIBitmapSource,
            [In] int x,
            [In] int y,
            [In] int width,
            [In] int height,
            [Out] out IWICBitmap ppIBitmap);

        unsafe void CreateBitmapFromMemory(
            [In] int uiWidth,
            [In] int uiHeight,
            [In] Guid pixelFormat,
            [In] int cbStride,
            [In] int cbBufferSize,
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 4)] byte* pbBuffer,
            [Out] out IWICBitmap ppIBitmap);

        void CreateBitmapFromHBITMAP(
            [In] IntPtr hBitmap,
            [In] IntPtr hPalette,
            [In] WICBitmapAlphaChannelOption options,
            [Out] out IWICBitmap ppIBitmap);

        void CreateBitmapFromHICON(
            [In] IntPtr hIcon,
            [Out] out IWICBitmap ppIBitmap);

        void CreateComponentEnumerator(
            [In] WICComponentType componentTypes,
            [In] WICComponentEnumerateOptions options,
            [Out] out IEnumUnknown ppIEnumUnknown);

        void CreateFastMetadataEncoderFromDecoder(
            [In] IWICBitmapDecoder pIDecoder,
            [Out] out IWICFastMetadataEncoder ppIFastEncoder);

        void CreateFastMetadataEncoderFromFrameDecode(
            [In] IWICBitmapFrameDecode pIFrameDecoder,
            [Out] out IWICFastMetadataEncoder ppIFastEncoder);

        unsafe void CreateQueryWriter(
            [In] Guid guidMetadataFormat,
            [In] Guid* pguidVendor,
            [Out] out IWICMetadataQueryWriter ppIQueryWriter);

        unsafe void CreateQueryWriterFromReader(
            [In] IWICMetadataQueryReader pIQueryReader,
            [In] Guid* pguidVendor,
            [Out] out IWICMetadataQueryWriter ppIQueryWriter);
    }
}
