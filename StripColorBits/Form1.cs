using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StripColorBits
{
	public partial class Form1 : Form
	{

		Color mainColor = Color.Blue, strippedColor = Color.Blue;
		int bits = 0xff;

		public Form1()
		{
			InitializeComponent();
			cmbBits.SelectedIndex = 0;
		}

		int mainRedChannel, mainGreenChannel, mainBlueChannel, strippedRedChannel, strippedGreenChannel, strippedBlueChannel;
		string mainRedBits, mainGreenBits, mainBlueBits, strippedRedBits, strippedGreenBits, strippedBlueBits;
		void CreateDisplayDataFromColors()
		{
			mainRedChannel = (int)mainColor.R;
			mainGreenChannel = (int)mainColor.G;
			mainBlueChannel = (int)mainColor.B;
			strippedRedChannel = mainRedChannel & bits;
			strippedGreenChannel = mainGreenChannel & bits;
			strippedBlueChannel = mainBlueChannel & bits;

			mainRedBits = ConvertToBits(mainRedChannel);
			mainGreenBits = ConvertToBits(mainGreenChannel);
			mainBlueBits = ConvertToBits(mainBlueChannel);
			strippedRedBits = ConvertToBits(strippedRedChannel);
			strippedGreenBits = ConvertToBits(strippedGreenChannel);
			strippedBlueBits = ConvertToBits(strippedBlueChannel);
		}

		string ConvertToBits( int value )
		{
			string ret = String.Empty;
			int bit = 0x80;

			for( int i=0; i<8; i++ )
			{
				if((value&bit)!= 0 )
				{
					ret += "1 ";
				}
				else
				{
					ret += "0 ";
				}
				bit >>= 1;
			}

			return (ret);
		}

		void PaintTheData(Graphics g)
		{
			CreateDisplayDataFromColors();

			Color main = Color.FromArgb(mainRedChannel, mainGreenChannel, mainBlueChannel);
			Color stripped = Color.FromArgb(strippedRedChannel, strippedGreenChannel, strippedBlueChannel);

			SolidBrush mainBrush = new SolidBrush(main);
			SolidBrush strippedBrush = new SolidBrush(stripped);
			SolidBrush blackBrush = new SolidBrush(Color.Black);
			Pen blackPen = new Pen(Color.Black, 5);
			Font fnt = new Font(FontFamily.GenericSansSerif, 15);

			g.FillRectangle(mainBrush, 20, 20, 100, 100);
			g.DrawRectangle(blackPen, 20, 20, 100, 100);
			g.FillRectangle(strippedBrush, 150+20, 20, 100, 100);
			g.DrawRectangle(blackPen, 150 + 20, 20, 100, 100);

			g.DrawString("Original Red:", fnt, blackBrush, 320, 20);
			g.DrawString("Original Green:", fnt, blackBrush, 300, 50);
			g.DrawString("Original Blue:", fnt, blackBrush, 313, 80);
			g.DrawString(mainRedBits, fnt, blackBrush, 313+130, 20);
			g.DrawString(mainGreenBits, fnt, blackBrush, 313 + 130, 50);
			g.DrawString(mainBlueBits, fnt, blackBrush, 313 + 130, 80);

			g.DrawString("Stripped Red:", fnt, blackBrush, 320+300, 20);
			g.DrawString("Stripped Green:", fnt, blackBrush, 300 + 300, 50);
			g.DrawString("Stripped Blue:", fnt, blackBrush, 313 + 300, 80);
			g.DrawString(strippedRedBits, fnt, blackBrush, 313 + 130 + 300, 20);
			g.DrawString(strippedGreenBits, fnt, blackBrush, 313 + 130 + 300, 50);
			g.DrawString(strippedBlueBits, fnt, blackBrush, 313 + 130 + 300, 80);
		}

		private void OnPaint(object sender, PaintEventArgs e)
		{
			PaintTheData(e.Graphics);
		}

		void CreateStrippedColor()
		{
			bits = 0xff;
			for (int i = 0; i < cmbBits.SelectedIndex; i++)
			{
				bits <<= 1;
				bits &= 0xff;
			}
			strippedRedChannel = mainRedChannel & bits;
			strippedGreenChannel = mainGreenChannel & bits;
			strippedBlueChannel = mainBlueChannel & bits;
			strippedColor = Color.FromArgb(strippedRedChannel, strippedGreenChannel, strippedBlueChannel);
		}

		private void OnSelectionChanged(object sender, EventArgs e)
		{
			CreateStrippedColor();
			Invalidate();
			Update();
		}

		private void btnSelectColor_Click(object sender, EventArgs e)
		{
			DialogResult result = colorDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				mainColor = colorDialog1.Color;
				CreateStrippedColor();
				Invalidate();
				Update();
			}
		}
	}
}
