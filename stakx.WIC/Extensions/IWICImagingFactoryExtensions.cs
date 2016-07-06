using System;

namespace stakx.WIC.Interop
{
    public static class IWICImagingFactoryExtensions
    {
        public static IWICBitmapDecoder CreateDecoderFromFileHandle(this IWICImagingFactory imagingFactory, IntPtr hFile, WICDecodeOptions metadataOptions, Guid? pguidVendor = null)
        {
            using (var pguidVendorPtr = CoTaskMemPtr.From(pguidVendor))
            {
                return imagingFactory.CreateDecoderFromFileHandle(hFile, pguidVendorPtr, metadataOptions);
            }
        }

        public static IWICBitmapDecoder CreateDecoderFromFilename(this IWICImagingFactory imagingFactory, string wzFilename, Guid? pguidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
        {
            using (var pguidVendorPtr = CoTaskMemPtr.From(pguidVendor))
            {
                return imagingFactory.CreateDecoderFromFilename(wzFilename, pguidVendorPtr, StreamAccessMode.GENERIC_READ, metadataOptions);
            }
        }

        public static IWICBitmapDecoder CreateDecoderFromStream(this IWICImagingFactory imagingFactory, IStream pIStream, WICDecodeOptions metadataOptions, Guid? pguidVendor = null)
        {
            using (var pguidVendorPtr = CoTaskMemPtr.From(pguidVendor))
            {
                return imagingFactory.CreateDecoderFromStream(pIStream, pguidVendorPtr, metadataOptions);
            }
        }

        public static IWICBitmapEncoder CreateEncoder(this IWICImagingFactory factory, Guid guidContainerFormat, Guid? pguidVendor = null)
        {
            using (var pguidVendorPtr = CoTaskMemPtr.From(pguidVendor))
            {
                return factory.CreateEncoder(guidContainerFormat, pguidVendorPtr);
            }
        }

        public static IWICMetadataQueryWriter CreateQueryWriter(this IWICImagingFactory imagingFactory, Guid guidMetadataFormat, Guid? pguidVendor = null)
        {
            using (var pguidVendorPtr = CoTaskMemPtr.From(pguidVendor))
            {
                return imagingFactory.CreateQueryWriter(guidMetadataFormat, pguidVendorPtr);
            }
        }

        public static IWICMetadataQueryWriter CreateQueryWriterFromReader(this IWICImagingFactory imagingFactory, IWICMetadataQueryReader pIQueryReader, Guid? pguidVendor = null)
        {
            using (var pguidVendorPtr = CoTaskMemPtr.From(pguidVendor))
            {
                return imagingFactory.CreateQueryWriterFromReader(pIQueryReader, pguidVendorPtr);
            }
        }
    }
}
