using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB555_Color_Picker
{
    public partial class Form1 : Form
    {
        private string Previous_555_Text = "";
        private string Previous_Hex_Text = "";
        private bool Changing = false;

        public Form1()
        {
            InitializeComponent();
            rgb555Box.TextChanged += Rgb555Box_TextChanged;
            hexBox.TextChanged += HexBox_TextChanged;
        }

        private void Rgb555Box_TextChanged(object sender, EventArgs e)
        {
            if (Changing)
            {
                return;
            }

            Changing = true;
            rgb555Box.Text = rgb555Box.Text.ToUpper();
            if (ushort.TryParse(rgb555Box.Text, NumberStyles.AllowHexSpecifier, null, out ushort RGB))
            {
                hexBox.Text = RGB555_to_Hex(RGB).ToString("X6");
                Previous_555_Text = rgb555Box.Text;
            }
            else if (!string.IsNullOrEmpty(rgb555Box.Text))
            {
                rgb555Box.Text = Previous_555_Text;
            }
            else
            {
                Previous_555_Text = "";
                hexBox.Text = "000000";
            }
            previewPanel.BackColor = Color.FromArgb((int)(0xFF000000 + uint.Parse(hexBox.Text, NumberStyles.AllowHexSpecifier, null)));
            rgb555Box.SelectionStart = rgb555Box.Text.Length;
            rgb555Box.SelectionLength = 0;
            Changing = false;
        }

        private void HexBox_TextChanged(object sender, EventArgs e)
        {
            if (Changing)
            {
                return;
            }

            Changing = true;
            hexBox.Text = hexBox.Text.ToUpper();
            if (uint.TryParse(hexBox.Text, NumberStyles.AllowHexSpecifier, null, out uint Hex))
            {
                rgb555Box.Text = Hex_to_RGB555(Hex).ToString("X4");
                Previous_Hex_Text = hexBox.Text;
            }
            else if (!string.IsNullOrEmpty(hexBox.Text))
            {
                hexBox.Text = Previous_Hex_Text;
            }
            else
            {
                Previous_Hex_Text = "";
                rgb555Box.Text = "0000";
            }
            previewPanel.BackColor = Color.FromArgb((int)(0xFF000000 + uint.Parse(hexBox.Text, NumberStyles.AllowHexSpecifier, null)));
            hexBox.SelectionStart = hexBox.Text.Length;
            hexBox.SelectionLength = 0;
            Changing = false;
        }

        // From: https://social.msdn.microsoft.com/Forums/vstudio/en-US/0fd7134a-0bd8-4460-9ed5-012e038d9054/16bpp-color-format-help?forum=csharpgeneral
        private ushort Hex_to_RGB555(uint Hex)
        {
            uint R = (Hex >> 16) & 0xFF;
            uint G = (Hex >> 8) & 0xFF;
            uint B = Hex & 0xFF;
            uint r = R * 31 / 255;
            uint g = G * 31 / 255;
            uint b = B * 31 / 255;

            return (ushort)(r << (10) | (g << 5) | b);
        }

        private uint RGB555_to_Hex(ushort RGB)
        {
            uint r = (uint)((RGB >> (10)) & 31);
            uint g = (uint)((RGB >> 5) & 31);
            uint b = (uint)(RGB & 31);
            uint R = r * 255 / 31;
            uint G = g * 255 / 31;
            uint B = b * 255 / 31;

            return (R << 16) | (G << 8) | B;
        }
    }
}
