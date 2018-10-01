using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using AGS.Plugin.FontEditor;

namespace TTF_Test
{
	public partial class MainWindow: Form
	{
		private	System.Drawing.Drawing2D.SmoothingMode Smooth;
		private System.Drawing.Drawing2D.InterpolationMode Interpolation;
		private System.Drawing.Text.TextRenderingHint TextRendering;

		private Int32				MaxSize			= 100;
		private Font				font			= new Font("Arial", 9, FontStyle.Bold);
		private SizeF				size;
		private string				str;
		private Brush				brush			= new SolidBrush(Color.White);
		private Brush				blackbrush		= new SolidBrush(Color.Black);
		private NumberFormatInfo	Nfi				= new NumberFormatInfo();
		private List<PictureBox>	PictList		= new List<PictureBox>();
		private CWFNFontInfo		fontinfowfn;
		private CSCIFontInfo		fontinfosci;
		private int					lineSpacing;
		private float				lineSpacingPixel;

		private FolderBrowserDialog Fbd = new FolderBrowserDialog();
		const int staticposx=200;
		const int staticposy=26;
		int posx = staticposx;
		int posy = staticposy;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

                font.Dispose();
                brush.Dispose();
                blackbrush.Dispose();
            }
            base.Dispose(disposing);
        }

		internal static string Chr(int p_intByte)
		{
			if ( (p_intByte < 0) || (p_intByte > 255) )
			{
				throw new ArgumentOutOfRangeException("p_intByte", p_intByte, "Must be between 0 and 255.");
			}
			byte[] bytBuffer = new byte[] { (byte)p_intByte };
			return Encoding.GetEncoding(1252).GetString(bytBuffer);
		}

		public MainWindow()
		{
			InitializeComponent();

			Nfi.NumberDecimalSeparator	= ".";
			Nfi.NumberDecimalDigits		= 2;
			Nfi.NegativeSign			= "-";
			Nfi.PercentSymbol			= "%";

			TextRendering = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

			foreach ( FontFamily font in System.Drawing.FontFamily.Families )
			{
				ComboFont.Items.Add(font.Name);
			}

			//foreach ( FontStyle style in Enum.GetValues(typeof(FontStyle)) )
			//{
			//    ComboStyle.Items.Add(style.ToString());
			//}

			for ( int counter = 6; counter < MaxSize; counter++ )
			{
				ComboSize.Items.Add(counter.ToString());
			}

			FontFamily fontFamily = new FontFamily("Arial");

			if ( fontFamily.IsStyleAvailable(FontStyle.Bold) )
			{
				ComboStyle.Items.Add(FontStyle.Bold.ToString());
			}
			if ( fontFamily.IsStyleAvailable(FontStyle.Italic) )
			{
				ComboStyle.Items.Add(FontStyle.Italic.ToString());
			}
			if ( fontFamily.IsStyleAvailable(FontStyle.Regular) )
			{
				ComboStyle.Items.Add(FontStyle.Regular.ToString());
			}
			if ( fontFamily.IsStyleAvailable(FontStyle.Strikeout) )
			{
				ComboStyle.Items.Add(FontStyle.Strikeout.ToString());
			}
			if ( fontFamily.IsStyleAvailable(FontStyle.Underline) )
			{
				ComboStyle.Items.Add(FontStyle.Underline.ToString());
			}

			ComboFont.SelectedItem = "Arial";
			ComboSize.SelectedItem = "9";
			ComboStyle.SelectedItem = FontStyle.Regular.ToString();

			this.ComboFont.SelectedIndexChanged += new System.EventHandler(this.ComboFont_SelectedIndexChanged);
			this.ComboSize.SelectedIndexChanged += new System.EventHandler(this.ComboSize_SelectedIndexChanged);
			this.ComboStyle.SelectedIndexChanged += new System.EventHandler(this.ComboStyle_SelectedIndexChanged);

			lineSpacing = fontFamily.GetLineSpacing(FontStyle.Regular);
			Font fonty = new Font(fontFamily, 9);
			lineSpacingPixel = fonty.Size * lineSpacing / fontFamily.GetEmHeight(FontStyle.Regular);

			if ( Fbd.SelectedPath == "" )
			{
				TxtPath.Text = @"C:\";
			}
			else
			{
				TxtPath.Text = Fbd.SelectedPath;
			}
		}
		private void MainWindow_Paint(object sender, PaintEventArgs e)
		{
			posx = staticposx;
			posy = staticposy;

			for ( int character = 0; character < 256; character++ )
			{
				str = Chr(character);
				size = e.Graphics.MeasureString(str, font);

				e.Graphics.SmoothingMode = Smooth;
				e.Graphics.InterpolationMode = Interpolation;
				e.Graphics.TextRenderingHint = TextRendering;

				e.Graphics.FillRectangle(blackbrush, new Rectangle(posx, posy, (int)Math.Ceiling(size.Width), (int)Math.Ceiling(size.Height)));
				e.Graphics.DrawString(str, font, brush, new PointF(posx, posy));
				//e.Graphics.DrawString(size.Width.ToString(Nfi) + " " + size.Height.ToString(Nfi), font, brush, new PointF(3, 12 * character + 50));

				posx += (int)size.Width + 5;

				if ( (character+1) % 16 == 0 )
				{
					posx = staticposx;

					if ( ComboSize.SelectedItem == null )
					{
						posy += MaxSize;
					}
					else
					{
						posy += (int)lineSpacingPixel + int.Parse((string)ComboSize.SelectedItem);
					}
				}
			}
		}
		private void MainWindow_Click(object sender, EventArgs e)
		{
			posx = staticposx;
			posy = staticposy;
			this.Invalidate();
		}
		private void MainWindow_SizeChanged(object sender, EventArgs e)
		{
			posx = staticposx;
			posy = staticposy;
			this.Invalidate();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			fontinfowfn = new CWFNFontInfo();
			fontinfosci = new CSCIFontInfo();

			CreateThePictureList();
			CreateTheFont(fontinfowfn);
			CreateTheFont(fontinfosci);
			SaveTheWFNFont();
			SaveTheSCIFont();
		}

		private void CreateThePictureList()
		{
			Bitmap temp = new Bitmap(400, 400);
			Graphics tempgraph = Graphics.FromImage(temp);
			PictList.Clear();

			for ( int character = 0; character < 256; character++ )
			{
				Bitmap b;
				str = Chr(character);
				size = tempgraph.MeasureString(str, font);

				if ( size.Width > 32 )
				{
					b = new Bitmap(8, (int)Math.Ceiling(size.Height));
					Graphics graphics = Graphics.FromImage(b);

					graphics.FillRectangle(blackbrush, new Rectangle(0, 0, 32, b.Height));
					//graphics.DrawString(str, font, brush, new PointF(0, 0));
					graphics.Dispose();
				}
				else
				{
					b = new Bitmap((int)Math.Ceiling(size.Width), (int)Math.Ceiling(size.Height));
					Graphics graphics = Graphics.FromImage(b);

					graphics.FillRectangle(blackbrush, new Rectangle(0, 0, b.Width, b.Height));
					graphics.DrawString(str, font, brush, new PointF(0, 0));
					graphics.Dispose();
				}

				Bitmap bitmap = new Bitmap(b, b.Width, b.Height);
				PictureBox pict = new PictureBox();
				pict.Width = b.Width;
				pict.Height = pict.Height;

				b = Indexed.NativeMethods.CopyToBpp(b, 1);

				if ( !Correction.CorrectImage(b, out bitmap) )
				{
					pict.Image = b;
				}
				else
				{
					pict.Image = bitmap;
				}

				PictList.Add(pict);
			}
		}
		private void CreateTheFont(CFontInfo fontinfo)
		{
			int counter = 0;
			fontinfo.NumberOfCharacters = (Int16)PictList.Count;
			fontinfo.Character = new CCharInfo[fontinfo.NumberOfCharacters];
			
			while ( counter < PictList.Count )
			{
				fontinfo.Character[counter] = new CCharInfo();
				Bitmap bitmap = (Bitmap)PictList[counter].Image;
				fontinfo.Character[counter].Index = counter;
				fontinfo.Character[counter].Width = (UInt16)bitmap.Width;
				fontinfo.Character[counter].Height = (UInt16)bitmap.Height;

				int tempnr = 0;

				if ( bitmap.Width <= 8 )
				{
					tempnr = 1;
				}
				else if ( bitmap.Width <= 16 )
				{
					tempnr = 2;
				}
				else if ( bitmap.Width <= 24 )
				{
					tempnr = 3;
				}
				else if ( bitmap.Width <= 32 )
				{
					tempnr = 4;
				}

				fontinfo.Character[counter].ByteLines = new byte[bitmap.Height * tempnr];

				CFontUtils.SaveByteLinesFromPicture(fontinfo.Character[counter], bitmap);

				counter++;
			}
		}
		private void SaveTheWFNFont()
		{
			if ( !System.IO.Directory.Exists(TxtPath.Text) )
			{
				TxtPath.Text = @"C:\";
			}

			fontinfowfn.FontName = "AGSFNT" + int.Parse(TxtNumber.Text) + ".WFN";
			fontinfowfn.FontPath = System.IO.Path.Combine(TxtPath.Text, "AGSFNT" + int.Parse(TxtNumber.Text) + ".WFN");
			fontinfowfn.WFNName = "WGT Font File  ";

			try
			{
				System.IO.FileStream fs = System.IO.File.Open(fontinfowfn.FontPath, System.IO.FileMode.Create);
				System.IO.BinaryWriter binaryWriter = new System.IO.BinaryWriter(fs);

				fontinfowfn.Write(binaryWriter);

				binaryWriter.Close();
			}
			catch { MessageBox.Show(string.Format("Could not write the current font. {0}", fontinfowfn.FontPath)); }
			//fs.Close();
		}
		private void SaveTheSCIFont()
		{
			if ( !System.IO.Directory.Exists(TxtPath.Text) )
			{
				TxtPath.Text = @"C:\";
			}

			fontinfosci.FontName = "FONT." + int.Parse(TxtNumber.Text).ToString("000");
			fontinfosci.FontPath = System.IO.Path.Combine(TxtPath.Text, "FONT." + int.Parse(TxtNumber.Text).ToString("000"));

			try
			{
				System.IO.FileStream fs = System.IO.File.Open(fontinfosci.FontPath, System.IO.FileMode.Create);
				System.IO.BinaryWriter binaryWriter = new System.IO.BinaryWriter(fs);

				fontinfosci.Write(binaryWriter);

				binaryWriter.Close();
			}
			catch { MessageBox.Show(string.Format("Could not write the current font. {0}", fontinfosci.FontPath)); }
			//fs.Close();
		}

		private void ComboFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			/* Style-Combobox eventuell mit anderen Werten füllen, da nicht alle Style für eine Schrift auch verfügbar ist. */
			
			FontFamily fontFamily = new FontFamily(ComboFont.SelectedItem.ToString());
			ComboStyle.Items.Clear();

			if ( fontFamily.IsStyleAvailable(FontStyle.Bold) )
			{
				ComboStyle.Items.Add(FontStyle.Bold.ToString());
			}
			if ( fontFamily.IsStyleAvailable(FontStyle.Italic) )
			{
				ComboStyle.Items.Add(FontStyle.Italic.ToString());
			}
			if ( fontFamily.IsStyleAvailable(FontStyle.Regular) )
			{
				ComboStyle.Items.Add(FontStyle.Regular.ToString());
			}
			if ( fontFamily.IsStyleAvailable(FontStyle.Strikeout) )
			{
				ComboStyle.Items.Add(FontStyle.Strikeout.ToString());
			}
			if ( fontFamily.IsStyleAvailable(FontStyle.Underline) )
			{
				ComboStyle.Items.Add(FontStyle.Underline.ToString());
			}

			if ( ComboStyle.SelectedItem == null )
			{
				ComboStyle.SelectedIndex = 0;
			}

			font = new Font(ComboFont.SelectedItem.ToString(), int.Parse((string)ComboSize.SelectedItem), (FontStyle)Enum.Parse(typeof(FontStyle), (string)ComboStyle.SelectedItem));
			lineSpacing = fontFamily.GetLineSpacing((FontStyle)Enum.Parse(typeof(FontStyle), (string)ComboStyle.SelectedItem));
			try
			{
				Font fonty = new Font(fontFamily, int.Parse((string)ComboSize.SelectedItem));
				lineSpacingPixel = fonty.Size * lineSpacing / fontFamily.GetEmHeight((FontStyle)Enum.Parse(typeof(FontStyle), (string)ComboStyle.SelectedItem));
			}
			catch { }
			this.Invalidate();
		}
		private void ComboSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*  */
			font = new Font(ComboFont.SelectedItem.ToString(), int.Parse((string)ComboSize.SelectedItem), (FontStyle)Enum.Parse(typeof(FontStyle), (string)ComboStyle.SelectedItem));
			FontFamily fontFamily = new FontFamily(ComboFont.SelectedItem.ToString());
			lineSpacing = fontFamily.GetLineSpacing((FontStyle)Enum.Parse(typeof(FontStyle), (string)ComboStyle.SelectedItem));
			Font fonty = new Font(fontFamily, int.Parse((string)ComboSize.SelectedItem));
			lineSpacingPixel = fonty.Size * lineSpacing / fontFamily.GetEmHeight((FontStyle)Enum.Parse(typeof(FontStyle), (string)ComboStyle.SelectedItem));

			this.Invalidate();
		}
		private void ComboStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*  */
			font = new Font(ComboFont.SelectedItem.ToString(), int.Parse((string)ComboSize.SelectedItem), (FontStyle)Enum.Parse(typeof(FontStyle), (string)ComboStyle.SelectedItem));
			FontFamily fontFamily = new FontFamily(ComboFont.SelectedItem.ToString());
			lineSpacing = fontFamily.GetLineSpacing((FontStyle)Enum.Parse(typeof(FontStyle), (string)ComboStyle.SelectedItem));
			try
			{
				Font fonty = new Font(fontFamily, int.Parse((string)ComboSize.SelectedItem));
				lineSpacingPixel = fonty.Size * lineSpacing / fontFamily.GetEmHeight((FontStyle)Enum.Parse(typeof(FontStyle), (string)ComboStyle.SelectedItem));
			}
			catch { }

			this.Invalidate();
		}

		private void RdAntiAlias_CheckedChanged(object sender, EventArgs e)
		{
			Smooth = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.Invalidate();
		}
		private void RdDefault_CheckedChanged(object sender, EventArgs e)
		{
			Smooth = System.Drawing.Drawing2D.SmoothingMode.Default;
			this.Invalidate();
		}
		private void RdHighQuality_CheckedChanged(object sender, EventArgs e)
		{
			Smooth = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.Invalidate();
		}
		private void RdHighSpeed_CheckedChanged(object sender, EventArgs e)
		{
			Smooth = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
			this.Invalidate();
		}
		private void RdInvalid_CheckedChanged(object sender, EventArgs e)
		{
			Smooth = System.Drawing.Drawing2D.SmoothingMode.Invalid;
			this.Invalidate();
		}
		private void RdNone_CheckedChanged(object sender, EventArgs e)
		{
			Smooth = System.Drawing.Drawing2D.SmoothingMode.None;
			this.Invalidate();
		}

		private void RdBicubic_CheckedChanged(object sender, EventArgs e)
		{
			Interpolation = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
			this.Invalidate();
		}
		private void RdBilinear_CheckedChanged(object sender, EventArgs e)
		{
			Interpolation = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
			this.Invalidate();
		}
		private void RdDefaultInterpolation_CheckedChanged(object sender, EventArgs e)
		{
			Interpolation = System.Drawing.Drawing2D.InterpolationMode.Default;
			this.Invalidate();
		}
		private void RdHigh_CheckedChanged(object sender, EventArgs e)
		{
			Interpolation = System.Drawing.Drawing2D.InterpolationMode.High;
			this.Invalidate();

		}
		private void RdHighQualityBicubic_CheckedChanged(object sender, EventArgs e)
		{
			Interpolation = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			this.Invalidate();
		}
		private void RdHighQualityLinear_CheckedChanged(object sender, EventArgs e)
		{
			Interpolation = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			this.Invalidate();
		}
		private void RdInvalidInterpolation_CheckedChanged(object sender, EventArgs e)
		{
			Interpolation = System.Drawing.Drawing2D.InterpolationMode.Invalid;
			this.Invalidate();
		}
		private void RdLow_CheckedChanged(object sender, EventArgs e)
		{
			Interpolation = System.Drawing.Drawing2D.InterpolationMode.Low;
			this.Invalidate();
		}
		private void RdNearestNeigbor_CheckedChanged(object sender, EventArgs e)
		{
			Interpolation = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			this.Invalidate();
		}

		private void RdTextAntiAlias_CheckedChanged(object sender, EventArgs e)
		{
			TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.Invalidate();
		}
		private void RdTextAntiALiasGridFit_CheckedChanged(object sender, EventArgs e)
		{
			TextRendering = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			this.Invalidate();
		}
		private void RdTextClearTypeGridFit_CheckedChanged(object sender, EventArgs e)
		{
			TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.Invalidate();
		}
		private void RdTextSingleBitPerPixel_CheckedChanged(object sender, EventArgs e)
		{
			TextRendering = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
			this.Invalidate();
		}
		private void RdTextSingleBitPerPixelGridFit_CheckedChanged(object sender, EventArgs e)
		{
			TextRendering = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
			this.Invalidate();
		}
		private void RdTextSystemDefault_CheckedChanged(object sender, EventArgs e)
		{
			TextRendering = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.Invalidate();
		}

		private void BtnPath_Click(object sender, EventArgs e)
		{
			if ( Fbd.ShowDialog() == DialogResult.OK )
			{
				if ( Fbd.SelectedPath != "" )
				{
					TxtPath.Text = Fbd.SelectedPath;
				}
			}
		}
	}
}
