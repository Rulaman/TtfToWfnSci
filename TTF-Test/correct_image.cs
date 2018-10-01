using System;
using System.Drawing;
using System.Drawing.Imaging;

public class Correction
{
	public static bool CorrectImage(Bitmap original, out Bitmap corrected)
	{
		BitmapData bmpData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadWrite, original.PixelFormat);

		if ( bmpData.Stride < 0 )
		{
			corrected = new Bitmap(original.Width, original.Height, original.PixelFormat);
			BitmapData cbmpdata = corrected.LockBits(new Rectangle(0, 0, corrected.Width, corrected.Height), ImageLockMode.ReadWrite, corrected.PixelFormat);

			IntPtr ptroriginal = bmpData.Scan0;
			IntPtr ptrorrected = cbmpdata.Scan0;
			byte[] array = new byte[Math.Abs(bmpData.Stride)];

			for ( int cnt = 0; cnt < original.Height; cnt++ )
			{
				System.Runtime.InteropServices.Marshal.Copy(ptroriginal, array, 0, Math.Abs(bmpData.Stride));
				System.Runtime.InteropServices.Marshal.Copy(array, 0, ptrorrected, cbmpdata.Stride);

				ptroriginal = (IntPtr)((int)ptroriginal + bmpData.Stride);
				ptrorrected = (IntPtr)((int)ptrorrected + cbmpdata.Stride);
			}

			original.UnlockBits(bmpData);
			corrected.UnlockBits(cbmpdata);

			return true;
		}
		else
		{
			original.UnlockBits(bmpData);
			corrected = null;
			return false;
		}
	}
}
