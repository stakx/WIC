using System.ComponentModel;

namespace stakx.WIC.Interop
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class IWICColorContextExtensions
    {
        public static void InitializeFromMemory(this IWICColorContext colorContext, byte[] pbBuffer)
        {
            colorContext.InitializeFromMemory(pbBuffer, pbBuffer.Length);
        }

        public static byte[] GetProfileBytes(this IWICColorContext colorContext)
        {
            FetchIntoBuffer<byte> fetcher = colorContext.GetProfileBytes;
            return fetcher.FetchArray();
        }
    }
}
