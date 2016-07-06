using System.ComponentModel;

namespace stakx.WIC.Interop
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class IWICComponentInfoExtensions
    {
        public static string GetAuthor(this IWICComponentInfo componentInfo)
        {
            StringBufferMethod fn = componentInfo.GetAuthor;
            return fn.InvokeAndConvertBufferToString();
        }

        public static string GetFriendlyName(this IWICComponentInfo componentInfo)
        {
            StringBufferMethod fn = componentInfo.GetFriendlyName;
            return fn.InvokeAndConvertBufferToString();
        }

        public static string GetVersion(this IWICComponentInfo componentInfo)
        {
            StringBufferMethod fn = componentInfo.GetVersion;
            return fn.InvokeAndConvertBufferToString();
        }

        public static string GetSpecVersion(this IWICComponentInfo componentInfo)
        {
            StringBufferMethod fn = componentInfo.GetSpecVersion;
            return fn.InvokeAndConvertBufferToString();
        }
    }
}
