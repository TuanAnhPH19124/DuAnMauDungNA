using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3UI
{
    public class ThemColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        public static List<string> colors = new List<string>
        {
            "#EF6C00",
            "#87C9FF",
            "#B71C64",
            "#A12059"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double green = color.G;
            double blue = color.B;
            double red = color.R;

            if (correctionFactor < 0)
            {
                correctionFactor += 1;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
