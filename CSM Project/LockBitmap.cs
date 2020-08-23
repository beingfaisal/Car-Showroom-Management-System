using System;
using System.Drawing;

namespace CSM_Project
{
    internal class LockBitmap
    {
        private Bitmap bmp;

        public LockBitmap(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        internal void LockBits()
        {
            throw new NotImplementedException();
        }
    }
}