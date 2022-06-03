using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace SMP1.LB
{
    class Methods
    {
        public MemoryStream mrs = new MemoryStream();
        public byte[] bit;
        //convert to bit
        public byte[] ToByte() {
            return mrs.ToArray();
        }
        //convet to image
        public MemoryStream ToImage()
        {
            return new MemoryStream(bit);
        }
    
    
    }
}
