using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IErrorLog)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IErrorLog
    {
        void AddError(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszPropName,
            [In] IntPtr pExcepInfo); // EXCEPINFO*
    }
}
