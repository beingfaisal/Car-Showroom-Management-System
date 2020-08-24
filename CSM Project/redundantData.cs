using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project
{
    public class redundantData
    {
        public struct empInfo
        {
            public string id, pin, name, contact, address, email, status;
            public empInfo(string s)
            {
                id = pin = name = contact = address = email = status = s;
            }
        }

        public static Image ReplaceColor(Image _image, Color _colorOld, Color _colorNew)
        {
            int _tolerance = 100;
            Bitmap bmap = (Bitmap)_image.Clone();

            Color c;
            int iR_Min, iR_Max;
            int iG_Min, iG_Max;
            int iB_Min, iB_Max;

            //Defining Tolerance
            //R
            iR_Min = Math.Max((int)_colorOld.R - _tolerance, 0);
            iR_Max = Math.Min((int)_colorOld.R + _tolerance, 255);

            //G
            iG_Min = Math.Max((int)_colorOld.G - _tolerance, 0);
            iG_Max = Math.Min((int)_colorOld.G + _tolerance, 255);

            //B
            iB_Min = Math.Max((int)_colorOld.B - _tolerance, 0);
            iB_Max = Math.Min((int)_colorOld.B + _tolerance, 255);


            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);


                    //Determinig Color Match
                    if (
                        (c.R >= iR_Min && c.R <= iR_Max) &&
                        (c.G >= iG_Min && c.G <= iG_Max) &&
                        (c.B >= iB_Min && c.B <= iB_Max)
                    )
                        if (_colorNew == Color.Transparent)
                            bmap.SetPixel(x, y, Color.FromArgb(0,
                              _colorNew.R,
                              _colorNew.G,
                              _colorNew.B));
                        else
                            bmap.SetPixel(x, y, Color.FromArgb(c.A,
                              _colorNew.R,
                              _colorNew.G,
                              _colorNew.B));
                }
            }
            return (Image)bmap.Clone();
        }
    }
}
