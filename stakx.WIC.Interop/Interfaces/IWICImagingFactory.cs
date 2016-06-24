using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICImagingFactory)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IWICImagingFactory
    {
        #warning `IWICImagingFactory.CreateDecoderFromFilename` is incomplete.
        void CreateDecoderFromFilename();

        #warning `IWICImagingFactory.CreateDecoderFromStream` is incomplete.
        void CreateDecoderFromStream();

        #warning `IWICImagingFactory.CreateDecoderFromFileHandle` is incomplete.
        void CreateDecoderFromFileHandle();

        #warning `IWICImagingFactory.CreateComponentInfo` is incomplete.
        void CreateComponentInfo();

        #warning `IWICImagingFactory.CreateDecoder` is incomplete.
        void CreateDecoder();

        #warning `IWICImagingFactory.CreateEncoder` is incomplete.
        void CreateEncoder();

        void CreatePalette(
            [Out] out IWICPalette ppIPalette);

        #warning `IWICImagingFactory.CreateFormatConverter` is incomplete.
        void CreateFormatConverter();

        #warning `IWICImagingFactory.CreateBitmapScaler` is incomplete.
        void CreateBitmapScaler();

        #warning `IWICImagingFactory.CreateBitmapClipper` is incomplete.
        void CreateBitmapClipper();

        #warning `IWICImagingFactory.CreateBitmapFlipRotator` is incomplete.
        void CreateBitmapFlipRotator();

        #warning `IWICImagingFactory.CreateStream` is incomplete.
        void CreateStream();

        #warning `IWICImagingFactory.CreateColorContext` is incomplete.
        void CreateColorContext();

        #warning `IWICImagingFactory.CreateColorTransformer` is incomplete.
        void CreateColorTransformer();

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

        #warning `IWICImagingFactory.CreateComponentEnumerator` is incomplete.
        void CreateComponentEnumerator();

        #warning `IWICImagingFactory.CreateFastMetadataEncoderFromDecoder` is incomplete.
        void CreateFastMetadataEncoderFromDecoder();

        #warning `IWICImagingFactory.CreateFastMetadataEncoderFromFrameDecode` is incomplete.
        void CreateFastMetadataEncoderFromFrameDecode();

        #warning `IWICImagingFactory.CreateQueryWriter` is incomplete.
        void CreateQueryWriter();

        #warning `IWICImagingFactory.CreateQueryWriterFromReader` is incomplete.
        void CreateQueryWriterFromReader();
    }
}
