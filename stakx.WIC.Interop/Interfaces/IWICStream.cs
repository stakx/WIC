using System.ComponentModel;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICStream)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IWICStream : IStream
    {
        #region Members inherited from `IStream`

        #region Members inherited from `ISequentialStream`

        new unsafe void Read(
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] void* pv,
            [In] int cb,
            [Out] out int pcbRead);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        new unsafe void RemoteRead(
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte* pv,
            [In] int cb,
            [Out] out int pcbRead);

        new unsafe void Write(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] void* pv,
            [In] int cb,
            [Out] out int pcbWritten);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        new unsafe void RemoteWrite(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte* pv,
            [In] int cb,
            [Out] out int pcbWritten);

        #endregion

        new void Seek(
            [In] long dlibMove,
            [In] STREAM_SEEK dwOrigin,
            [Out] out long plibNewPosition);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        new void RemoteSeek(
            [In] long dlibMove,
            [In] STREAM_SEEK dwOrigin,
            [Out] out long plibNewPosition);

        new void SetSize(
            [In] long libNewSize);

        new void CopyTo(
            [In] IStream pstm,
            [In] long cb,
            [Out] out long pcbRead,
            [Out] out long pcbWritten);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        new void RemoteCopyTo(
            [In] IStream pstm,
            [In] long cb,
            [Out] out long pcbRead,
            [Out] out long pcbWritten);

        new void Commit(
            [In] STGC grfCommitFlags);

        new void Revert();

        new void LockRegion(
            [In] long libOffset,
            [In] long cb,
            [In] LOCKTYPE dwLockType);

        new void UnlockRegion(
            [In] long libOffset,
            [In] long cb,
            [In] LOCKTYPE dwLockType);

        new void Stat(
            [In, Out] ref STATSTG pstatstg,
            [In] STATFLAG grfStatFlag);

        new void Clone(
            [Out] out IStream ppstm);

        #endregion

        void InitializeFromIStream(
            [In] IStream pIStream);

        void InitializeFromFilename(
            [In, MarshalAs(UnmanagedType.LPWStr)] string wzFileName,
            [In] StreamAccessMode dwDesiredAccess);

        unsafe void InitializeFromMemory(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte* pbBuffer,
            [In] int cbBufferSize);

        void InitializeFromIStreamRegion(
            [In] IStream pIStream,
            [In] long ulOffset,
            [In] long ulMaxSize);
    }
}
