using System.Drawing;

namespace KapDesign.WinForm.Core
{
    public static class StringAlignmentExtern
    {

        /*
         *      TopLeft = 1,
                MiddleLeft = 16, // 0x00000010
                BottomLeft = 256, // 0x00000100
             
                TopRight = 4,
                MiddleRight = 64, // 0x00000040
                BottomRight = 1024, // 0x00000400
       
                TopCenter = 2,
                MiddleCenter = 32, // 0x00000020
                BottomCenter = 512, // 0x00000200

         *      TopLeft = 1,
                TopRight = 4,
                TopCenter = 2,
   
                MiddleLeft = 16, // 0x00000010
                MiddleCenter = 32, // 0x00000020
                MiddleRight = 64, // 0x00000040
              
                BottomLeft = 256, // 0x00000100
                BottomRight = 1024, // 0x00000400
                BottomCenter = 512, // 0x00000200
         */

        public static StringAlignment GetAlignment(this ContentAlignment cAlignment)
        {
            int ta = (int)cAlignment;
            return ta == 1 || ta == 16 || ta == 256 ? StringAlignment.Near :
                ta == 4 || ta == 64 || ta == 1024 ? StringAlignment.Far : StringAlignment.Center;
        }

        public static StringAlignment GetLineAlignment(this ContentAlignment cAlignment)
        {
            int ta = (int)cAlignment;
            return ta == 1 || ta == 2 || ta == 4 ? StringAlignment.Near :
                ta == 256 || ta == 512 || ta == 1024 ? StringAlignment.Far : StringAlignment.Center;
        }
    }
}
