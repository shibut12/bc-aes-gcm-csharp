using System;

namespace BcAesGcm.Models
{
    public class CryptoMessage
    {
        public byte[] Tag { get; set; }
        public byte[] Iv { get; set; }
        public byte[] Cipher { get; set; }
    }
}
