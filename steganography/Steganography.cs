using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;

namespace steganography
{
    public class Steganogeraphy
    {
        private int _flagBits;

        public Steganogeraphy(int flagBits = 8)
        {
            _flagBits = flagBits;
        }

        public Image EncryptText(Image image, string text) 
        {         
            StringBuilder sb = new StringBuilder();

            foreach (char c in text.ToCharArray())
            {
                var a = Convert.ToString(c, 2);
                sb.Append(a.PadLeft(8, '0'));
            }
            var binary = sb.ToString();

            // Convert string bits to an array
            List<byte> binaryText = new List<byte>();
            foreach (char ch in binary)
            {
                binaryText.Add(Convert.ToByte(ch.ToString()));
            }

            Bitmap bmp = (Bitmap)image;

            int currentBinaryIndex = 0;
            int flagBits = 0;
            for (var i = 0; i < bmp.Height; i++)
            {
                for (var j = 0; j < bmp.Width; j++)
                {
                    // Get image current pixel, this will return a pixel of color with (R,G,B)
                    Color pixel = bmp.GetPixel(j, i);

                    // Get r,g,b of the current pixel, And save them into an array
                    int[] pixelRgb = new int[3];
                    pixelRgb[0] = pixel.R - pixel.R % 2;
                    pixelRgb[1] = pixel.G - pixel.G % 2;
                    pixelRgb[2] = pixel.B - pixel.B % 2;

                    if (currentBinaryIndex >= binaryText.Count)
                    {
                        // All of binary embedded in image, job is done
                        // When all of bits of text embedded, we will add 8 zero to the end of embedded text, its a flag for dectypting
                        bmp.SetPixel(j, i, Color.FromArgb(pixelRgb[0], pixelRgb[1], pixelRgb[2]));
                        flagBits++;
                        // When all 8 zero bits added, jobs is done
                        if (flagBits >= _flagBits)
                            return bmp;
                        continue;
                    }

                    // The LSB of each R,G,B is 0 now, we just have to change LSB if current binary of text is not 0
                    for (var c = 0; c < 3; c++)
                    {
                        // If current binary is 1, we decrease the r,g,b by 1
                        if (binaryText[currentBinaryIndex] == 1)
                        {
                            if (pixelRgb[c] != 0)
                                pixelRgb[c]--;
                            else
                                pixelRgb[c]++;
                        }
                        // And at the end, we will go for next binary of text
                        currentBinaryIndex++;
                        if (currentBinaryIndex >= binaryText.Count)
                            break;
                    }
                    bmp.SetPixel(j, i, Color.FromArgb(pixelRgb[0], pixelRgb[1], pixelRgb[2]));
                }

            }
            return bmp;

        }
        public String DecryptText(Image image)
        {
            string textBits = "";
            Bitmap bmp = (Bitmap)image;
            int flagBits = 0;
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    // Get image current pixel, this will return a pixel of color with (R,G,B)
                    var pixel = bmp.GetPixel(j, i);

                    // Get r,g,b of the current pixel, And save them into an array
                    int[] pixelRGB = new int[3];
                    pixelRGB[0] = pixel.R;
                    pixelRGB[1] = pixel.G;
                    pixelRGB[2] = pixel.B;

                    for (int c = 0; c < 3; c++)
                    {
                        if (pixelRGB[c] % 2 == 0)
                        {
                            flagBits++;
                            if (flagBits >= _flagBits)
                            {
                                var byteList = new List<byte>();
                                for (var b = 0; b < textBits.Length; b += 8)
                                {
                                    try
                                    {
                                        byteList.Add(Convert.ToByte(textBits.Substring(b, 8), 2));
                                    }
                                    catch
                                    {
                                        // ignored
                                    }
                                }
                                string text = Encoding.ASCII.GetString(byteList.ToArray());
                                return text;
                            }
                        }
                        else
                            flagBits = 0;
                        textBits += pixelRGB[c] % 2;
                    }
                }
            }
            return textBits;
        }

        public static string GetImageBits(Image image)
        {
            Bitmap bmp = (Bitmap)image;
            StringBuilder st = new StringBuilder();
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    var pixel = bmp.GetPixel(i, j);
                    st.Append(Convert.ToString(pixel.R, 2).PadLeft(8, '0') + " ");

                }
            }

            return st.ToString();
        }
    }
   

}

