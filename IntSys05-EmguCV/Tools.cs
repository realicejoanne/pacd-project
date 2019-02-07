using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntSys05_EmguCV
{
    public static class Tools
    {
        public static void RGBtoHSV(int r, int g, int b)
        {
            double h, s, v;
            h = s = v = 0;

            int max = Math.Max(r, Math.Max(g, b));
            int min = Math.Min(r, Math.Min(g, b));

            // H
            if (max == min)
            {
                h = 0;
            }
            else if (max == r && g >= b)
            {
                h = 60 * ((double)(g - b) / (double)(max - min));
            }
            else if (max == r && g < b)
            {
                h = 60 * ((double)(g - b) / (double)(max - min)) + 360;
            }
            else if (max == g)
            {
                h = 60 * ((double)(b - r) / (double)(max - min)) + 120;
            }
            else if (max == b)
            {
                h = 60 * ((double)(r - g) / (double)(max - min)) + 240;
            }

            // S
            if (max == 0)
            {
                s = 0;
            }
            else
            {
                s = (1 - ((double)min / (double)max)) * 255;
            }

            // V
            v = max;
        }

        public static void HSVtoRGB(int h, int s, int v)
        {
            double r = 0, g = 0, b = 0;

            if (s == 0)
            {
                r = v;
                g = v;
                b = v;
            }
            else
            {
                int i;
                double f, p, q, t;

                if (h == 360)
                    h = 0;
                else
                    h = h / 60;

                i = (int)Math.Truncate((double)h);
                f = h - i;

                p = v * (1.0 - s);
                q = v * (1.0 - (s * f));
                t = v * (1.0 - (s * (1.0 - f)));

                switch (i)
                {
                    case 0:
                        r = v;
                        g = t;
                        b = p;
                        break;

                    case 1:
                        r = q;
                        g = v;
                        b = p;
                        break;

                    case 2:
                        r = p;
                        g = v;
                        b = t;
                        break;

                    case 3:
                        r = p;
                        g = q;
                        b = v;
                        break;

                    case 4:
                        r = t;
                        g = p;
                        b = v;
                        break;

                    default:
                        r = v;
                        g = p;
                        b = q;
                        break;
                }

            }

            r = r * 255;
            g = g * 255;
            b = b * 255;
            //return new RGB((byte)(r * 255), (byte)(g * 255), (byte)(b * 255));
        }


    }
}
