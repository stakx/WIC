using System.ComponentModel;

namespace stakx.WIC.Interop
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static class IWICMetadataQueryReaderExtensions
    {
        public static string GetLocation(this IWICMetadataQueryReader metadataQueryReader)
        {
            FetchIntoBuffer<char> fetcher = metadataQueryReader.GetLocation;
            return fetcher.FetchString();
        }
    }
}
