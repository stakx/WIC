using System.ComponentModel;

namespace stakx.WIC.Interop
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public enum STREAM_SEEK : int
    {
        STREAM_SEEK_SET = 0,
        STREAM_SEEK_CUR = 1,
        STREAM_SEEK_END = 2,
    }
}
