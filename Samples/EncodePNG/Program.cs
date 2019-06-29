using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using WIC;
using WIC.Constants;

namespace Sample
{
    class Program
    {
        static IEnumerable<IWICBitmapEncoderInfo> EnumEncoders(IWICImagingFactory wic)
        {
            return wic.CreateComponentEnumerator(WICComponentType.WICEncoder, WICComponentEnumerateOptions.WICComponentEnumerateDefault)
                .AsEnumerable()
                .OfType<IWICBitmapEncoderInfo>();
        }

        static void Main(string[] args)
        {
            const int width = 256;
            const int height = 256;
            const int bytesPerPixel = 3;

            var wif = new WICImagingFactory();

            // find the PNG encoder information
            var pngEncoderInfo = EnumEncoders(wif)
                .Where(y => y.GetFriendlyName() == "PNG Encoder")
                .First();

            // create the PNG encoder
            var pngEncoder = wif.CreateEncoder(pngEncoderInfo.GetContainerFormat());

            using (var stream = File.Create("result.png"))
            {
                pngEncoder.Initialize(stream.AsCOMStream(), WICBitmapEncoderCacheOption.WICBitmapEncoderNoCache);

                var frame = pngEncoder.CreateNewFrame();

                frame.Initialize(null);

                // set pixel format
                var format = WICPixelFormat.WICPixelFormat24bppBGR;
                frame.SetPixelFormat(ref format);

                // check if the pixel format was accepted
                if (format != WICPixelFormat.WICPixelFormat24bppBGR)
                {
                    throw new ArgumentException("The requested pixel format was not accepted");
                }

                frame.SetResolution(new Resolution(96, 96));
                frame.SetSize(width, height);

                var image = new byte[width * height * bytesPerPixel];

                // create a RGB gradient image
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        image[(y * width + x) * bytesPerPixel + 0] = (byte)x;           // blue
                        image[(y * width + x) * bytesPerPixel + 1] = (byte)y;           // green
                        image[(y * width + x) * bytesPerPixel + 2] = (byte)(255 - y);   // red
                    }
                }

                // write it to the frame
                IWICBitmapFrameEncodeExtensions.WritePixels(frame, height, width * bytesPerPixel, image);

                // commit everything to stream
                frame.Commit();
                pngEncoder.Commit();
            }
        }
    }
}
