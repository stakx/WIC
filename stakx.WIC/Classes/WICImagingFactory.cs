using System.Runtime.InteropServices;

namespace stakx.WIC
{
    [ComImport]
    [Guid(IID.IWICImagingFactory)]
    [CoClass(typeof(WICImagingFactoryClass))]
    public interface WICImagingFactory : IWICImagingFactory { }

    [ComImport]
    [Guid(CLSID.WICImagingFactory)]
    [ComDefaultInterface(typeof(IWICImagingFactory))]
    public class WICImagingFactoryClass { }
}
