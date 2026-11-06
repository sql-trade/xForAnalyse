// Decompiled with JetBrains decompiler
// Type: dje_qJY2NRDBMWDXJ5VJEZ6UJQ5FCUUAXZB5MYNFBYJZLQ5B6QPVFPZXQ_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
using System.Security;

#nullable disable
internal static class dje_qJY2NRDBMWDXJ5VJEZ6UJQ5FCUUAXZB5MYNFBYJZLQ5B6QPVFPZXQ_ejd
{
  public static void \u0023\u003DzbPXqxauLIM19FvgM26UCiAK9iejQ(uint _param0)
  {
    if (_param0 == 0U)
      return;
    int num1 = (int) _param0;
    if (true)
      goto label_3;
label_2:
    uint num2;
    throw new InvalidOperationException(num2.ToString());
label_3:
    num2 = (uint) num1;
    goto label_2;
  }

  [DllImport("ncrypt.dll", EntryPoint = "NCryptFreeObject")]
  public static extern uint dje_z8EWB9LKXGRDFLU9GJ7NDWKUUKV9TKGDTS3_ejd(IntPtr dje_zDV256B5X_ejd);

  [DllImport("ncrypt.dll", EntryPoint = "NCryptEncrypt")]
  public static extern uint dje_zJX3AHZCXW4RTUDNB7JQK27URV7AK7FGDULPBNRK3GLM7NGZ_ejd(
    dje_qJY2NRDBMWDXJ5VJEZ6UJQ5FCUUAXZB5MYNFBYJZLQ5B6QPVFPZXQ_ejd.dje_zAJDS47HK_ejd dje_zDV256B5X_ejd,
    [MarshalAs(UnmanagedType.LPArray)] byte[] dje_z7AU835VP_ejd,
    int dje_zGVFT2SZ2_ejd,
    IntPtr dje_zAJDS47HK_ejd,
    [MarshalAs(UnmanagedType.LPArray)] byte[] dje_zKWRHPBFH_ejd,
    int dje_zGKAT5CXU_ejd,
    out int dje_zEHHVQ2F9_ejd,
    int dje_z7QG7UYHJ_ejd);

  [DllImport("ncrypt.dll", EntryPoint = "NCryptImportKey", CharSet = CharSet.Unicode)]
  public static extern uint dje_zSNCZGSNWYV8S633PKJJ6QFKPXWGQ_ejd(
    dje_qJY2NRDBMWDXJ5VJEZ6UJQ5FCUUAXZB5MYNFBYJZLQ5B6QPVFPZXQ_ejd.dje_zKWRHPBFH_ejd dje_zDV256B5X_ejd,
    IntPtr dje_z7AU835VP_ejd,
    string dje_zGVFT2SZ2_ejd,
    IntPtr dje_zAJDS47HK_ejd,
    out dje_qJY2NRDBMWDXJ5VJEZ6UJQ5FCUUAXZB5MYNFBYJZLQ5B6QPVFPZXQ_ejd.dje_zAJDS47HK_ejd dje_zKWRHPBFH_ejd,
    [MarshalAs(UnmanagedType.LPArray)] byte[] dje_zGKAT5CXU_ejd,
    int dje_zEHHVQ2F9_ejd,
    uint dje_z7QG7UYHJ_ejd);

  [DllImport("ncrypt.dll", EntryPoint = "NCryptOpenStorageProvider", CharSet = CharSet.Unicode)]
  public static extern uint dje_zZ92PR45D9JTU4M584B6Y923L6ZN4A2BGUGEHBFEYVRAVEHQ_ejd(
    out dje_qJY2NRDBMWDXJ5VJEZ6UJQ5FCUUAXZB5MYNFBYJZLQ5B6QPVFPZXQ_ejd.dje_zKWRHPBFH_ejd dje_zDV256B5X_ejd,
    string dje_z7AU835VP_ejd,
    uint dje_zGVFT2SZ2_ejd);

  [SecurityCritical]
  public sealed class dje_zAJDS47HK_ejd : SafeHandleZeroOrMinusOneIsInvalid
  {
    public dje_zAJDS47HK_ejd()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector(true);
    }

    public virtual bool IsInvalid
    {
      get
      {
        if (true)
          ;
        return ((SafeHandle) this).handle == IntPtr.Zero;
      }
    }

    protected virtual bool ReleaseHandle()
    {
      if (true)
        ;
      return dje_qJY2NRDBMWDXJ5VJEZ6UJQ5FCUUAXZB5MYNFBYJZLQ5B6QPVFPZXQ_ejd.dje_z8EWB9LKXGRDFLU9GJ7NDWKUUKV9TKGDTS3_ejd(((SafeHandle) this).handle) == 0U;
    }
  }

  public struct dje_zDV256B5X_ejd
  {
    public uint dje_zDV256B5X_ejd;
    public int dje_z7AU835VP_ejd;
    public int dje_zGVFT2SZ2_ejd;
    public int dje_zAJDS47HK_ejd;
    public int dje_zKWRHPBFH_ejd;
    public int dje_zGKAT5CXU_ejd;
  }

  [SecurityCritical]
  public sealed class dje_zKWRHPBFH_ejd : SafeHandleZeroOrMinusOneIsInvalid
  {
    public dje_zKWRHPBFH_ejd()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector(true);
    }

    public virtual bool IsInvalid
    {
      get
      {
        if (true)
          ;
        return ((SafeHandle) this).handle == IntPtr.Zero;
      }
    }

    protected virtual bool ReleaseHandle()
    {
      if (true)
        ;
      return dje_qJY2NRDBMWDXJ5VJEZ6UJQ5FCUUAXZB5MYNFBYJZLQ5B6QPVFPZXQ_ejd.dje_z8EWB9LKXGRDFLU9GJ7NDWKUUKV9TKGDTS3_ejd(((SafeHandle) this).handle) == 0U;
    }
  }
}
