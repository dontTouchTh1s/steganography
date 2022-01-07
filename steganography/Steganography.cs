using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;

namespace steganography
{
    public class Steganogeraphy
    {
        public Image encrypt_text(Image image, string text) 
        {         
            StringBuilder sb = new StringBuilder();

            foreach (char c in text.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            string binrary = sb.ToString();

            List<Byte> binraryText = new List<byte>();
            foreach (char ch in binrary)
            {
                String s = ch.ToString();
                binraryText.Add(Convert.ToByte(s));
            }


            Bitmap bmp = (Bitmap)image;

            int currentBinraryIndex = 0;
            int flagZeroBits = 0;
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    // Get image current pixel, this will return a pixel of color with (R,G,B)
                    Color pixel = bmp.GetPixel(j, i);

                    // Get r,g,b of the current pixel, And save them into an array
                    int[] pixelRGB = new int[3];
                    pixelRGB[0] = pixel.R - pixel.R % 2;
                    pixelRGB[1] = pixel.G - pixel.G % 2;
                    pixelRGB[2] = pixel.B - pixel.B % 2;

                    if (currentBinraryIndex >= binraryText.Count)
                    {
                        // All of binrary embeded in image, job is done
                        // When all of bits of text embeded, we will add 8 zero to the end of embeded text, its a flag for dectypting
                        flagZeroBits++;
                        if (flagZeroBits >= 8)
                            // When all 8 zero bits added, jobs is done
                            return bmp;
                        continue;
                    }

                    // The LSB of each R,G,B is 0 now, we just have to change LSB if current binrary of text is not 0
                    for (int c = 0; c < 3; c++)
                    {
                        // If current binrary is 1, we decrease the r,g,b by 1
                        if (binraryText[currentBinraryIndex] == 1)
                        {
                            if (pixelRGB[c] != 0)
                                pixelRGB[c]--;
                            else
                                pixelRGB[c]++;
                        }
                        // And at the end, we will go for next binrary of text
                        currentBinraryIndex++;
                        if (currentBinraryIndex >= binraryText.Count)
                            break;
                    }
                    bmp.SetPixel(j, i, Color.FromArgb(pixelRGB[0], pixelRGB[1], pixelRGB[2]));
                }

            }
            return bmp;

        }
        public String decrypt_text(Bitmap bmp)
        {
            string textBits = "";
            int flagZeroBits = 0;
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    // Get image current pixel, this will return a pixel of color with (R,G,B)
                    Color pixel = bmp.GetPixel(j, i);

                    // Get r,g,b of the current pixel, And save them into an array
                    int[] pixelRGB = new int[3];
                    pixelRGB[0] = pixel.R;
                    pixelRGB[1] = pixel.G;
                    pixelRGB[2] = pixel.B;

                    for (int c = 0; c < 3; c++)
                    {
                        if (pixelRGB[c] % 2 == 0)
                        {
                            flagZeroBits++;
                            if (flagZeroBits >= 8)
                            {
                                List<Byte> byteList = new List<Byte>();
                                for (int b = 0; i < textBits.Length; b += 8)
                                {
                                    try
                                    {
                                        byteList.Add(Convert.ToByte(textBits.Substring(b, 8), 2));
                                    }
                                    catch { }
                                }
                                string text = Encoding.ASCII.GetString(byteList.ToArray());
                                return text;
                            }
                        }
                        else
                            flagZeroBits = 0;
                        textBits += pixelRGB[c] % 2;
                    }
                }
            }
            return textBits;
        }
    }
   

}

