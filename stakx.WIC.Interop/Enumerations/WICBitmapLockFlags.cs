using System;

namespace stakx.WIC.Interop
{
    [Flags]
    public enum WICBitmapLockFlags : int
    {
        WICBitmapLockRead = 0x00000001,
        WICBitmapLockWrite = 0x00000002,
    }
}
