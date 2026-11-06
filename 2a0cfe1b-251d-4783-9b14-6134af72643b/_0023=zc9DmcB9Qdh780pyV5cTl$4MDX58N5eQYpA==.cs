// Decompiled with JetBrains decompiler
// Type: #=zc9DmcB9Qdh780pyV5cTl$4MDX58N5eQYpA==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

#nullable disable
internal static class \u0023\u003Dzc9DmcB9Qdh780pyV5cTl\u00244MDX58N5eQYpA\u003D\u003D
{
  public static BitmapImage \u0023\u003DzgpHJ6jmxWRak(this Bitmap _param0)
  {
    MemoryStream memoryStream1 = new MemoryStream();
    MemoryStream memoryStream2;
    if (true)
      memoryStream2 = memoryStream1;
    BitmapImage bitmapImage1;
    try
    {
      ((Image) _param0).Save((Stream) memoryStream2, ImageFormat.Png);
      ((Stream) memoryStream2).Position = 0L;
      BitmapImage bitmapImage2 = new BitmapImage();
      bitmapImage2.BeginInit();
      bitmapImage2.StreamSource = (Stream) memoryStream2;
      bitmapImage2.CacheOption = BitmapCacheOption.OnLoad;
      bitmapImage2.EndInit();
      bitmapImage2.Freeze();
      ((Image) _param0).Dispose();
      if (true)
        bitmapImage1 = bitmapImage2;
    }
    finally
    {
      ((IDisposable) memoryStream2).Dispose();
    }
    return bitmapImage1;
  }

  public static ImageSource \u0023\u003DzHbeIWtlQxEIQ(this Bitmap _param0)
  {
    BitmapData bitmapData1 = _param0.LockBits(new Rectangle(0, 0, ((Image) _param0).Width, ((Image) _param0).Height), (ImageLockMode) 1, ((Image) _param0).PixelFormat);
    if (true)
      goto label_2;
label_1:
    BitmapData bitmapData2;
    BitmapSource bitmapSource = BitmapSource.Create(bitmapData2.Width, bitmapData2.Height, (double) ((Image) _param0).HorizontalResolution, (double) ((Image) _param0).VerticalResolution, PixelFormats.Bgra32, (BitmapPalette) null, bitmapData2.Scan0, bitmapData2.Stride * bitmapData2.Height, bitmapData2.Stride);
    _param0.UnlockBits(bitmapData2);
    return (ImageSource) bitmapSource;
label_2:
    bitmapData2 = bitmapData1;
    goto label_1;
  }

  public static BitmapSource \u0023\u003DzJjJrRUyxbrlS(this Bitmap _param0)
  {
    try
    {
      PixelFormat pixelFormat1 = ((Image) _param0).PixelFormat;
      if (true)
        goto label_2;
label_1:
      PixelFormat pixelFormat2;
      PixelFormat pixelFormat3;
      if (pixelFormat2 <= 139273)
      {
        if (pixelFormat2 != 137224)
        {
          if (pixelFormat2 != 139273)
            goto label_10;
        }
        else
        {
          PixelFormat bgr24 = PixelFormats.Bgr24;
          if (true)
          {
            pixelFormat3 = bgr24;
            goto label_17;
          }
          goto label_17;
        }
      }
      else if (pixelFormat2 != 925707 && pixelFormat2 != 2498570)
        goto label_10;
      PixelFormat pbgra32 = PixelFormats.Pbgra32;
      if (true)
      {
        pixelFormat3 = pbgra32;
        goto label_17;
      }
      goto label_17;
label_10:
      using (Bitmap bitmap = new Bitmap(((Image) _param0).Width, ((Image) _param0).Height, (PixelFormat) 925707))
      {
        using (Graphics graphics = Graphics.FromImage((Image) bitmap))
        {
          graphics.DrawImageUnscaled((Image) _param0, 0, 0);
          return bitmap.\u0023\u003DzJjJrRUyxbrlS();
        }
      }
label_17:
      Rectangle rectangle = new Rectangle(0, 0, ((Image) _param0).Width, ((Image) _param0).Height);
      BitmapData bitmapData = _param0.LockBits(rectangle, (ImageLockMode) 1, ((Image) _param0).PixelFormat);
      try
      {
        double dpiX = (double) ((Image) _param0).HorizontalResolution > 0.0 ? (double) ((Image) _param0).HorizontalResolution : 96.0;
        double dpiY = (double) ((Image) _param0).VerticalResolution > 0.0 ? (double) ((Image) _param0).VerticalResolution : 96.0;
        BitmapSource bitmapSource = BitmapSource.Create(((Image) _param0).Width, ((Image) _param0).Height, dpiX, dpiY, pixelFormat3, (BitmapPalette) null, bitmapData.Scan0, bitmapData.Stride * ((Image) _param0).Height, bitmapData.Stride);
        bitmapSource.Freeze();
        return bitmapSource;
      }
      finally
      {
        _param0.UnlockBits(bitmapData);
      }
label_2:
      pixelFormat2 = pixelFormat1;
      goto label_1;
    }
    catch (Exception ex)
    {
      return (BitmapSource) _param0.\u0023\u003DzgpHJ6jmxWRak();
    }
  }

  public static Bitmap \u0023\u003DzD_rDeuE\u003D(this Bitmap _param0, float _param1)
  {
    Bitmap bitmap1 = new Bitmap(((Image) _param0).Height, ((Image) _param0).Width);
    if (true)
      goto label_2;
label_1:
    Bitmap bitmap2;
    bitmap2.SetResolution(((Image) _param0).VerticalResolution, ((Image) _param0).HorizontalResolution);
    Graphics graphics1 = Graphics.FromImage((Image) bitmap2);
    Graphics graphics2;
    if (true)
      graphics2 = graphics1;
    Bitmap bitmap3;
    try
    {
      graphics2.TranslateTransform((float) ((Image) bitmap2).Width / 2f, (float) ((Image) bitmap2).Height / 2f);
      graphics2.RotateTransform(_param1);
      graphics2.TranslateTransform((float) (-(double) ((Image) _param0).Width / 2.0), (float) (-(double) ((Image) _param0).Height / 2.0));
      graphics2.DrawImage((Image) _param0, new Point(0, 0));
      Bitmap bitmap4 = bitmap2;
      if (true)
        bitmap3 = bitmap4;
    }
    finally
    {
      ((IDisposable) graphics2)?.Dispose();
    }
    return bitmap3;
label_2:
    bitmap2 = bitmap1;
    goto label_1;
  }
}
