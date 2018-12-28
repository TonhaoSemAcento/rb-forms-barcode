using System;

namespace Rb.Forms.Barcode.Standard
{
    public class BarcodeEventArgs : EventArgs
    {
        public Barcode Barcode { get; private set; }
        
        public BarcodeEventArgs(Barcode barcode)
        {
            Barcode = barcode;
        }
    }
}
